# Contribution au projet

## Conventions de commits

Les messages de commit suivent le format Conventional Commits : `<type>(<portée>): <description>`.

Regrouper les changements et créer les commits dans l’ordre suivant, uniquement pour les catégories réellement présentes :

1. Fichiers de base du projet : `chore(app): ...`
2. Fichiers Git et configuration de l’éditeur, notamment `.git` et `.editorconfig` : utiliser une portée `chore(...)` adaptée.
3. Fichiers de configuration GitHub (`.github`) : utiliser une portée `chore(...)` adaptée.
4. Fonctionnalités métier : `feat(métier): ...`
5. Fonctionnalités de données : `feat(données): ...`

Respecter cet ordre lorsque plusieurs catégories sont modifiées. Chaque commit doit contenir uniquement les changements cohérents de sa catégorie et décrire précisément son contenu.
