-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 16, 2023 at 09:20 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `salmanapplication`
--

-- --------------------------------------------------------

--
-- Table structure for table `records`
--

CREATE TABLE `records` (
  `Record_ID` int(100) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `EmailAdd` varchar(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `Country` varchar(100) NOT NULL,
  `Contact` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `records`
--

INSERT INTO `records` (`Record_ID`, `FirstName`, `LastName`, `EmailAdd`, `Gender`, `Country`, `Contact`) VALUES
(1, 'Muhammad', 'Salman', 'salman@gmail.com', 'Male', 'Pakistan', '03366874516'),
(2, 'Muhammad', 'Bilal', 'mbilal@hotmail.com', 'Male', 'Germany', '00971'),
(3, 'Adnan', 'Talib', 'adnan@hotmail.com', 'Male', 'Pakistan', '1010125'),
(4, 'Muhammad', 'Salman', 'salman0097@gmail.com', 'Male', 'Bangladesh', '987654321'),
(5, 'User', 'User', 'user', 'Female', 'Canada', '123001'),
(7, 'Muhammad', 'Salman', 'salman97@gmail.com', 'Female', 'United Arab Emirates', '454545'),
(8, 'abc', 'xyz', 'az@gmail.com', 'Male', 'Denmark', '654123'),
(10, 'xD123', 'xD123', 'xD123@gmail.com', 'Female', 'Kuwait', '123456'),
(11, 'name', 'name', 'name@gmail.com', 'Female', 'Oman', '912345'),
(12, 'Talha', 'Khan', 'talhakhan@gmail.com', 'Male', 'France', '871456789'),
(13, 'Salman', 'Haleem', 'gmail.com', 'Male', 'Canada', '123'),
(14, 'Wajjih', 'Uddin', 'wajih@iqra.edu.pk', 'Female', 'France', '911-123'),
(15, 'Muhammad', 'Bilal', 'bilal123@gmail.com', 'Male', 'Pakistan', '787878');

-- --------------------------------------------------------

--
-- Table structure for table `userlogin`
--

CREATE TABLE `userlogin` (
  `User_name` varchar(100) NOT NULL,
  `User_password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `userlogin`
--

INSERT INTO `userlogin` (`User_name`, `User_password`) VALUES
('admin', 'admin'),
('root', 'root'),
('salman97', 'salman97'),
('salman', '0097'),
('bilal911', 'bilal12345'),
('root', 'root123'),
('xyz', 'xyz123'),
('talha123', 'talha12'),
('bilal302', 'bilal302'),
('test', 'test'),
('faizan', 'faizan1234');

-- --------------------------------------------------------

--
-- Table structure for table `usersignup`
--

CREATE TABLE `usersignup` (
  `UID` int(100) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Contact` varchar(100) NOT NULL,
  `Uname` varchar(100) NOT NULL,
  `Upassword` varchar(100) NOT NULL,
  `DoB` varchar(50) NOT NULL,
  `Gender` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usersignup`
--

INSERT INTO `usersignup` (`UID`, `FirstName`, `LastName`, `Email`, `Contact`, `Uname`, `Upassword`, `DoB`, `Gender`) VALUES
(1, 'Muhammad', 'Salman', 'salman97@gmail.com', '03366874516', 'salman97', 'salman0097', '12-01-2023', 'Male'),
(2, 'Muhammad', 'Bilal', 'bilal@gmail.com', '03138091211', 'bilal911', 'bilal12345', '15-06-2022', 'Male'),
(3, 'Test1', 'Test2', 'test@mail.com', '123456', 'root', 'root123', '12-01-2023', 'Female'),
(4, 'Abc', 'Abc', 'abc@gmail.com', '009712345', 'xyz', 'xyz123', '30-12-2022', 'Male'),
(5, 'Muhammad', 'Talha', 'talha12@hotmail.com', '0313123456', 'talha123', 'talha12', '15-11-2022', 'Male'),
(6, 'Muhammad', 'Bilal', 'bilal@gmial.com', '12345678900', 'bilal302', 'bilal302', '17-06-2022', 'Male'),
(7, 'Test', 'User', 'testing@hotmail.com', 'test00123', 'test', 'test', '18-06-2020', 'Male'),
(8, 'Faizan', 'Talib', 'faizan28@gmail.com', '0331122334455', 'faizan', 'faizan1234', '17-01-2023', 'Male');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `records`
--
ALTER TABLE `records`
  ADD PRIMARY KEY (`Record_ID`);

--
-- Indexes for table `usersignup`
--
ALTER TABLE `usersignup`
  ADD PRIMARY KEY (`UID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `records`
--
ALTER TABLE `records`
  MODIFY `Record_ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `usersignup`
--
ALTER TABLE `usersignup`
  MODIFY `UID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
