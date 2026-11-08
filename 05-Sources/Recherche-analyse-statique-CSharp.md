---
type: recherche
statut: documente
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, analyse-statique, sources]
---
# Recherche : analyse statique C#

Recherche initiale du **8 novembre 2026**, à partir d'une capture de publication LinkedIn fournie dans la conversation. L'URL de la publication et le dépôt de son auteur n'ont pas été fournis. La capture n'est pas republiée dans ce dépôt.

## Ce que la capture établit

- PMD CPD est nommé dans une note du rapport.
- Les tableaux concernent C# et TypeScript, avec une comparaison Base/PR.
- Les mesures de structure incluent des noms de la famille CK et TCC.
- Le moteur de métriques C# et le fournisseur de CI ne sont pas identifiables.

Les autres outils documentés sont des options découvertes pendant la recherche, sans attribution à l'auteur de la publication.

## Sources primaires

| Source | Utilisation dans le coffre |
|---|---|
| [Analyse du code .NET](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview) | Analyseurs du SDK et règles non activées par défaut |
| [Configuration des analyseurs](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-options) | Sévérités et sélection des règles |
| [Propriétés MSBuild](https://learn.microsoft.com/en-us/dotnet/core/project-sdk/msbuild-props) | Configuration du SDK |
| [CA1502](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1502) | Seuil de complexité cyclomatique |
| [Génération des métriques](https://learn.microsoft.com/en-us/visualstudio/code-quality/how-to-generate-code-metrics-data) | Cible MSBuild Metrics et sortie XML |
| [Définitions Microsoft](https://learn.microsoft.com/en-us/visualstudio/code-quality/code-metrics-values) | Contenu et limites du rapport |
| [Paquet Metrics 5.0.0](https://www.nuget.org/packages/Microsoft.CodeAnalysis.Metrics/5.0.0) | Inspection de la cible invoquant Metrics.exe |
| [Documentation CPD](https://pmd.github.io/pmd/pmd_userdocs_cpd.html) | Duplication et usage en ligne de commande |
| [Support C# PMD](https://pmd.github.io/pmd/pmd_languages_cs.html) | CPD disponible, moteur de règles C# absent |
| [Release PMD 7.29.0](https://github.com/pmd/pmd/releases/tag/pmd_releases/7.29.0) | Version et archive de l'exemple |
| [Projet CK](https://github.com/mauricioaniche/ck) | Famille de métriques et outil Java |
| [Analyseur Sonar C#](https://github.com/SonarSource/sonar-dotnet) | Alternative d'analyse au build |
| [Scanner .NET Sonar](https://docs.sonarsource.com/sonarqube-cloud/analyzing-source-code/scanners/sonarscanner-for-dotnet/using) | Séquence begin/build/end |
| [Roslynator](https://github.com/dotnet/roslynator) | Analyseurs complémentaires |
| [Meziantou.Analyzer](https://github.com/meziantou/Meziantou.Analyzer) | Analyseurs complémentaires |
| [Métriques NDepend](https://www.ndepend.com/docs/code-metrics) | Option d'analyse architecturale |

## État des vérifications

Le [README de l'exemple](../80-Exemples/csharp-ci/README.md) décrit les commandes de vérification. Les exécutions GitHub Actions fournissent les résultats et les rapports téléchargeables : [Actions du dépôt](https://github.com/Walfhand/second-brain/actions).

Les analyseurs complémentaires, SonarQube et NDepend ont fait l'objet d'une recherche documentaire. Ils ne sont pas installés dans l'exemple minimal. Le comparateur Base/PR et un calcul complet CK restent des extensions décrites, sans implémentation fournie.

[Carte du sujet](../01-Cartes/Analyse-statique-CSharp.md) · [Guide](../04-Guides/Analyse-statique-CSharp-en-pipeline.md)
