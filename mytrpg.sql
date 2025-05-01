-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Nov 27, 2024 at 02:31 PM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mytrpg`
--

-- --------------------------------------------------------

--
-- Table structure for table `campaign`
--

CREATE TABLE `campaign` (
  `CampaignID` int(11) NOT NULL,
  `CampaignName` varchar(200) NOT NULL,
  `Genre` varchar(150) NOT NULL,
  `Status` varchar(10) NOT NULL,
  `DMID` int(11) NOT NULL,
  `CampaignDescription` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `campaign`
--

INSERT INTO `campaign` (`CampaignID`, `CampaignName`, `Genre`, `Status`, `DMID`, `CampaignDescription`) VALUES
(13, 'Taddle Fantasy', 'Fantasy, Action', 'Ongoing', 1, 'Fantast'),
(14, 'หมู่บ้านเหี้ยนตะเคียนหลอน', 'ระทึกขวัญ, สยองขวัญ', 'Ongoing', 5, 'เรื่องราวมันเริ่มต้นขึ้นจากการที่ผู้ใหญ่บ้านต้องการ จะตัดต้นตะเคียนแต่ก็ไม่สามารถตัดได้');

-- --------------------------------------------------------

--
-- Table structure for table `cattack`
--

CREATE TABLE `cattack` (
  `CharacterAttackID` int(11) NOT NULL,
  `CID` int(11) NOT NULL,
  `Attack1` varchar(255) DEFAULT NULL,
  `Attack2` varchar(255) DEFAULT NULL,
  `Attack3` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cattack`
--

