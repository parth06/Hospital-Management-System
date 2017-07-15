-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 15, 2017 at 09:12 AM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 7.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hms`
--

-- --------------------------------------------------------

--
-- Table structure for table `doctorreg`
--

CREATE TABLE `doctorreg` (
  `Did` int(11) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Login_id` int(11) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Department` varchar(20) NOT NULL,
  `DoB` date NOT NULL,
  `Email` varchar(20) NOT NULL,
  `Mno` varchar(10) NOT NULL,
  `Qualification` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `doctorreg`
--

INSERT INTO `doctorreg` (`Did`, `Name`, `Login_id`, `Gender`, `Department`, `DoB`, `Email`, `Mno`, `Qualification`) VALUES
(1, 'Sanjay', 2, 'Male', 'Dermatology', '1990-07-06', 'sanjay@ssg.com', '8899977666', 'MBBS');

-- --------------------------------------------------------

--
-- Table structure for table `inpatient`
--

CREATE TABLE `inpatient` (
  `id` int(11) NOT NULL,
  `P_id` int(11) NOT NULL,
  `DateOfAdmit` date NOT NULL,
  `diseases` varchar(20) NOT NULL,
  `Roomno` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inpatient`
--

INSERT INTO `inpatient` (`id`, `P_id`, `DateOfAdmit`, `diseases`, `Roomno`) VALUES
(1, 1, '2017-04-12', 'Flu', 3);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `Username` varchar(10) NOT NULL,
  `Password` varchar(10) NOT NULL,
  `UserType` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `Username`, `Password`, `UserType`) VALUES
(1, 'ramesh1', 'ramesh1', 'Staff'),
(2, 'sanjay2', 'sanjay2', 'Doctor'),
(3, 'anshu3', 'anshu3', 'Staff');

-- --------------------------------------------------------

--
-- Table structure for table `outpatient`
--

CREATE TABLE `outpatient` (
  `id` int(11) NOT NULL,
  `cid` int(11) NOT NULL,
  `OutDate` date NOT NULL,
  `Remarks` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outpatient`
--

INSERT INTO `outpatient` (`id`, `cid`, `OutDate`, `Remarks`) VALUES
(1, 1, '2017-04-15', '');

-- --------------------------------------------------------

--
-- Table structure for table `patientreg`
--

CREATE TABLE `patientreg` (
  `Pid` int(11) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `DoB` date NOT NULL,
  `BloodGroup` varchar(5) NOT NULL,
  `allergy` varchar(20) NOT NULL,
  `phone` varchar(10) NOT NULL,
  `Address` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `patientreg`
--

INSERT INTO `patientreg` (`Pid`, `Name`, `Gender`, `DoB`, `BloodGroup`, `allergy`, `phone`, `Address`) VALUES
(1, 'Ashish', 'Male', '1997-04-16', 'A+', 'Food Allergy', '8989898989', '1st Floor, Procube Cube Center,Nizampura,Vadodara'),
(2, 'Neel', 'Male', '1986-07-28', 'B+', '', '7878433987', 'Anand'),
(3, 'Yash', 'Male', '0000-00-00', 'O+', '', '9898799799', 'Vadodara'),
(4, 'Shubham', 'Male', '0000-00-00', 'O+', '', '8866699777', 'Vadodara'),
(5, 'Deep', 'Male', '1990-07-06', 'A+', 'Dust', '7878464646', 'Anand');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `id` int(11) NOT NULL,
  `Type` varchar(10) NOT NULL,
  `Fee` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`id`, `Type`, `Fee`) VALUES
(1, 'AC', 500),
(2, 'AC', 500),
(3, 'AC', 500),
(4, 'General', 200),
(5, 'General', 200);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `Sid` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `Login_id` int(11) NOT NULL,
  `phone` varchar(10) NOT NULL,
  `DoB` date NOT NULL,
  `Address` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`Sid`, `name`, `Login_id`, `phone`, `DoB`, `Address`) VALUES
(1, 'Ramesh', 1, '9999988888', '1986-02-10', '203-Indra Complex,Manjalpur,Vadodara'),
(2, 'Anshu', 3, '9679797979', '1984-07-05', 'Anand');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `doctorreg`
--
ALTER TABLE `doctorreg`
  ADD PRIMARY KEY (`Did`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `outpatient`
--
ALTER TABLE `outpatient`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `patientreg`
--
ALTER TABLE `patientreg`
  ADD PRIMARY KEY (`Pid`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`Sid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `doctorreg`
--
ALTER TABLE `doctorreg`
  MODIFY `Did` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `outpatient`
--
ALTER TABLE `outpatient`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `patientreg`
--
ALTER TABLE `patientreg`
  MODIFY `Pid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `room`
--
ALTER TABLE `room`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `Sid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
