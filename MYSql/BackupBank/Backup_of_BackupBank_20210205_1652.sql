-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: Bank
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `account` (
  `AccountNumber` char(4) NOT NULL,
  `AccountType` char(4) DEFAULT NULL,
  `CustomerID` char(4) DEFAULT NULL,
  PRIMARY KEY (`AccountNumber`),
  KEY `FK_CustomerId` (`CustomerID`),
  KEY `FK_AccountType` (`AccountType`),
  CONSTRAINT `FK_AccountType` FOREIGN KEY (`AccountType`) REFERENCES `accounttype` (`AccountType`),
  CONSTRAINT `FK_CustomerId` FOREIGN KEY (`CustomerID`) REFERENCES `customers` (`CId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account`
--

LOCK TABLES `account` WRITE;
/*!40000 ALTER TABLE `account` DISABLE KEYS */;
INSERT INTO `account` VALUES ('A001','SA03','C001'),('A002','SA02','C002'),('A003','SA01','C003'),('A004','CA01','C004');
/*!40000 ALTER TABLE `account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `accounttype`
--

DROP TABLE IF EXISTS `accounttype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `accounttype` (
  `AccountType` char(4) NOT NULL,
  `AccountName` varchar(30) DEFAULT NULL,
  `Description` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`AccountType`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounttype`
--

LOCK TABLES `accounttype` WRITE;
/*!40000 ALTER TABLE `accounttype` DISABLE KEYS */;
INSERT INTO `accounttype` VALUES ('CA01','Basic Current Account','Basic Current Account'),('SA01','Basic Savings Account','Basic Savings Account'),('SA02','Premium Savings Account','Premium Savings Account'),('SA03','Super Star Savings Account','Savings Account for children under 18 year of age.');
/*!40000 ALTER TABLE `accounttype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `branch`
--

DROP TABLE IF EXISTS `branch`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `branch` (
  `BranchCode` char(4) NOT NULL,
  `BranchName` varchar(30) DEFAULT NULL,
  `IFSC_Code` char(11) DEFAULT NULL,
  `state` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`BranchCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `branch`
--

LOCK TABLES `branch` WRITE;
/*!40000 ALTER TABLE `branch` DISABLE KEYS */;
INSERT INTO `branch` VALUES ('B001','Paharpur','BARB0PAHMUZ','Bihar'),('B002','Hajipur','BARB0HAJIPU','Bihar'),('B003','Damodarpur','SBIN0123456','Bihar'),('B004','Sitamarahi',NULL,'Bihar'),('B005','Motihari',NULL,'Bihar');
/*!40000 ALTER TABLE `branch` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `CId` char(4) NOT NULL,
  `customerName` varchar(30) DEFAULT NULL,
  `BranchCode` char(4) DEFAULT NULL,
  `Gender` char(1) DEFAULT NULL,
  `Contact_No` char(10) DEFAULT NULL,
  `state` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`CId`),
  UNIQUE KEY `Contact_No` (`Contact_No`),
  KEY `FK_BranchCode` (`BranchCode`),
  CONSTRAINT `FK_BranchCode` FOREIGN KEY (`BranchCode`) REFERENCES `branch` (`BranchCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES ('C001','Neha Bharti','B001','F','6299481145','Bihar'),('C002','Tanishka Bharti','B001','F','8745362894','Panjab'),('C003','Svati Singh','B002','F','9576483254','Meghalaya'),('C004','Astha Priya','B003','F','9856473456','Goa');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `EId` char(4) NOT NULL,
  `EmployeeName` varchar(30) DEFAULT NULL,
  `BranchCode` char(4) DEFAULT NULL,
  `Gender` char(1) DEFAULT NULL,
  `Contact_No` char(10) DEFAULT NULL,
  `State` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`EId`),
  UNIQUE KEY `Contact_No` (`Contact_No`),
  KEY `FK_BranchCodeEmployee` (`BranchCode`),
  CONSTRAINT `FK_BranchCodeEmployee` FOREIGN KEY (`BranchCode`) REFERENCES `branch` (`BranchCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES ('E001','Amisha Kumari','B001','F','8965432356','Bihar'),('E002','Nisha Kumari','B002','F','9834562346','Bihar'),('E003','Shivani Kumari','B003','F','9787563834','Bihar'),('E004','Tanishka Bharti','B004','F','9565192821','Bihar'),('E005','Simran Suman','B005','F','8754384931','Bihar');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-02-05 19:00:16
