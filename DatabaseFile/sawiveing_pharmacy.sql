-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 08, 2022 at 05:31 PM
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
(1, 'Admin', '2022-05-11', 'ຊາຍ', 'office', '123', 'admin', '123', '1'),
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

--
-- Dumping data for table `import_detail`
--

INSERT INTO `import_detail` (`ipd_id`, `imp_id`, `mdc_id`, `imp_qty`, `imp_prices`) VALUES
(1, 3, 1, 1, 5000.00);

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
(1, 'ປາລາເຊຕະໂມນ123', 3, 2, 5, '2022-07-01', 5000.00, 'ກິນ 3 ເມັດ(ເຊົ້າ, ສວາຍ, ແລງ)/ມື້'),
(4, 'ຊາຣາ', 4, 1, 5, '2022-05-14', 6000.00, 'ກິນເຊົ້າສວາຍແລງ');

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
(7, '2022-05-22 08:13:16', 60000.00, 1, 1, 0.00),
(8, '2022-05-23 12:31:46', 6000.00, 1, 0, 0.00),
(9, '2022-05-23 12:34:44', 60000.00, 1, 0, 0.00),
(10, '2022-05-23 12:36:36', 6000.00, 1, 0, 0.00),
(11, '2022-05-23 12:58:03', 60000.00, 1, 0, 0.00),
(12, '2022-05-23 12:58:24', 60000.00, 1, 1, 0.00);

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
(10, 7, 1, 60000.00, 1),
(11, 8, 4, 6000.00, 1),
(12, 9, 1, 60000.00, 1),
(13, 10, 4, 6000.00, 1),
(14, 11, 1, 60000.00, 1),
(15, 12, 1, 60000.00, 1);

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
  `imp_date` timestamp NULL DEFAULT current_timestamp(),
  `emp_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tb_import`
--

