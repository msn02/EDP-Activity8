-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 25, 2024 at 06:43 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `emp_mgt`
--
CREATE DATABASE IF NOT EXISTS `emp_mgt` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `emp_mgt`;

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `dept_id` int(11) NOT NULL,
  `dept_name` varchar(45) NOT NULL,
  `dept_location` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`dept_id`, `dept_name`, `dept_location`) VALUES
(1, 'Marketing ', 'Camalig, Albay'),
(2, 'Operations', 'Daraga, Albay'),
(3, 'Technology', 'Guinobatan, Albay'),
(4, 'Human Resources', 'Legazpi City, Albay'),
(5, 'Communications', 'Ligao City, Albay');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `emp_id` int(11) NOT NULL,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `contact_num` double NOT NULL,
  `email` varchar(255) NOT NULL,
  `dept_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_id`, `first_name`, `last_name`, `contact_num`, `email`, `dept_id`) VALUES
(1, 'Janelle', 'Canoy', 9982377035, 'janellec4noy@example.com', 1),
(2, 'Cesar', 'Fernandez', 9836735858, 'cesar.fernandz90@example.com', 2),
(3, 'Gabriel', 'Suarez', 9323206305, 'gabriel.suarez348@example.com', 3),
(4, 'Jasmine', 'Condat', 9074850021, 'jasmineCo45@example.com', 4),
(5, 'Ariel', 'Magtangob', 9340493127, 'arielM21@example.com', 5),
(6, 'Daniel', 'Lomibao', 9023248659, 'lomibao03D@example.com', 1),
(7, 'Riley', 'Alvarez', 9285616064, 'riley89.alz@example.com', 2),
(8, 'John', 'Velasquez', 9362103843, 'velasquezJohn36@example.com', 3),
(9, 'Joaquin', 'Gomez', 9262738231, 'gomezquin31@example.com', 4),
(11, 'Henry', 'Diaz', 9373829227, 'henrydiaz47@example.com', 5),
(12, 'Catherine', 'Cruz', 9362362738, 'cathy6C@example.com', 1),
(13, 'Jessica', 'Mondragon', 9764251425, 'mondragon51@example.com', 2),
(14, 'Mickey', 'Villalobos', 9263892436, 'villalobos.mickey90@example.com', 3),
(15, 'Maricris', 'Buen', 9702923823, 'mariBuen16@example.com', 4),
(16, 'Mary Grace', 'Castuera', 9854328289, 'castuera87mg@example.com', 5),
(19, 'Joseph', 'Borlagdan', 9123456789, 'joseph123@example.com', 1),
(20, 'Marjorie', 'Sambajon', 9349347594, 'mj567@example.com', 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`dept_id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_id`),
  ADD KEY `dept_id_idx` (`dept_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `dept_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `emp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `dept_id` FOREIGN KEY (`dept_id`) REFERENCES `department` (`dept_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
