-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 30, 2017 at 11:25 AM
-- Server version: 5.7.14
-- PHP Version: 7.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `author`
--

CREATE TABLE `author` (
  `Author` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `author`
--

INSERT INTO `author` (`Author`) VALUES
('Test Author 01'),
('Test Author 02'),
('Test Author 03'),
('Test Author 04');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `Accession_ID` int(10) NOT NULL,
  `Title` varchar(200) NOT NULL,
  `ISBN` varchar(20) NOT NULL,
  `Publisher` varchar(200) NOT NULL,
  `Price` int(10) NOT NULL,
  `Section` varchar(20) NOT NULL,
  `Author` varchar(100) NOT NULL,
  `Edition` int(2) NOT NULL,
  `Shelf_ID` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`Accession_ID`, `Title`, `ISBN`, `Publisher`, `Price`, `Section`, `Author`, `Edition`, `Shelf_ID`) VALUES
(1, 'LINUX NETWORKING', 'ISBN-996784689', 'PUBLISHER1', 2500, 'Lendings', 'Test Author 01', 5, 'IT'),
(2, 'BASIC ACCOUNTING', 'ISBN-785878', 'PUBLISHER2', 5600, 'Reference', 'Test Author 02', 1, 'ACC');

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

CREATE TABLE `departments` (
  `DepID` varchar(10) NOT NULL DEFAULT 'HND',
  `DepName` varchar(100) NOT NULL DEFAULT 'Higher National Deploma in '
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`DepID`, `DepName`) VALUES
('HNDA', 'Higher National Deploma in Accountancy'),
('HNDIT', 'Higher National Deploma in Information Technology');

-- --------------------------------------------------------

--
-- Table structure for table `lending_info`
--

