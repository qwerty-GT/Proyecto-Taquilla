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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
INSERT INTO `bitacora` VALUES (1,'LOG IN','2018-08-05 17:34:42','chopes','chopes@localhost'),(2,'LOG IN','2018-08-05 17:38:13','chopes','chopes@localhost'),(3,'LOG IN','2018-08-05 18:05:12','chopes','root@localhost'),(4,'LOG IN','2018-08-05 20:35:49','chopes','root@localhost'),(5,'LOG IN','2018-08-05 20:46:39','chopes','root@localhost'),(6,'LOG IN','2018-08-05 22:07:32','chopes','chopes@localhost'),(7,'LOG IN','2018-08-05 22:09:41','chopes','chopes@localhost');
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
  `descripcion_clasificacion` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_clasificacion`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clasificacion`
--

LOCK TABLES `clasificacion` WRITE;
/*!40000 ALTER TABLE `clasificacion` DISABLE KEYS */;
INSERT INTO `clasificacion` VALUES (1,'A'),(2,'B-13'),(3,'B-15'),(4,'R'),(5,'NC-17'),(6,'NR');
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
  `id_departamento` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_departamento` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_departamento`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
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
  `vuelto_factura` double DEFAULT NULL,
  `nit_clientes` varchar(15) NOT NULL,
  `id_metodo_pago` int(11) NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcion`
--

LOCK TABLES `funcion` WRITE;
/*!40000 ALTER TABLE `funcion` DISABLE KEYS */;
INSERT INTO `funcion` VALUES (1,1,'2018-05-15',2,1,1,1,2),(2,3,'2018-05-18',2,1,2,2,1),(3,4,'2018-05-17',2,1,3,3,2),(4,5,'2018-05-16',1,2,1,4,2),(5,6,'2018-05-20',1,2,2,5,1),(6,8,'2018-05-30',1,2,3,6,2);
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `idioma`
--

LOCK TABLES `idioma` WRITE;
/*!40000 ALTER TABLE `idioma` DISABLE KEYS */;
INSERT INTO `idioma` VALUES (1,'SPANISH'),(2,'INGLES');
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
  `nombre_pelicula` varchar(45) DEFAULT NULL,
  `estado_pelicula` int(11) DEFAULT NULL,
  `sinopsis_pelicula` varchar(700) DEFAULT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pelicula`
--

