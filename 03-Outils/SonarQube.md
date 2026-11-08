---
type: outil
statut: a-evaluer
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, sonar, ci]
sources:
  - https://docs.sonarsource.com/sonarqube-cloud/analyzing-source-code/scanners/sonarscanner-for-dotnet/using
  - https://docs.sonarsource.com/sonarqube-cloud/analyzing-source-code/ci-based-analysis/github-actions-for-sonarcloud
---
# SonarQube

Plateforme à évaluer quand il faut centraliser les analyses et les contrôles de qualité. Pour C#, utiliser **SonarScanner for .NET** autour de la compilation. L'action générique de scan ne remplace pas cette séquence. [Intégration GitHub Actions](https://docs.sonarsource.com/sonarqube-cloud/analyzing-source-code/ci-based-analysis/github-actions-for-sonarcloud).

## Séquence Cloud

Après installation d'une version fixée de `dotnet-sonarscanner`, définir les variables du projet et fournir `SONAR_TOKEN` depuis un secret CI :

```bash
dotnet sonarscanner begin /k:"$SONAR_PROJECT_KEY" /o:"$SONAR_ORGANIZATION" /d:sonar.token="$SONAR_TOKEN" /d:sonar.qualitygate.wait=true
dotnet build MonProjet.csproj --configuration Release --no-incremental
dotnet sonarscanner end /d:sonar.token="$SONAR_TOKEN"
```

Les commandes supposent un shell Bash et un projet Cloud déjà configuré. Pour Server, suivre sa documentation et renseigner l'hôte requis.

## Points à vérifier

Le scanner modifie des paramètres de compilation, dont `WarningsAsErrors`. Garder un job séparé pour les contrôles locaux bloquants. Le jeton fourni au début doit aussi être fourni à la fin. [Utilisation du scanner](https://docs.sonarsource.com/sonarqube-cloud/analyzing-source-code/scanners/sonarscanner-for-dotnet/using).

Vérifier le plan et les fonctions disponibles pour les branches et PR avant de choisir une offre. Pour une PR de fork, tenir compte de l'absence de secrets avec le déclencheur habituel `pull_request` ; conserver les contrôles locaux.

État : piste documentée ; aucun compte, serveur ni jeton Sonar n'a été configuré pour ce coffre.

[SonarAnalyzer.CSharp](SonarAnalyzer-CSharp.md) · [Guide de pipeline](../04-Guides/Analyse-statique-CSharp-en-pipeline.md)
