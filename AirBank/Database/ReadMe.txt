DATABASE SETUP

TO CREATE DATABASE, COPY THE BELOW CODE

CREATE DATABASE administratordb;
CREATE TABLE `account` (
  `AccountID` int(11) NOT NULL,
  `Firstname` varchar(50) DEFAULT NULL,
  `Lastname` varchar(50) DEFAULT NULL,
  `Middle` varchar(50) DEFAULT NULL,
  `Birthdate` date DEFAULT NULL,
  `Balance` decimal(10,2) DEFAULT NULL,
  `Passcode` varchar(255) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `Gender` varchar(10) DEFAULT NULL
);
CREATE TABLE `admindb` (
  `id` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL
);
CREATE TABLE `log` (
  `id` int(11) NOT NULL,
  `AccountID` int(11) NOT NULL,
  `Count` int(11) DEFAULT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Date` varchar(50) DEFAULT NULL,
  `Time` varchar(50) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL
);
