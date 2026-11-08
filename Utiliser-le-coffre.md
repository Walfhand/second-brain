---
type: guide
statut: documente
cree: 2026-11-08
modifie: 2026-11-08
tags: [obsidian, organisation]
---
# Utiliser le coffre

## Ajouter une découverte

1. Déposer le lien dans [l'inbox](00-Inbox/Inbox.md), avec une phrase expliquant son intérêt.
2. Si le sujet mérite une note, créer un fichier au titre précis et insérer un [modèle](90-Modeles/Modele-note.md) avec la commande **Templates : insérer un modèle**.
3. Reformuler ce que l'on veut retenir, ajouter la source et dater la vérification.
4. Relier la note à une carte existante et à une note voisine utile.
5. Retirer l'entrée de l'inbox quand le classement est terminé.

Créer une nouvelle carte quand un sujet commence à regrouper plusieurs notes. Éviter les dossiers vides pour des thèmes encore hypothétiques.

## Conventions

Une note couvre un sujet. Un guide explique une procédure ; une fiche outil explique quand utiliser cet outil. Référencer l'exemple exécutable au lieu de recopier sa configuration dans plusieurs notes.

Les noms de fichiers restent sans accents ni espaces pour faciliter les liens et les commandes. Les titres des notes conservent une orthographe française normale.

Propriétés communes : `type`, `statut`, `cree`, `modifie`, `tags`. Pour une recherche ou un outil, ajouter `verifie` et `sources`. Valeurs de statut : `a-lire`, `a-evaluer`, `documente`, `teste`, `archive`. Le statut `teste` doit préciser ce qui a été exécuté et dans quel environnement.

Les liens Markdown relatifs fonctionnent dans Obsidian et sur GitHub. Obsidian permet de retrouver les liens entrants et de naviguer dans le graphe. Sources : [liens internes](https://obsidian.md/help/links), [propriétés](https://obsidian.md/help/properties), [Templates](https://obsidian.md/help/plugins/templates).

## Sauvegarder sur GitHub

```bash
git status
git add .
git commit -m "Ajoute une note sur un sujet"
git push
```

Relire les changements avant de les publier. Ce coffre utilise Git pour sa synchronisation ; il ne configure pas Obsidian Sync.

[Retour à l'accueil](Accueil.md)
