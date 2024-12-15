# Campus Events Management System

Un système de gestion d'événements pour campus permettant aux enseignants de créer et gérer des événements, et aux étudiants de les consulter.

## Prérequis

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download)
- [dotnet-ef](https://www.nuget.org/packages/dotnet-ef)
- Docker
- Git

## Installation et Configuration

1. Cloner le projet
```bash
git clone https://github.com/DavidGailleton/dotnet_mvc_web_isitech.git
cd ./dotnet_mvc_web_isitech
```

2. Démarrer la base de données MariaDB avec Docker
```bash
docker-compose up -d
```

3. Installer les dépendances du projet
```bash
dotnet restore
```

4. Appliquer les migrations pour créer la base de données
```bash
dotnet ef database update
```

## Démarrage du projet

1. Lancer l'application
```bash
dotnet run
```

2. Ouvrir un navigateur et aller à l'url indiqué dans le terminal

## Comptes de test

L'application est préchargée avec plusieurs comptes de test :

### Enseignants
- Email: martin.dupont@teacher.com
- Mot de passe: Teacher123!

### Étudiants
- Email: lucas.petit@student.com
- Mot de passe: Student123!

## Fonctionnalités à tester

### Pour les Teachers

1. Connexion
    - Utiliser les identifiants enseignant fournis
    - Accéder à la page de connexion via le bouton "Login"

2. Gestion des événements
    - Créer un nouvel événement via le bouton "Create New Event"
    - Modifier un événement existant
    - Supprimer un événement
    - Visualiser la liste des événements

3. Gestion des comptes
    - Visualiser la liste des étudiants
    - Modifier les informations des étudiants
    - Supprimer des comptes étudiants

### Pour les Students

1. Inscription
    - Créer un nouveau compte étudiant via le formulaire d'inscription
    - Renseigner les informations requises

2. Consultation des événements
    - Visualiser la liste des événements
    - Utiliser les filtres de recherche (titre, date)
    - Consulter les détails d'un événement

## Fonctionnalités supplémentaires

- Pagination sur la liste des événements
- Tri des événements par date ou titre
- Export PDF des événements

## Structure du projet

- `Controllers/` : Contrôleurs de l'application
- `Models/` : Modèles de données et ViewModels
- `Views/` : Vues de l'application
- `Data/` : Configuration de la base de données
- `Migrations/` : Migrations Entity Framework

## Tests à effectuer

1. Test du système d'authentification
    - Création de compte
    - Connexion
    - Déconnexion
    - Accès aux fonctionnalités restreintes

2. Test de la gestion des événements
    - CRUD complet pour les enseignants
    - Consultation pour les étudiants
    - Validation des formulaires
    - Messages de confirmation

3. Test des fonctionnalités de recherche
    - Filtrage par titre
    - Filtrage par date
    - Pagination
    - Tri