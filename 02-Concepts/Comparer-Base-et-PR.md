---
type: concept
statut: documente
cree: 2026-11-08
modifie: 2026-11-08
tags: [ci, metriques, pull-request]
---
# Comparer une base et une PR

Le tableau de la capture nécessite deux analyses et une étape de comparaison. Un rapport XML sur une seule révision ne donne pas cette différence.

## Procédure proposée

1. Choisir les révisions : le commit de la branche cible comme base, et le commit de tête de la PR comme candidat. Pour mesurer depuis le point de divergence, utiliser le merge-base et le préciser.
2. Extraire chaque révision dans un dossier séparé. Utiliser les mêmes versions d'outils et les mêmes règles de mesure pour les deux analyses.
3. Restaurer et compiler chaque révision avec son SDK compatible, puis générer les rapports de métriques et de duplication.
4. Aligner les résultats par projet, type et signature. Traiter les ajouts et suppressions avant de calculer les différences.
5. Écrire le tableau Markdown dans `$GITHUB_STEP_SUMMARY` et conserver les rapports bruts comme artefacts.

Cette procédure est une conception à appliquer au projet cible. L'exemple du coffre produit les rapports d'une seule révision ; il ne contient pas encore ce comparateur.

## Conventions du rapport

| Situation | Résultat à afficher |
|---|---|
| Mesure disponible des deux côtés | Base, candidat, différence et règle appliquée |
| Nouvel élément | « ajouté », sans inventer une ancienne valeur |
| Élément supprimé | « supprimé » |
| Analyse interrompue ou fichiers exclus | « incomplet » avec la cause |
| Mesure non prise en charge | « n/a » |

Un pourcentage de duplication nécessite un dénominateur explicite et des intervalles de lignes dédupliqués. Additionner les lignes de chaque bloc CPD peut compter certaines lignes plusieurs fois.

Pour bloquer une PR, commencer par les nouveaux diagnostics choisis. Une hausse de LOC ou du nombre de types peut accompagner une fonctionnalité utile ; elle ne suffit pas à établir une régression.

[Guide de pipeline](../04-Guides/Analyse-statique-CSharp-en-pipeline.md) · [Métriques CK](Metriques-CK.md)