INSERT INTO `cattack` (`CharacterAttackID`, `CID`, `Attack1`, `Attack2`, `Attack3`) VALUES
(2, 4, '', '', ''),
(4, 6, '', '', ''),
(5, 7, 'ต่อย', 'เตะ', 'ใช้อุปกรณ์'),
(6, 8, '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `cgear`
--

CREATE TABLE `cgear` (
  `CharacterGearID` int(11) NOT NULL,
  `CID` int(11) NOT NULL,
  `Gear1` varchar(255) DEFAULT NULL,
  `Gear2` varchar(255) DEFAULT NULL,
  `Gear3` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cgear`
--

INSERT INTO `cgear` (`CharacterGearID`, `CID`, `Gear1`, `Gear2`, `Gear3`) VALUES
(2, 4, '', '', ''),
(4, 6, 'test create from other', 'test create from other', 'test create from other'),
(5, 7, '', '', ''),
(6, 8, 'แว่นสายตา', 'เสื้อสูทร', 'กางเกงขายาว');

-- --------------------------------------------------------

--
-- Table structure for table `characters`
--

CREATE TABLE `characters` (
  `CharacterID` int(11) NOT NULL,
  `CampaignID` int(11) NOT NULL,
  `UID` int(11) NOT NULL,
  `Title` varchar(250) NOT NULL,
  `Name` varchar(250) NOT NULL,
  `Class` varchar(250) NOT NULL,
  `Alignment` varchar(250) NOT NULL,
  `Background` varchar(500) NOT NULL,
  `STR` tinyint(2) UNSIGNED NOT NULL DEFAULT '0',
  `DEX` tinyint(2) UNSIGNED NOT NULL DEFAULT '0',
  `CON` tinyint(2) UNSIGNED NOT NULL DEFAULT '0',
  `INTELLIGENCE` tinyint(2) UNSIGNED NOT NULL DEFAULT '0',
  `WIS` tinyint(2) UNSIGNED NOT NULL DEFAULT '0',
  `CHA` tinyint(2) UNSIGNED NOT NULL DEFAULT '0',
  `AC` tinyint(2) UNSIGNED NOT NULL DEFAULT '0',
  `Health` tinyint(2) UNSIGNED NOT NULL DEFAULT '20',
  `Willpower` tinyint(2) UNSIGNED NOT NULL DEFAULT '12'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `characters`
--

INSERT INTO `characters` (`CharacterID`, `CampaignID`, `UID`, `Title`, `Name`, `Class`, `Alignment`, `Background`, `STR`, `DEX`, `CON`, `INTELLIGENCE`, `WIS`, `CHA`, `AC`, `Health`, `Willpower`) VALUES
(4, 13, 1, 'Mr.', 'Brave', 'Sword Man', 'Good', 'Doctor', 5, 3, 3, 2, 3, 2, 0, 20, 12),
(6, 13, 2, 'test create from other', 'test create from other', 'test create from other', 'test create from other', 'test create from other', 1, 1, 1, 1, 1, 1, 0, 20, 12),
(7, 14, 2, 'นาย', 'ธัญณรงค์ คงสามารถ', 'นักวิทยาศาสตร์เรื่องลี้ลัับ', 'รักพวกพ้องมุทะลุ', 'นักวิทยาศาสตร์ที่มีความเชื่อในสิ่งลี้ลับจึงเริ่มทำวิจัย แต่ก็พิสูจน์เหตุ์การณต่างๆได้ว่าเป็นทริคไปทั้งหมดและพยายามตามหาของจริงอยู๋เรื่อยไป', 2, 2, 1, 7, 1, 3, 0, 20, 12),
(8, 14, 5, 'นาย', 'ธงธง มุ่งเจริญ', 'บัญชี', 'ผู้นำองกรณ์', 'ผู้นำองค์กรณ์', 5, 1, 1, 4, 4, 6, 5, 20, 12);

-- --------------------------------------------------------

--
-- Table structure for table `cinventory`
--

CREATE TABLE `cinventory` (
  `CharacterInventoryID` int(11) NOT NULL,
  `CID` int(11) NOT NULL,
  `Item1` varchar(255) DEFAULT NULL,
  `Item2` varchar(255) DEFAULT NULL,
  `Item3` varchar(255) DEFAULT NULL,
  `Item4` varchar(255) DEFAULT NULL,
  `Item5` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cinventory`
--

INSERT INTO `cinventory` (`CharacterInventoryID`, `CID`, `Item1`, `Item2`, `Item3`, `Item4`, `Item5`) VALUES
(2, 4, NULL, NULL, NULL, NULL, NULL),
(4, 6, NULL, NULL, NULL, NULL, NULL),
(5, 7, NULL, NULL, NULL, NULL, NULL),
(6, 8, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `cspelltalent`
--

CREATE TABLE `cspelltalent` (
  `CharacterSpellTalentID` int(11) NOT NULL,
  `CID` int(11) NOT NULL,
  `ST1` varchar(255) DEFAULT NULL,
  `ST2` varchar(255) DEFAULT NULL,
  `ST3` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cspelltalent`
--

INSERT INTO `cspelltalent` (`CharacterSpellTalentID`, `CID`, `ST1`, `ST2`, `ST3`) VALUES
(2, 4, '', '', ''),
(4, 6, '', '', ''),
(5, 7, 'สร้างสรรค์', 'วิเคราะห์', 'เทคโนโลยี'),
(6, 8, '', 'เจรจา', '');

-- --------------------------------------------------------

--
-- Table structure for table `dm`
--

CREATE TABLE `dm` (
  `UID` int(11) NOT NULL,
  `DM` tinyint(1) NOT NULL,
  `username` varbinary(255) NOT NULL,
  `pass` varbinary(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `dm`
--

INSERT INTO `dm` (`UID`, `DM`, `username`, `pass`) VALUES
(1, 1, 0x9dc319d2818f6209c592ea503f13c8a1, 0x9dc319d2818f6209c592ea503f13c8a1),
(2, 1, 0x38a245da7a0b10c954ee8e8861f8b814, 0x38a245da7a0b10c954ee8e8861f8b814),
(4, 1, 0x366ea56fb0110f5ed6af9487409ca881, 0x366ea56fb0110f5ed6af9487409ca881),
(5, 1, 0x10c430fd4b16b4b2d064f622a2c8a881, 0xde7a8d2f40aa8ad9cb8531e84b14aa491096da0a123dbd66dcc0292bd4a0a3d0);

-- --------------------------------------------------------

--
-- Table structure for table `player`
--

CREATE TABLE `player` (
  `UID` int(11) NOT NULL,
  `Player` tinyint(1) NOT NULL,
  `username` varbinary(255) NOT NULL,
  `pass` varbinary(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `player`
--

INSERT INTO `player` (`UID`, `Player`, `username`, `pass`) VALUES
(3, 1, 0x38a245da7a0b10c954ee8e8861f8b814, 0x38a245da7a0b10c954ee8e8861f8b814);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `UID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`UID`) VALUES
(1),
(2),
(3),
(4),
(5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `campaign`
--
ALTER TABLE `campaign`
  ADD PRIMARY KEY (`CampaignID`),
  ADD KEY `DMID` (`DMID`);

--
-- Indexes for table `cattack`
--
ALTER TABLE `cattack`
  ADD PRIMARY KEY (`CharacterAttackID`),
  ADD UNIQUE KEY `CID` (`CID`);

--
-- Indexes for table `cgear`
--
ALTER TABLE `cgear`
  ADD PRIMARY KEY (`CharacterGearID`),
  ADD UNIQUE KEY `CID` (`CID`);

--
-- Indexes for table `characters`
--
ALTER TABLE `characters`
  ADD PRIMARY KEY (`CharacterID`),
  ADD KEY `CampaignID` (`CampaignID`),
  ADD KEY `UID` (`UID`);

--
-- Indexes for table `cinventory`
--
ALTER TABLE `cinventory`
  ADD PRIMARY KEY (`CharacterInventoryID`),
  ADD UNIQUE KEY `CID` (`CID`);

--
-- Indexes for table `cspelltalent`
--
ALTER TABLE `cspelltalent`
  ADD PRIMARY KEY (`CharacterSpellTalentID`),
  ADD UNIQUE KEY `CID` (`CID`);

--
-- Indexes for table `dm`
--
ALTER TABLE `dm`
  ADD PRIMARY KEY (`UID`),
  ADD KEY `UID` (`UID`);

--
-- Indexes for table `player`
--
ALTER TABLE `player`
  ADD PRIMARY KEY (`UID`),
  ADD KEY `UID` (`UID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `campaign`
--
ALTER TABLE `campaign`
  MODIFY `CampaignID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `cattack`
--
ALTER TABLE `cattack`
  MODIFY `CharacterAttackID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `cgear`
--
ALTER TABLE `cgear`
  MODIFY `CharacterGearID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `characters`
--
ALTER TABLE `characters`
  MODIFY `CharacterID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `cinventory`
--
ALTER TABLE `cinventory`
  MODIFY `CharacterInventoryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `cspelltalent`
--
ALTER TABLE `cspelltalent`
  MODIFY `CharacterSpellTalentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `campaign`
--
ALTER TABLE `campaign`
  ADD CONSTRAINT `campaign_ibfk_1` FOREIGN KEY (`DMID`) REFERENCES `dm` (`UID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `cattack`
--
ALTER TABLE `cattack`
  ADD CONSTRAINT `cattack_ibfk_1` FOREIGN KEY (`CID`) REFERENCES `characters` (`CharacterID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `cgear`
--
ALTER TABLE `cgear`
  ADD CONSTRAINT `cgear_ibfk_1` FOREIGN KEY (`CID`) REFERENCES `characters` (`CharacterID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `characters`
--
ALTER TABLE `characters`
  ADD CONSTRAINT `characters_ibfk_1` FOREIGN KEY (`CampaignID`) REFERENCES `campaign` (`CampaignID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `characters_ibfk_2` FOREIGN KEY (`UID`) REFERENCES `user` (`UID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `cinventory`
--
ALTER TABLE `cinventory`
  ADD CONSTRAINT `cinventory_ibfk_1` FOREIGN KEY (`CID`) REFERENCES `characters` (`CharacterID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `cspelltalent`
--
ALTER TABLE `cspelltalent`
  ADD CONSTRAINT `cspelltalent_ibfk_1` FOREIGN KEY (`CID`) REFERENCES `characters` (`CharacterID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `dm`
--
ALTER TABLE `dm`
  ADD CONSTRAINT `dm_ibfk_1` FOREIGN KEY (`UID`) REFERENCES `user` (`UID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `player`
--
ALTER TABLE `player`
  ADD CONSTRAINT `player_ibfk_1` FOREIGN KEY (`UID`) REFERENCES `user` (`UID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
