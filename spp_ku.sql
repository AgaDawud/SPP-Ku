-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: spp_ku
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tb_kelas`
--

DROP TABLE IF EXISTS `tb_kelas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_kelas` (
  `id_kelas` char(4) NOT NULL,
  `nama_kelas` varchar(20) NOT NULL,
  `kopetensi_keahlian` varchar(40) NOT NULL,
  PRIMARY KEY (`id_kelas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_kelas`
--

LOCK TABLES `tb_kelas` WRITE;
/*!40000 ALTER TABLE `tb_kelas` DISABLE KEYS */;
INSERT INTO `tb_kelas` VALUES ('K001','X MM 1','Multimedia'),('K002','X MM 2','Multimedia'),('K003','X RPL 1','Rekayasa Perangkat Lunak'),('K004','X RPL 2','Rekayasa Perangkat Lunak'),('K005','X TITL 1','Teknik Instalasi Tenaga Listrik'),('K006','X TITL 2','Teknik Instalasi Tenaga Listrik'),('K007','X TKRO 1','Teknik Kendaraan Ringan Otomotif'),('K008','X TKRO 2','Teknik Kendaraan Ringan Otomotif'),('K009','XI MM 1','Multimedia'),('K010','XI MM 2','Multimedia'),('K011','XI RPL 1','Rekayasa Perangkat Lunak'),('K012','XI RPL 2','Rekayasa Perangkat Lunak'),('K013','XI TITL 1','Teknik Instalasi Tenaga Listrik'),('K014','XI TITL 2','Teknik Instalasi Tenaga Listrik'),('K015','XI TKRO 1','Teknik Kendaraan Ringan Otomotif'),('K016','XI TKRO 2','Teknik Kendaraan Ringan Otomotif');
/*!40000 ALTER TABLE `tb_kelas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pegawai`
--

DROP TABLE IF EXISTS `tb_pegawai`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pegawai` (
  `id_pegawai` char(4) NOT NULL,
  `nama_pegawai` varchar(60) NOT NULL,
  `jenis_kelamin` varchar(10) NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `alamat` text NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(15) NOT NULL,
  `level` enum('admin','pegawai') NOT NULL,
  PRIMARY KEY (`id_pegawai`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pegawai`
--

LOCK TABLES `tb_pegawai` WRITE;
/*!40000 ALTER TABLE `tb_pegawai` DISABLE KEYS */;
INSERT INTO `tb_pegawai` VALUES ('P001','David Firmansah','Laki-laki','085321497215','Desa Karangjaya, Kec. Purwajaya, Kab. Cirebon','david_a1','david#p1','admin'),('P002','Moch. Farhan Dwi Kurniawan','Laki-laki','085369427812','Desa Sumbersari, Kec. Singaraja, Kab. Pekalongan','farhan_u1','farhan#p2','pegawai'),('P003','Mochammad Dawud Adinaga','Laki-laki','081235403515','Desa Muneng, ','dawud_a2','dawud#p3','admin');
/*!40000 ALTER TABLE `tb_pegawai` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pembayaran`
--

DROP TABLE IF EXISTS `tb_pembayaran`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pembayaran` (
  `id_pembayaran` char(6) NOT NULL,
  `id_pegawai` char(4) NOT NULL,
  `nis` char(8) NOT NULL,
  `tgl_bayar` date NOT NULL,
  `bulan_dibayar` varchar(8) NOT NULL,
  `tahun_dibayar` int(4) NOT NULL,
  `id_spp` char(5) NOT NULL,
  `jumlah_bayar` int(11) NOT NULL,
  PRIMARY KEY (`id_pembayaran`),
  KEY `id_pegawai` (`id_pegawai`),
  KEY `id_spp` (`id_spp`),
  KEY `nis` (`nis`),
  CONSTRAINT `tb_pembayaran_ibfk_1` FOREIGN KEY (`id_pegawai`) REFERENCES `tb_pegawai` (`id_pegawai`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tb_pembayaran_ibfk_2` FOREIGN KEY (`id_spp`) REFERENCES `tb_spp` (`id_spp`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tb_pembayaran_ibfk_3` FOREIGN KEY (`nis`) REFERENCES `tb_siswa` (`nis`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pembayaran`
--

LOCK TABLES `tb_pembayaran` WRITE;
/*!40000 ALTER TABLE `tb_pembayaran` DISABLE KEYS */;
INSERT INTO `tb_pembayaran` VALUES ('PB0001','P001','110.0001','2024-12-07','Desember',2024,'S0001',200000),('PB0002','P001','110.0002','2024-12-09','Desember',2024,'S0001',250000),('PB0003','P001','110.0005','2024-12-12','Desember',2024,'S0001',350000),('PB0004','P001','110.0008','2024-12-16','Desember',2024,'S0001',185000),('PB0005','P001','110.0007','2024-12-07','Desember',2024,'S0001',235000);
/*!40000 ALTER TABLE `tb_pembayaran` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_siswa`
--

DROP TABLE IF EXISTS `tb_siswa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_siswa` (
  `nis` char(8) NOT NULL,
  `nama_siswa` varchar(60) NOT NULL,
  `jenis_kelamin` varchar(10) NOT NULL,
  `id_kelas` char(4) NOT NULL,
  `alamat` text NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `id_spp` char(5) NOT NULL,
  PRIMARY KEY (`nis`),
  KEY `id_spp` (`id_spp`),
  KEY `id_kelas` (`id_kelas`),
  CONSTRAINT `tb_siswa_ibfk_1` FOREIGN KEY (`id_spp`) REFERENCES `tb_spp` (`id_spp`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tb_siswa_ibfk_2` FOREIGN KEY (`id_kelas`) REFERENCES `tb_kelas` (`id_kelas`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_siswa`
--

LOCK TABLES `tb_siswa` WRITE;
/*!40000 ALTER TABLE `tb_siswa` DISABLE KEYS */;
INSERT INTO `tb_siswa` VALUES ('110.0001','Fadilah Rahman','Laki-laki','K016','Desa Blobo, Kec. Sumberasih, Kab. Probolinggo','085241367421','S0001'),('110.0002','Andre Mahardika','Laki-laki','K010','Desa Lemah Kembar, Kec. Sumberasih, Kab. Probolinggo','085314729856','S0001'),('110.0003','Adi Maulana','Laki-laki','K012','Desa Jangur, Kec. Sumberasih, Kab. Probolinggo','085632479634','S0001'),('110.0004','Siti Fatimah','Perempuan','K012','Desa Bayeman, Kec. Tongas, Kab. Probolinggo','085396421789','S0001'),('110.0005','Sakila Asbaul Khusna','Perempuan','K012','Desa Sumberbendo, Kec. Sumberasih, Kab. Probolinggo','081296357894','S0001'),('110.0006','Riska Putri Andriani','Perempuan','K012','Desa Jangur, Kec. Sumberasih, Kab. Probolinggo','082963147526','S0001'),('110.0007','Salam Sarifudin','Laki-laki','K012','Desa Sumurmati, Kec. Sumberasih, Kab. Probolinggo','083214789635','S0001'),('110.0008','Muhammad Riyadi','Laki-laki','K012','Desa Muneng, Kec. Sumberasih, Kab. Probolinggo','081963548794','S0001');
/*!40000 ALTER TABLE `tb_siswa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_spp`
--

DROP TABLE IF EXISTS `tb_spp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_spp` (
  `id_spp` char(5) NOT NULL,
  `tahun` int(11) NOT NULL,
  `nominal` int(11) NOT NULL,
  PRIMARY KEY (`id_spp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_spp`
--

LOCK TABLES `tb_spp` WRITE;
/*!40000 ALTER TABLE `tb_spp` DISABLE KEYS */;
INSERT INTO `tb_spp` VALUES ('S0001',2024,500000),('S0002',2025,400000),('S0003',2026,550000),('S0004',2027,350000),('S0005',2028,360000),('S0006',2029,450000);
/*!40000 ALTER TABLE `tb_spp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `vpembayaran`
--

DROP TABLE IF EXISTS `vpembayaran`;
/*!50001 DROP VIEW IF EXISTS `vpembayaran`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vpembayaran` AS SELECT
 1 AS `id_pegawai`,
  1 AS `nama_pegawai`,
  1 AS `nis`,
  1 AS `nama_siswa`,
  1 AS `id_kelas`,
  1 AS `nama_kelas`,
  1 AS `kopetensi_keahlian`,
  1 AS `id_pembayaran`,
  1 AS `tgl_bayar`,
  1 AS `bulan_dibayar`,
  1 AS `tahun_dibayar`,
  1 AS `jumlah_bayar` */;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vpembayaran`
--

/*!50001 DROP VIEW IF EXISTS `vpembayaran`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_unicode_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vpembayaran` AS select `tb_pegawai`.`id_pegawai` AS `id_pegawai`,`tb_pegawai`.`nama_pegawai` AS `nama_pegawai`,`tb_siswa`.`nis` AS `nis`,`tb_siswa`.`nama_siswa` AS `nama_siswa`,`tb_kelas`.`id_kelas` AS `id_kelas`,`tb_kelas`.`nama_kelas` AS `nama_kelas`,`tb_kelas`.`kopetensi_keahlian` AS `kopetensi_keahlian`,`tb_pembayaran`.`id_pembayaran` AS `id_pembayaran`,`tb_pembayaran`.`tgl_bayar` AS `tgl_bayar`,`tb_pembayaran`.`bulan_dibayar` AS `bulan_dibayar`,`tb_pembayaran`.`tahun_dibayar` AS `tahun_dibayar`,`tb_pembayaran`.`jumlah_bayar` AS `jumlah_bayar` from (((`tb_kelas` join `tb_siswa` on(`tb_siswa`.`id_kelas` = `tb_kelas`.`id_kelas`)) join `tb_pembayaran` on(`tb_pembayaran`.`nis` = `tb_siswa`.`nis`)) join `tb_pegawai` on(`tb_pembayaran`.`id_pegawai` = `tb_pegawai`.`id_pegawai`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-07 14:40:40
