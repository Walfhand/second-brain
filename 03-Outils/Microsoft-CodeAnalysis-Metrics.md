---
type: outil
statut: teste
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, metriques, roslyn]
sources:
  - https://learn.microsoft.com/en-us/visualstudio/code-quality/how-to-generate-code-metrics-data
  - https://www.nuget.org/packages/Microsoft.CodeAnalysis.Metrics/5.0.0
---
# Microsoft.CodeAnalysis.Metrics

Paquet Microsoft qui ajoute une cible MSBuild `Metrics` et écrit un rapport XML. Les résultats couvrent notamment complexité cyclomatique, maintenabilité, couplage, profondeur d'héritage et lignes de code. [Génération](https://learn.microsoft.com/en-us/visualstudio/code-quality/how-to-generate-code-metrics-data), [définitions](https://learn.microsoft.com/en-us/visualstudio/code-quality/code-metrics-values).

## Utilisation

Après ajout du paquet au projet :

```powershell
dotnet restore MonProjet.csproj
dotnet msbuild MonProjet.csproj /t:Metrics /p:Configuration=Release /p:MetricsOutputFile=metrics.xml
```

Dans une solution à plusieurs projets, produire un fichier distinct par projet pour éviter les écrasements. Utiliser `PrivateAssets="all"` sur la référence du paquet.

## Runner Windows dans cet exemple

Inspection du paquet **5.0.0** : sa cible `buildTransitive/Microsoft.CodeAnalysis.Metrics.targets` invoque `Metrics/Metrics.exe`. Le workflow fourni utilise donc `windows-latest`. Cette observation concerne le paquet inspecté ; elle ne prétend pas décrire toutes les façons d'exécuter un calcul Roslyn. [Paquet vérifié](https://www.nuget.org/packages/Microsoft.CodeAnalysis.Metrics/5.0.0).

## Limites

L'essai CI avec Metrics 5.0.0 a révélé l'absence de `BuildHost` dans le paquet. L'[exemple](../80-Exemples/csharp-ci/README.md) prépare ce composant depuis le paquet Microsoft correspondant et utilise C# 13 pour rester compatible avec le moteur embarqué. L'ajout du seul paquet Metrics n'a pas suffi dans l'environnement testé.

Le rapport ne constitue pas toute la suite [CK](../02-Concepts/Metriques-CK.md). Il ne fournit pas non plus un tableau Base/PR ni une détection de duplication. Conserver le XML et séparer la réussite de l'analyse des seuils de qualité retenus.

Vérification : génération réussie sur GitHub Actions Windows après préparation de BuildHost. L'artefact XML téléchargé contient `Calculator` et les mesures attendues. [Exécution vérifiée](https://github.com/Walfhand/second-brain/actions/runs/42489838557).

[Guide de pipeline](../04-Guides/Analyse-statique-CSharp-en-pipeline.md) · [PMD CPD](PMD-CPD.md)
