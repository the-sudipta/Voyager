-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: sql6.freemysqlhosting.net
-- Generation Time: Mar 05, 2024 at 05:23 PM
-- Server version: 5.5.62-0ubuntu0.14.04.1
-- PHP Version: 7.0.33-0ubuntu0.16.04.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sql6688926`
--

-- --------------------------------------------------------

--
-- Table structure for table `Air_Table`
--

CREATE TABLE `Air_Table` (
  `id` int(50) NOT NULL,
  `air` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Air_Table`
--

INSERT INTO `Air_Table` (`id`, `air`) VALUES
(1, 'Biman Bangladesh Airlines'),
(2, 'Novoair'),
(3, 'Regent Airways'),
(4, 'US-Bangla Airlines');

-- --------------------------------------------------------

--
-- Table structure for table `Bus_Table`
--

CREATE TABLE `Bus_Table` (
  `id` int(50) NOT NULL,
  `bus` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Bus_Table`
--

INSERT INTO `Bus_Table` (`id`, `bus`) VALUES
(1, 'Green Line'),
(2, 'Desh Travels'),
(3, 'Shohagh Paribahan'),
(4, 'Soudia Coach Service'),
(5, 'Shyamoli Paribahan'),
(6, 'Royal Coach');

-- --------------------------------------------------------

--
-- Table structure for table `Client_Table`
--

CREATE TABLE `Client_Table` (
  `id` int(50) NOT NULL,
  `name` char(50) DEFAULT NULL,
  `phone` char(50) DEFAULT NULL,
  `mail` char(50) DEFAULT NULL,
  `nid` char(50) DEFAULT NULL,
  `member` int(30) DEFAULT NULL,
  `date` char(30) DEFAULT NULL,
  `destination` char(50) DEFAULT NULL,
  `transport` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Client_Table`
--

INSERT INTO `Client_Table` (`id`, `name`, `phone`, `mail`, `nid`, `member`, `date`, `destination`, `transport`) VALUES
(1, 'Sudipta Kumar', '01931117419', 'dip.kumar020@gmail.com', '112233123321', 3, '4/5/2022', 'Bandarban', 'Novoair'),
(2, 'Samrat Parvez', '01853538364', 'samrat@gmail.com', '123321123321123', 2, '27/4/2022', 'Bandarban', 'Royal Coach'),
(3, 'Rajib', '0191111111111111', 'rajib@gmail.com', '1111111111111111111', 3, 'asdasdsada', 'Rangamati', 'Biman Bangladesh Airlines');

-- --------------------------------------------------------

--
-- Table structure for table `Destination_Table`
--

CREATE TABLE `Destination_Table` (
  `id` int(50) NOT NULL,
  `destination` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Destination_Table`
--

INSERT INTO `Destination_Table` (`id`, `destination`) VALUES
(1, 'Dhaka'),
(2, 'Dinajpur'),
(3, 'Comilla'),
(4, 'Sonargaon'),
(5, 'Bogra'),
(6, 'Bandarban'),
(7, 'Sylhet'),
(8, 'Rangamati'),
(9, 'Netrokona'),
(10, 'Sundarban'),
(11, 'Saint Martain'),
(12, 'Barishal'),
(13, 'Chittagong'),
(14, 'Coxs Bazar'),
(15, 'Moulovi Bazar'),
(16, 'Patuakhali'),
(17, 'Bagerhat');

-- --------------------------------------------------------

--
-- Table structure for table `Hotel_Table`
--

CREATE TABLE `Hotel_Table` (
  `id` int(50) NOT NULL,
  `hotel` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Hotel_Table`
--

INSERT INTO `Hotel_Table` (`id`, `hotel`) VALUES
(1, 'Hotel Noorjahan Grand'),
(2, 'Hotel Shuktara'),
(3, 'Hotel Noorjahan Grand'),
(4, 'Hotel Shuktara'),
(5, 'La Vinchi Hotel'),
(6, 'Hotel Lake Castle'),
(7, 'Traveller In'),
(8, 'Hotel Saint Martain Limited'),
(9, 'Nirvana Inn'),
(10, 'NAAS Serviced Apartments'),
(11, 'Hotel Golden Inn'),
(12, 'Asia Hotel & Resorts'),
(13, 'Hotel Valley Garden'),
(14, 'The Raintree Dhaka'),
(15, 'Richmond Hotel & Apartments'),
(16, 'The Enchanted'),
(17, 'Richmond Hotel & Suites'),
(18, 'Hotel Progati Inn'),
(19, 'Grand Oriental Hotel'),
(20, 'Bashanti Bay Resort');

-- --------------------------------------------------------

--
-- Table structure for table `Message_Table`
--

CREATE TABLE `Message_Table` (
  `id` int(50) NOT NULL,
  `admin` char(255) DEFAULT NULL,
  `recep` char(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Message_Table`
--

INSERT INTO `Message_Table` (`id`, `admin`, `recep`) VALUES
(1, 'How are you?', 'Hello');

-- --------------------------------------------------------

--
-- Table structure for table `Staffs_Table`
--

CREATE TABLE `Staffs_Table` (
  `id` int(50) NOT NULL,
  `username` char(30) DEFAULT NULL,
  `password` char(50) DEFAULT NULL,
  `earnings` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Staffs_Table`
--

INSERT INTO `Staffs_Table` (`id`, `username`, `password`, `earnings`) VALUES
(1, 'samrat_admin', 'samrat', '50000'),
(2, 'riya_recep', 'ripty', '30000');

-- --------------------------------------------------------

--
-- Table structure for table `Tour_Table`
--

CREATE TABLE `Tour_Table` (
  `id` int(50) NOT NULL,
  `tours` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Tour_Table`
--

INSERT INTO `Tour_Table` (`id`, `tours`) VALUES
(1, '4/5/2022'),
(2, '27/4/2022'),
(3, '4/5/2023');

-- --------------------------------------------------------

--
-- Table structure for table `Train_Table`
--

CREATE TABLE `Train_Table` (
  `id` int(50) NOT NULL,
  `train` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Train_Table`
--

INSERT INTO `Train_Table` (`id`, `train`) VALUES
(1, 'Sonar Bangla'),
(2, 'Kalani Express'),
(3, 'Chattala Express'),
(4, 'Hawr Express'),
(5, 'Upobon Express'),
(6, 'Maganogor Provati Express'),
(7, 'Parbat Express'),
(8, 'Joyontika Express');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Air_Table`
--
ALTER TABLE `Air_Table`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Bus_Table`
--
ALTER TABLE `Bus_Table`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Client_Table`
--
ALTER TABLE `Client_Table`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Destination_Table`
--
ALTER TABLE `Destination_Table`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Hotel_Table`
--
ALTER TABLE `Hotel_Table`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Message_Table`
--
ALTER TABLE `Message_Table`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Staffs_Table`
--
ALTER TABLE `Staffs_Table`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Tour_Table`
--
ALTER TABLE `Tour_Table`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `Train_Table`
--
ALTER TABLE `Train_Table`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Air_Table`
--
ALTER TABLE `Air_Table`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `Bus_Table`
--
ALTER TABLE `Bus_Table`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `Client_Table`
--
ALTER TABLE `Client_Table`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `Destination_Table`
--
ALTER TABLE `Destination_Table`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `Hotel_Table`
--
ALTER TABLE `Hotel_Table`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `Message_Table`
--
ALTER TABLE `Message_Table`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `Staffs_Table`
--
ALTER TABLE `Staffs_Table`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `Tour_Table`
--
ALTER TABLE `Tour_Table`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `Train_Table`
--
ALTER TABLE `Train_Table`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
