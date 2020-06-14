-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 17, 2018 at 10:58 AM
-- Server version: 10.1.35-MariaDB
-- PHP Version: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library`
--

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `bookId` varchar(8) NOT NULL,
  `bookTitle` varchar(20) NOT NULL,
  `authorName` varchar(20) NOT NULL,
  `publicationYear` int(4) NOT NULL,
  `availableQuantity` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`bookId`, `bookTitle`, `authorName`, `publicationYear`, `availableQuantity`) VALUES
('1', 'Lord Of The Rings', 'J.J. Tolkien', 1954, 12),
('2', 'Harry Potter ', 'J.K. Rowling', 1997, 8);

-- --------------------------------------------------------

--
-- Table structure for table `borrowinfo`
--

CREATE TABLE `borrowinfo` (
  `borrowId` varchar(8) NOT NULL,
  `bookId` varchar(8) NOT NULL,
  `userId` varchar(8) NOT NULL,
  `borrowDate` varchar(11) NOT NULL,
  `returnDate` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `borrowinfo`
--

INSERT INTO `borrowinfo` (`borrowId`, `bookId`, `userId`, `borrowDate`, `returnDate`) VALUES
('b1', '2', 'shawon', '17/12/2018', '18/17/2018');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `userId` varchar(8) NOT NULL,
  `password` int(8) NOT NULL,
  `eName` varchar(20) NOT NULL,
  `phoneNumber` int(20) NOT NULL,
  `address` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`userId`, `password`, `eName`, `phoneNumber`, `address`) VALUES
('17-33', 324, 'fakhrul', 880176767, 'fakhrul'),
('shawon', 123, 'shawon@gmail.com', 880111111, 'dhaka');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `userId` varchar(8) NOT NULL,
  `employeeName` varchar(20) NOT NULL,
  `phoneNumber` int(11) NOT NULL,
  `role` varchar(11) NOT NULL,
  `salary` double(6,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `userId` varchar(8) NOT NULL,
  `password` varchar(8) NOT NULL,
  `status` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`userId`, `password`, `status`) VALUES
('17', '34', 0),
('shawon', '123', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`bookId`);

--
-- Indexes for table `borrowinfo`
--
ALTER TABLE `borrowinfo`
  ADD PRIMARY KEY (`borrowId`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`userId`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`userId`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD UNIQUE KEY `UNIQUE` (`userId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
