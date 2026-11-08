# Second Brain

Un coffre Obsidian pour garder les outils, idées et ressources que je veux retrouver. Les notes sont en français, reliées entre elles et lisibles sur GitHub.

**[Ouvrir l'accueil](Accueil.md)** · [Mode d'emploi](Utiliser-le-coffre.md) · [Inbox](00-Inbox/Inbox.md)

## Premier dossier : analyse statique C#

- [Carte du sujet et choix des outils](01-Cartes/Analyse-statique-CSharp.md)
- [Guide d'intégration dans GitHub Actions](04-Guides/Analyse-statique-CSharp-en-pipeline.md)
- [Exemple exécutable et fichiers à reprendre](80-Exemples/csharp-ci/README.md)
- [Sources et état des vérifications](05-Sources/Recherche-analyse-statique-CSharp.md)

Le point de départ est un tableau comparant les métriques d'une base et d'une pull request. Les notes distinguent les outils identifiés sur cette capture des solutions recherchées ensuite.

## Ouvrir dans Obsidian

```bash
git clone https://github.com/Walfhand/second-brain.git
```

Dans Obsidian : **Ouvrir un dossier comme coffre**, choisir `second-brain`, puis ouvrir `Accueil.md`. Les modèles utilisent le plugin natif Templates. Aucun plugin communautaire n'est nécessaire.

## Organisation

| Dossier | Usage |
|---|---|
| `00-Inbox` | Captures rapides à trier |
| `01-Cartes` | Points d'entrée par domaine et sujet |
| `02-Concepts` | Explications réutilisables |
| `03-Outils` | Une fiche par outil |
| `04-Guides` | Procédures et choix pratiques |
| `05-Sources` | Références et recherches datées |
| `06-Projets` | Mise en pratique liée à un objectif |
| `70-Pieces-jointes` | Pièces jointes choisies pour publication |
| `80-Exemples` | Configurations et exemples exécutables |
| `90-Modeles` | Modèles de notes |
| `99-Archives` | Notes devenues obsolètes |

Pour ajouter un autre centre d'intérêt, créer sa carte dans `01-Cartes` et la relier à l'accueil. Les dossiers d'outils, de concepts et de sources restent communs.

Ce dépôt est public : n'y mettre que les informations que l'on souhaite publier. Les réglages de session Obsidian et les fichiers de compilation sont exclus de Git.
