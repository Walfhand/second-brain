---
type: exemple
statut: documente
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, ci, exemple]
---
# Exemple C# : analyse statique

Bibliothèque minimale pour exécuter les configurations décrites dans le [guide](../../04-Guides/Analyse-statique-CSharp-en-pipeline.md). Le [workflow actif](../../.github/workflows/quality.yml) compile avec les analyseurs, écrit un XML de métriques sur Windows et lance CPD sur Linux.

## Fichiers

| Fichier | Rôle |
|---|---|
| [Directory.Build.props](Directory.Build.props) | Analyseurs recommandés et fichier de seuils |
| [.editorconfig](.editorconfig) | Activation explicite de CA1502 |
| [CodeMetricsConfig.txt](CodeMetricsConfig.txt) | Seuil de complexité cyclomatique : 10 |
| [Demo.csproj](Demo.csproj) | Projet .NET 10 et paquet Metrics 5.0.0 |
| [global.json](global.json) | SDK 10.0.402 |
| [Calculator.cs](src/Calculator.cs) | Petite source à analyser |

## Exécuter

Depuis ce dossier, avec le SDK sélectionné :

```bash
dotnet restore Demo.csproj
dotnet build Demo.csproj --configuration Release --no-restore --no-incremental --warnaserror
```

Sur Windows, après restauration :

```powershell
dotnet msbuild Demo.csproj /t:Metrics /p:Configuration=Release /p:MetricsOutputFile=metrics.xml
```

Avec PMD 7.29.0 dans le PATH et Java disponible :

```bash
pmd cpd --dir src --language cs --minimum-tokens 100 --format xml --report-file cpd.xml --fail-on-error
```

Les rapports XML sont des sorties de build, exclus de Git. GitHub Actions les conserve comme artefacts.

## Adapter à un projet réel

Copier les configurations pertinentes, ajouter la référence Metrics au projet et reprendre le workflow. Modifier `PROJECT`, `SOURCE`, `working-directory` et la version de SDK selon le projet. Choisir une sortie Metrics par projet. Les propriétés doivent atteindre les projets mesurés ; vérifier la portée des fichiers `Directory.Build.props` déjà présents.

Le workflow contrôle une révision. La [comparaison Base/PR](../../02-Concepts/Comparer-Base-et-PR.md) et les métriques CK absentes du rapport Microsoft demandent des étapes supplémentaires.

## Vérifier les contrôles

Pour vérifier CA1502, introduire temporairement une méthode avec onze branches `if` indépendantes : le build doit signaler CA1502 et échouer avec `--warnaserror`. Retirer ensuite la méthode et reconstruire.

Pour vérifier CPD, introduire deux blocs identiques dépassant cent tokens : le contrôle doit signaler la duplication. Un fichier impossible à tokeniser doit aussi faire échouer l'analyse avec `--fail-on-error`. Faire ces essais sur une copie temporaire.

Pour vérifier Metrics, ouvrir l'artefact Windows et contrôler la présence de mesures pour `SecondBrain.Demo.Calculator`. Les résultats des exécutions sont visibles dans [GitHub Actions](https://github.com/Walfhand/second-brain/actions).

Le coffre ne configure pas de service SonarQube. Les autres analyseurs ont des fiches documentaires, sans installation dans cet exemple.
