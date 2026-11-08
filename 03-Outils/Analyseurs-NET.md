---
type: outil
statut: documente
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, analyse-statique, dotnet]
sources:
  - https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview
  - https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-options
---
# Analyseurs .NET

Les analyseurs du SDK .NET produisent des diagnostics pendant la compilation. Ils constituent le premier contrôle proposé pour un projet C# : API, fiabilité, performances et autres règles de qualité. [Vue d'ensemble Microsoft](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview).

## Dans une pipeline

Activer `AnalysisLevel`, choisir les sévérités dans `.editorconfig`, puis compiler :

```bash
dotnet restore MonProjet.csproj
dotnet build MonProjet.csproj --configuration Release --no-restore --no-incremental --warnaserror
```

`--warnaserror` bloque aussi sur les autres avertissements de compilation. Sur un projet existant, on peut plutôt promouvoir quelques règles choisies en `error` dans `.editorconfig`.

## À retenir

- .NET 5+ active les analyseurs de qualité pour les projets concernés, mais pas toutes les règles.
- `AnalysisLevel=latest-all` n'active pas les anciennes règles de métriques CA1501/CA1502/CA1505/CA1506 : les sélectionner explicitement.
- Choisir une version d'analyse et un SDK stables pour éviter de modifier les diagnostics au cours d'une comparaison.

Sources : [activation et exceptions](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview), [configuration et sévérité](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-options).

Les diagnostics servent à décider si le build passe. Pour obtenir des mesures chiffrées à archiver, voir [Microsoft Metrics](Microsoft-CodeAnalysis-Metrics.md).

[Exemple de configuration](../80-Exemples/csharp-ci/README.md) · [Carte du sujet](../01-Cartes/Analyse-statique-CSharp.md)
