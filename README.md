<p align="center">
  <img src="https://sites.google.com/site/portcomptongjea/_/rsrc/1472690907149/missions/projetpersonnelencadre-bts/gsb.jpg" style="width:130px; height:100px;" />
</p>
 <h3 align="center">Projet gesAMM</h3>

  <p align="center">
    <a href="https://github.com/lebruntom/Ap_6/issues">Signaler un Bug</a>
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Sommaire</summary>
  <ol>
    <li>
      <a href="#Presentation">Présentation</a>
      <ul>
        <li><a href="#Contexte">Contexte</a></li>
        <li><a href="#Projet">Projet</a></li>
	<li><a href="#Technologie">Technologies Utilisées</a></li>
      </ul>
    </li>
    <li>
      <a href="#Installation">Installation</a>
      <ul>
        <li><a href="#Prerequis">Les Prérequis</a></li>
        <li><a href="#Importation">Importation du projet</a></li>
        <li><a href="#Configuration">Configuration</a></li>
      </ul>
    </li>
    <li><a href="#Utilisation">Utilisation</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

<!-- Contexte -->
## Contexte

Le laboratoire Galaxy Swiss Bourdin (GSB) est issu de la fusion entre le géant américain Galaxy et le conglomérat européen Swiss Bourdin L'entreprise est un grand groupe pharmaceutique qui fabrique des médicaments.

Dans ce projet, notre équipe était composée de 3 personnes.

<p align="right">(<a href="#top">Retour en haut</a>)</p>

### Projet

GSB désire mettre à disposition de l'équipe technique de l'entreprise une application dédiée au suivi des étapes de validation de mise sur le marché d'un médicament.

Le laboratoire GSB désire se pourvoir d'une application interne, accessible uniquement au personnel du laboratoire technique, application de type client/serveur.

<p align="right">(<a href="#top">Retour en haut</a>)</p>


### Technologie

Lors de la réalisation de ce projet, nous avons utilisés différentes technologies :

* [C#](https://fr.wikipedia.org/wiki/C_sharp)
* [SQL Server](https://fr.wikipedia.org/wiki/Microsoft_SQL_Server/)

<p align="right">(<a href="#top">Retour en haut</a>)</p>

<!-- Installation -->
## Installation

Afin de pouvoir visualiser et utiliser notre projet, il est néccessaire de procéder à quelques actions :

### Les Prérequis

Dans un premier temps, nous aurons de visual studio pour programmer en c#

* Télécharger visual studio sur [visualstudio.microsoft.com](https://visualstudio.microsoft.com/fr/downloads/)


Ensuite, nous aurons besoin de SQL Server

* Télécharger SQL Server sur [microsoft.com](https://www.microsoft.com/fr-fr/sql-server/sql-server-downloads)

Vous aurez aussi besoin du script de la création de la base de données accéssible dans le projet en format .sql
### Importation

1. Importez la base de données dans SQL server et executer la en vérifiant que toutes les tables se sont correctement créées.


### Configuration

Une fois le projet lancé dans visual studio et la base de données importée, rendez vous dans la class BD du projet.

Modifiez les informations de connexion à la base de données en changeant le nom du poste, en mettant le nom du votre à la place et en modifiant le nom de la base de données si votre nom de base de données et différent que celui indiqué.
```c#
//connection à la base de données
private static string Connexionstring = @"Data Source=BTS2020-20\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
public static SqlConnection Connexion = new SqlConnection(Connexionstring);
```

<!-- Utilisation -->
## Utilisation

Le projet est constitué de différentes pages :

* une page d'accueil 
* une page d'ajout d'un médicament
* une page de consultation des médicaments par famille
* une page de mise à jour des étapes normées
* une page de consultation du workflow des étapes d'un médicament

<p align="right">(<a href="#top">Retour en haut</a>)</p>


<!-- CONTACT -->
## Contact

Tom Lebrun - [@TomLebrun](https://www.linkedin.com/in/tom-lebrun) - tomlebrun27@gmail.com

Lien du projet : [https://github.com/lebruntom/Ap_6](https://github.com/lebruntom/Ap_6)

<p align="right">(<a href="#top">Retour en haut</a>)</p>

