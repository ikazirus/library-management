-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 28, 2017 at 09:32 AM
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
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `ISBN` varchar(20) NOT NULL,
  `Title` varchar(200) NOT NULL,
  `Price` int(10) NOT NULL,
  `Section` varchar(20) NOT NULL,
  `Author` varchar(100) NOT NULL,
  `Edition` int(2) NOT NULL,
  `Shelf_ID` varchar(10) NOT NULL,
  `Available` tinyint(1) NOT NULL DEFAULT '1',
  `Copies` int(3) NOT NULL DEFAULT '1',
  `Notes` varchar(2000) NOT NULL DEFAULT 'Add a note......'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `book_ascn`
--

CREATE TABLE `book_ascn` (
  `Asseccion_ID` varchar(20) NOT NULL DEFAULT 'BK',
  `ISBN` varchar(20) NOT NULL,
  `Issued` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `course_type`
--

CREATE TABLE `course_type` (
  `Course_Type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `course_type`
--

INSERT INTO `course_type` (`Course_Type`) VALUES
('Full Time'),
('Part Time');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `DepID` varchar(20) NOT NULL DEFAULT 'HND',
  `DepName` varchar(100) NOT NULL DEFAULT 'Higher National Deploma in '
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`DepID`, `DepName`) VALUES
('HNDA', 'Higher National Deploma in Accountancy'),
('HNDT.Agri', 'Higher National Deploma in Agriculture'),
('HNDBS', 'Higher National Deploma in Building Services'),
('HNDBA', 'Higher National Deploma in Business Administration'),
('HNDBF', 'Higher National Deploma in Business Finance'),
('HNDCivil', 'Higher National Deploma in Engineering - Civil'),
('HNDElect', 'Higher National Deploma in Engineering - Electrical'),
('HNDMecha', 'Higher National Deploma in Engineering - Mechanical'),
('HNDE', 'Higher National Deploma in English '),
('HNDFT', 'Higher National Deploma in Food Technology'),
('HNDIT', 'Higher National Deploma in Information Technology'),
('HNDM', 'Higher National Deploma in Management'),
('HNDQS', 'Higher National Deploma in Quantity Survey'),
('HNDTHM', 'Higher National Deploma in Tourism and Hospitality Management');

-- --------------------------------------------------------

--
-- Table structure for table `issue_book`
--

CREATE TABLE `issue_book` (
  `Issue_ID` varchar(20) NOT NULL,
  `Accession_ID` varchar(20) NOT NULL,
  `StudentID` int(10) NOT NULL,
  `Patron` varchar(20) NOT NULL,
  `Borrowed_Date` date NOT NULL,
  `Due_Date` date NOT NULL,
  `Returned_Date` date DEFAULT NULL,
  `Returned` tinyint(1) NOT NULL DEFAULT '0',
  `Fine` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
-- Table structure for table `patron`
--

CREATE TABLE `patron` (
  `User_Name` varchar(200) NOT NULL,
  `Password` varchar(250) NOT NULL,
  `Type` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `patron`
--

INSERT INTO `patron` (`User_Name`, `Password`, `Type`) VALUES
('Admin', 'b59c67bf196a4758191e42f76670ceba', 'admin');

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
('Eng', 'English'),
('IT', 'INFORMATION TECHNOLOGY'),
('Lit', 'Literature'),
('Mgt', 'Managemnt'),
('Mth', 'Mathematics'),
('Tou', 'Tourism');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `StudentID` int(10) NOT NULL,
  `First_Name` varchar(50) NOT NULL,
  `Last_Name` varchar(50) NOT NULL,
  `NIC` int(10) NOT NULL,
  `Address` varchar(200) NOT NULL,
  `Department` varchar(20) NOT NULL,
  `Year` int(4) NOT NULL,
  `Course_Type` varchar(20) NOT NULL,
  `AdmissionNo` int(5) NOT NULL,
  `Gender` char(1) NOT NULL,
  `Telephone` int(10) NOT NULL,
  `Active` tinyint(1) NOT NULL DEFAULT '1',
  `L_Book_Issued` tinyint(1) NOT NULL DEFAULT '0',
  `R_Book_Issued` tinyint(1) NOT NULL DEFAULT '0',
  `Fine` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
(2026),
(2027),
(2028),
(2029),
(2030);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`ISBN`),
  ADD KEY `ISBN` (`ISBN`),
  ADD KEY `Title` (`Title`),
  ADD KEY `Section` (`Section`),
  ADD KEY `Author` (`Author`),
  ADD KEY `Section_2` (`Section`),
  ADD KEY `Shelf_ID` (`Shelf_ID`);

--
-- Indexes for table `book_ascn`
--
ALTER TABLE `book_ascn`
  ADD PRIMARY KEY (`Asseccion_ID`),
  ADD KEY `ISBN` (`ISBN`);

--
-- Indexes for table `course_type`
--
ALTER TABLE `course_type`
  ADD PRIMARY KEY (`Course_Type`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`DepID`),
  ADD UNIQUE KEY `DepName` (`DepName`);

--
-- Indexes for table `issue_book`
--
ALTER TABLE `issue_book`
  ADD PRIMARY KEY (`Issue_ID`),
  ADD KEY `StudentID` (`StudentID`),
  ADD KEY `Accession_ID` (`Accession_ID`),
  ADD KEY `Patron` (`Patron`);

--
-- Indexes for table `lib_section`
--
ALTER TABLE `lib_section`
  ADD PRIMARY KEY (`Section`);

--
-- Indexes for table `patron`
--
ALTER TABLE `patron`
  ADD PRIMARY KEY (`User_Name`);

--
-- Indexes for table `shelf`
--
ALTER TABLE `shelf`
  ADD PRIMARY KEY (`Shelf_ID`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`StudentID`),
  ADD UNIQUE KEY `NIC` (`NIC`),
  ADD KEY `Admission` (`Department`,`AdmissionNo`,`Year`),
  ADD KEY `Year` (`Year`),
  ADD KEY `type` (`Course_Type`);

--
-- Indexes for table `year`
--
ALTER TABLE `year`
  ADD PRIMARY KEY (`Year`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `book`
--
ALTER TABLE `book`
  ADD CONSTRAINT `book_ibfk_3` FOREIGN KEY (`Shelf_ID`) REFERENCES `shelf` (`Shelf_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `book_ibfk_4` FOREIGN KEY (`Section`) REFERENCES `lib_section` (`Section`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `book_ascn`
--
ALTER TABLE `book_ascn`
  ADD CONSTRAINT `book_ascn_ibfk_1` FOREIGN KEY (`ISBN`) REFERENCES `book` (`ISBN`);

--
-- Constraints for table `issue_book`
--
ALTER TABLE `issue_book`
  ADD CONSTRAINT `issue_book_ibfk_1` FOREIGN KEY (`StudentID`) REFERENCES `student` (`StudentID`),
  ADD CONSTRAINT `issue_book_ibfk_3` FOREIGN KEY (`Patron`) REFERENCES `patron` (`User_Name`) ON UPDATE CASCADE,
  ADD CONSTRAINT `issue_book_ibfk_4` FOREIGN KEY (`Accession_ID`) REFERENCES `book_ascn` (`Asseccion_ID`);

--
-- Constraints for table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `student_ibfk_1` FOREIGN KEY (`Year`) REFERENCES `year` (`Year`),
  ADD CONSTRAINT `student_ibfk_2` FOREIGN KEY (`Department`) REFERENCES `department` (`DepID`),
  ADD CONSTRAINT `student_ibfk_3` FOREIGN KEY (`Course_Type`) REFERENCES `course_type` (`Course_Type`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
