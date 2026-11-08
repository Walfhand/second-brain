---
type: concept
statut: documente
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, complexite]
sources:
  - https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1502
  - https://www.sonarsource.com/resources/cognitive-complexity/
---
# Complexité du code

## Cyclomatique

Cette mesure décrit les chemins indépendants dans le flux de contrôle. La règle Microsoft **CA1502** signale les méthodes qui dépassent un seuil configurable ; elle n'est pas activée par défaut dans .NET 10. [Règle CA1502](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1502).

L'exemple du coffre active CA1502 et place le seuil à 10 dans `CodeMetricsConfig.txt`. Ce nombre est un choix de départ à évaluer sur le projet.

## Cognitive

Sonar propose une autre mesure pour estimer la difficulté de compréhension du flux, notamment face aux structures imbriquées. [Présentation de SonarSource](https://www.sonarsource.com/resources/cognitive-complexity/).

La règle C# **S3776** porte sur la complexité cognitive. On peut l'activer avec [SonarAnalyzer.CSharp](../03-Outils/SonarAnalyzer-CSharp.md). Source : [spécification dans le dépôt Sonar](https://github.com/SonarSource/sonar-dotnet/blob/master/analyzers/rspec/cs/S3776.json).

## Lire un seuil

Une ligne « méthodes > 10 » ne dit pas, à elle seule, s'il s'agit de complexité cyclomatique, cognitive ou de longueur. Toujours indiquer l'unité, l'outil, sa version et le périmètre.

Une méthode peut rester sous un seuil et être difficile à maintenir. Utiliser le signal pour ouvrir le code, examiner sa responsabilité et décider d'un changement utile.

[Métriques CK](Metriques-CK.md) · [Carte du sujet](../01-Cartes/Analyse-statique-CSharp.md)
