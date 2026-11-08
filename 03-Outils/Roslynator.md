---
type: outil
statut: a-evaluer
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, roslyn, analyse-statique]
sources:
  - https://github.com/dotnet/roslynator
---
# Roslynator

Ensemble d'outils d'analyse C# fondés sur Roslyn. Le paquet `Roslynator.Analyzers` permet de faire exécuter les règles pendant le build. [Dépôt officiel](https://github.com/dotnet/roslynator).

## Quand l'évaluer

Quand les [analyseurs .NET](Analyseurs-NET.md) ne couvrent pas certaines conventions C# utiles au projet. Installer une version compatible avec le compilateur, avec `PrivateAssets="all"`, puis examiner les diagnostics avant d'en rendre certains bloquants.

## Choix proposé

Commencer par les règles qui corrigent un problème rencontré. Vérifier les doublons avec [SonarAnalyzer](SonarAnalyzer-CSharp.md) et [Meziantou](Meziantou-Analyzer.md) avant d'empiler les paquets.

Roslynator ne remplace pas [CPD](PMD-CPD.md) pour la duplication ni un rapport complet de [métriques CK](../02-Concepts/Metriques-CK.md).

État : dépôt et mode d'intégration documentés ; paquet non testé dans le coffre.

[Carte du sujet](../01-Cartes/Analyse-statique-CSharp.md)
