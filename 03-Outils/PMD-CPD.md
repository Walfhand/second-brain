---
type: outil
statut: teste
cree: 2026-11-08
modifie: 2026-11-08
verifie: 2026-11-08
tags: [csharp, duplication, ci]
sources:
  - https://pmd.github.io/pmd/pmd_userdocs_cpd.html
  - https://pmd.github.io/pmd/pmd_languages_cs.html
---
# PMD CPD

**Copy/Paste Detector** détecte les blocs similaires par leurs tokens. La capture initiale nomme cet outil. PMD prend en charge **C# pour CPD**, sans analyse C# par son moteur de règles. [Support C#](https://pmd.github.io/pmd/pmd_languages_cs.html).

## Commande

Après installation de PMD et de Java :

```bash
pmd cpd --dir src --language cs --minimum-tokens 100 --format xml --report-file cpd.xml --fail-on-error
```

`100` est un seuil de tokens choisi pour l'exemple. Ajuster ce seuil sur du code réel. CPD peut fonctionner sans compiler le projet. [Documentation CPD](https://pmd.github.io/pmd/pmd_userdocs_cpd.html).

## Dans la CI

Le workflow proposé utilise PMD **7.29.0**, vérifie le SHA-256 de l'archive et conserve le rapport. Il échoue en cas de duplication ou d'erreur de traitement. Pour une phase d'observation, `--no-fail-on-violation` conserve le signal sans faire échouer sur les duplications ; garder `--fail-on-error`.

Une erreur de lexer indique un problème de lecture d'un fichier. Ne pas transformer ce cas en « 0 % de duplication ». Les anciennes options qui ignorent des erreurs lexicales peuvent cacher un périmètre incomplet. [Options et codes de sortie](https://github.com/pmd/pmd/blob/main/docs/pages/pmd/userdocs/cpd/cpd.md).

Vérification avec PMD 7.29.0 : source de démonstration acceptée, duplication volontaire bloquée avec le code 4, fichier à chaîne non terminée bloqué avec le code 5. Le contrôle et son artefact passent aussi sur GitHub Actions Linux.

[Exemple exécutable](../80-Exemples/csharp-ci/README.md) · [Comparer Base et PR](../02-Concepts/Comparer-Base-et-PR.md)
