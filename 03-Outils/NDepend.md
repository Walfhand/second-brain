---
type: outil
statut: a-evaluer
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, metriques, architecture, commercial]
sources:
  - https://www.ndepend.com/docs/code-metrics
  - https://www.ndepend.com/docs/ndepend-console
---
# NDepend

Outil commercial d'analyse .NET à évaluer pour les dépendances, les règles d'architecture, les métriques et le suivi d'une base de code.

Son catalogue inclut notamment profondeur d'héritage, nombre de descendants, couplages, complexité et plusieurs mesures de cohésion. Il faut comparer leurs définitions aux mesures attendues, en particulier pour [la famille CK](../02-Concepts/Metriques-CK.md). [Catalogue des métriques](https://www.ndepend.com/docs/code-metrics).

## Dans une pipeline

La console permet de lancer une analyse et de produire un rapport à partir d'une configuration NDepend. Le runner, les assemblies et la licence doivent correspondre à la version retenue. [Documentation de la console](https://www.ndepend.com/docs/ndepend-console).

## Quand cela vaut une évaluation

Quand la maintenance d'un calcul maison des dépendances et de la cohésion devient un travail à part entière. Vérifier les métriques requises sur un projet représentatif et confirmer les conditions de licence CI avant adoption.

La documentation consultée n'établit pas que NDepend reproduit directement les colonnes RFC et TCC de la capture. Ne pas promettre une correspondance complète sans prototype.

État : recherche documentaire ; aucune licence achetée, aucun produit installé.

[Comparaison Base/PR](../02-Concepts/Comparer-Base-et-PR.md) · [Carte du sujet](../01-Cartes/Analyse-statique-CSharp.md)
