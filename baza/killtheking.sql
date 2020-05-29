-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 29. Maj 2020. u 14:13
-- Verzija servera: 10.1.36-MariaDB
-- PHP Version: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `killtheking`
--

-- --------------------------------------------------------

--
-- Struktura tabele `players`
--

CREATE TABLE `players` (
  `id` int(10) NOT NULL,
  `username` varchar(17) NOT NULL,
  `hash` varchar(17) NOT NULL,
  `score` int(10) NOT NULL DEFAULT '0',
  `salt` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Prikaz podataka tabele `players`
--

INSERT INTO `players` (`id`, `username`, `hash`, `score`, `salt`) VALUES
(15, 'uros9995', '$5$rounds=5000$st', 0, '$5$rounds=5000$steamedhamsuros9995$'),
(16, 'invoker95', '$5$rounds=5000$st', 0, '$5$rounds=5000$steamedhamsinvoker95$'),
(17, 'invokeeer', '$5$rounds=5000$st', 0, '$5$rounds=5000$steamedhamsinvokeeer$'),
(18, 'butcherLa', '$5$rounds=5000$st', 0, '$5$rounds=5000$steamedhamsbutcherLa$'),
(19, 'danilooo', '$5$rounds=5000$st', 0, '$5$rounds=5000$steamedhamsdanilooo$'),
(20, 'urosicaa', '$5$rounds=5000$st', 0, '$5$rounds=5000$steamedhamsurosicaa$'),
(21, 'pejicici', '$5$rounds=5000$st', 0, '$5$rounds=5000$steamedhamspejicici$'),
(22, 'kretenizam', '$5$rounds=5000$st', 0, '$5$rounds=5000$steamedhamskretenizam$'),
(23, 'salabajzer', '$5$rounds=5000$st', 0, '$5$rounds=5000$steamedhamssalabajzer$');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `players`
--
ALTER TABLE `players`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `players`
--
ALTER TABLE `players`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
