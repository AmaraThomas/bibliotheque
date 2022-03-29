-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mar. 29 mars 2022 à 13:25
-- Version du serveur : 10.4.21-MariaDB
-- Version de PHP : 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `sqlbibliotheque`
--

-- --------------------------------------------------------

--
-- Structure de la table `abonne`
--

CREATE TABLE `abonne` (
  `Id_abonne` int(11) NOT NULL,
  `nom` varchar(255) DEFAULT NULL,
  `prenom` varchar(255) DEFAULT NULL,
  `adresse` varchar(255) DEFAULT NULL,
  `date_adhesion` date DEFAULT NULL,
  `matricule` varchar(255) DEFAULT NULL,
  `telephone` varchar(255) DEFAULT NULL,
  `date_naissance` date DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `deleted` bit(1) NOT NULL,
  `Id_categorie` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `auteur`
--

CREATE TABLE `auteur` (
  `Id_auteur` int(11) NOT NULL,
  `nom` varchar(255) DEFAULT NULL,
  `prenom` varchar(255) DEFAULT NULL,
  `deleted` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `auteur_livre`
--

CREATE TABLE `auteur_livre` (
  `Id_livre` int(11) NOT NULL,
  `Id_auteur` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `Id_categorie` int(11) NOT NULL,
  `titre` varchar(255) DEFAULT NULL,
  `deleted` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `editeur`
--

CREATE TABLE `editeur` (
  `Id_editeur` int(11) NOT NULL,
  `nom` varchar(255) DEFAULT NULL,
  `deleted` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `emprunt`
--

CREATE TABLE `emprunt` (
  `Id_emprunt` int(11) NOT NULL,
  `date_sortie` date DEFAULT NULL,
  `date_retour` date DEFAULT NULL,
  `deleted` bit(1) NOT NULL,
  `Id_exemplaire` int(11) NOT NULL,
  `Id_abonne` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `exemplaire`
--

CREATE TABLE `exemplaire` (
  `Id_exemplaire` int(11) NOT NULL,
  `date_achat` date DEFAULT NULL,
  `emplacement` varchar(255) DEFAULT NULL,
  `deleted` bit(1) NOT NULL,
  `Id_editeur` int(11) NOT NULL,
  `Id_usure` int(11) NOT NULL,
  `Id_livre` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `livre`
--

CREATE TABLE `livre` (
  `Id_livre` int(11) NOT NULL,
  `titre` varchar(255) DEFAULT NULL,
  `isbn` varchar(255) DEFAULT NULL,
  `deleted` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `livre_motcle`
--

CREATE TABLE `livre_motcle` (
  `Id_livre` int(11) NOT NULL,
  `Id_motcle` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `livre_theme`
--

CREATE TABLE `livre_theme` (
  `Id_livre` int(11) NOT NULL,
  `Id_theme` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `motcle`
--

CREATE TABLE `motcle` (
  `Id_motcle` int(11) NOT NULL,
  `mot` varchar(255) DEFAULT NULL,
  `deleted` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE `reservation` (
  `Id_reservation` int(11) NOT NULL,
  `date_reservation` date DEFAULT NULL,
  `deleted` bit(1) NOT NULL,
  `Id_editeur` int(11) DEFAULT NULL,
  `Id_livre` int(11) NOT NULL,
  `Id_abonne` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `theme`
--

CREATE TABLE `theme` (
  `Id_theme` int(11) NOT NULL,
  `titre` varchar(255) DEFAULT NULL,
  `deleted` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `usure`
--

CREATE TABLE `usure` (
  `Id_usure` int(11) NOT NULL,
  `etat` varchar(255) DEFAULT NULL,
  `deleted` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `abonne`
--
ALTER TABLE `abonne`
  ADD PRIMARY KEY (`Id_abonne`),
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `Id_categorie` (`Id_categorie`);

--
-- Index pour la table `auteur`
--
ALTER TABLE `auteur`
  ADD PRIMARY KEY (`Id_auteur`);

--
-- Index pour la table `auteur_livre`
--
ALTER TABLE `auteur_livre`
  ADD PRIMARY KEY (`Id_livre`,`Id_auteur`),
  ADD KEY `Id_auteur` (`Id_auteur`);

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`Id_categorie`);

--
-- Index pour la table `editeur`
--
ALTER TABLE `editeur`
  ADD PRIMARY KEY (`Id_editeur`);

--
-- Index pour la table `emprunt`
--
ALTER TABLE `emprunt`
  ADD PRIMARY KEY (`Id_emprunt`),
  ADD KEY `Id_exemplaire` (`Id_exemplaire`),
  ADD KEY `Id_abonne` (`Id_abonne`);

--
-- Index pour la table `exemplaire`
--
ALTER TABLE `exemplaire`
  ADD PRIMARY KEY (`Id_exemplaire`),
  ADD KEY `Id_editeur` (`Id_editeur`),
  ADD KEY `Id_usure` (`Id_usure`),
  ADD KEY `Id_livre` (`Id_livre`);

--
-- Index pour la table `livre`
--
ALTER TABLE `livre`
  ADD PRIMARY KEY (`Id_livre`);

--
-- Index pour la table `livre_motcle`
--
ALTER TABLE `livre_motcle`
  ADD PRIMARY KEY (`Id_livre`,`Id_motcle`),
  ADD KEY `Id_motcle` (`Id_motcle`);

--
-- Index pour la table `livre_theme`
--
ALTER TABLE `livre_theme`
  ADD PRIMARY KEY (`Id_livre`,`Id_theme`),
  ADD KEY `Id_theme` (`Id_theme`);

--
-- Index pour la table `motcle`
--
ALTER TABLE `motcle`
  ADD PRIMARY KEY (`Id_motcle`);

--
-- Index pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`Id_reservation`),
  ADD KEY `Id_editeur` (`Id_editeur`),
  ADD KEY `Id_livre` (`Id_livre`),
  ADD KEY `Id_abonne` (`Id_abonne`);

--
-- Index pour la table `theme`
--
ALTER TABLE `theme`
  ADD PRIMARY KEY (`Id_theme`);

--
-- Index pour la table `usure`
--
ALTER TABLE `usure`
  ADD PRIMARY KEY (`Id_usure`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `abonne`
--
ALTER TABLE `abonne`
  MODIFY `Id_abonne` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `auteur`
--
ALTER TABLE `auteur`
  MODIFY `Id_auteur` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `Id_categorie` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `editeur`
--
ALTER TABLE `editeur`
  MODIFY `Id_editeur` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `emprunt`
--
ALTER TABLE `emprunt`
  MODIFY `Id_emprunt` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `exemplaire`
--
ALTER TABLE `exemplaire`
  MODIFY `Id_exemplaire` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `livre`
--
ALTER TABLE `livre`
  MODIFY `Id_livre` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `motcle`
--
ALTER TABLE `motcle`
  MODIFY `Id_motcle` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `Id_reservation` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `theme`
--
ALTER TABLE `theme`
  MODIFY `Id_theme` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `usure`
--
ALTER TABLE `usure`
  MODIFY `Id_usure` int(11) NOT NULL AUTO_INCREMENT;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `abonne`
--
ALTER TABLE `abonne`
  ADD CONSTRAINT `abonne_ibfk_1` FOREIGN KEY (`Id_categorie`) REFERENCES `categorie` (`Id_categorie`);

--
-- Contraintes pour la table `auteur_livre`
--
ALTER TABLE `auteur_livre`
  ADD CONSTRAINT `auteur_livre_ibfk_1` FOREIGN KEY (`Id_livre`) REFERENCES `livre` (`Id_livre`),
  ADD CONSTRAINT `auteur_livre_ibfk_2` FOREIGN KEY (`Id_auteur`) REFERENCES `auteur` (`Id_auteur`);

--
-- Contraintes pour la table `emprunt`
--
ALTER TABLE `emprunt`
  ADD CONSTRAINT `emprunt_ibfk_1` FOREIGN KEY (`Id_exemplaire`) REFERENCES `exemplaire` (`Id_exemplaire`),
  ADD CONSTRAINT `emprunt_ibfk_2` FOREIGN KEY (`Id_abonne`) REFERENCES `abonne` (`Id_abonne`);

--
-- Contraintes pour la table `exemplaire`
--
ALTER TABLE `exemplaire`
  ADD CONSTRAINT `exemplaire_ibfk_1` FOREIGN KEY (`Id_editeur`) REFERENCES `editeur` (`Id_editeur`),
  ADD CONSTRAINT `exemplaire_ibfk_2` FOREIGN KEY (`Id_usure`) REFERENCES `usure` (`Id_usure`),
  ADD CONSTRAINT `exemplaire_ibfk_3` FOREIGN KEY (`Id_livre`) REFERENCES `livre` (`Id_livre`);

--
-- Contraintes pour la table `livre_motcle`
--
ALTER TABLE `livre_motcle`
  ADD CONSTRAINT `livre_motcle_ibfk_1` FOREIGN KEY (`Id_livre`) REFERENCES `livre` (`Id_livre`),
  ADD CONSTRAINT `livre_motcle_ibfk_2` FOREIGN KEY (`Id_motcle`) REFERENCES `motcle` (`Id_motcle`);

--
-- Contraintes pour la table `livre_theme`
--
ALTER TABLE `livre_theme`
  ADD CONSTRAINT `livre_theme_ibfk_1` FOREIGN KEY (`Id_livre`) REFERENCES `livre` (`Id_livre`),
  ADD CONSTRAINT `livre_theme_ibfk_2` FOREIGN KEY (`Id_theme`) REFERENCES `theme` (`Id_theme`);

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`Id_editeur`) REFERENCES `editeur` (`Id_editeur`),
  ADD CONSTRAINT `reservation_ibfk_2` FOREIGN KEY (`Id_livre`) REFERENCES `livre` (`Id_livre`),
  ADD CONSTRAINT `reservation_ibfk_3` FOREIGN KEY (`Id_abonne`) REFERENCES `abonne` (`Id_abonne`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