LOCK TABLES `pelicula` WRITE;
/*!40000 ALTER TABLE `pelicula` DISABLE KEYS */;
INSERT INTO `pelicula` VALUES (1,'12 horas para sobrevivir: El inicio',1,'Detrás de cada tradición hay una revolución. Muy pronto, se testigo por 12 horas de la anarquía en Estados Unidos. Se bienvenido al movimiento que empezó como un simple experimento: 12 Horas para Sobrevivir: El Inicio. Para reducir la tasa de criminalidad por debajo del uno por ciento durante el resto del año, los Nuevos Padres Fundadores de los Estados Unidos, ponen a prueba una teoría sociológica para descargar la agresividad de una comunidad aislada por una noche. Pero la violencia de los opresores se encontrará con la rabia de los marginados y se contagiará desde las fronteras de la ciudad prueba, extendiéndose por toda la nación.',5,3,'01:06:00','https://static.cinepolis.com/videos/28117/1/2/28117.webm','https://m.media-amazon.com/images/M/MV5BYmVjMWJhMTYtMzUxMC00ODdhLTk3YzMtZDFhNGUyOGFhYTY0XkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_UX182_CR0,0,182,268_AL_.jpg'),(2,'Dios no está muerto 3',0,'La tercera película de la saga \"Dios No Está Muerto\" toma una dirección diferente enfocándose en la vida espiritual del Reverendo Dave,cuya fe es probada después de que su mejor amigo muere cuando la iglesia que pastorea es incendiada. Las luchas personales y con Dios que enfrenta el pastor Dave nos llevan en un viaje de cuestionamientos y reflexión sobre la fe, los creyentes y la iglesia.',3,1,'01:15:00','https://www.youtube.com/watch?v=VGpQh_wz1Jw','https://m.media-amazon.com/images/M/MV5BZTI4Y2Q1MGQtYjE3Yy00N2VkLTg5YTgtOGI4Y2QxMTA3NTgxXkEyXkFqcGdeQXVyNTQ3MjE4NTU@._V1_UY268_CR5,0,182,268_AL_.jpg'),(3,'Hotel Transylvania 3: Monstruos de vac.',1,'Nuestra familia de monstruos favorita se embarca en un crucero de lujo para que por fin Drac pueda tomarse un descanso de proveer de vacaciones al resto en el hotel. Es una navegación tranquila para la pandilla de Drac, ya que los monstruos se entregan a toda la diversión a bordo que ofrece el crucero, desde el voleibol de monstruos y las excursiones exóticas, a ponerse al día con sus bronceados de luna. Pero las vacaciones de ensueño se convierten en una pesadilla cuando Mavis se da cuenta de que Drac se ha enamorado de la misteriosa capitana de la nave, Ericka, quien esconde un peligroso secreto que podría destruir a todos los monstruos.',1,2,'01:24:00','https://static.cinepolis.com/videos/27994/1/2/27994.webm','https://m.media-amazon.com/images/M/MV5BNTQwOTg0MDI3Nl5BMl5BanBnXkFtZTgwNjkyNzgxNDM@._V1_SY1000_CR0,0,674,1000_AL_.jpg'),(4,'Mentes poderosas',1,'Cuando los adolescentes desarrollan misteriosamente nuevas y poderosas habilidades, el gobierno los declara una amenaza y los detiene. Ruby, de 16 años, una de las jóvenes más poderosas con las que se haya encontrado alguien, escapa del campamento y se une a un grupo de jóvenes fugitivos que buscan refugio seguro. Pronto esta familia recién formada se da cuenta de que los adultos que están en el poder los han traicionado, correr ya no será suficiente y deben oponer resistencia, utilizando su poder colectivo para recuperar el control de su futuro.',3,10,'01:34:00','https://static.cinepolis.com/videos/28119/1/2/28119.webm','https://m.media-amazon.com/images/M/MV5BMTUxOGE3OTUtM2I2My00YzE3LTg2NDktZTI3NjE4NDdjMGFiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg'),(5,'Misión: Imposible repercusión',1,'Las mejores intenciones a menudo vuelven para perseguirte. MISIÓN: IMPOSIBLE - REPERCUSIÓN regresa con Ethan Hunt (Tom Cruise) y su equipo de la FMI (Alec Baldwin, Simon Pegg, Ving Rhames) junto con algunos aliados (Rebecca Ferguson, Michelle Monaghan) en una carrera contra reloj, después de una misión que salió mal. Henry Cavill, Angela Bassett y Vanessa Kirby también se unen al elenco. Christopher McQuarrie regresa como director de esta nueva entrega.',3,3,'01:20:00','https://static.cinepolis.com/videos/27981/1/2/27981.webm','https://m.media-amazon.com/images/M/MV5BMTk3NDY5MTU0NV5BMl5BanBnXkFtZTgwNDI3MDE1NTM@._V1_.jpg'),(6,'Rascacielos: Rescate en las alturas',1,'Will Ford, un experto en seguridad encargado de gestionar las infraestructuras de los rascacielos más grandes del mundo. Pero es acusado tras el incendio de uno de estos edificios en China y acabará envuelto en diversos peligros, que pondrán en una situación delicada a sus seres queridos y a sí mismo.',2,3,'01:25:00','https://static.cinepolis.com/videos/27983/1/2/27983.webm','https://m.media-amazon.com/images/M/MV5BOGM3MzQwYzItNDA1Ny00MzIyLTg5Y2QtYTAwMzNmMDU2ZDgxXkEyXkFqcGdeQXVyMjMxOTE0ODA@._V1_UX140_CR0,0,140,209_AL_.jpg'),(7,'A la deriva',0,'Después de haberse conocido Tahití, la casualidad hace que Tami Oldham (Shailene Woodley) y Richard Sharp (Sam Claflin) inicien un bello romance. La pareja disfrutará entonces de un viaje por el mar en su velero. Pero, en medio del océano, se verán sorprendidos por una de las mayores tormentas jamás registradas. Tras el paso del huracán, deberán sobrevivir a la deriva con un velero destrozado, sin comida y sin agua.',2,3,'01:40:00','https://static.cinepolis.com/videos/27982/1/2/27982.webm','https://m.media-amazon.com/images/M/MV5BMTkxMTI2MjE4OF5BMl5BanBnXkFtZTgwMjIyODQzNTM@._V1_.jpg'),(8,'El hombre hormiga y la avispa',1,'Desde el Universo Cinematográfico de Marvel llega \'Ant-Man y la Avispa\', un nuevo capítulo que presenta héroes con la asombrosa capacidad de contraerse. Después de \'Capitán América: Civil War\' Scott Lang tendrá que lidiar con las consecuencias de sus elecciones como superhéroe y como padre. Mientras lucha por re-equilibrar su vida con sus responsabilidades como Ant-Man, se enfrentará a Hope van Dyne y al Dr. Hank Pym en una nueva y urgente misión. Scott debe volver a enfundarse el traje y aprender a luchar junto con Avispa, al tiempo que trabajan en equipo para descubrir secretos del pasado.',3,3,'01:25:00','https://static.cinepolis.com/videos/27912/1/2/27912.webm','https://m.media-amazon.com/images/M/MV5BYjcyYTk0N2YtMzc4ZC00Y2E0LWFkNDgtNjE1MzZmMGE1YjY1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg');
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
  `puntos_promocion` int(11) DEFAULT NULL,
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
INSERT INTO `sala` VALUES (1,6,6,4,1,1),(2,6,6,2,2,1),(3,6,6,1,3,1),(4,6,6,4,1,2),(5,6,6,5,2,1),(6,6,6,3,3,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subtitulado`
--

LOCK TABLES `subtitulado` WRITE;
/*!40000 ALTER TABLE `subtitulado` DISABLE KEYS */;
INSERT INTO `subtitulado` VALUES (1,'SPANISH'),(2,'N/A');
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

-- Dump completed on 2018-08-06  3:02:07
