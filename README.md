##  Système de Gestion RH

### 1. **Contexte**
Le projet vise à développer un système de gestion des ressources humaines (RH) basé sur le web, qui permettra de gérer efficacement les données des employés, le suivi de la présence et la gestion des salaires. Ce système vise à automatiser et à améliorer les processus RH internes tout en facilitant la prise de décision basée sur les données.

### 2. **Objectifs**
- Créer un système de gestion RH pour centraliser les données des employés.
- Suivre les présences et absences des employés de manière précise.
- Automatiser la gestion des salaires en intégrant des fonctions de traitement de la paie.
- Améliorer l'efficacité du flux de travail RH et réduire les erreurs humaines.

### 3. **Technologies Utilisées**
- **Framework**: .NET Core 6.0
- **Langage de Programmation**: C#
- **Framework Frontend**: ASP.NET MVC
- **ORM**: Entity Framework et Dapper
- **Base de Données**: SQL Server
- **Environnement de Développement**: Visual Studio Code
- **Système de Gestion de Versions**: Git

### 4. **Fonctionnalités Fonctionnelles**
#### 4.1 Gestion des Employés
- Ajouter, modifier, supprimer et afficher des informations sur les employés.
- Champs requis pour chaque employé : Nom, Prénom, Poste, Salaire, Date d'embauche, Département.

#### 4.2 Suivi des Présences
- Saisie quotidienne des présences et absences des employés.
- Génération de rapports mensuels de présence.
- Calcul des heures supplémentaires.

#### 4.3 Gestion de la Paie
- Calcul automatique des salaires mensuels en fonction des données de présence.
- Prise en compte des primes, des heures supplémentaires et des retenues.
- Génération de bulletins de paie pour chaque employé.

#### 4.4 Gestion des Congés
- Système de demande de congés par les employés.
- Validation et suivi des congés par le service RH.

### 5. **Fonctionnalités Non Fonctionnelles**
#### 5.1 Sécurité
- Authentification des utilisateurs avec différents niveaux d’accès (Admin, RH, Employés).
- Gestion des rôles et des autorisations.
  
#### 5.2 Performances
- Système optimisé pour un grand nombre d'employés et un accès simultané de plusieurs utilisateurs.
  
#### 5.3 Accessibilité
- Interface utilisateur intuitive et responsive, compatible avec les mobiles et les tablettes.

#### 5.4 Fiabilité et Disponibilité
- Sauvegarde automatique et régulier des données.
- Disponibilité continue du système, avec un taux d'erreur minimal.

### 6. **Architecture**
Le système sera basé sur une architecture **MVC** (Model-View-Controller). L’interaction avec la base de données se fera via **Entity Framework** et **Dapper**. Les modèles représenteront les données et la logique métier, les vues afficheront les informations, et les contrôleurs géreront les requêtes utilisateur et les réponses.

### 7. **Base de Données**
La base de données sera conçue avec **SQL Server** pour stocker les informations relatives aux employés, à leurs présences, aux salaires, et aux congés. La base sera structurée de manière à supporter une croissance future.

#### Modèle de Données (Exemple)
- **Table Employés**: Id, Nom, Prénom, Date d’embauche, Département, Salaire.
- **Table Présences**: Id, EmployéId, Date, Statut (Présent/Absent).
- **Table Paie**: Id, EmployéId, Mois, SalaireBrut, Retenues, SalaireNet.

### 8. **Gestion des Risques**
- **Risque de Sécurité**: Gestion des accès via des rôles et des permissions bien définis.
- **Risque de Perte de Données**: Mise en place de sauvegardes régulières.
- **Risque de Non-Respect des Délais**: Utilisation de méthodologies agiles (SCRUM) pour suivre les étapes du projet.

### 9. **Planification**
Le projet sera découpé en plusieurs sprints, chacun ayant un objectif précis :
- **Sprint 1**: Création des modèles et de la base de données.
- **Sprint 2**: Développement du module de gestion des employés.
- **Sprint 3**: Développement du module de suivi des présences.
- **Sprint 4**: Développement du module de gestion de la paie.
- **Sprint 5**: Tests, déploiement et maintenance.

### 10. **Responsabilités**
- **Développeur Backend**: Développer les API et l’interaction avec la base de données via Entity Framework et Dapper.
- **Développeur Frontend**: Développer l’interface utilisateur avec ASP.NET MVC.
- **Responsable RH**: Valider les fonctionnalités spécifiques aux ressources humaines.
