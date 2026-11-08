---
type: concept
statut: documente
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, metriques, architecture]
sources:
  - https://github.com/mauricioaniche/ck
  - https://learn.microsoft.com/en-us/visualstudio/code-quality/code-metrics-values
---
# Métriques CK

La famille Chidamber et Kemerer sert à décrire la structure orientée objet. Le logiciel Java nommé CK implémente ces mesures et d'autres ; son nom dans une capture ne prouve pas son utilisation sur du C#. [Projet CK](https://github.com/mauricioaniche/ck).

| Mesure | Question posée |
|---|---|
| WMC | Quelle complexité cumulent les méthodes de la classe ? |
| CBO | À combien d'autres types la classe est-elle couplée ? |
| RFC | Combien de méthodes peuvent participer à sa réponse ? |
| DIT | Quelle est la profondeur de sa chaîne d'héritage ? |
| NOC | Combien de sous-classes directes possède-t-elle ? |
| LCOM | Dans quelle mesure ses méthodes manquent-elles de cohésion ? |

La capture contient aussi **TCC**, une mesure de cohésion entre méthodes allant de 0 à 1. TCC complète la famille CK. La définition des dépendances, des appels résolus et des méthodes prises en compte dépend de l'implémentation.

## Couverture en C#

[Microsoft Metrics](../03-Outils/Microsoft-CodeAnalysis-Metrics.md) fournit complexité cyclomatique, couplage, profondeur d'héritage, indice de maintenabilité et lignes de code. Il ne produit pas un rapport complet WMC/CBO/RFC/NOC/TCC prêt à reproduire la capture. [Mesures Microsoft](https://learn.microsoft.com/en-us/visualstudio/code-quality/code-metrics-values).

Pour une couverture exacte, évaluer [NDepend](../03-Outils/NDepend.md) mesure par mesure, ou développer un calcul Roslyn. Avant un calcul maison, écrire les conventions : constructeurs, propriétés, classes partielles, code généré, appels externes et héritage. Éviter de renommer le couplage Microsoft « CBO » sans vérifier sa définition.

[Carte du sujet](../01-Cartes/Analyse-statique-CSharp.md) · [Comparer Base et PR](Comparer-Base-et-PR.md)
