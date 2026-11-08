---
type: carte
statut: documente
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, analyse-statique, ci, navigation]
---
# Analyse statique C#

## Point de départ

Une capture de rapport affiche duplication C#/TypeScript, méthodes au-dessus d'un seuil et structure des classes : WMC, CBO, RFC, DIT, NOC, TCC, lignes et membres. Les colonnes comparent `Base`, `PR` et leur différence.

La mention **PMD CPD** identifie le détecteur de duplication. Le titre « métriques CK et PMD » décrit des familles de métriques ; il ne permet pas d'identifier le moteur C#. Les outils ci-dessous ont été recherchés comme solutions possibles. [Détail des sources](../05-Sources/Recherche-analyse-statique-CSharp.md).

## Choisir un point de départ

| Besoin | Fiche | Usage proposé |
|---|---|---|
| Diagnostics pendant la compilation | [Analyseurs .NET](../03-Outils/Analyseurs-NET.md) | Premier contrôle à activer |
| Rapport XML de métriques | [Microsoft.CodeAnalysis.Metrics](../03-Outils/Microsoft-CodeAnalysis-Metrics.md) | Complexité, couplage, héritage, taille |
| Code dupliqué | [PMD CPD](../03-Outils/PMD-CPD.md) | Complément aux analyseurs |
| Règles Sonar sans serveur | [SonarAnalyzer.CSharp](../03-Outils/SonarAnalyzer-CSharp.md) | Complément possible, à sélectionner |
| Historique et quality gate | [SonarQube](../03-Outils/SonarQube.md) | Plateforme à évaluer |
| Règles C# supplémentaires | [Roslynator](../03-Outils/Roslynator.md), [Meziantou](../03-Outils/Meziantou-Analyzer.md) | Ajouter selon les problèmes rencontrés |
| Analyse de l'architecture | [NDepend](../03-Outils/NDepend.md) | Option commerciale à évaluer |

La proposition initiale est **analyseurs .NET + Metrics + CPD**. Elle donne des diagnostics et des rapports sans configurer un serveur Sonar. Les fiches contiennent les limites et les sources de chaque choix.

## Comprendre et intégrer

- [Métriques CK et couverture des outils](../02-Concepts/Metriques-CK.md)
- [Complexité cyclomatique et cognitive](../02-Concepts/Complexite-du-code.md)
- [Comparer une base et une PR](../02-Concepts/Comparer-Base-et-PR.md)
- [Guide de pipeline](../04-Guides/Analyse-statique-CSharp-en-pipeline.md)
- [Exemple à reprendre](../80-Exemples/csharp-ci/README.md)

[Informatique](Informatique.md) · [Accueil](../Accueil.md)
