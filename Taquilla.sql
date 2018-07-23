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
-- Table structure for table `asientos`
--

DROP TABLE IF EXISTS `asientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `asientos` (
  `id_asiento` int(11) NOT NULL,
  `fila_asiento` int(11) DEFAULT NULL,
  `columna_asiento` int(11) DEFAULT NULL,
  `id_sala` int(11) NOT NULL,
  PRIMARY KEY (`id_asiento`),
  KEY `fk_Asiento_Sala1_idx` (`id_sala`),
  CONSTRAINT `fk_Asiento_Sala1` FOREIGN KEY (`id_sala`) REFERENCES `sala` (`id_sala`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asientos`
--

LOCK TABLES `asientos` WRITE;
/*!40000 ALTER TABLE `asientos` DISABLE KEYS */;
/*!40000 ALTER TABLE `asientos` ENABLE KEYS */;
UNLOCK TABLES;

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
  `ip_conputadora_bitacora` varchar(45) DEFAULT NULL,
  `usu_mysql_bitacora` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_bitacora`),
  KEY `fk_Bitacora_Usuario1_idx` (`usu_usuario`),
  CONSTRAINT `fk_Bitacora_Usuario1` FOREIGN KEY (`usu_usuario`) REFERENCES `usuario` (`usu_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
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
  `id_departamento` varchar(30) NOT NULL,
  PRIMARY KEY (`id_cine`),
  KEY `fk_CINE_DEPARTAMENTO1_idx` (`id_departamento`),
  CONSTRAINT `fk_CINE_DEPARTAMENTO1` FOREIGN KEY (`id_departamento`) REFERENCES `departamento` (`id_departamento`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cine`
--

LOCK TABLES `cine` WRITE;
/*!40000 ALTER TABLE `cine` DISABLE KEYS */;
INSERT INTO `cine` VALUES (1,'MIRAFLORES','ZONA 3','Guatemala'),(2,'NARANJO MALL','ZONA 5','Guatemala'),(3,'PRADERA','ZONA 12','San Marcos'),(4,'CAYALA','ZONA 1','Zacapa');
/*!40000 ALTER TABLE `cine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clasificacion`
--

DROP TABLE IF EXISTS `clasificacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clasificacion` (
  `id_clasificacion` varchar(30) NOT NULL COMMENT 'A\nB\nC\nB15\nB12',
  PRIMARY KEY (`id_clasificacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clasificacion`
--

LOCK TABLES `clasificacion` WRITE;
/*!40000 ALTER TABLE `clasificacion` DISABLE KEYS */;
INSERT INTO `clasificacion` VALUES ('G'),('NC-17'),('NR'),('PG'),('PG-13'),('R');
/*!40000 ALTER TABLE `clasificacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `nit_cliente` varchar(15) NOT NULL,
  `nombre_cliente` varchar(30) DEFAULT NULL,
  `apellido_cliente` varchar(30) DEFAULT NULL,
  `email_cliente` varchar(35) DEFAULT NULL COMMENT 'Si posee tarjeta de cine para acumular puntos\n\n',
  `puntos_cliente` int(11) DEFAULT NULL,
  `direccion_cliente` varchar(45) DEFAULT NULL,
  `telefono_cliente` int(11) DEFAULT NULL,
  `dpi_cliente` int(11) DEFAULT NULL,
  `usu_usuario` varchar(30) NOT NULL,
  PRIMARY KEY (`nit_cliente`),
  KEY `fk_CLIENTE_USUARIO1_idx` (`usu_usuario`),
  CONSTRAINT `fk_CLIENTE_USUARIO1` FOREIGN KEY (`usu_usuario`) REFERENCES `usuario` (`usu_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamento` (
  `id_departamento` varchar(30) NOT NULL,
  PRIMARY KEY (`id_departamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES ('Alta Verapaz'),('Baja Verapaz'),('Chimaltenango'),('Chiquimula'),('El Progreso'),('Escuintla'),('Guatemala'),('Huehuetenango'),('Izabal'),('Jalapa'),('Jutiapa'),('Petén'),('Quetzaltenango'),('Quiché'),('Retalhuleu'),('Sacatepéquez'),('San Marcos'),('Santa Rosa'),('Sololá Sololá'),('Suchitepéquez'),('Totonicapán'),('Zacapa');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
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
  `vuelto_factura` double DEFAULT NULL,
  `nit_clientes` varchar(15) NOT NULL,
  `id_metodo_pago` varchar(45) NOT NULL,
  `id_promocion` int(11) NOT NULL,
  `fecha_factura` date DEFAULT NULL,
  `hora_factura` time DEFAULT NULL,
  `id_reservacion` int(11) NOT NULL,
  `puntos_factura` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_factura`),
  KEY `fk_Factura_Cliente1_idx` (`nit_clientes`),
  KEY `fk_Factura_Metodo de pago1_idx` (`id_metodo_pago`),
  KEY `fk_Factura_Promocion1_idx` (`id_promocion`),
  CONSTRAINT `fk_Factura_Cliente1` FOREIGN KEY (`nit_clientes`) REFERENCES `cliente` (`nit_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Factura_Metodo de pago1` FOREIGN KEY (`id_metodo_pago`) REFERENCES `metodo_pago` (`id_metodo_pago`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Factura_Promocion1` FOREIGN KEY (`id_promocion`) REFERENCES `promocion` (`id_promocion`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formato`
--

DROP TABLE IF EXISTS `formato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formato` (
  `id_formato` varchar(30) NOT NULL COMMENT '2D\n3D\n4DX\nVIP',
  `precio_formato` float DEFAULT NULL,
  PRIMARY KEY (`id_formato`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formato`
--

LOCK TABLES `formato` WRITE;
/*!40000 ALTER TABLE `formato` DISABLE KEYS */;
INSERT INTO `formato` VALUES ('2D',43),('3D',79),('4D',98),('4DX',110),('IMAX',50),('MACRO XE',55),('VIP',85);
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
  `id_subtitulado` varchar(30) NOT NULL,
  `id_idioma` varchar(30) NOT NULL,
  `id_horario` time NOT NULL,
  `id_sala` int(11) NOT NULL,
  PRIMARY KEY (`id_funcion`),
  KEY `fk_Hora_Funcion_Pelicula1_idx` (`id_pelicula`),
  KEY `fk_FUNCION_SUBTITULADO1_idx` (`id_subtitulado`),
  KEY `fk_FUNCION_IDIOMA1_idx` (`id_idioma`),
  KEY `fk_FUNCION_HORARIO1_idx` (`id_horario`),
  KEY `fk_FUNCION_SALA1_idx` (`id_sala`),
  CONSTRAINT `fk_FUNCION_HORARIO1` FOREIGN KEY (`id_horario`) REFERENCES `horario` (`id_horario`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_FUNCION_IDIOMA1` FOREIGN KEY (`id_idioma`) REFERENCES `idioma` (`id_idioma`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_FUNCION_SALA1` FOREIGN KEY (`id_sala`) REFERENCES `sala` (`id_sala`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_FUNCION_SUBTITULADO1` FOREIGN KEY (`id_subtitulado`) REFERENCES `subtitulado` (`id_subtitulado`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Hora_Funcion_Pelicula1` FOREIGN KEY (`id_pelicula`) REFERENCES `pelicula` (`id_pelicula`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcion`
--

LOCK TABLES `funcion` WRITE;
/*!40000 ALTER TABLE `funcion` DISABLE KEYS */;
INSERT INTO `funcion` VALUES (2,2,'2018-04-04','FRANCES','ALEMAN','01:24:00',2),(3,1,'2017-04-04','FRANCES','ALEMAN','05:40:00',2);
/*!40000 ALTER TABLE `funcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genero`
--

DROP TABLE IF EXISTS `genero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genero` (
  `id_genero` varchar(30) NOT NULL COMMENT 'ACCION\nCOMEDIA\nROMANCE...',
  PRIMARY KEY (`id_genero`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genero`
--

LOCK TABLES `genero` WRITE;
/*!40000 ALTER TABLE `genero` DISABLE KEYS */;
INSERT INTO `genero` VALUES ('ACCION'),('CIENCIA FICCION'),('COMEDIA'),('DRAMA'),('FANTASIA'),('MELODRAMA'),('MUSICAL'),('ROMANCE'),('SUSPENSE'),('TERROR');
/*!40000 ALTER TABLE `genero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horario`
--

DROP TABLE IF EXISTS `horario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horario` (
  `id_horario` time NOT NULL,
  PRIMARY KEY (`id_horario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horario`
--

LOCK TABLES `horario` WRITE;
/*!40000 ALTER TABLE `horario` DISABLE KEYS */;
INSERT INTO `horario` VALUES ('01:24:00'),('05:40:00'),('12:34:00'),('21:20:00'),('22:30:00');
/*!40000 ALTER TABLE `horario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `idioma`
--

DROP TABLE IF EXISTS `idioma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `idioma` (
  `id_idioma` varchar(30) NOT NULL,
  PRIMARY KEY (`id_idioma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `idioma`
--

LOCK TABLES `idioma` WRITE;
/*!40000 ALTER TABLE `idioma` DISABLE KEYS */;
INSERT INTO `idioma` VALUES ('ALEMAN'),('FRANCES'),('INGLES'),('SPANISH');
/*!40000 ALTER TABLE `idioma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `metodo_pago`
--

DROP TABLE IF EXISTS `metodo_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `metodo_pago` (
  `id_metodo_pago` varchar(30) NOT NULL,
  PRIMARY KEY (`id_metodo_pago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `metodo_pago`
--

LOCK TABLES `metodo_pago` WRITE;
/*!40000 ALTER TABLE `metodo_pago` DISABLE KEYS */;
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
  `nombre_pelicula` varchar(30) DEFAULT NULL,
  `estado_pelicula` varchar(30) DEFAULT NULL,
  `sinopsis_pelicula` varchar(150) DEFAULT NULL,
  `id_clasificacion` varchar(30) NOT NULL,
  `id_genero` varchar(30) NOT NULL,
  `duracion_pelicula` time DEFAULT NULL,
  PRIMARY KEY (`id_pelicula`),
  KEY `fk_Pelicula_Clasificacion1_idx` (`id_clasificacion`),
  KEY `fk_Pelicula_Genero1_idx` (`id_genero`),
  CONSTRAINT `fk_Pelicula_Clasificacion1` FOREIGN KEY (`id_clasificacion`) REFERENCES `clasificacion` (`id_clasificacion`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Pelicula_Genero1` FOREIGN KEY (`id_genero`) REFERENCES `genero` (`id_genero`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pelicula`
--

LOCK TABLES `pelicula` WRITE;
/*!40000 ALTER TABLE `pelicula` DISABLE KEYS */;
INSERT INTO `pelicula` VALUES (1,'Interestelar','ESTRENADA','La película presenta a un equipo de astronautas que viaja a través de un agujero de gusano en busca de un nuevo hogar para la humanidad. ','PG','CIENCIA FICCION','01:43:00'),(2,'TOY STORY','ESTRENADA','La historia sigue las aventuras de un grupo de juguetes vivientes, en particular del vaquero Woody y el guardián espacial Buzz Lightyear. ','PG','FANTASIA','01:30:00');
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
  `descuento_promocion` int(11) DEFAULT NULL,
  `fecha_promocion` datetime DEFAULT NULL,
  `puntos_promocion` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_promocion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `promocion`
--

LOCK TABLES `promocion` WRITE;
/*!40000 ALTER TABLE `promocion` DISABLE KEYS */;
/*!40000 ALTER TABLE `promocion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `puntos`
--

DROP TABLE IF EXISTS `puntos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `puntos` (
  `id_puntos` int(11) NOT NULL AUTO_INCREMENT,
  `valor_puntos` int(11) DEFAULT NULL,
  `nit_cliente` varchar(15) NOT NULL,
  `id_promocion` int(11) NOT NULL,
  PRIMARY KEY (`id_puntos`),
  KEY `fk_Acumulado de puntos_Cliente1_idx` (`nit_cliente`),
  KEY `fk_Acumulado de puntos_Promocion1_idx` (`id_promocion`),
  CONSTRAINT `fk_Acumulado de puntos_Cliente1` FOREIGN KEY (`nit_cliente`) REFERENCES `cliente` (`nit_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Acumulado de puntos_Promocion1` FOREIGN KEY (`id_promocion`) REFERENCES `promocion` (`id_promocion`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `puntos`
--

LOCK TABLES `puntos` WRITE;
/*!40000 ALTER TABLE `puntos` DISABLE KEYS */;
/*!40000 ALTER TABLE `puntos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservacion`
--

DROP TABLE IF EXISTS `reservacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reservacion` (
  `id_funcion` int(11) NOT NULL,
  `id_factura` int(11) NOT NULL,
  `costo_reservacion` float DEFAULT NULL,
  `id_tipo` varchar(30) NOT NULL,
  KEY `fk_Reservación_Hora_Funcion1_idx` (`id_funcion`),
  KEY `fk_RESERVACION_FACTURA1_idx` (`id_factura`),
  KEY `fk_RESERVACION_TIPO1_idx` (`id_tipo`),
  CONSTRAINT `fk_RESERVACION_FACTURA1` FOREIGN KEY (`id_factura`) REFERENCES `factura` (`id_factura`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_RESERVACION_TIPO1` FOREIGN KEY (`id_tipo`) REFERENCES `tipo` (`id_tipo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Reservación_Hora_Funcion1` FOREIGN KEY (`id_funcion`) REFERENCES `funcion` (`id_funcion`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservacion`
--

LOCK TABLES `reservacion` WRITE;
/*!40000 ALTER TABLE `reservacion` DISABLE KEYS */;
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
  `id_formato` varchar(30) NOT NULL,
  `numero_sala` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_sala`),
  KEY `fk_SALA_CINE1_idx` (`id_cine`),
  KEY `fk_SALA_FORMATO1_idx` (`id_formato`),
  CONSTRAINT `fk_SALA_CINE1` FOREIGN KEY (`id_cine`) REFERENCES `cine` (`id_cine`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_SALA_FORMATO1` FOREIGN KEY (`id_formato`) REFERENCES `formato` (`id_formato`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala`
--

LOCK TABLES `sala` WRITE;
/*!40000 ALTER TABLE `sala` DISABLE KEYS */;
INSERT INTO `sala` VALUES (1,22,18,2,'IMAX',13),(2,23,12,3,'VIP',5);
/*!40000 ALTER TABLE `sala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subtitulado`
--

DROP TABLE IF EXISTS `subtitulado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subtitulado` (
  `id_subtitulado` varchar(30) NOT NULL COMMENT 'DOLBY\nATMOSPHERIC...',
  PRIMARY KEY (`id_subtitulado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subtitulado`
--

LOCK TABLES `subtitulado` WRITE;
/*!40000 ALTER TABLE `subtitulado` DISABLE KEYS */;
INSERT INTO `subtitulado` VALUES ('ALEMAN'),('FRANCES'),('INGLES'),('JAPONES'),('RUSO'),('SPANISH');
/*!40000 ALTER TABLE `subtitulado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo`
--

DROP TABLE IF EXISTS `tipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo` (
  `id_tipo` varchar(30) NOT NULL,
  `porcentaje_precio_tipo` float DEFAULT NULL,
  PRIMARY KEY (`id_tipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo`
--

LOCK TABLES `tipo` WRITE;
/*!40000 ALTER TABLE `tipo` DISABLE KEYS */;
INSERT INTO `tipo` VALUES ('3 ERA EDAD',1),('ADULTO',1.2),('NIÑO',1);
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
  `pass_usuario` varchar(30) DEFAULT NULL,
  `privilegio_usuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`usu_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('chopes','1243',0),('root','1243',0);
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

-- Dump completed on 2018-07-23 15:41:46
