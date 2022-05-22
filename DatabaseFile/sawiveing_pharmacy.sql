-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 22, 2022 at 03:48 PM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 7.3.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sawiveing_pharmacy`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `cus_id` int(11) NOT NULL,
  `cus_name` varchar(255) DEFAULT NULL,
  `cus_gender` varchar(10) DEFAULT NULL,
  `cus_dob` date DEFAULT NULL,
  `cus_address` text DEFAULT NULL,
  `cus_tel` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`cus_id`, `cus_name`, `cus_gender`, `cus_dob`, `cus_address`, `cus_tel`) VALUES
(1, 'test123', 'ຊາຍ', '2022-05-13', 'sfsdfsdfs', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `emp_id` int(11) NOT NULL,
  `emp_name` varchar(255) DEFAULT NULL,
  `emp_dob` date DEFAULT NULL,
  `emp_gender` varchar(10) DEFAULT NULL,
  `emp_address` text DEFAULT NULL,
  `emp_tel` varchar(15) DEFAULT NULL,
  `emp_username` varchar(30) DEFAULT NULL,
  `emp_password` varchar(30) DEFAULT NULL,
  `stt` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_id`, `emp_name`, `emp_dob`, `emp_gender`, `emp_address`, `emp_tel`, `emp_username`, `emp_password`, `stt`) VALUES