CREATE TABLE `lending_info` (
  `Lending_ID` varchar(20) NOT NULL,
  `Accession_ID` int(10) NOT NULL,
  `StudentID` int(10) NOT NULL,
  `Borrowed_Date` date NOT NULL,
  `Due_Date` date NOT NULL,
  `Fine` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `lending_info`
--

INSERT INTO `lending_info` (`Lending_ID`, `Accession_ID`, `StudentID`, `Borrowed_Date`, `Due_Date`, `Fine`) VALUES
('20170530#1', 1, 1, '2017-05-30', '2017-06-13', 0),
('20170530#2', 2, 2, '2017-05-09', '2017-05-10', 200);

-- --------------------------------------------------------

--
-- Table structure for table `lib_section`
--

CREATE TABLE `lib_section` (
  `Section` varchar(20) NOT NULL,
  `Fine_Rate` int(2) NOT NULL,
  `Maximum_Duration` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `lib_section`
--

INSERT INTO `lib_section` (`Section`, `Fine_Rate`, `Maximum_Duration`) VALUES
('Lendings', 2, 14),
('Reference', 10, 1);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `User_Name` varchar(20) NOT NULL,
  `Password` varchar(25) NOT NULL,
  `Type` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`User_Name`, `Password`, `Type`) VALUES
('1', '1', 'admin'),
('2', '2', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `publisher`
--

CREATE TABLE `publisher` (
  `Publisher` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `publisher`
--

INSERT INTO `publisher` (`Publisher`) VALUES
('PUBLISHER1'),
('PUBLISHER2');

-- --------------------------------------------------------

--
-- Table structure for table `shelf`
--

CREATE TABLE `shelf` (
  `Shelf_ID` varchar(10) NOT NULL,
  `Catagory` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shelf`
--

INSERT INTO `shelf` (`Shelf_ID`, `Catagory`) VALUES
('ACC', 'ACCOUNTING'),
('IT', 'INFORMATION TECHNOLOGY');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `StudentID` int(10) NOT NULL,
  `First_Name` varchar(50) NOT NULL,
  `Last_Name` varchar(50) NOT NULL,
  `NIC` int(10) NOT NULL,
  `Address` varchar(200) NOT NULL,
  `Department` varchar(10) NOT NULL,
  `Year` int(4) NOT NULL,
  `Full_Time` tinyint(1) NOT NULL,
  `AdmissionNo` int(5) NOT NULL,
  `Gender` char(1) NOT NULL,
  `Telephone` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`StudentID`, `First_Name`, `Last_Name`, `NIC`, `Address`, `Department`, `Year`, `Full_Time`, `AdmissionNo`, `Gender`, `Telephone`) VALUES
(1, 'TOMMY', 'BROWN', 94622321, 'LONDON,UK', 'HNDIT', 2017, 1, 54, 'M', 9526326),
(2, 'GENE', 'GREY', 976545626, 'BOSTON,USA', 'HNDA', 2014, 0, 12, 'F', 95633231);

-- --------------------------------------------------------

--
-- Table structure for table `year`
--

CREATE TABLE `year` (
  `Year` int(4) NOT NULL DEFAULT '2'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `year`
--

INSERT INTO `year` (`Year`) VALUES
(2010),
(2011),
(2012),
(2013),
(2014),
(2015),
(2016),
(2017),
(2018),
(2019),
(2020),
(2021),
(2022),
(2023),
(2024),
(2025),
(2026);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `author`
--
ALTER TABLE `author`
  ADD PRIMARY KEY (`Author`);

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`Accession_ID`),
  ADD KEY `ISBN` (`ISBN`),
  ADD KEY `Title` (`Title`),
  ADD KEY `Publisher` (`Publisher`),
  ADD KEY `Section` (`Section`),
  ADD KEY `Author` (`Author`),
  ADD KEY `Section_2` (`Section`),
  ADD KEY `Shelf_ID` (`Shelf_ID`);

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`DepID`),
  ADD UNIQUE KEY `DepName` (`DepName`);

--
-- Indexes for table `lending_info`
--
ALTER TABLE `lending_info`
  ADD PRIMARY KEY (`Lending_ID`),
  ADD KEY `StudentID` (`StudentID`),
  ADD KEY `Accession_ID` (`Accession_ID`);

--
-- Indexes for table `lib_section`
--
ALTER TABLE `lib_section`
  ADD PRIMARY KEY (`Section`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`User_Name`);

--
-- Indexes for table `publisher`
--
ALTER TABLE `publisher`
  ADD PRIMARY KEY (`Publisher`);

--
-- Indexes for table `shelf`
--
ALTER TABLE `shelf`
  ADD PRIMARY KEY (`Shelf_ID`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`StudentID`),
  ADD UNIQUE KEY `NIC` (`NIC`),
  ADD KEY `Admission` (`Department`,`AdmissionNo`,`Year`,`Full_Time`),
  ADD KEY `Year` (`Year`);

--
-- Indexes for table `year`
--
ALTER TABLE `year`
  ADD PRIMARY KEY (`Year`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `books_ibfk_1` FOREIGN KEY (`Author`) REFERENCES `author` (`Author`),
  ADD CONSTRAINT `books_ibfk_2` FOREIGN KEY (`Publisher`) REFERENCES `publisher` (`Publisher`),
  ADD CONSTRAINT `books_ibfk_3` FOREIGN KEY (`Shelf_ID`) REFERENCES `shelf` (`Shelf_ID`),
  ADD CONSTRAINT `books_ibfk_4` FOREIGN KEY (`Section`) REFERENCES `lib_section` (`Section`);

--
-- Constraints for table `lending_info`
--
ALTER TABLE `lending_info`
  ADD CONSTRAINT `lending_info_ibfk_1` FOREIGN KEY (`StudentID`) REFERENCES `students` (`StudentID`),
  ADD CONSTRAINT `lending_info_ibfk_2` FOREIGN KEY (`Accession_ID`) REFERENCES `books` (`Accession_ID`);

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `students_ibfk_1` FOREIGN KEY (`Year`) REFERENCES `year` (`Year`),
  ADD CONSTRAINT `students_ibfk_2` FOREIGN KEY (`Department`) REFERENCES `departments` (`DepID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
