# Application de Gestion Commerciale - DeclicInfo

## Contexte et Objectifs du Projet
Cette application est un projet de deuxième année de BTS développé en mode collaboratif. Elle consiste en une application lourde de gestion commerciale dédiée à l'entreprise DECLICINFO. L'objectif principal de la solution est d'offrir une interface centralisée et sécurisée pour piloter l'activité commerciale après une authentification obligatoire.

L'application permet aux utilisateurs de :
* Consulter, ajouter, modifier et supprimer des fiches clients.
* Administrer le catalogue des produits (suivi des prix de vente et des catégories).
* Créer et mettre à jour les devis de l'entreprise.
* Consulter une synthèse complète des clients avec un système de filtrage ciblé.

---

## Architecture et Navigation de l'Application

L'accès global aux fonctionnalités est protégé par un mécanisme d'authentification strict.

### Écran d'Authentification
* **Formulaire de Connexion :** L'accès requiert la saisie d'un Nom d'utilisateur (Login) et d'un Mot de passe valides fournis par l'administrateur.
* **Contrôle de sécurité :** En cas de saisie erronée, l'application bloque l'accès et affiche un message d'erreur. Une authentification réussie redirige automatiquement l'utilisateur vers le menu principal.

### Menu Principal (Page d'Accueil)
Une fois connecté, l'utilisateur accède à un tableau de bord structuré en quatre grands blocs thématiques permettant de piloter l'activité :
* **Produits :** Liens d'accès direct vers la liste, l'ajout, la modification et la suppression de produits.
* **Clients :** Liens d'accès pour l'affichage de la liste, l'ajout, la modification et la suppression de fiches clients.
* **Devis :** Liens d'accès vers la consultation de la liste, la création, l'édition et la suppression de devis.
* **Synthèse :** Module transversal permettant d'obtenir une vue d'ensemble de l'activité des clients.

---

## Règles de Gestion et Validations Métier

L'application intègre des contrôles d'intégrité pour sécuriser les données de la base de données :
* **Génération des Identifiants :** Lors de l'ajout d'un nouveau client, le système prend en charge la création de la fiche et l'identifiant unique du client est automatiquement auto-généré par l'application.
* **Contrainte de suppression des clients :** Par mesure de sécurité et pour préserver l'historique commercial, la suppression d'un client est strictement autorisée uniquement si aucun devis n'est associé à ce dernier.

---

## Spécifications Techniques

L'application s'appuie sur une infrastructure technique spécifique :
* **Langage de programmation :** C#
* **Framework :** .NET 2.0 (Application lourde)
* **Système de Gestion de Base de Données :** Microsoft SQL Server 2019
* **Outil de Gestion :** SQL Server Management Studio (SSMS)

---

## Installation du Projet et Démarrage

### 1. Prérequis Système
* Environnement Windows configuré pour l'exécution d'applications .NET 2.0.
* Instance active de Microsoft SQL Server 2019 installée localement ou accessible sur le réseau.

### 2. Configuration de la Base de Données
1. Lancez SQL Server Management Studio (SSMS) et connectez-vous à votre instance de base de données.
2. Créez une nouvelle base de données contenant les structures nécessaires pour accueillir les relations clients, produits et devis.
3. Exécutez le script SQL de déploiement (comprenant les structures de tables et le jeu d'essai initial) fourni dans les sources du projet.

### 3. Fichier de Configuration
Ajustez la chaîne de connexion au sein du fichier de configuration de l'application (ex: `App.config`) pour l'associer à votre instance locale SQL Server :
```xml
<connectionStrings>
    <add name="DeclicInfoConnectionString" connectionString="Data Source=VOTRE_SERVEUR_SQL;Initial Catalog=DeclicInfo;Integrated Security=True;" />
</connectionStrings>
