-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: sis_control
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.17-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `idClientes` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) DEFAULT NULL,
  `Direccion` varchar(80) DEFAULT NULL,
  `Telefono` varchar(11) DEFAULT NULL,
  `Observaciones` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`idClientes`),
  UNIQUE KEY `idClientes_UNIQUE` (`idClientes`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `equipos`
--

DROP TABLE IF EXISTS `equipos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equipos` (
  `idEquipos` int(11) NOT NULL,
  `Tipo` varchar(45) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Observaciones` varchar(250) DEFAULT NULL,
  `Clientes_idClientes` int(11) NOT NULL,
  PRIMARY KEY (`idEquipos`),
  UNIQUE KEY `idEquipos_UNIQUE` (`idEquipos`),
  KEY `fk_Equipos_Clientes_idx` (`Clientes_idClientes`),
  CONSTRAINT `fk_Equipos_Clientes` FOREIGN KEY (`Clientes_idClientes`) REFERENCES `clientes` (`idClientes`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `fichas`
--

DROP TABLE IF EXISTS `fichas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fichas` (
  `idFichas` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `Realizar` varchar(250) DEFAULT NULL,
  `Realizado` varchar(250) DEFAULT NULL,
  `Importe` decimal(6,0) DEFAULT NULL,
  `Observaciones` varchar(250) DEFAULT NULL,
  `Equipos_idEquipos` int(11) NOT NULL,
  `Estado` varchar(45) NOT NULL,
  PRIMARY KEY (`idFichas`),
  UNIQUE KEY `idFichas_UNIQUE` (`idFichas`),
  KEY `fk_Fichas_Equipos1_idx` (`Equipos_idEquipos`),
  CONSTRAINT `fk_Fichas_Equipos1` FOREIGN KEY (`Equipos_idEquipos`) REFERENCES `equipos` (`idEquipos`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-17 17:26:39
