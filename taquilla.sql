-- MySQL dump 10.13  Distrib 5.7.12, for Win32 (AMD64)
--
-- Host: localhost    Database: taquilla
-- ------------------------------------------------------
-- Server version	5.7.20-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bitacora` (
  `id_bitacora` int(11) NOT NULL AUTO_INCREMENT,
  `operacion_bitacora` varchar(45) DEFAULT NULL,
  `fecha_hora_bitacora` datetime DEFAULT NULL,
  `usu_usuario` varchar(45) NOT NULL,
  `host_bitacora` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_bitacora`),
  KEY `fk_Bitacora_Usuario1_idx` (`usu_usuario`),
  CONSTRAINT `fk_Bitacora_Usuario1` FOREIGN KEY (`usu_usuario`) REFERENCES `usuario` (`usu_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
INSERT INTO `bitacora` VALUES (1,'LOG IN','2018-08-05 17:34:42','chopes','chopes@localhost'),(2,'LOG IN','2018-08-05 17:38:13','chopes','chopes@localhost'),(3,'LOG IN','2018-08-05 18:05:12','chopes','root@localhost'),(4,'LOG IN','2018-08-05 20:35:49','chopes','root@localhost'),(5,'LOG IN','2018-08-05 20:46:39','chopes','root@localhost'),(6,'LOG IN','2018-08-05 22:07:32','chopes','chopes@localhost'),(7,'LOG IN','2018-08-05 22:09:41','chopes','chopes@localhost'),(8,'LOG IN','2018-08-06 22:12:18','chopes','chopes@localhost'),(9,'LOG IN','2018-08-06 22:14:02','chopes','chopes@localhost'),(10,'LOG IN','2018-08-06 22:16:02','chopes','chopes@localhost'),(11,'LOG IN','2018-08-06 23:47:49','chopes','chopes@localhost'),(12,'LOG IN','2018-08-07 17:45:01','chopes','chopes@localhost'),(13,'LOG IN','2018-08-07 21:04:07','chopes','chopes@localhost'),(14,'LOG IN','2018-08-07 21:04:51','chopes','chopes@localhost'),(15,'LOG IN','2018-08-07 21:09:03','CHOPES','chopes@localhost'),(16,'LOG IN','2018-08-07 21:20:12','chopes','chopes@localhost'),(17,'LOG IN','2018-08-07 21:37:16','chopes','chopes@localhost'),(18,'LOG IN','2018-08-08 01:49:26','chopes','chopes@localhost'),(19,'LOG IN','2018-08-08 01:50:15','chopes','chopes@localhost'),(20,'LOG IN','2018-08-08 01:54:14','CHOPES','chopes@localhost'),(21,'LOG IN','2018-08-08 01:58:38','chopes','chopes@localhost');
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cine`
--

DROP TABLE IF EXISTS `cine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cine` (
  `id_cine` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_cine` varchar(30) DEFAULT NULL,
  `direccion_cine` varchar(45) DEFAULT NULL,
  `id_departamento` int(11) NOT NULL,
  PRIMARY KEY (`id_cine`),
  KEY `fk_CINE_DEPARTAMENTO1_idx` (`id_departamento`),
  CONSTRAINT `fk_CINE_DEPARTAMENTO1` FOREIGN KEY (`id_departamento`) REFERENCES `departamento` (`id_departamento`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cine`
--

LOCK TABLES `cine` WRITE;
/*!40000 ALTER TABLE `cine` DISABLE KEYS */;
INSERT INTO `cine` VALUES (1,'MIRAFLORES','ZONA 11',1),(2,'PORTALES','ZONA 18',1),(3,'CAYALÁ','ZONA 16',1),(4,'OAKLAND MALL','ZONA 10',1),(5,'UTZ','ZONA 7 - XELA',2);
/*!40000 ALTER TABLE `cine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clasificacion`
--

DROP TABLE IF EXISTS `clasificacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clasificacion` (
  `id_clasificacion` int(11) NOT NULL AUTO_INCREMENT COMMENT 'A\nB\nC\nB15\nB12',
  `nombre_clasificacion` varchar(30) DEFAULT NULL,
  `descripcion_clasificacion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_clasificacion`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clasificacion`
--

LOCK TABLES `clasificacion` WRITE;
/*!40000 ALTER TABLE `clasificacion` DISABLE KEYS */;
INSERT INTO `clasificacion` VALUES (1,'A','Apta para todo público'),(2,'PG','Sugiere la compañía de un adulto (10 años)'),(3,'PG-13','Sugiere la compañía de un adulto (13 años)'),(4,'R','No apta para menores de 17 años '),(5,'NC-17','Contenido sólo apto para mayores de 18 años');
/*!40000 ALTER TABLE `clasificacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `email_cliente` varchar(35) NOT NULL,
  `nombre_cliente` varchar(30) DEFAULT NULL,
  `telefono_cliente` int(11) DEFAULT NULL,
  `puntos_cliente` float DEFAULT NULL,
  PRIMARY KEY (`email_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES ('chopes@hotmail.com','chopes',3434,0),('poncianojosue@hotmail.com','Josue Ponciano',4343,0);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamento` (
  `id_departamento` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_departamento` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_departamento`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (1,'Guatemala'),(2,'Quetzaltenango');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `experiencia`
--

DROP TABLE IF EXISTS `experiencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `experiencia` (
  `id_experiencia` int(11) NOT NULL AUTO_INCREMENT COMMENT '2D\n3D\n4DX\nVIP',
  `descripcion_experiencia` varchar(30) DEFAULT NULL,
  `precio_experiencia` float DEFAULT NULL,
  PRIMARY KEY (`id_experiencia`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `experiencia`
--

LOCK TABLES `experiencia` WRITE;
/*!40000 ALTER TABLE `experiencia` DISABLE KEYS */;
INSERT INTO `experiencia` VALUES (1,'VIP',85),(2,'NORMAL',40),(3,'4DX',110);
/*!40000 ALTER TABLE `experiencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura` (
  `id_factura` int(11) NOT NULL AUTO_INCREMENT,
  `monto_pago_factura` double DEFAULT NULL,
  `puntos_factura` float DEFAULT NULL,
  `id_metodo_pago` int(11) NOT NULL,
  `id_promocion` int(11) NOT NULL,
  `fecha_factura` date DEFAULT NULL,
  `hora_factura` time DEFAULT NULL,
  `email_cliente` varchar(35) NOT NULL,
  PRIMARY KEY (`id_factura`),
  KEY `fk_Factura_Metodo de pago1_idx` (`id_metodo_pago`),
  KEY `fk_Factura_Promocion1_idx` (`id_promocion`),
  KEY `fk_FACTURA_CLIENTE1_idx` (`email_cliente`),
  CONSTRAINT `fk_FACTURA_CLIENTE1` FOREIGN KEY (`email_cliente`) REFERENCES `cliente` (`email_cliente`),
  CONSTRAINT `fk_Factura_Metodo de pago1` FOREIGN KEY (`id_metodo_pago`) REFERENCES `metodo_pago` (`id_metodo_pago`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Factura_Promocion1` FOREIGN KEY (`id_promocion`) REFERENCES `promocion` (`id_promocion`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
INSERT INTO `factura` VALUES (2,6,0,2,1,'2018-08-07','19:50:17','chopes@hotmail.com'),(3,6,0,1,1,'2018-08-07','20:03:11','chopes@hotmail.com'),(4,6,0,2,1,'2018-08-07','21:46:52','chopes@hotmail.com'),(5,6,0,1,1,'2018-08-07','21:47:11','chopes@hotmail.com'),(6,6,0,2,1,'2018-08-07','21:47:32','chopes@hotmail.com'),(7,264,18.48,1,1,'2018-08-07','22:15:44','chopes@hotmail.com'),(8,712.8,49.896,2,1,'2018-08-07','22:16:17','chopes@hotmail.com'),(9,80,5.6,1,1,'2018-08-07','22:19:41','chopes@hotmail.com'),(10,80,5.6,1,1,'2018-08-07','22:20:25','chopes@hotmail.com'),(11,80,5.6,1,1,'2018-08-08','00:52:20','poncianojosue@hotmail.com'),(12,306,21.42,1,1,'2018-08-08','00:55:04','poncianojosue@hotmail.com'),(13,326.4,22.848,2,1,'2018-08-08','01:00:07','poncianojosue@hotmail.com'),(14,396,27.72,1,1,'2018-08-08','01:04:49','poncianojosue@hotmail.com'),(15,102,7.14,1,1,'2018-08-08','01:07:06','poncianojosue@hotmail.com'),(16,554.4,38.808,2,1,'2018-08-08','01:13:25','poncianojosue@hotmail.com'),(17,120,8.4,1,1,'2018-08-08','01:15:37','poncianojosue@hotmail.com'),(18,554.4,38.808,1,1,'2018-08-08','01:18:43','poncianojosue@hotmail.com'),(19,306,21.42,3,1,'2018-08-08','01:19:49','poncianojosue@hotmail.com'),(20,102,7.14,2,1,'2018-08-08','01:20:50','poncianojosue@hotmail.com'),(21,306,21.42,1,1,'2018-08-08','01:25:02','poncianojosue@hotmail.com'),(22,120,8.4,2,1,'2018-08-08','06:54:39','poncianojosue@hotmail.com'),(23,204,14.28,1,1,'2018-08-08','07:13:53','poncianojosue@hotmail.com'),(24,102,7.14,2,1,'2018-08-08','07:16:47','poncianojosue@hotmail.com');
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formato`
--

DROP TABLE IF EXISTS `formato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formato` (
  `id_formato` int(11) NOT NULL AUTO_INCREMENT COMMENT '2D\n3D\n4DX\nVIP',
  `descripcion_formato` varchar(30) DEFAULT NULL,
  `precio_formato` float DEFAULT NULL,
  PRIMARY KEY (`id_formato`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formato`
--

LOCK TABLES `formato` WRITE;
/*!40000 ALTER TABLE `formato` DISABLE KEYS */;
INSERT INTO `formato` VALUES (1,'2D',1),(2,'3D',1.2);
/*!40000 ALTER TABLE `formato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcion`
--

DROP TABLE IF EXISTS `funcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `funcion` (
  `id_funcion` int(11) NOT NULL AUTO_INCREMENT,
  `id_pelicula` int(11) NOT NULL,
  `fecha_funcion` date DEFAULT NULL,
  `id_subtitulado` int(11) NOT NULL,
  `id_idioma` int(11) NOT NULL,
  `id_horario` int(11) NOT NULL,
  `id_sala` int(11) NOT NULL,
  `id_formato` int(11) NOT NULL,
  PRIMARY KEY (`id_funcion`),
  KEY `fk_Hora_Funcion_Pelicula1_idx` (`id_pelicula`),
  KEY `fk_FUNCION_SUBTITULADO1_idx` (`id_subtitulado`),
  KEY `fk_FUNCION_IDIOMA1_idx` (`id_idioma`),
  KEY `fk_FUNCION_HORARIO1_idx` (`id_horario`),
  KEY `fk_FUNCION_SALA1_idx` (`id_sala`),
  KEY `fk_FUNCION_FORMATO1_idx` (`id_formato`),
  CONSTRAINT `fk_FUNCION_FORMATO1` FOREIGN KEY (`id_formato`) REFERENCES `formato` (`id_formato`),
  CONSTRAINT `fk_FUNCION_HORARIO1` FOREIGN KEY (`id_horario`) REFERENCES `horario` (`id_horario`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_FUNCION_IDIOMA1` FOREIGN KEY (`id_idioma`) REFERENCES `idioma` (`id_idioma`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_FUNCION_SALA1` FOREIGN KEY (`id_sala`) REFERENCES `sala` (`id_sala`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_FUNCION_SUBTITULADO1` FOREIGN KEY (`id_subtitulado`) REFERENCES `subtitulado` (`id_subtitulado`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Hora_Funcion_Pelicula1` FOREIGN KEY (`id_pelicula`) REFERENCES `pelicula` (`id_pelicula`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcion`
--

LOCK TABLES `funcion` WRITE;
/*!40000 ALTER TABLE `funcion` DISABLE KEYS */;
INSERT INTO `funcion` VALUES (1,1,'2018-08-08',2,1,1,1,2),(2,3,'2018-08-09',2,1,2,2,1),(3,4,'2018-08-10',2,1,3,3,2),(4,5,'2018-08-11',1,2,1,4,2),(5,6,'2018-08-12',1,2,2,5,1),(6,8,'2018-08-13',1,2,3,6,2),(7,1,'2018-08-14',2,1,1,1,2),(8,3,'2018-08-15',2,1,2,2,1),(9,4,'2018-08-08',2,1,3,3,2),(10,5,'2018-08-09',1,2,1,4,1),(11,6,'2018-08-10',1,2,2,5,2),(12,8,'2018-08-11',1,2,3,6,1),(13,1,'2018-08-12',2,1,1,1,2),(14,3,'2018-08-13',2,1,2,2,1),(15,4,'2018-08-14',2,1,3,3,2);
/*!40000 ALTER TABLE `funcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genero`
--

DROP TABLE IF EXISTS `genero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genero` (
  `id_genero` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ACCION\nCOMEDIA\nROMANCE...',
  `descripcion_genero` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_genero`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genero`
--

LOCK TABLES `genero` WRITE;
/*!40000 ALTER TABLE `genero` DISABLE KEYS */;
INSERT INTO `genero` VALUES (1,'DRAMA'),(2,'COMEDIA'),(3,'ACCION'),(4,'CIENCIA FICCION'),(5,'FANTASIA'),(6,'TERROR'),(7,'ROMANCE'),(8,'MUSICAL'),(9,'ANIMACION'),(10,'SUSPENSO');
/*!40000 ALTER TABLE `genero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horario`
--

DROP TABLE IF EXISTS `horario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horario` (
  `id_horario` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion_horario` time DEFAULT NULL,
  PRIMARY KEY (`id_horario`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horario`
--

LOCK TABLES `horario` WRITE;
/*!40000 ALTER TABLE `horario` DISABLE KEYS */;
INSERT INTO `horario` VALUES (1,'15:20:00'),(2,'22:30:00'),(3,'12:00:00');
/*!40000 ALTER TABLE `horario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `idioma`
--

DROP TABLE IF EXISTS `idioma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `idioma` (
  `id_idioma` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion_idioma` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_idioma`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `idioma`
--

LOCK TABLES `idioma` WRITE;
/*!40000 ALTER TABLE `idioma` DISABLE KEYS */;
INSERT INTO `idioma` VALUES (1,'ESPAÑOL'),(2,'INGLES');
/*!40000 ALTER TABLE `idioma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `metodo_pago`
--

DROP TABLE IF EXISTS `metodo_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `metodo_pago` (
  `id_metodo_pago` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion_metodo_pago` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_metodo_pago`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `metodo_pago`
--

LOCK TABLES `metodo_pago` WRITE;
/*!40000 ALTER TABLE `metodo_pago` DISABLE KEYS */;
INSERT INTO `metodo_pago` VALUES (1,'Visa'),(2,'Mastercard'),(3,'Amex');
/*!40000 ALTER TABLE `metodo_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pelicula`
--

DROP TABLE IF EXISTS `pelicula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pelicula` (
  `id_pelicula` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_pelicula` varchar(45) DEFAULT NULL,
  `estado_pelicula` int(11) DEFAULT NULL,
  `sinopsis_pelicula` varchar(1000) DEFAULT NULL,
  `id_clasificacion` int(11) NOT NULL,
  `id_genero` int(11) NOT NULL,
  `duracion_pelicula` time DEFAULT NULL,
  `video_pelicula` varchar(500) DEFAULT NULL,
  `imagen_pelicula` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`id_pelicula`),
  KEY `fk_Pelicula_Clasificacion1_idx` (`id_clasificacion`),
  KEY `fk_Pelicula_Genero1_idx` (`id_genero`),
  CONSTRAINT `fk_Pelicula_Clasificacion1` FOREIGN KEY (`id_clasificacion`) REFERENCES `clasificacion` (`id_clasificacion`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Pelicula_Genero1` FOREIGN KEY (`id_genero`) REFERENCES `genero` (`id_genero`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pelicula`
--

LOCK TABLES `pelicula` WRITE;
/*!40000 ALTER TABLE `pelicula` DISABLE KEYS */;
INSERT INTO `pelicula` VALUES (1,'12 horas para sobrevivir: El inicio',1,'Detrás de cada tradición hay una revolución. Muy pronto, se testigo por 12 horas de la anarquía en Estados Unidos. Se bienvenido al movimiento que empezó como un simple experimento: 12 Horas para Sobrevivir: El Inicio. Para reducir la tasa de criminalidad por debajo del uno por ciento durante el resto del año, los Nuevos Padres Fundadores de los Estados Unidos, ponen a prueba una teoría sociológica para descargar la agresividad de una comunidad aislada por una noche. Pero la violencia de los opresores se encontrará con la rabia de los marginados y se contagiará desde las fronteras de la ciudad prueba, extendiéndose por toda la nación.',5,3,'01:06:00','https://static.cinepolis.com/videos/28117/1/2/28117.webm','https://m.media-amazon.com/images/M/MV5BYmVjMWJhMTYtMzUxMC00ODdhLTk3YzMtZDFhNGUyOGFhYTY0XkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_UX182_CR0,0,182,268_AL_.jpg'),(2,'Dios no está muerto 3',0,'La tercera película de la saga \"Dios No Está Muerto\" toma una dirección diferente enfocándose en la vida espiritual del Reverendo Dave,cuya fe es probada después de que su mejor amigo muere cuando la iglesia que pastorea es incendiada. Las luchas personales y con Dios que enfrenta el pastor Dave nos llevan en un viaje de cuestionamientos y reflexión sobre la fe, los creyentes y la iglesia.',3,1,'00:00:00','https://www.youtube.com/watch?v=VGpQh_wz1Jw','https://m.media-amazon.com/images/M/MV5BZTI4Y2Q1MGQtYjE3Yy00N2VkLTg5YTgtOGI4Y2QxMTA3NTgxXkEyXkFqcGdeQXVyNTQ3MjE4NTU@._V1_UY268_CR5,0,182,268_AL_.jpg'),(3,'Hotel Transylvania 3: Monstruos de vac.',1,'Nuestra familia de monstruos favorita se embarca en un crucero de lujo para que por fin Drac pueda tomarse un descanso de proveer de vacaciones al resto en el hotel. Es una navegación tranquila para la pandilla de Drac, ya que los monstruos se entregan a toda la diversión a bordo que ofrece el crucero, desde el voleibol de monstruos y las excursiones exóticas, a ponerse al día con sus bronceados de luna. Pero las vacaciones de ensueño se convierten en una pesadilla cuando Mavis se da cuenta de que Drac se ha enamorado de la misteriosa capitana de la nave, Ericka, quien esconde un peligroso secreto que podría destruir a todos los monstruos.',1,2,'01:24:00','https://static.cinepolis.com/videos/27994/1/2/27994.webm','https://m.media-amazon.com/images/M/MV5BNTQwOTg0MDI3Nl5BMl5BanBnXkFtZTgwNjkyNzgxNDM@._V1_SY1000_CR0,0,674,1000_AL_.jpg'),(4,'Mentes poderosas',1,'Cuando los adolescentes desarrollan misteriosamente nuevas y poderosas habilidades, el gobierno los declara una amenaza y los detiene. Ruby, de 16 años, una de las jóvenes más poderosas con las que se haya encontrado alguien, escapa del campamento y se une a un grupo de jóvenes fugitivos que buscan refugio seguro. Pronto esta familia recién formada se da cuenta de que los adultos que están en el poder los han traicionado, correr ya no será suficiente y deben oponer resistencia, utilizando su poder colectivo para recuperar el control de su futuro.',3,10,'01:34:00','https://static.cinepolis.com/videos/28119/1/2/28119.webm','https://m.media-amazon.com/images/M/MV5BMTUxOGE3OTUtM2I2My00YzE3LTg2NDktZTI3NjE4NDdjMGFiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg'),(5,'Misión: Imposible repercusión',1,'Las mejores intenciones a menudo vuelven para perseguirte. MISIÓN: IMPOSIBLE - REPERCUSIÓN regresa con Ethan Hunt (Tom Cruise) y su equipo de la FMI (Alec Baldwin, Simon Pegg, Ving Rhames) junto con algunos aliados (Rebecca Ferguson, Michelle Monaghan) en una carrera contra reloj, después de una misión que salió mal. Henry Cavill, Angela Bassett y Vanessa Kirby también se unen al elenco. Christopher McQuarrie regresa como director de esta nueva entrega.',3,3,'01:20:00','https://static.cinepolis.com/videos/27981/1/2/27981.webm','https://m.media-amazon.com/images/M/MV5BMTk3NDY5MTU0NV5BMl5BanBnXkFtZTgwNDI3MDE1NTM@._V1_.jpg'),(6,'Rascacielos: Rescate en las alturas',1,'Will Ford, un experto en seguridad encargado de gestionar las infraestructuras de los rascacielos más grandes del mundo. Pero es acusado tras el incendio de uno de estos edificios en China y acabará envuelto en diversos peligros, que pondrán en una situación delicada a sus seres queridos y a sí mismo.',2,3,'01:25:00','https://static.cinepolis.com/videos/27983/1/2/27983.webm','https://m.media-amazon.com/images/M/MV5BOGM3MzQwYzItNDA1Ny00MzIyLTg5Y2QtYTAwMzNmMDU2ZDgxXkEyXkFqcGdeQXVyMjMxOTE0ODA@._V1_UX140_CR0,0,140,209_AL_.jpg'),(7,'A la deriva',0,'Después de haberse conocido Tahití, la casualidad hace que Tami Oldham (Shailene Woodley) y Richard Sharp (Sam Claflin) inicien un bello romance. La pareja disfrutará entonces de un viaje por el mar en su velero. Pero, en medio del océano, se verán sorprendidos por una de las mayores tormentas jamás registradas. Tras el paso del huracán, deberán sobrevivir a la deriva con un velero destrozado, sin comida y sin agua.',2,3,'01:40:00','https://static.cinepolis.com/videos/27982/1/2/27982.webm','https://m.media-amazon.com/images/M/MV5BMTkxMTI2MjE4OF5BMl5BanBnXkFtZTgwMjIyODQzNTM@._V1_.jpg'),(8,'El hombre hormiga y la avispa',1,'Desde el Universo Cinematográfico de Marvel llega \'Ant-Man y la Avispa\', un nuevo capítulo que presenta héroes con la asombrosa capacidad de contraerse. Después de \'Capitán América: Civil War\' Scott Lang tendrá que lidiar con las consecuencias de sus elecciones como superhéroe y como padre. Mientras lucha por re-equilibrar su vida con sus responsabilidades como Ant-Man, se enfrentará a Hope van Dyne y al Dr. Hank Pym en una nueva y urgente misión. Scott debe volver a enfundarse el traje y aprender a luchar junto con Avispa, al tiempo que trabajan en equipo para descubrir secretos del pasado.',3,3,'01:25:00','https://static.cinepolis.com/videos/27912/1/2/27912.webm','https://m.media-amazon.com/images/M/MV5BYjcyYTk0N2YtMzc4ZC00Y2E0LWFkNDgtNjE1MzZmMGE1YjY1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg'),(9,'Jurassic World: El reino caído',1,'Han pasado cuatro años desde que el parque de atracciones y centro vacacional de lujo Jurassic World fue destruido por los dinosaurios. La Isla Nublar está ahora abandonada por los humanos, mientras los dinosaurios intentan sobrevivir por si mismos en la jungla. Cuando el volcán durmiente de la isla vuelve a la vida, Owen Grady (Chris Pratt) y Claire Dearing (Bryce Dallas Howard) organizarán un equipo de rescate para salvar a aquellos dinosaurios que han quedado con vida tras la extinción. En su expedición, Owen intentará encontrar a Blue, su dinosaurio favorito que aún permanece perdido en la jungla. Mientras, Claire, que ha adquirido un gran respeto por estas criaturas, considera que su misión es salvarlas. Juntos aterrizarán en una isla inestable en la que la lava supone una gran amenza. Además, como telón de fondo está la conspiración que podría poner en peligro a todo el planeta y hacerlo retroceder a un orden no visto desde los tiempos prehistóricos.',3,3,'02:10:00','https://static.cinepolis.com/videos/27721/1/2/27721.webm','https://m.media-amazon.com/images/M/MV5BMjMyNjI3ODQyNV5BMl5BanBnXkFtZTgwNDM5NTk5MjE@._V1_.jpg'),(10,'Los increíbles 2',1,'Regresa nuestra familia favorita de superhéroes. Pero esta vez la protagonista es Helen mientras que Bob se queda en casa, con Violet y Dash, y se ve obligado a convertirse en un héroe de la vida \"normal\". Es una transición difícil para todos, y lo será más aun cuando la familia se dé cuenta de los superpoderes del bebé Jack-Jack. Además, aparece un nuevo villano que trama una conspiración brillante y peligrosa. La familia y Frozone deberán encontrar la forma de volver a trabajar juntos, algo bastante complicado a pesar de que todos son... Increíbles.',1,9,'02:00:00','https://static.cinepolis.com/videos/27568/1/2/27568.webm','https://m.media-amazon.com/images/M/MV5BMTEzNzY0OTg0NTdeQTJeQWpwZ15BbWU4MDU3OTg3MjUz._V1_UX182_CR0,0,182,268_AL_.jpg'),(11,'Christopher Robin, un reencuentro inol.',0,'En la reconfortante aventura de acción real \'Christopher Robin\', el pequeño al que le encantaba embarcarse en aventuras en el Bosque de los Cien Acres con una pandilla de vivaces y adorables animales de peluche ha crecido y ha perdido el rumbo. Ahora depende de sus amigos de infancia adentrarse en nuestro mundo para ayudar a Christopher Robin a recordar el cariñoso y alegre niño que todavía es en su interior',1,9,'00:00:00','https://static.cinepolis.com/videos/28115/1/2/28115.webm','https://m.media-amazon.com/images/M/MV5BYzUxMDQ3YTctMmY2NS00MzcwLWJlZWEtZDU3NmRmYWIzMDM0XkEyXkFqcGdeQXVyODQ0NzA0NDI@._V1_SY1000_CR0,0,681,1000_AL_.jpg'),(12,'Historias de ultratumba',0,'El experto en psicología y escéptico a la hora de valorar sucesos paranormales Profesor Phillip Goodman es contactado por su antiguo instructor, Charles Cameron, un famoso parapsicólogo televisivo al que habían dado por muerto tras estar desaparecido durante 15 años. Ahora necesita de manera imperiosa la ayuda de Goodman para desacreditar tres casos que le tienen tremendamente impactado',3,6,'00:00:00','https://static.cinepolis.com/videos/27979/1/2/27979.webm','https://m.media-amazon.com/images/M/MV5BMTYxMjUyMTAzN15BMl5BanBnXkFtZTgwNTM5ODYwNDI@._V1_SY1000_CR0,0,663,1000_AL_.jpg');
/*!40000 ALTER TABLE `pelicula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `promocion`
--

DROP TABLE IF EXISTS `promocion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `promocion` (
  `id_promocion` int(11) NOT NULL,
  `nombre_promocion` varchar(30) DEFAULT NULL,
  `descripcion_promocion` varchar(100) DEFAULT NULL,
  `descuento_promocion` float DEFAULT NULL,
  `puntos_promocion` float DEFAULT NULL,
  `inicio_promocion` date DEFAULT NULL,
  `fin_promocion` date DEFAULT NULL,
  PRIMARY KEY (`id_promocion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `promocion`
--

LOCK TABLES `promocion` WRITE;
/*!40000 ALTER TABLE `promocion` DISABLE KEYS */;
INSERT INTO `promocion` VALUES (1,'NONE','Sin promoción',0,0.1,'2018-08-06','2025-08-07');
/*!40000 ALTER TABLE `promocion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservacion`
--

DROP TABLE IF EXISTS `reservacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reservacion` (
  `id_reservacion` int(11) NOT NULL AUTO_INCREMENT,
  `id_funcion` int(11) NOT NULL,
  `id_factura` int(11) NOT NULL,
  `asiento_reservacion` varchar(45) DEFAULT NULL,
  `id_tipo` int(11) NOT NULL,
  `costo_reservacion` float DEFAULT NULL,
  PRIMARY KEY (`id_reservacion`),
  KEY `fk_Reservación_Hora_Funcion1_idx` (`id_funcion`),
  KEY `fk_RESERVACION_FACTURA1_idx` (`id_factura`),
  KEY `fk_RESERVACION_TIPO1_idx` (`id_tipo`),
  CONSTRAINT `fk_RESERVACION_FACTURA1` FOREIGN KEY (`id_factura`) REFERENCES `factura` (`id_factura`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_RESERVACION_TIPO1` FOREIGN KEY (`id_tipo`) REFERENCES `tipo` (`id_tipo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Reservación_Hora_Funcion1` FOREIGN KEY (`id_funcion`) REFERENCES `funcion` (`id_funcion`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservacion`
--

LOCK TABLES `reservacion` WRITE;
/*!40000 ALTER TABLE `reservacion` DISABLE KEYS */;
INSERT INTO `reservacion` VALUES (2,2,2,'12',2,40),(3,2,2,'13',2,40),(4,2,3,'24',2,40),(5,2,3,'25',2,40),(6,4,4,'15',2,102),(7,4,4,'16',2,102),(8,4,5,'14',2,102),(9,6,6,'14',3,132),(10,3,7,'5',2,132),(11,3,7,'6',2,132),(12,6,8,'33',1,158.4),(13,6,8,'34',2,132),(14,6,8,'35',2,132),(15,6,8,'36',2,132),(16,2,9,'23',2,40),(17,2,9,'26',2,40),(18,2,10,'35',2,40),(19,2,10,'36',2,40),(20,2,11,'43',2,40),(21,2,11,'44',2,40),(22,1,12,'22',2,102),(23,1,12,'23',2,102),(24,1,12,'24',3,102),(25,1,13,'25',1,122.4),(26,1,13,'26',3,102),(27,1,13,'27',3,102),(28,6,14,'23',2,132),(29,6,14,'24',2,132),(30,6,14,'25',3,132),(31,4,15,'25',2,102),(32,6,16,'43',1,158.4),(33,6,16,'44',2,132),(34,6,16,'45',2,132),(35,6,16,'46',3,132),(36,2,17,'32',2,40),(37,2,17,'33',2,40),(38,2,17,'34',2,40),(39,6,18,'53',1,158.4),(40,6,18,'54',2,132),(41,6,18,'55',3,132),(42,6,18,'56',3,132),(43,4,19,'33',2,102),(44,4,19,'34',3,102),(45,4,19,'35',3,102),(46,4,20,'24',3,102),(47,4,21,'43',2,102),(48,4,21,'44',2,102),(49,4,21,'45',3,102),(50,2,22,'45',2,40),(51,2,22,'46',2,40),(52,2,22,'47',3,40),(53,1,23,'34',2,102),(54,1,23,'35',2,102),(55,1,24,'36',2,102);
/*!40000 ALTER TABLE `reservacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sala`
--

DROP TABLE IF EXISTS `sala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sala` (
  `id_sala` int(11) NOT NULL AUTO_INCREMENT,
  `filas_sala` int(11) DEFAULT NULL,
  `columnas_sala` int(11) DEFAULT NULL,
  `id_cine` int(11) NOT NULL,
  `id_experiencia` int(11) NOT NULL,
  `numero_sala` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_sala`),
  KEY `fk_SALA_CINE1_idx` (`id_cine`),
  KEY `fk_SALA_FORMATO1_idx` (`id_experiencia`),
  CONSTRAINT `fk_SALA_CINE1` FOREIGN KEY (`id_cine`) REFERENCES `cine` (`id_cine`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_SALA_FORMATO1` FOREIGN KEY (`id_experiencia`) REFERENCES `experiencia` (`id_experiencia`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala`
--

LOCK TABLES `sala` WRITE;
/*!40000 ALTER TABLE `sala` DISABLE KEYS */;
INSERT INTO `sala` VALUES (1,6,10,4,1,1),(2,6,10,2,2,1),(3,6,10,1,3,1),(4,6,10,4,1,2),(5,6,10,5,2,1),(6,6,10,3,3,1);
/*!40000 ALTER TABLE `sala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subtitulado`
--

DROP TABLE IF EXISTS `subtitulado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subtitulado` (
  `id_subtitulado` int(11) NOT NULL AUTO_INCREMENT COMMENT 'DOLBY\nATMOSPHERIC...',
  `descripcion_subtitulado` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_subtitulado`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subtitulado`
--

LOCK TABLES `subtitulado` WRITE;
/*!40000 ALTER TABLE `subtitulado` DISABLE KEYS */;
INSERT INTO `subtitulado` VALUES (1,'ESPAÑOL'),(2,'SIN SUBTITULO');
/*!40000 ALTER TABLE `subtitulado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo`
--

DROP TABLE IF EXISTS `tipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo` (
  `id_tipo` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion_tipo` varchar(30) DEFAULT NULL,
  `precio_tipo` float DEFAULT NULL,
  PRIMARY KEY (`id_tipo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo`
--

LOCK TABLES `tipo` WRITE;
/*!40000 ALTER TABLE `tipo` DISABLE KEYS */;
INSERT INTO `tipo` VALUES (1,'ADULTO',1.2),(2,'NIÑO',1),(3,'3 ERA EDAD',1);
/*!40000 ALTER TABLE `tipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `usu_usuario` varchar(30) NOT NULL,
  `pass_usuario` varchar(32) DEFAULT NULL,
  `insert_usuario` int(11) DEFAULT NULL,
  `select_usuario` int(11) DEFAULT NULL,
  `update_usuario` int(11) DEFAULT NULL,
  `delete_usuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`usu_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('chopes','e1d5be1c7f2f456670de3d53c7b54f4a',1,1,1,1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-08  8:34:14