(1, 'admin', '2022-05-11', 'male', 'office', '123', 'admin', '123', '1'),
(4, 'Pou', '2022-05-13', 'ຊາຍ', 'test', '123', 'Pou', '123456', NULL),
(5, 'staff', '2022-05-13', 'ຊາຍ', 'staff', '123', 'staff', '123', NULL),
(6, 'test333', '2022-04-01', 'ຍິງ', 'test3351', '12345', 'test33', '123', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `import_detail`
--

CREATE TABLE `import_detail` (
  `ipd_id` int(11) NOT NULL,
  `imp_id` int(11) DEFAULT NULL,
  `mdc_id` int(11) DEFAULT NULL,
  `imp_qty` int(11) DEFAULT NULL,
  `imp_prices` double(11,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `medicine`
--

CREATE TABLE `medicine` (
  `mdc_id` int(11) NOT NULL,
  `mdc_name` varchar(255) DEFAULT NULL,
  `type_id` int(11) DEFAULT NULL,
  `unit_id` int(11) DEFAULT NULL,
  `mdc_stock` int(11) DEFAULT NULL,
  `expired_date` date DEFAULT NULL,
  `mdc_price` double(11,2) DEFAULT NULL,
  `mdc_detail` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `medicine`
--

INSERT INTO `medicine` (`mdc_id`, `mdc_name`, `type_id`, `unit_id`, `mdc_stock`, `expired_date`, `mdc_price`, `mdc_detail`) VALUES
(1, 'ປາລາເຊຕະໂມນ123', 3, 2, 6, '2022-07-01', 60000.00, 'ກິນ 3 ເມັດ(ເຊົ້າ, ສວາຍ, ແລງ)/ມື້'),
(4, 'ຊາຣາ', 4, 1, 6, '2022-05-14', 6000.00, 'ກິນເຊົ້າສວາຍແລງ');

-- --------------------------------------------------------

--
-- Table structure for table `purchase`
--

CREATE TABLE `purchase` (
  `pch_id` int(11) NOT NULL,
  `pch_date` timestamp NULL DEFAULT current_timestamp(),
  `emp_id` int(11) DEFAULT NULL,
  `sup_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `purchase`
--

INSERT INTO `purchase` (`pch_id`, `pch_date`, `emp_id`, `sup_id`) VALUES
(1, '2022-05-22 11:52:09', 1, 1),
(2, '2022-05-22 11:53:43', 1, 1),
(3, '2022-05-22 12:04:47', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `purchase_detail`
--

CREATE TABLE `purchase_detail` (
  `pd_id` int(11) NOT NULL,
  `pch_id` int(11) DEFAULT NULL,
  `mdc_id` int(11) DEFAULT NULL,
  `pd_price` double(11,2) DEFAULT NULL,
  `pd_qty` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `purchase_detail`
--

INSERT INTO `purchase_detail` (`pd_id`, `pch_id`, `mdc_id`, `pd_price`, `pd_qty`) VALUES
(1, 2, 1, 60000.00, 10),
(2, 2, 4, 6000.00, 10),
(3, 3, 1, 60000.00, 1),
(4, 3, 4, 6000.00, 1);

-- --------------------------------------------------------

--
-- Table structure for table `sale`
--

CREATE TABLE `sale` (
  `sale_id` int(11) NOT NULL,
  `sale_date` timestamp NULL DEFAULT current_timestamp(),
  `sale_pay` double(11,2) DEFAULT NULL,
  `emp_id` int(11) DEFAULT NULL,
  `cus_id` int(11) DEFAULT NULL,
  `sale_discount` double(11,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sale`
--

INSERT INTO `sale` (`sale_id`, `sale_date`, `sale_pay`, `emp_id`, `cus_id`, `sale_discount`) VALUES
(2, '2022-05-22 05:00:23', 60000.00, 1, 1, 6000.00),
(3, '2022-05-22 05:00:23', 60000.00, 1, 1, 6000.00),
(4, '2022-05-22 05:00:23', 60000.00, 1, 1, 6000.00),
(5, '2022-05-22 05:00:23', 60000.00, 1, 1, 6000.00),
(6, '2022-05-22 05:02:54', 12000.00, 1, 1, 0.00),
(7, '2022-05-22 08:13:16', 60000.00, 1, 1, 0.00);

-- --------------------------------------------------------

--
-- Table structure for table `sale_detail`
--

CREATE TABLE `sale_detail` (
  `sd_id` int(11) NOT NULL,
  `sale_id` int(11) DEFAULT NULL,
  `mdc_id` int(11) DEFAULT NULL,
  `sd_price` double(11,2) DEFAULT NULL,
  `sd_qty` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sale_detail`
--

INSERT INTO `sale_detail` (`sd_id`, `sale_id`, `mdc_id`, `sd_price`, `sd_qty`) VALUES
(1, 2, 1, 60000.00, 1),
(2, 2, 4, 6000.00, 1),
(3, 3, 1, 60000.00, 1),
(4, 3, 4, 6000.00, 1),
(5, 4, 1, 60000.00, 1),
(6, 4, 4, 6000.00, 1),
(7, 5, 1, 60000.00, 1),
(8, 5, 4, 6000.00, 1),
(9, 6, 4, 6000.00, 2),
(10, 7, 1, 60000.00, 1);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `sup_id` int(11) NOT NULL,
  `sup_name` varchar(255) DEFAULT NULL,
  `sup_company` varchar(255) DEFAULT NULL,
  `sup_contact` varchar(15) DEFAULT NULL,
  `sup_email` varchar(100) DEFAULT NULL,
  `sup_address` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`sup_id`, `sup_name`, `sup_company`, `sup_contact`, `sup_email`, `sup_address`) VALUES
(1, 'test', 'test', '123', 'test@gmail.com', 'test');

-- --------------------------------------------------------

--
-- Table structure for table `tb_import`
--

CREATE TABLE `tb_import` (
  `imp_id` int(11) NOT NULL,
  `imp_date` datetime DEFAULT NULL,
  `emp_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `type`
--

CREATE TABLE `type` (
  `type_id` int(11) NOT NULL,
  `type_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `type`
--

INSERT INTO `type` (`type_id`, `type_name`) VALUES
(1, 'ຢ່າແກ້ປວດ'),
(3, 'ຢ່າແກ້ກະເພາະ'),
(4, 'ຢາລົດໄຂ້');

-- --------------------------------------------------------

--
-- Table structure for table `unit`
--

CREATE TABLE `unit` (
  `unit_id` int(11) NOT NULL,
  `unit_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `unit`
--

INSERT INTO `unit` (`unit_id`, `unit_name`) VALUES
(1, 'ເມັດ'),
(2, 'ແຜງ'),
(3, 'ຫຼອດ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`cus_id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_id`);

--
-- Indexes for table `import_detail`
--
ALTER TABLE `import_detail`
  ADD PRIMARY KEY (`ipd_id`);

--
-- Indexes for table `medicine`
--
ALTER TABLE `medicine`
  ADD PRIMARY KEY (`mdc_id`);

--
-- Indexes for table `purchase`
--
ALTER TABLE `purchase`
  ADD PRIMARY KEY (`pch_id`);

--
-- Indexes for table `purchase_detail`
--
ALTER TABLE `purchase_detail`
  ADD PRIMARY KEY (`pd_id`);

--
-- Indexes for table `sale`
--
ALTER TABLE `sale`
  ADD PRIMARY KEY (`sale_id`);

--
-- Indexes for table `sale_detail`
--
ALTER TABLE `sale_detail`
  ADD PRIMARY KEY (`sd_id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`sup_id`);

--
-- Indexes for table `tb_import`
--
ALTER TABLE `tb_import`
  ADD PRIMARY KEY (`imp_id`);

--
-- Indexes for table `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`type_id`);

--
-- Indexes for table `unit`
--
ALTER TABLE `unit`
  ADD PRIMARY KEY (`unit_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `cus_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `emp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `import_detail`
--
ALTER TABLE `import_detail`
  MODIFY `ipd_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `medicine`
--
ALTER TABLE `medicine`
  MODIFY `mdc_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `purchase`
--
ALTER TABLE `purchase`
  MODIFY `pch_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `purchase_detail`
--
ALTER TABLE `purchase_detail`
  MODIFY `pd_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `sale`
--
ALTER TABLE `sale`
  MODIFY `sale_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `sale_detail`
--
ALTER TABLE `sale_detail`
  MODIFY `sd_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `sup_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tb_import`
--
ALTER TABLE `tb_import`
  MODIFY `imp_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `type`
--
ALTER TABLE `type`
  MODIFY `type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `unit`
--
ALTER TABLE `unit`
  MODIFY `unit_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
