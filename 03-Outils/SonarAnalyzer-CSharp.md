---
type: outil
statut: a-evaluer
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, analyse-statique, sonar]
sources:
  - https://github.com/SonarSource/sonar-dotnet
  - https://github.com/SonarSource/sonar-dotnet/blob/master/analyzers/rspec/cs/S3776.json
---
# SonarAnalyzer.CSharp

Analyseur Roslyn de SonarSource utilisable depuis un projet C#. Le paquet NuGet apporte des diagnostics au build ; son utilisation seule ne nécessite pas un serveur SonarQube. [Dépôt officiel](https://github.com/SonarSource/sonar-dotnet).

## Intérêt

Évaluer ce paquet pour des règles de fiabilité et de maintenabilité supplémentaires. La règle **S3776** porte sur la [complexité cognitive](../02-Concepts/Complexite-du-code.md). [Spécification S3776](https://github.com/SonarSource/sonar-dotnet/blob/master/analyzers/rspec/cs/S3776.json).

Ajouter une référence `SonarAnalyzer.CSharp` avec une version stable explicitement choisie et `PrivateAssets="all"`, puis sélectionner les sévérités :

```ini
[*.cs]
dotnet_diagnostic.S3776.severity = warning
```

Le build exécute l'analyseur. Pour bloquer sur cette règle, choisir `error` ou une politique d'avertissements adaptée.

## Limites

Ce paquet ne donne pas, à lui seul, un tableau de bord avec historique, pourcentage de duplication et comparaison de branches. Pour ces fonctions, étudier [SonarQube](SonarQube.md).

Si SonarScanner pilote le build, vérifier les règles et versions gérées par le serveur avant d'ajouter une deuxième configuration locale.

État : documentation consultée ; paquet non installé dans l'exemple minimal du coffre.

[Analyseurs .NET](Analyseurs-NET.md) · [Carte du sujet](../01-Cartes/Analyse-statique-CSharp.md)
