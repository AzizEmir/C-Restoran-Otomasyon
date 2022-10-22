-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 13 May 2022, 07:38:31
-- Sunucu sürümü: 10.4.24-MariaDB
-- PHP Sürümü: 7.4.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `dbrestorant`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `satislar`
--

CREATE TABLE `satislar` (
  `id` int(11) NOT NULL,
  `menuAdı=Fiyati` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `tarih` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `satislar`
--

INSERT INTO `satislar` (`id`, `menuAdı=Fiyati`, `tarih`) VALUES
(45, 'İskender=45', '2022-05-02'),
(46, 'Baklava=30', '2022-05-02'),
(47, 'Biftek=55', '2022-05-02'),
(48, 'Hamburger=35', '2022-05-02'),
(49, 'İskender=45', '2022-05-02'),
(50, 'Biftek=55', '2022-05-02'),
(51, 'Pancar Salatası=12', '2022-05-02'),
(52, 'Baklava=30', '2022-05-02'),
(53, 'Biftek=55', '2022-05-02'),
(54, 'Biftek=55', '2022-05-02'),
(55, 'Biftek=55', '2022-05-02'),
(56, 'Biftek=55', '2022-05-02'),
(57, 'Biftek=55', '2022-05-02'),
(58, 'Biftek=55', '2022-05-02'),
(59, 'Nohutlu Pilav=15', '2022-05-02'),
(60, 'Nohutlu Pilav=15', '2022-05-02'),
(61, 'Sultan Sarması=20', '2022-05-02'),
(62, 'Biftek=55', '2022-05-02'),
(63, 'Biftek=55', '2022-05-02'),
(64, 'Biftek=55', '2022-05-02'),
(65, 'Biftek=55', '2022-05-02'),
(66, 'Biftek=55', '2022-05-02'),
(67, 'Biftek=55', '2022-05-02'),
(68, 'Biftek=55', '2022-05-02'),
(69, 'Biftek=55', '2022-05-02'),
(70, 'Hamburger=35', '2022-05-02'),
(71, 'Pancar Salatası=12', '2022-05-02'),
(72, 'Hamburger=35', '2022-05-02'),
(73, 'Pancar Salatası=12', '2022-05-02'),
(74, 'Hamburger=35', '2022-05-02'),
(75, 'Pancar Salatası=12', '2022-05-02'),
(76, 'Lahmacun=35', '2022-05-02'),
(77, 'Biftek=55', '2022-05-02'),
(78, 'Biftek=55', '2022-05-02'),
(79, 'Biftek=55', '2022-05-02'),
(80, 'Biftek=55', '2022-05-02'),
(81, 'Biftek=55', '2022-05-02'),
(82, 'Biftek=55', '2022-05-02'),
(83, 'Biftek=55', '2022-05-02'),
(84, 'Sultan Sarması=20', '2022-05-02'),
(85, 'Nohutlu Pilav=15', '2022-05-02'),
(86, 'Pancar Salatası=12', '2022-05-02'),
(87, 'Fırında Tavuk=38', '2022-05-02'),
(88, 'Lahmacun=35', '2022-05-02'),
(89, 'Sultan Sarması=20', '2022-05-02'),
(90, 'Biftek=55', '2022-05-02'),
(91, 'Biftek=55', '2022-05-02'),
(92, 'Biftek=55', '2022-05-02'),
(93, 'Biftek=55', '2022-05-02'),
(94, 'Biftek=55', '2022-05-02'),
(95, 'Biftek=55', '2022-05-02'),
(96, 'Biftek=55', '2022-05-02'),
(97, 'Biftek=55', '2022-05-02'),
(98, 'Biftek=55', '2022-05-02'),
(99, 'Biftek=55', '2022-05-02'),
(100, 'Biftek=55', '2022-05-02'),
(101, 'Biftek=55', '2022-05-02'),
(102, 'Biftek=55', '2022-05-02'),
(103, 'Biftek=55', '2022-05-02'),
(104, 'Biftek=55', '2022-05-02'),
(105, 'Biftek=55', '2022-05-02'),
(106, 'Söğürmeli Kebap=30', '2022-05-02'),
(107, 'Söğürmeli Kebap=30', '2022-05-02'),
(108, 'Pancar Salatası=12', '2022-05-02'),
(109, 'Baklava=30', '2022-05-02'),
(110, 'Hamburger=35', '2022-05-02'),
(111, 'Hamburger=35', '2022-05-02'),
(112, 'Söğürmeli Kebap=30', '2022-05-02'),
(113, 'Biftek=55', '2022-05-02'),
(114, 'Biftek=55', '2022-05-02'),
(115, 'Biftek=55', '2022-05-02'),
(116, 'Biftek=55', '2022-05-02'),
(117, 'Biftek=55', '2022-05-02'),
(118, 'Biftek=55', '2022-05-02'),
(119, 'Biftek=55', '2022-05-02'),
(120, 'Biftek=55', '2022-05-02'),
(121, 'Biftek=55', '2022-05-02'),
(122, 'Biftek=55', '2022-05-02'),
(137, 'Biftek=55', '2022-05-02'),
(138, 'Biftek=55', '2022-05-02'),
(139, 'Biftek=55', '2022-05-02'),
(140, 'Biftek=55', '2022-05-02'),
(141, 'Biftek=55', '2022-05-02'),
(142, 'Biftek=55', '2022-05-02'),
(143, 'Biftek=55', '2022-05-02'),
(144, 'Biftek=55', '2022-05-02'),
(145, 'Biftek=55', '2022-05-02'),
(146, 'Biftek=55', '2022-05-02'),
(147, 'Biftek=55', '2022-05-02'),
(148, 'Biftek=55', '2022-05-02'),
(149, 'Biftek=55', '2022-05-02'),
(150, 'Biftek=55', '2022-05-02'),
(151, 'Biftek=55', '2022-05-02'),
(152, 'Biftek=55', '2022-05-02'),
(153, 'Biftek=55', '2022-05-02'),
(154, 'Biftek=55', '2022-05-02'),
(155, 'Biftek=55', '2022-05-02'),
(156, 'Biftek=55', '2022-05-02'),
(157, 'Biftek=55', '2022-05-02'),
(158, 'Biftek=55', '2022-05-02'),
(159, 'Biftek=55', '2022-05-02'),
(160, 'Biftek=55', '2022-05-02'),
(161, 'Biftek=55', '2022-05-02'),
(162, 'Biftek=55', '2022-05-02'),
(163, 'Biftek=55', '2022-05-02'),
(164, 'Biftek=55', '2022-05-02'),
(165, 'Biftek=55', '2022-05-02'),
(166, 'Biftek=55', '2022-05-02'),
(167, 'Pancar Salatası=12', '2022-05-04'),
(168, 'Söğürmeli Kebap=30', '2022-05-04'),
(169, 'Fırında Tavuk=38', '2022-05-04'),
(170, 'Sultan Sarması=20', '2022-05-04'),
(171, 'Baklava=30', '2022-05-05'),
(172, 'Fırında Tavuk=38', '2022-05-05'),
(173, 'Baklava=30', '2022-05-05'),
(174, 'Fırında Tavuk=38', '2022-05-05'),
(175, 'Biftek=55', '2022-05-05'),
(176, 'Biftek=55', '2022-05-05'),
(177, 'Biftek=55', '2022-05-05'),
(178, 'Börülce Salatası=10', '2022-05-05'),
(179, 'Baklava=30', '2022-05-05'),
(180, 'Lahmacun=35', '2022-05-06'),
(181, 'Lahmacun=35', '2022-05-06'),
(182, 'Lahmacun=35', '2022-05-06'),
(183, 'Biftek=32', '2022-05-06'),
(184, 'Biftek=32', '2022-05-06'),
(185, 'Biftek=32', '2022-05-06'),
(186, 'Biftek=32', '2022-05-06'),
(187, 'Biftek=32', '2022-05-06'),
(188, 'Biftek=32', '2022-05-08'),
(189, 'Biftek=32', '2022-05-08'),
(190, 'Nohutlu Pilav=15', '2022-05-08'),
(191, 'Meyve Salatası=24', '2022-05-09');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yemekler`
--

CREATE TABLE `yemekler` (
  `id` int(11) NOT NULL,
  `ad` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `tur` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `fiyat` int(11) NOT NULL,
  `resim` varchar(200) COLLATE utf8mb4_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `yemekler`
--

INSERT INTO `yemekler` (`id`, `ad`, `tur`, `fiyat`, `resim`) VALUES
(3, 'Biftek', 'İçecek', 32, '6050Biftek.jpg'),
(4, 'İskender', 'Tatlı', 44, '902iskender-kebap.jpg'),
(5, 'Hamburger', 'Ana Yemek', 35, ''),
(6, 'Lahmacun', 'Ana Yemek', 35, '6621Lahmacun.jpg'),
(7, 'Pancar Salatası', 'Salata', 12, '1998Pancar Salata.jpg'),
(8, 'Sultan Sarması', 'Tatlı', 20, '7343Sultan sarması.jpg'),
(9, 'Baklava', 'Tatlı', 30, '3538Baklava.jpg'),
(10, 'Söğürmeli Kebap', 'Ana Yemek', 30, '1491Söğürmeli kebap.jpg'),
(11, 'Fırında Tavuk', 'Ana Yemek', 38, '5199Fırında Tavuk şiş.jpg'),
(12, 'Nohutlu Pilav', 'Ana Yemek', 15, '6777Nohutlu Pilav.jpg'),
(13, 'Meyve Salatası', 'Salata', 24, '628Meyve Salatası.jpg'),
(14, 'Köz Biber Salatası', 'Salata', 10, '8838Köz Biber Salatası.jpg'),
(15, 'Börülce Salatası', 'Salata', 10, '1817Börülce Salatası.jpg'),
(19, 'Chef\'s spesial', 'Ana Yemek', 100, NULL);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yemekturu`
--

CREATE TABLE `yemekturu` (
  `id` int(11) NOT NULL,
  `Tur` varchar(20) COLLATE utf8mb4_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `yemekturu`
--

INSERT INTO `yemekturu` (`id`, `Tur`) VALUES
(26, 'Tatlı'),
(27, 'İçecek'),
(28, 'Ana Yemek'),
(29, 'Salata');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `satislar`
--
ALTER TABLE `satislar`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `yemekler`
--
ALTER TABLE `yemekler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `yemekturu`
--
ALTER TABLE `yemekturu`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `satislar`
--
ALTER TABLE `satislar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=192;

--
-- Tablo için AUTO_INCREMENT değeri `yemekler`
--
ALTER TABLE `yemekler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- Tablo için AUTO_INCREMENT değeri `yemekturu`
--
ALTER TABLE `yemekturu`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
