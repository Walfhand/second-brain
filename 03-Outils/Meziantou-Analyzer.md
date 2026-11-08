---
type: outil
statut: a-evaluer
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, roslyn, analyse-statique]
sources:
  - https://github.com/meziantou/Meziantou.Analyzer
---
# Meziantou.Analyzer

Analyseur Roslyn C# qui ajoute des diagnostics de qualité et de bonnes pratiques. Son dépôt contient les règles, leurs configurations et les correctifs disponibles. [Dépôt officiel](https://github.com/meziantou/Meziantou.Analyzer).

## Intégration

Référencer le paquet `Meziantou.Analyzer` avec une version fixée et `PrivateAssets="all"`. La compilation exécute les règles ; `.editorconfig` permet de choisir les sévérités.

## Quand l'évaluer

En complément des [analyseurs .NET](Analyseurs-NET.md), si une règle répond à un problème concret du projet. Lire la règle et son coût d'adoption avant de l'activer sur toute une base existante.

Comparer les diagnostics avec [Roslynator](Roslynator.md) et [SonarAnalyzer](SonarAnalyzer-CSharp.md). Choisir l'ensemble qui apporte les contrôles utiles sans produire plusieurs messages sur le même problème.

Ce paquet produit des diagnostics ; pour les mesures structurelles et la duplication, garder [Metrics](Microsoft-CodeAnalysis-Metrics.md) et [CPD](PMD-CPD.md).

État : documentation consultée ; paquet non testé dans le coffre.

[Carte du sujet](../01-Cartes/Analyse-statique-CSharp.md)
