---
type: guide
statut: documente
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, ci, github-actions, analyse-statique]
---
# Analyse statique C# dans une pipeline

## Choix de départ

Compiler avec les [analyseurs .NET](../03-Outils/Analyseurs-NET.md), produire un XML avec [Microsoft Metrics](../03-Outils/Microsoft-CodeAnalysis-Metrics.md) et détecter la duplication avec [CPD](../03-Outils/PMD-CPD.md). L'exemple utilise GitHub Actions et un petit projet SDK-style ; les commandes peuvent être reprises dans Azure Pipelines ou GitLab CI.

Le résultat est un ensemble de diagnostics et de rapports sur une révision. Pour obtenir le tableau Base/PR de la capture, ajouter ensuite [deux analyses et un comparateur](../02-Concepts/Comparer-Base-et-PR.md). Les métriques Microsoft couvrent seulement une partie des [mesures CK](../02-Concepts/Metriques-CK.md).

## 1. Reprendre les fichiers

Voir [l'exemple](../80-Exemples/csharp-ci/README.md) :

- placer `Directory.Build.props`, `Directory.Build.targets`, `.editorconfig` et `CodeMetricsConfig.txt` au niveau voulu dans le dépôt C# ;
- reprendre la référence `Microsoft.CodeAnalysis.Metrics` et le `PackageDownload` de l'exemple, qui fournit le composant BuildHost absent du paquet testé ;
- copier [le workflow](../.github/workflows/quality.yml), puis adapter `PROJECT` et `SOURCE` ;
- conserver le SDK du projet dans un `global.json` et adapter `setup-dotnet`.

Avec des projets multi-cibles, sélectionner aussi le framework à analyser. Avec plusieurs projets, exécuter la cible Metrics pour chacun et utiliser des chemins de sortie distincts.

L'exemple compile avec .NET 10 et fixe C# 13 pour le moteur Metrics embarqué. Vérifier cette compatibilité avant de reprendre l'exemple sur une base utilisant des syntaxes plus récentes.

## 2. Choisir les règles bloquantes

L'exemple utilise `10.0-recommended`, active CA1502 dans `.editorconfig` et fixe sa limite à 10 dans `CodeMetricsConfig.txt`. `Directory.Build.props` transmet ce fichier comme `AdditionalFiles` aux analyseurs. [Configuration du SDK](https://learn.microsoft.com/en-us/dotnet/core/project-sdk/msbuild-props), [seuil CA1502](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1502).

La commande `dotnet build --warnaserror` bloque sur les avertissements. Sur une base existante, commencer par quelques règles en sévérité `error`, puis élargir après avoir examiné le bruit et les exceptions utiles.

Le seuil CA1502 porte sur la complexité **cyclomatique**. Pour un contrôle de complexité cognitive, évaluer [SonarAnalyzer.CSharp](../03-Outils/SonarAnalyzer-CSharp.md) et S3776 séparément.

## 3. Générer les rapports

Le job Windows restaure, compile, puis exécute `dotnet msbuild /t:Metrics`. Le paquet inspecté lance un `.exe` Windows ; l'exemple le vérifie sur ce système. Le job Linux installe Java et une version fixée de PMD, puis analyse uniquement `SOURCE`.

CPD conserve son comportement bloquant en cas de duplication. Pour commencer en observation, ajouter `--no-fail-on-violation`, tout en gardant `--fail-on-error`. Une erreur de lecture doit rester visible.

Les étapes `upload-artifact` tournent même après un échec pour conserver les rapports disponibles. Un rapport absent n'est pas une mesure à zéro. [Artefacts GitHub Actions](https://docs.github.com/en/actions/concepts/workflows-and-actions/workflow-artifacts).

## 4. Adapter le périmètre

Analyser les sources applicatives. Séparer le code généré, les migrations et les tests si leurs conventions diffèrent ; documenter les exclusions. CPD cible ici le dossier `src` qui ne contient ni `bin` ni `obj`. Les analyseurs et les métriques ont leurs propres règles de prise en compte du code généré.

Ajouter les tests du projet cible à la pipeline, avec leur runner et leur collecte de couverture. Le petit exemple de ce coffre est une bibliothèque de démonstration, sans suite de tests métier.

## 5. Aller vers le rapport de la capture

La note [Comparer Base et PR](../02-Concepts/Comparer-Base-et-PR.md) définit les révisions, les valeurs manquantes et le calcul des différences. Conserver la configuration de mesure constante et indiquer la couverture de l'analyse.

Pour RFC, NOC, TCC et les autres mesures absentes du XML Microsoft, vérifier [NDepend](../03-Outils/NDepend.md) ou chiffrer le travail d'un calcul Roslyn avant de l'ajouter.

Pour un tableau de bord partagé, voir [SonarQube](../03-Outils/SonarQube.md). Garder les contrôles locaux bloquants dans un job indépendant du scanner.

[Carte du sujet](../01-Cartes/Analyse-statique-CSharp.md) · [Sources et vérifications](../05-Sources/Recherche-analyse-statique-CSharp.md)
