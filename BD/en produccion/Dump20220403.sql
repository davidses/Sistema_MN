-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: siscontrol
-- ------------------------------------------------------
-- Server version	8.0.28

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
  `idClientes` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) DEFAULT NULL,
  `Direccion` varchar(80) DEFAULT NULL,
  `Telefono` varchar(11) DEFAULT NULL,
  `Observaciones` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`idClientes`),
  UNIQUE KEY `idClientes_UNIQUE` (`idClientes`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (6,'ADRIAN ROSA','GRAHAM BELL 2725','3513069596','YO'),(7,'ARIELA','','3516203174','AMIGA NANCY'),(8,'JUAN NOTEBOOK','','3518637811','GREMIO'),(9,'IVAN FLORES','','3517520098','HERMANO GUILLE'),(10,'LORENA','','3512315362',''),(11,'JOSE PADRINO EMA','','3515129877','');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipos`
--

DROP TABLE IF EXISTS `equipos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equipos` (
  `idEquipos` int NOT NULL,
  `Tipo` varchar(45) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Observaciones` varchar(250) DEFAULT NULL,
  `Clientes_idClientes` int NOT NULL,
  PRIMARY KEY (`idEquipos`),
  UNIQUE KEY `idEquipos_UNIQUE` (`idEquipos`),
  KEY `fk_Equipos_Clientes_idx` (`Clientes_idClientes`),
  CONSTRAINT `fk_Equipos_Clientes` FOREIGN KEY (`Clientes_idClientes`) REFERENCES `clientes` (`idClientes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipos`
--

LOCK TABLES `equipos` WRITE;
/*!40000 ALTER TABLE `equipos` DISABLE KEYS */;
INSERT INTO `equipos` VALUES (61,'NOTEBOOK','ACER ASPIRE ONE D257-1800','SN: 12010340225',11),(111,'NOTEBOOK','BANGHO B-X0X1','SN: ??',10),(120,'NOTEBOOK','ACER ES1-431 (N15Q5)','SN: NXMZCAL009648105F17600\r\n',7),(124,'NOTEBOOK','LENOVO G475','SN: MB00131077',6),(143,'NOTEBOOK','NETBOOK G2 (BANGHO)','SN: AA2073652635',8),(144,'NOTEBOOK','NETBOOK G13 (PLAN CEIBAL URUGUAY)','SN: ??',8),(145,'NOTEBOOK','HP 11-R002LA','SN: SCD5527K5W',9),(146,'MONITOR','SAMSUNG S19A300B','SN: 2111H8XBA04773A',9);
/*!40000 ALTER TABLE `equipos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fichas`
--

DROP TABLE IF EXISTS `fichas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fichas` (
  `idFichas` int NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `Realizar` varchar(250) DEFAULT NULL,
  `Realizado` varchar(250) DEFAULT NULL,
  `Importe` decimal(6,0) DEFAULT NULL,
  `Observaciones` varchar(250) DEFAULT NULL,
  `Equipos_idEquipos` int NOT NULL,
  `Estado` varchar(45) NOT NULL,
  PRIMARY KEY (`idFichas`),
  UNIQUE KEY `idFichas_UNIQUE` (`idFichas`),
  KEY `fk_Fichas_Equipos1_idx` (`Equipos_idEquipos`),
  CONSTRAINT `fk_Fichas_Equipos1` FOREIGN KEY (`Equipos_idEquipos`) REFERENCES `equipos` (`idEquipos`)
) ENGINE=InnoDB AUTO_INCREMENT=207 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fichas`
--

LOCK TABLES `fichas` WRITE;
/*!40000 ALTER TABLE `fichas` DISABLE KEYS */;
INSERT INTO `fichas` VALUES (200,'2022-04-03','NO BOOTEA','- DISCO ROTO (CONSEGUIR LOGICA PARA RECUPERAR INFO)',0,'CON BATT, CARGADOR Y BOLSA NARANJA',120,'PENDIENTE'),(201,'2022-04-03','- AL GOLPEARLA SE APAGA','- PRUEBA REALIZADA CON EXITO (NO SE APAGO NUNCA)\r\n- SE RECOMENDARA QUE EL CLIENTE REVISE EL CARGADOR',0,'CON BATT SIN CARGADOR',143,'TERMINADO'),(202,'2022-04-03','- DESBLOQUEAR','- SE PROBO UN BIN DE (LEO037) PERO NO BOOTEABA, SE VOLVIO AL BIN ORIGINAL Y SE VA A FORMATEAR PARA VER EL CONTADOR DE ARRANQUES.',0,'SIN CARGADOR',144,'PENDIENTE'),(203,'2022-04-03','- NO BOOTEA\r\n- SE DESCONFIGURO LA BIOS POR FALTA DE PILA','',0,'SIN CARGADOR',145,'PENDIENTE'),(204,'2022-04-03','- NO ENCIENDE\r\n*** CAMBIAR CONTROLADOR VCC_CORE (TPS51218) Y MOSFET ALTA/BAJA','** PRESUPUESTO NO ACEPTADOR **',0,'CON BAT Y CARGADOR',111,'TERMINADO'),(205,'2022-04-03','- PANTALLA ROTA (NO SE CONSIGUE AUN)','',0,'CON BATT SIN CARGADOR',61,'PENDIENTE'),(206,'2022-04-03','- NO ENCIENDE','',0,'CON CARGADOR Y BASE COMPLETA',146,'PENDIENTE');
/*!40000 ALTER TABLE `fichas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-03 12:58:41