INSERT INTO `tb_import` (`imp_id`, `imp_date`, `emp_id`) VALUES
(1, '2022-05-23 12:14:32', 1),
(2, '2022-05-23 13:05:24', 1),
(3, '2022-05-23 13:07:18', 1);

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

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewexpense`
-- (See below for the actual view)
--
CREATE TABLE `viewexpense` (
`imp_date` varchar(10)
,`imp_qty` decimal(32,0)
,`imp_price` double(19,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewexpensemonth`
-- (See below for the actual view)
--
CREATE TABLE `viewexpensemonth` (
`imp_date` varchar(69)
,`imp_qty` decimal(32,0)
,`imp_price` double(19,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewexpenseyear`
-- (See below for the actual view)
--
CREATE TABLE `viewexpenseyear` (
`imp_date` varchar(4)
,`imp_qty` decimal(32,0)
,`imp_price` double(19,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewimport`
-- (See below for the actual view)
--
CREATE TABLE `viewimport` (
`imp_id` int(11)
,`imp_qty` decimal(32,0)
,`total` double(19,2)
,`imp_date` varchar(10)
,`emp_id` int(11)
,`emp_name` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewpurchase`
-- (See below for the actual view)
--
CREATE TABLE `viewpurchase` (
`pch_id` int(11)
,`pd_qty` decimal(32,0)
,`total` double(19,2)
,`pch_date` varchar(10)
,`emp_id` int(11)
,`emp_name` varchar(255)
,`sup_id` int(11)
,`sup_name` varchar(255)
,`sup_company` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewrevenue`
-- (See below for the actual view)
--
CREATE TABLE `viewrevenue` (
`sale_date` varchar(10)
,`sd_qty` decimal(32,0)
,`total` double(19,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewrevenuemonth`
-- (See below for the actual view)
--
CREATE TABLE `viewrevenuemonth` (
`sale_date` varchar(69)
,`sd_price` double(19,2)
,`sd_qty` decimal(32,0)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `viewrevenueyear`
-- (See below for the actual view)
--
CREATE TABLE `viewrevenueyear` (
`sale_date` varchar(4)
,`sd_price` double(19,2)
,`sd_qty` decimal(32,0)
);

-- --------------------------------------------------------

--
-- Structure for view `viewexpense`
--
DROP TABLE IF EXISTS `viewexpense`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewexpense`  AS SELECT date_format(`im`.`imp_date`,'%Y-%m-%d') AS `imp_date`, sum(`id`.`imp_qty`) AS `imp_qty`, sum(`id`.`imp_prices`) AS `imp_price` FROM (`tb_import` `im` left join `import_detail` `id` on(`im`.`imp_id` = `id`.`imp_id`)) GROUP BY date_format(`im`.`imp_date`,'%Y-%m-%d') ;

-- --------------------------------------------------------

--
-- Structure for view `viewexpensemonth`
--
DROP TABLE IF EXISTS `viewexpensemonth`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewexpensemonth`  AS SELECT date_format(`im`.`imp_date`,'%M-%Y') AS `imp_date`, sum(`id`.`imp_qty`) AS `imp_qty`, sum(`id`.`imp_prices`) AS `imp_price` FROM (`tb_import` `im` left join `import_detail` `id` on(`im`.`imp_id` = `id`.`imp_id`)) GROUP BY date_format(`im`.`imp_date`,'%Y-%m') ;

-- --------------------------------------------------------

--
-- Structure for view `viewexpenseyear`
--
DROP TABLE IF EXISTS `viewexpenseyear`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewexpenseyear`  AS SELECT date_format(`im`.`imp_date`,'%Y') AS `imp_date`, sum(`id`.`imp_qty`) AS `imp_qty`, sum(`id`.`imp_prices`) AS `imp_price` FROM (`tb_import` `im` left join `import_detail` `id` on(`im`.`imp_id` = `id`.`imp_id`)) GROUP BY date_format(`im`.`imp_date`,'%Y') ;

-- --------------------------------------------------------

--
-- Structure for view `viewimport`
--
DROP TABLE IF EXISTS `viewimport`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewimport`  AS SELECT `id`.`imp_id` AS `imp_id`, sum(`id`.`imp_qty`) AS `imp_qty`, sum(`id`.`imp_qty` * `id`.`imp_prices`) AS `total`, date_format(`it`.`imp_date`,'%Y-%m-%d') AS `imp_date`, `it`.`emp_id` AS `emp_id`, `e`.`emp_name` AS `emp_name` FROM ((`import_detail` `id` left join `tb_import` `it` on(`id`.`imp_id` = `it`.`imp_id`)) left join `employee` `e` on(`it`.`emp_id` = `e`.`emp_id`)) GROUP BY `id`.`imp_id` ;

-- --------------------------------------------------------

--
-- Structure for view `viewpurchase`
--
DROP TABLE IF EXISTS `viewpurchase`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewpurchase`  AS SELECT `pd`.`pch_id` AS `pch_id`, sum(`pd`.`pd_qty`) AS `pd_qty`, sum(`pd`.`pd_qty` * `pd`.`pd_price`) AS `total`, date_format(`p`.`pch_date`,'%Y-%m-%d') AS `pch_date`, `p`.`emp_id` AS `emp_id`, `e`.`emp_name` AS `emp_name`, `p`.`sup_id` AS `sup_id`, `s`.`sup_name` AS `sup_name`, `s`.`sup_company` AS `sup_company` FROM (((`purchase_detail` `pd` left join `purchase` `p` on(`pd`.`pch_id` = `p`.`pch_id`)) left join `employee` `e` on(`p`.`emp_id` = `e`.`emp_id`)) left join `supplier` `s` on(`p`.`sup_id` = `s`.`sup_id`)) GROUP BY `pd`.`pch_id` ;

-- --------------------------------------------------------

--
-- Structure for view `viewrevenue`
--
DROP TABLE IF EXISTS `viewrevenue`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewrevenue`  AS SELECT date_format(`s`.`sale_date`,'%Y-%m-%d') AS `sale_date`, sum(`sd`.`sd_qty`) AS `sd_qty`, sum(`sd`.`sd_qty` * `sd`.`sd_price`) AS `total` FROM (`sale` `s` left join `sale_detail` `sd` on(`s`.`sale_id` = `sd`.`sale_id`)) GROUP BY date_format(`s`.`sale_date`,'%Y-%m-%d') ;

-- --------------------------------------------------------

--
-- Structure for view `viewrevenuemonth`
--
DROP TABLE IF EXISTS `viewrevenuemonth`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewrevenuemonth`  AS SELECT date_format(`s`.`sale_date`,'%M-%Y') AS `sale_date`, sum(`sd`.`sd_price`) AS `sd_price`, sum(`sd`.`sd_qty`) AS `sd_qty` FROM (`sale` `s` left join `sale_detail` `sd` on(`s`.`sale_id` = `sd`.`sale_id`)) GROUP BY date_format(`s`.`sale_date`,'%Y-%m') ;

-- --------------------------------------------------------

--
-- Structure for view `viewrevenueyear`
--
DROP TABLE IF EXISTS `viewrevenueyear`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewrevenueyear`  AS SELECT date_format(`s`.`sale_date`,'%Y') AS `sale_date`, sum(`sd`.`sd_price`) AS `sd_price`, sum(`sd`.`sd_qty`) AS `sd_qty` FROM (`sale` `s` left join `sale_detail` `sd` on(`s`.`sale_id` = `sd`.`sale_id`)) GROUP BY date_format(`s`.`sale_date`,'%Y') ;

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
  MODIFY `ipd_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

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
  MODIFY `sale_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `sale_detail`
--
ALTER TABLE `sale_detail`
  MODIFY `sd_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `sup_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tb_import`
--
ALTER TABLE `tb_import`
  MODIFY `imp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

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
