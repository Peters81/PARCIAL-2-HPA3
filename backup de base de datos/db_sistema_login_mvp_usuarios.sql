-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: localhost    Database: db_sistema_login_mvp
-- ------------------------------------------------------
-- Server version	8.0.46

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
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `dsId` varchar(50) NOT NULL,
  `dsUsuario` varchar(50) NOT NULL,
  `dsPassword` varchar(255) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
  `dsEstado` char(1) NOT NULL DEFAULT '1',
  `dtFechaCreacion` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `nombreCompleto` varchar(100) NOT NULL DEFAULT '',
  `correo` varchar(120) NOT NULL DEFAULT '',
  `rol` varchar(50) NOT NULL DEFAULT 'Operador',
  PRIMARY KEY (`id`),
  UNIQUE KEY `dsId` (`dsId`),
  UNIQUE KEY `dsUsuario` (`dsUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'001','admin','PBKDF2-SHA256$600000$N8nKWgTzw+eyUQSgO2x5nw==$Hj9mxjMqkQaXMsE5r9F4YFelfbGOLD0uFuV/mh+3F5Q=','1','2026-11-08 19:50:55','Administrador de demostración','admin@example.com','Administrador'),(2,'002','luis','PBKDF2-SHA256$600000$5cNJm+qdJe7rgAd/t2qnuA==$khuppp1NoRIoY+/NFVCGbyLx/tZNhV2ryeOEE9kUrVM=','1','2026-11-08 19:50:55','Luis (demostración)','luis@example.com','Operador'),(3,'003','cristell','PBKDF2-SHA256$600000$bmhnffg/9O3j6C9+GwgVew==$Yz3Nk0esIV5z4efplRO9q33oDliOk9acYeMH0EgfIzA=','1','2026-11-08 19:50:55','Cristell (demostración)','cristell@example.com','Operador'),(4,'004','carlos','PBKDF2-SHA256$600000$tfyijIY1d12aBWKbU/ZTrQ==$9anBzLgsKZ7/8vk6vbfMkG3r3WYeCpXRP/0T7StkpkA=','0','2026-11-08 19:50:55','Carlos (demostración)','carlos@example.com','Operador');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-11-09 11:33:39
