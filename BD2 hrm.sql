-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-05-2020 a las 06:49:21
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `hrm`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `area`
--

CREATE TABLE `area` (
  `id_area` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `area`
--

INSERT INTO `area` (`id_area`, `nombre`, `estado`) VALUES
(1, 'Recursos Humanos', 1),
(2, 'Producción', 1),
(3, 'Contabilidad', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asistencia`
--

CREATE TABLE `asistencia` (
  `id_asistencia` int(11) NOT NULL,
  `id_empleado` int(11) DEFAULT NULL,
  `feha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ayuda`
--

CREATE TABLE `ayuda` (
  `Id_ayuda` int(11) NOT NULL,
  `Ruta` text COLLATE utf8_unicode_ci NOT NULL,
  `indice` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `ayuda`
--

INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`) VALUES
(1, 'Página web ayuda/ayuda.chm', 'menu.html'),
(2, 'Página web ayuda/ayuda.chm', 'Menúboletos.html');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `candidatos`
--

CREATE TABLE `candidatos` (
  `id_candidato` int(11) NOT NULL,
  `nombres` varchar(50) DEFAULT NULL,
  `apellidos` varchar(50) DEFAULT NULL,
  `nit` varchar(15) DEFAULT NULL,
  `cui` varchar(20) DEFAULT NULL,
  `correo` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `sexo` varchar(10) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `estado` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE `categorias` (
  `id_categoria` int(11) NOT NULL,
  `nombre_categoria` varchar(45) DEFAULT NULL,
  `descripcion_categoria` text DEFAULT NULL,
  `ESTADO` tinyint(4) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`id_categoria`, `nombre_categoria`, `descripcion_categoria`, `ESTADO`) VALUES
(1, 'Categoria Numero 1', 'No hay descripcion', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cita`
--

CREATE TABLE `cita` (
  `id_cita` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `id_candidato` int(11) DEFAULT NULL,
  `estado` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `comisiones`
--

CREATE TABLE `comisiones` (
  `id_comisiones` int(11) NOT NULL,
  `id_tipo_comisiones` int(11) DEFAULT NULL,
  `id_empleado` int(11) DEFAULT NULL,
  `id_factura` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `comisiones`
--

INSERT INTO `comisiones` (`id_comisiones`, `id_tipo_comisiones`, `id_empleado`, `id_factura`, `estado`) VALUES
(1, 1, 2, 1, 1),
(2, 1, 2, 2, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conceptos`
--

CREATE TABLE `conceptos` (
  `id_concepto` int(11) NOT NULL,
  `id_empleado` int(11) DEFAULT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `id_tipo` int(11) DEFAULT NULL,
  `monto` int(11) DEFAULT NULL,
  `debe_Haber` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `conceptos`
--

INSERT INTO `conceptos` (`id_concepto`, `id_empleado`, `fecha_inicio`, `fecha_fin`, `id_tipo`, `monto`, `debe_Haber`, `estado`) VALUES
(1, 2, '2020-04-02', '2020-04-16', 1, 300, 1, 1),
(2, 1, '2020-04-15', '2020-04-30', 2, 170, 0, 1),
(3, 6, '2020-04-01', '2020-04-30', 1, 300, 1, 0),
(4, 6, '1111-11-11', '1111-11-11', 1, 300, 1, 1),
(5, 6, '1111-11-11', '1111-11-11', 1, 300, 1, 1),
(6, 6, '1111-11-11', '1111-11-11', 1, 300, 1, 1),
(8, 6, '2020-04-22', '2020-04-22', 1, 300, 1, 1),
(9, 6, '2020-04-22', '2020-04-22', 1, 300, 1, 1),
(10, 6, '1111-11-11', '1111-11-11', 1, 300, 1, 1),
(11, 18, '1111-11-11', '1111-11-11', 1, 300, 1, 1),
(12, 9, '1111-11-11', '1111-11-11', 1, 300, 1, 0),
(13, 17, '1111-11-11', '1111-11-11', 1, 500, 1, 1),
(14, 17, '1111-11-11', '1111-11-11', 2, 500, 0, 1),
(15, 19, '1111-11-11', '1111-11-11', 1, 650, 1, 1),
(16, 19, '1111-11-11', '1111-11-11', 2, 700, 0, 1),
(17, 19, '2020-04-24', '2020-04-24', 3, 410, 1, 1),
(18, 20, '1111-11-11', '1111-11-11', 1, 500, 1, 1),
(19, 20, '2020-04-24', '2020-04-24', 3, 1000, 1, 1),
(20, 22, '2020-05-02', '2020-05-02', 1, 700, 1, 1),
(21, 22, '2020-05-02', '2020-05-02', 2, 200, 0, 1),
(22, 22, '2020-05-01', '2020-05-31', 3, 0, 1, 0),
(24, 22, '1111-11-11', '1111-11-11', 1, 300, 1, 1),
(25, 22, '2020-05-02', '2020-05-02', 1, 300, 1, 1),
(26, 2, '1111-11-11', '1111-11-11', 2, 300, 0, 1),
(27, 23, '2020-05-02', '2020-05-03', 1, 200, 1, 1),
(28, 23, '2020-05-02', '2020-05-03', 2, 200, 0, 1),
(29, 27, '2020-05-02', '2020-05-05', 1, 300, 1, 1),
(30, 27, '2020-05-02', '2020-05-05', 2, 200, 0, 1),
(31, 31, '1111-11-11', '1111-11-11', 1, 0, 1, 1),
(32, 31, '1111-11-11', '1111-11-11', 2, 200, 0, 1),
(33, 32, '2020-05-01', '2020-05-30', 1, 500, 1, 1),
(34, 32, '2020-05-01', '2020-05-30', 3, 300, 1, 1),
(35, 33, '2020-05-02', '2020-05-09', 1, 500, 1, 1),
(37, 33, '2020-05-02', '2020-05-09', 2, 200, 1, 1),
(38, 34, '2020-05-02', '2020-05-09', 1, 300, 1, 0),
(39, 34, '2020-05-02', '2020-05-09', 3, 200, 1, 1),
(40, 35, '2020-05-02', '2020-05-09', 2, 300, 0, 1),
(41, 36, '2020-05-02', '2020-05-09', 1, 300, 1, 1),
(42, 36, '1111-11-11', '1111-11-11', 2, 200, 0, 0),
(47, 35, '1111-11-11', '1111-11-11', 2, 200, 0, 1),
(48, 35, '2020-05-09', '2020-05-09', 3, 500, 1, 1),
(49, 36, '1111-11-11', '1111-11-11', 1, 500, 1, 0),
(50, 36, '1111-11-11', '1111-11-11', 4, 500, 1, 1),
(51, 36, '1111-11-11', '1111-11-11', 2, 700, 1, 1),
(52, 36, '2020-05-09', '2020-05-09', 2, 200, 0, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `despidos`
--

CREATE TABLE `despidos` (
  `id_despidos` int(11) NOT NULL,
  `id_empleado` int(11) DEFAULT NULL,
  `id_finiquito` int(11) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `motivo` varchar(100) DEFAULT NULL,
  `id_prestaciones` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_planilla`
--

CREATE TABLE `detalle_planilla` (
  `id_detalle` int(11) NOT NULL,
  `id_planilla` int(11) NOT NULL,
  `id_empleado` int(11) DEFAULT NULL,
  `sueldo_base` int(11) DEFAULT NULL,
  `sueldo_extraordinario` int(11) DEFAULT NULL,
  `total_devengado` int(11) DEFAULT NULL,
  `total_descuento` int(11) DEFAULT NULL,
  `total_liquido` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `detalle_planilla`
--

INSERT INTO `detalle_planilla` (`id_detalle`, `id_planilla`, `id_empleado`, `sueldo_base`, `sueldo_extraordinario`, `total_devengado`, `total_descuento`, `total_liquido`, `estado`) VALUES
(1, 1, 1, 3000, 51515, 555, 5255, 123, 1),
(1, 2, 1, 5000, 51515, 555, 5255, 123, 1),
(1, 3, 1, 3000, 51515, 555, 5255, 123, 1),
(1, 4, 1, 3000, 3000, 555, 5255, 123, 1),
(1, 5, 1, 3000, 3000, 555, 5255, 123, 1),
(1, 6, 1, 3000, 3025, 3300, 5255, 123, 1),
(1, 7, 1, 3000, 3025, 3300, 5255, 123, 1),
(1, 8, 1, 3000, 3025, 3300, 170, 3130, 1),
(1, 9, 1, 3000, 3025, 3302, 170, 3130, 1),
(1, 10, 1, 3000, 3025, 3302, 170, 6432, 1),
(1, 11, 1, 3000, 3025, 3302, 170, 6432, 1),
(1, 12, 1, 3000, 3025, 3302, 170, 6432, 1),
(1, 13, 1, 3000, 3025, 3302, 170, 6432, 1),
(1, 14, 1, 3000, 3025, 3302, 170, 6432, 1),
(1, 15, 1, 3000, 3025, 3302, 170, 6432, 1),
(1, 16, 1, 3000, 3025, 3302, 170, 6432, 1),
(1, 17, 1, 3000, 3025, 3302, 170, 6432, 1),
(1, 18, 1, 3000, 3025, 3302, 170, 6432, 1),
(1, 19, 1, 3000, 3025, 3002, 170, 5832, 1),
(1, 20, 1, 3000, 3025, 3002, 170, 5832, 1),
(1, 21, 4, 3000, 3000, 3000, 0, 6000, 1),
(1, 22, 7, 3000, 3000, 3000, 0, 6000, 1),
(1, 23, 7, 3000, 3000, 3000, 0, 6000, 1),
(2, 1, 2, 3000, 51515, 555, 5255, 123, 1),
(2, 2, 2, 5000, 51515, 555, 5255, 123, 1),
(2, 3, 2, 3000, 51515, 555, 5255, 123, 1),
(2, 4, 2, 3000, 3000, 555, 5255, 123, 1),
(2, 5, 2, 5000, 5000, 555, 5255, 123, 1),
(2, 6, 2, 5000, 5000, 5000, 5255, 123, 1),
(2, 7, 2, 5000, 5000, 5000, 5255, 123, 1),
(2, 8, 2, 5000, 5000, 5000, 0, 5000, 1),
(2, 9, 2, 5000, 5000, 5000, 0, 5000, 1),
(2, 10, 2, 5000, 5000, 5000, 0, 10000, 1),
(2, 11, 2, 5000, 5000, 5000, 0, 10000, 1),
(2, 12, 2, 5000, 5000, 5000, 0, 10000, 1),
(2, 13, 2, 5000, 5000, 5000, 0, 10000, 1),
(2, 14, 2, 5000, 5000, 5000, 0, 10000, 1),
(2, 15, 2, 5000, 5000, 5000, 0, 10000, 1),
(2, 16, 2, 5000, 5000, 5000, 0, 10000, 1),
(2, 17, 2, 5000, 5000, 5000, 0, 10000, 1),
(2, 18, 2, 5000, 5000, 5000, 0, 10000, 1),
(2, 19, 2, 5000, 5000, 5300, 0, 10600, 1),
(2, 20, 2, 5000, 5000, 5300, 300, 10300, 1),
(2, 21, 5, 3000, 3000, 3000, 0, 6000, 1),
(2, 22, 8, 3000, 3000, 3000, 0, 6000, 1),
(2, 23, 8, 3000, 3000, 3000, 0, 6000, 1),
(3, 13, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 14, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 15, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 16, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 17, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 18, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 19, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 20, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 21, 6, 3000, 3000, 4800, 0, 9600, 1),
(3, 22, 9, 3000, 3000, 3300, 0, 6600, 1),
(3, 23, 9, 3000, 3000, 3300, 0, 6600, 1),
(4, 13, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 14, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 15, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 16, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 17, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 18, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 19, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 20, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 21, 7, 3000, 3000, 3000, 0, 6000, 1),
(4, 22, 10, 3000, 3000, 3000, 0, 6000, 1),
(4, 23, 10, 3000, 3000, 3000, 0, 6000, 1),
(5, 13, 6, 3000, 3000, 5100, 0, 10200, 1),
(5, 14, 6, 3000, 3000, 3000, 0, 6000, 1),
(5, 15, 6, 3000, 3000, 5100, 0, 10200, 1),
(5, 16, 6, 3000, 3000, 4800, 0, 9600, 1),
(5, 17, 6, 3000, 3000, 4800, 0, 9600, 1),
(5, 18, 6, 3000, 3000, 4800, 0, 9600, 1),
(5, 19, 6, 3000, 3000, 4800, 0, 9600, 1),
(5, 20, 6, 3000, 3000, 4800, 0, 9600, 1),
(5, 21, 8, 3000, 3000, 3000, 0, 6000, 1),
(5, 22, 11, 3000, 3000, 3000, 0, 6000, 1),
(5, 23, 11, 3000, 3000, 3000, 0, 6000, 1),
(6, 13, 7, 3000, 3000, 3000, 0, 6000, 1),
(6, 15, 7, 3000, 3000, 3000, 0, 6000, 1),
(6, 16, 7, 3000, 3000, 3000, 0, 6000, 1),
(6, 17, 7, 3000, 3000, 3000, 0, 6000, 1),
(6, 18, 7, 3000, 3000, 3000, 0, 6000, 1),
(6, 19, 7, 3000, 3000, 3000, 0, 6000, 1),
(6, 20, 7, 3000, 3000, 3000, 0, 6000, 1),
(6, 21, 9, 3000, 3000, 3300, 0, 6600, 1),
(6, 22, 12, 3000, 3000, 3000, 0, 6000, 1),
(6, 23, 12, 3000, 3000, 3000, 0, 6000, 1),
(7, 13, 8, 3000, 3000, 3000, 0, 6000, 1),
(7, 15, 8, 3000, 3000, 3000, 0, 6000, 1),
(7, 16, 8, 3000, 3000, 3000, 0, 6000, 1),
(7, 17, 8, 3000, 3000, 3000, 0, 6000, 1),
(7, 18, 8, 3000, 3000, 3000, 0, 6000, 1),
(7, 19, 8, 3000, 3000, 3000, 0, 6000, 1),
(7, 20, 8, 3000, 3000, 3000, 0, 6000, 1),
(7, 21, 10, 3000, 3000, 3000, 0, 6000, 1),
(7, 22, 13, 5000, 5000, 5000, 0, 10000, 1),
(7, 23, 13, 5000, 5000, 5000, 0, 10000, 1),
(8, 13, 9, 3000, 3000, 3300, 0, 6600, 1),
(8, 15, 9, 3000, 3000, 3300, 0, 6600, 1),
(8, 16, 9, 3000, 3000, 3300, 0, 6600, 1),
(8, 17, 9, 3000, 3000, 3300, 0, 6600, 1),
(8, 18, 9, 3000, 3000, 3300, 0, 6600, 1),
(8, 19, 9, 3000, 3000, 3300, 0, 6600, 1),
(8, 20, 9, 3000, 3000, 3300, 0, 6600, 1),
(8, 21, 11, 3000, 3000, 3000, 0, 6000, 1),
(8, 22, 14, 3000, 3000, 3000, 0, 6000, 1),
(8, 23, 14, 3000, 3000, 3000, 0, 6000, 1),
(9, 13, 10, 3000, 3000, 3000, 0, 6000, 1),
(9, 15, 10, 3000, 3000, 3000, 0, 6000, 1),
(9, 16, 10, 3000, 3000, 3000, 0, 6000, 1),
(9, 17, 10, 3000, 3000, 3000, 0, 6000, 1),
(9, 18, 10, 3000, 3000, 3000, 0, 6000, 1),
(9, 19, 10, 3000, 3000, 3000, 0, 6000, 1),
(9, 20, 10, 3000, 3000, 3000, 0, 6000, 1),
(9, 21, 12, 3000, 3000, 3000, 0, 6000, 1),
(9, 22, 15, 3000, 3000, 3000, 0, 6000, 1),
(9, 23, 15, 3000, 3000, 3000, 0, 6000, 1),
(10, 13, 11, 3000, 3000, 3000, 0, 6000, 1),
(10, 15, 11, 3000, 3000, 3000, 0, 6000, 1),
(10, 16, 11, 3000, 3000, 3000, 0, 6000, 1),
(10, 17, 11, 3000, 3000, 3000, 0, 6000, 1),
(10, 18, 11, 3000, 3000, 3000, 0, 6000, 1),
(10, 19, 11, 3000, 3000, 3000, 0, 6000, 1),
(10, 20, 11, 3000, 3000, 3000, 0, 6000, 1),
(10, 21, 13, 5000, 5000, 5000, 0, 10000, 1),
(10, 22, 24, 3000, 3000, 3000, 0, 6000, 1),
(10, 23, 24, 3000, 3000, 3000, 0, 6000, 1),
(11, 13, 12, 3000, 3000, 3000, 0, 6000, 1),
(11, 15, 12, 3000, 3000, 3000, 0, 6000, 1),
(11, 16, 12, 3000, 3000, 3000, 0, 6000, 1),
(11, 17, 12, 3000, 3000, 3000, 0, 6000, 1),
(11, 18, 12, 3000, 3000, 3000, 0, 6000, 1),
(11, 19, 12, 3000, 3000, 3000, 0, 6000, 1),
(11, 20, 12, 3000, 3000, 3000, 0, 6000, 1),
(11, 21, 14, 3000, 3000, 3000, 0, 6000, 1),
(11, 22, 25, 3000, 3000, 3000, 0, 6000, 1),
(11, 23, 25, 3000, 3000, 3000, 0, 6000, 1),
(12, 13, 13, 5000, 5000, 5000, 0, 10000, 1),
(12, 15, 13, 5000, 5000, 5000, 0, 10000, 1),
(12, 16, 13, 5000, 5000, 5000, 0, 10000, 1),
(12, 17, 13, 5000, 5000, 5000, 0, 10000, 1),
(12, 18, 13, 5000, 5000, 5000, 0, 10000, 1),
(12, 19, 13, 5000, 5000, 5000, 0, 10000, 1),
(12, 20, 13, 5000, 5000, 5000, 0, 10000, 1),
(12, 21, 15, 3000, 3000, 3000, 0, 6000, 1),
(12, 22, 26, 3000, 3000, 3000, 0, 6000, 1),
(12, 23, 26, 3000, 3000, 3000, 0, 6000, 1),
(13, 13, 14, 3000, 3000, 3000, 0, 6000, 1),
(13, 15, 14, 3000, 3000, 3000, 0, 6000, 1),
(13, 16, 14, 3000, 3000, 3000, 0, 6000, 1),
(13, 17, 14, 3000, 3000, 3000, 0, 6000, 1),
(13, 18, 14, 3000, 3000, 3000, 0, 6000, 1),
(13, 19, 14, 3000, 3000, 3000, 0, 6000, 1),
(13, 20, 14, 3000, 3000, 3000, 0, 6000, 1),
(13, 22, 27, 3000, 3000, 3300, 200, 6400, 1),
(13, 23, 27, 3000, 3000, 3300, 200, 6400, 1),
(14, 13, 15, 3000, 3000, 3000, 0, 6000, 1),
(14, 15, 15, 3000, 3000, 3000, 0, 6000, 1),
(14, 16, 15, 3000, 3000, 3000, 0, 6000, 1),
(14, 17, 15, 3000, 3000, 3000, 0, 6000, 1),
(14, 18, 15, 3000, 3000, 3000, 0, 6000, 1),
(14, 19, 15, 3000, 3000, 3000, 0, 6000, 1),
(14, 20, 15, 3000, 3000, 3000, 0, 6000, 1),
(14, 22, 28, 3000, 3000, 3000, 0, 6000, 1),
(14, 23, 28, 3000, 3000, 3000, 0, 6000, 1),
(15, 13, 16, 3000, 3000, 3000, 0, 6000, 1),
(15, 15, 16, 3000, 3000, 3000, 0, 6000, 1),
(15, 16, 16, 3000, 3000, 3000, 0, 6000, 1),
(15, 17, 16, 3000, 3000, 3000, 0, 6000, 1),
(15, 18, 16, 3000, 3000, 3000, 0, 6000, 1),
(15, 19, 16, 3000, 3000, 3000, 0, 6000, 1),
(15, 20, 16, 3000, 3000, 3000, 0, 6000, 1),
(15, 22, 29, 3000, 3000, 3000, 0, 6000, 1),
(15, 23, 29, 3000, 3000, 3000, 0, 6000, 1),
(16, 13, 17, 3000, 3000, 3500, 0, 7000, 1),
(16, 15, 17, 3000, 3000, 3500, 500, 6500, 1),
(16, 16, 17, 3000, 3000, 3500, 500, 6500, 1),
(16, 17, 17, 3000, 3000, 3500, 500, 6500, 1),
(16, 18, 17, 3000, 3000, 3500, 500, 6500, 1),
(16, 19, 17, 3000, 3000, 3500, 500, 6500, 1),
(16, 20, 17, 3000, 3000, 3500, 500, 6500, 1),
(16, 22, 30, 3000, 3000, 3000, 0, 6000, 1),
(16, 23, 30, 3000, 3000, 3000, 0, 6000, 1),
(17, 13, 18, 3000, 3000, 3300, 0, 6600, 1),
(17, 15, 18, 3000, 3000, 3300, 0, 6600, 1),
(17, 16, 18, 3000, 3000, 3300, 0, 6600, 1),
(17, 17, 18, 3000, 3000, 3300, 0, 6600, 1),
(17, 18, 18, 3000, 3000, 3300, 0, 6600, 1),
(17, 19, 18, 3000, 3000, 3300, 0, 6600, 1),
(17, 20, 18, 3000, 3000, 3300, 0, 6600, 1),
(17, 22, 31, 3000, 3000, 3000, 200, 5800, 1),
(17, 23, 31, 3000, 3000, 3000, 200, 5800, 1),
(18, 15, 19, 5000, 5000, 6060, 700, 11420, 1),
(18, 16, 19, 5000, 5000, 6060, 700, 11420, 1),
(18, 17, 19, 5000, 5000, 6060, 700, 11420, 1),
(18, 18, 19, 5000, 5000, 6060, 700, 11420, 1),
(18, 19, 19, 5000, 5000, 6060, 700, 11420, 1),
(18, 20, 19, 5000, 5000, 6060, 700, 11420, 1),
(18, 23, 32, 3000, 3000, 3800, 0, 7600, 1),
(19, 16, 20, 3000, 3000, 4500, 0, 9000, 1),
(19, 17, 20, 3000, 3000, 4500, 0, 9000, 1),
(19, 18, 20, 3000, 3000, 4500, 0, 9000, 1),
(19, 19, 20, 3000, 3000, 4500, 0, 9000, 1),
(19, 20, 20, 3000, 3000, 4500, 0, 9000, 1),
(19, 23, 33, 3000, 3000, 3700, 0, 7400, 1),
(20, 19, 21, 3000, 3000, 3000, 0, 6000, 1),
(20, 20, 21, 3000, 3000, 3000, 0, 6000, 1),
(20, 23, 34, 3000, 3000, 3500, 0, 7000, 1),
(21, 19, 22, 3000, 3000, 4300, 200, 8400, 1),
(21, 20, 22, 3000, 3000, 4300, 200, 8400, 1),
(21, 23, 35, 3000, 3000, 3000, 300, 5700, 1),
(22, 23, 36, 3000, 3000, 3300, 0, 6600, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `documentos`
--

CREATE TABLE `documentos` (
  `id_documentos` int(11) NOT NULL,
  `id_candidato` int(11) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `Documento` varchar(40) DEFAULT NULL,
  `estado` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `id_empleado` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `sexo` varchar(10) DEFAULT NULL,
  `fecha_de_nacimiento` date DEFAULT NULL,
  `cui` varchar(20) DEFAULT NULL,
  `correo` varchar(45) DEFAULT NULL,
  `id_puesto` int(11) DEFAULT NULL,
  `id_area` int(11) DEFAULT NULL,
  `nit` varchar(13) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`id_empleado`, `nombre`, `apellido`, `sexo`, `fecha_de_nacimiento`, `cui`, `correo`, `id_puesto`, `id_area`, `nit`, `direccion`, `estado`) VALUES
(1, 'Juan Jose', 'Gamez Blanco', 'Masculino', '1997-11-23', '555465466', 'juan@hotmail.com', 1, 1, '6161654-4', 'BDM', 2),
(2, 'Edgar ruben', 'Baches', 'Masculinos', '1997-04-14', '4586153176', 'juan@hotmail.com', 3, 2, '6161654-3', 'zona 21', 2),
(3, 'josue', 'Rodas', 'Masculino', '2020-04-21', '23423423', 'juan@hotmail.com', 1, 3, '6161654-4', 'Solola', 0),
(4, 'Victor ', 'Gonzales', 'Masculino', '2020-04-15', '44522222855', 'juan@hotmail.com', 1, 1, '59239255-3', 'Guatemala', 2),
(5, 'saul', 'ramirez', 'Masculino', '2020-04-15', '445282581', 'juan@hotmail.com', 1, 1, '85342198', 'Guatemala', 2),
(6, 'paco', 'paco', 'Masculino', '2020-04-15', '8928492', 'paco@hotmail.com', 1, 1, '5632259-9', 'Guatemala', 2),
(7, 'paco', '1', 'Masculino', '2020-04-15', '1', '1', 1, 1, '1', '1', 0),
(8, '1', '1', 'Femenino', '2020-04-15', '1', '1', 1, 1, '1', '1', 1),
(9, '2', '2', 'Femenino', '2020-04-23', '2', '2', 1, 1, '2', '2', 1),
(10, '2', '2', 'Femenino', '2020-04-22', '2', '2', 1, 1, '4', '4', 1),
(11, '2', '2', 'Masculino', '2020-04-22', '2', '2', 2, 1, '2', '2', 1),
(12, 'jj', 'jj', 'Masculino', '2020-04-01', '32333', 'juan', 1, 1, '4444', 'BDM', 1),
(13, '5', '5', 'Femenino', '2020-04-19', '5', '55', 3, 3, '55', '55', 1),
(14, '33', '33', 'Masculino', '2020-04-19', '33', '33', 2, 3, '33', '33', 1),
(15, 'raul', 'Blanco', 'Masculino', '2020-04-24', '86546546554', 'raul@hotmail.com', 1, 1, '66885522', 'Guatemala', 1),
(16, '2311', '2311', 'Masculino', '2020-04-22', '12', '123', 2, 3, '12', '12', 0),
(17, 'paola', 'herrera', 'Femenino', '2020-04-22', '566689525', 'paola@hotmail.com', 1, 2, '5321525-3', 'Guetamala', 0),
(18, 'paco', 'tobillas', 'Femenino', '2020-04-01', '0888', 'jgambeb', 1, 3, '56644', 'BDM', 0),
(19, 'juan', 'Gamez', 'Masculino', '2020-04-24', '566665544', 'juan@hotmail.com', 3, 1, '444454-5', 'Zona1', 0),
(20, 'Gustavo', 'Perez', 'Masculino', '2020-04-24', '5599669', 'gus657@gmail.com', 1, 2, '55266-5', 'zona 6', 0),
(21, 'Hermnesto', 'Ramirez', 'Masculino', '1997-11-23', '333233134134', 'juan@hotmail', 1, 2, '5588966-8', 'Ciudad', 0),
(22, 'pedro', 'Ramirez', 'Masculino', '2020-05-13', '5544455', 'ramirez@gmail.com', 1, 3, '5525255-6', 'Guatemala', 0),
(23, 'ramiro', 'estrada', 'Masculino', '2020-05-03', '5798320', 'ramiro@hotmail.com', 1, 1, '564217-5', 'Guatemala', 0),
(24, 'edgar', 'edgar', 'Masculino', '2020-05-01', '2566844', '40222', 1, 2, '5662', 'ciudad', 1),
(25, 'Edgar', 'choc', 'Masculino', '2020-05-15', '522582252', 'cas01@gmail.com', 1, 2, '6161654-4', 'zona 21', 1),
(26, 'paco', 'paco', 'Masculino', '2020-05-06', '23447', 'paco@hotmail.com', 1, 3, '547233', 'Guatemala', 1),
(27, 'tono', 'tono', 'Masculino', '2020-05-04', '56644', 'tono@hotmail.com', 1, 1, '', '', 1),
(28, 'martin', 'perez', 'Masculino', '2020-05-07', '2223232', 'j@hotmial.com', 1, 3, '56789552', 'Guatemala', 1),
(29, 'paco', 'Gonzales', 'Masculino', '2020-05-06', '58977891', 'juan@hotmailcom', 1, 2, '5654488-4', 'Guatemala', 1),
(30, 'tony', 'Gomez', 'Masculino', '2020-05-06', '536566444', 'tony@hotmial.com', 2, 2, '5665244-1', 'Guatemala', 1),
(31, 'pati', 'goazales', 'Femenino', '2020-05-06', '56999785', 'pati@gamil.com', 2, 1, '56677888', 'Gautemala', 1),
(32, 'Juan', 'Jose ', 'Masculino', '2020-05-09', '1234567891', 'juan@hotmail.com', 2, 2, '452225-5', 'Guatemala', 1),
(33, 'Juan ', 'Perez', 'Masculino', '2020-05-11', '4566256646444477', 'juan@hotmail.com', 1, 1, '455666', 'guatemala', 1),
(34, 'ruben', 'casasola', 'Masculino', '2020-05-01', '1234567891234', 'juan@hotmail.com', 1, 2, '456778-5', 'Guatemala', 1),
(35, 'juan', 'Gamez', 'Femenino', '2020-05-08', '2233333333333', 'juan@hotmai.com', 1, 3, '55555555555-5', 'Guatemala', 1),
(36, 'juan', 'Gamez', 'Masculino', '2020-04-15', '5555555555555', 'juan@hotmail.com', 1, 2, '77777777777-5', 'Guatemala', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleos`
--

CREATE TABLE `empleos` (
  `id_empleos` int(11) NOT NULL,
  `id_solicitud` int(11) DEFAULT NULL,
  `id_sueldo` int(11) DEFAULT NULL,
  `detalles` varchar(80) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `tipo` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `empleos`
--

INSERT INTO `empleos` (`id_empleos`, `id_solicitud`, `id_sueldo`, `detalles`, `fecha`, `tipo`, `estado`) VALUES
(1, 1, 1, 'Se nececita personal con urgencias', '2020-05-15', 'Temporala', 0),
(2, 1, 2, 'Se nececita empleado ', '2020-05-07', 'Temporal', 1),
(3, 1, 1, 'hola', '2020-05-01', 'Indefinido', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `finiqito`
--

CREATE TABLE `finiqito` (
  `id_finiqito` int(11) NOT NULL,
  `id_empleados` int(11) DEFAULT NULL,
  `motivo` varchar(200) NOT NULL,
  `descripcion` varchar(300) NOT NULL,
  `total_prestaciones` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `finiqito`
--

INSERT INTO `finiqito` (`id_finiqito`, `id_empleados`, `motivo`, `descripcion`, `total_prestaciones`, `estado`) VALUES
(1, 8, 'Por ebrio', 'falta los viernes', 45000, 1),
(2, 8, 'Por presentarse ebrio a trabajar', 'Los dias biernes ingreseba bajo efectos de alcool a la empresa', 45000, 1),
(3, 6, 'ebrio', 'faltas', 5000, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `horas`
--

CREATE TABLE `horas` (
  `id_hora` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `costo` float DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `id_empleado` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `horas`
--

INSERT INTO `horas` (`id_hora`, `cantidad`, `costo`, `fecha`, `id_empleado`, `estado`) VALUES
(1, NULL, NULL, NULL, NULL, 1),
(2, 5, 5, '2020-04-17', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfiles`
--

CREATE TABLE `perfiles` (
  `id_perfil` int(11) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `educacion` varchar(50) NOT NULL,
  `nivel` varchar(50) NOT NULL,
  `descripcion` varchar(350) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `perfiles`
--

INSERT INTO `perfiles` (`id_perfil`, `nombre`, `educacion`, `nivel`, `descripcion`, `estado`) VALUES
(2, 'Gerentes', 'Universitaria', '9 semestre', 'Experiencia en programacion ', 0),
(3, 'Recursos Humanos1', 'Universitaria', 'Ingenieria en sistemas', '-Conociminetos en programacion -Agilidad Social', 1),
(4, 'Recursos Humanos', '0', '0', '-Conociminetos en programacion', 1),
(5, 'Recursos Humanos', 'Universitaria', '4to semestre ingenieria', '-Conocimiento en programacion\r\n-Diseño estrategica', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `planilla`
--

CREATE TABLE `planilla` (
  `id_planilla` int(11) NOT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `planilla`
--

INSERT INTO `planilla` (`id_planilla`, `fecha_inicio`, `fecha_fin`, `Nombre`, `estado`) VALUES
(1, '2020-04-02', '2020-04-29', 'Bienestar', 0),
(2, '2020-04-01', '2020-04-30', 'Bienestar', 0),
(3, '2020-04-02', '2020-04-29', 'Bienestar1', 0),
(4, '2020-04-01', '2020-04-30', 'Prueba3', 0),
(5, '2020-04-01', '2020-04-30', 'Prueba4', 1),
(6, '2020-04-01', '2020-04-30', 'Prueba5', 1),
(7, '2020-04-01', '2020-04-30', 'Bienestar S.A', 1),
(8, '2020-04-01', '2020-04-30', 'FIN', 1),
(9, '2020-04-01', '2020-04-30', 'PRUU', 1),
(10, '2020-04-01', '2020-04-30', 'planilla fin', 1),
(11, '2020-04-01', '2020-04-30', 'VAli', 1),
(12, '2020-04-01', '2020-04-30', 'ssss', 1),
(13, '2020-04-01', '2020-04-30', 'GUS', 1),
(14, '2020-04-01', '2020-04-30', 'Bienestar', 1),
(15, '2020-04-13', '2020-04-13', 'dd', 1),
(16, '2020-04-01', '2020-04-30', 'Gustavo baluck', 1),
(17, '2020-04-01', '2020-04-23', 'Validaciones', 1),
(18, '2020-04-01', '2020-04-30', 'Bienestar', 1),
(19, '2020-04-13', '2020-04-13', '', 1),
(20, '2020-04-13', '2020-04-13', 'Pruebas', 1),
(21, '2020-05-01', '2020-04-30', 'Pureba ', 1),
(22, '2020-04-13', '2020-04-13', 'prueba ul', 1),
(23, '2020-05-01', '2020-05-31', 'Validaciones ', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prestaciones`
--

CREATE TABLE `prestaciones` (
  `id_prestaciones` int(11) NOT NULL,
  `id_despido` int(11) DEFAULT NULL,
  `detalles` varchar(45) DEFAULT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `feha_fin` date DEFAULT NULL,
  `total` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pruebas`
--

CREATE TABLE `pruebas` (
  `id_pruebas` int(11) NOT NULL,
  `id_candidato` int(11) DEFAULT NULL,
  `putuacion` int(11) DEFAULT NULL,
  `detalles` varchar(50) DEFAULT NULL,
  `estado` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puestos`
--

CREATE TABLE `puestos` (
  `id_puesto` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `id_sueldo` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `puestos`
--

INSERT INTO `puestos` (`id_puesto`, `nombre`, `id_sueldo`, `estado`) VALUES
(1, 'Desarollador', 3, 1),
(2, 'Secretaria', 3, 1),
(3, 'Gerente', 2, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `solicitudes`
--

CREATE TABLE `solicitudes` (
  `id_solicitud` int(11) NOT NULL,
  `id_perfil` int(11) DEFAULT NULL,
  `id_area` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `detalles` varchar(45) DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `motivo` varchar(45) DEFAULT NULL,
  `id_puesto` int(11) DEFAULT NULL,
  `porcentaje` int(11) NOT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `solicitudes`
--

INSERT INTO `solicitudes` (`id_solicitud`, `id_perfil`, `id_area`, `fecha`, `detalles`, `Cantidad`, `motivo`, `id_puesto`, `porcentaje`, `estado`) VALUES
(1, 2, 2, '2020-05-09', 'Temporal', 1, 'Temporal', 1, 1, 2),
(2, 3, 2, '2020-05-07', 'hola', 2, 'jaja', 3, 10, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sueldos`
--

CREATE TABLE `sueldos` (
  `id_sueldo` int(11) NOT NULL,
  `salario` float DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `sueldos`
--

INSERT INTO `sueldos` (`id_sueldo`, `salario`, `estado`) VALUES
(1, 6000, 1),
(2, 5000, 1),
(3, 3000, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_comisiones`
--

CREATE TABLE `tipo_comisiones` (
  `id_tipo_comisiones` int(11) NOT NULL,
  `nombre` varchar(65) DEFAULT NULL,
  `isPercentage` int(11) NOT NULL DEFAULT 1,
  `valor` decimal(15,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_comisiones`
--

INSERT INTO `tipo_comisiones` (`id_tipo_comisiones`, `nombre`, `isPercentage`, `valor`, `estado`) VALUES
(1, 'Comision por venta', 1, '1.00', 1),
(2, 'gg', 1, '2.00', 1),
(3, 'gg', 1, '2.00', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_concepto`
--

CREATE TABLE `tipo_concepto` (
  `id_tipo` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_concepto`
--

INSERT INTO `tipo_concepto` (`id_tipo`, `nombre`, `estado`) VALUES
(1, 'Bonificación', 1),
(2, 'IGSS', 1),
(3, 'Bono 14', 1),
(4, 'Aguinaldo', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `area`
--
ALTER TABLE `area`
  ADD PRIMARY KEY (`id_area`);

--
-- Indices de la tabla `asistencia`
--
ALTER TABLE `asistencia`
  ADD PRIMARY KEY (`id_asistencia`),
  ADD KEY `emple_idx` (`id_empleado`);

--
-- Indices de la tabla `candidatos`
--
ALTER TABLE `candidatos`
  ADD PRIMARY KEY (`id_candidato`);

--
-- Indices de la tabla `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id_categoria`);

--
-- Indices de la tabla `cita`
--
ALTER TABLE `cita`
  ADD PRIMARY KEY (`id_cita`),
  ADD KEY `cadi_idx` (`id_candidato`);

--
-- Indices de la tabla `comisiones`
--
ALTER TABLE `comisiones`
  ADD PRIMARY KEY (`id_comisiones`),
  ADD KEY `fk_tipo_comisiones_comisiones` (`id_tipo_comisiones`),
  ADD KEY `fk_empleados_comisiones` (`id_empleado`),
  ADD KEY `fk_factura_comisiones` (`id_factura`);

--
-- Indices de la tabla `conceptos`
--
ALTER TABLE `conceptos`
  ADD PRIMARY KEY (`id_concepto`),
  ADD KEY `tipo_idx` (`id_tipo`),
  ADD KEY `empleado_idx` (`id_empleado`);

--
-- Indices de la tabla `despidos`
--
ALTER TABLE `despidos`
  ADD PRIMARY KEY (`id_despidos`),
  ADD KEY `assss_idx` (`id_empleado`),
  ADD KEY `presss_idx` (`id_prestaciones`);

--
-- Indices de la tabla `detalle_planilla`
--
ALTER TABLE `detalle_planilla`
  ADD PRIMARY KEY (`id_detalle`,`id_planilla`),
  ADD KEY `planilla_idx` (`id_planilla`),
  ADD KEY `empleo_idx` (`id_empleado`);

--
-- Indices de la tabla `documentos`
--
ALTER TABLE `documentos`
  ADD PRIMARY KEY (`id_documentos`),
  ADD KEY `candiii_idx` (`id_candidato`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`id_empleado`),
  ADD KEY `puesto_idx` (`id_puesto`),
  ADD KEY `area_idx` (`id_area`);

--
-- Indices de la tabla `empleos`
--
ALTER TABLE `empleos`
  ADD PRIMARY KEY (`id_empleos`),
  ADD KEY `solicitudd_idx` (`id_solicitud`),
  ADD KEY `suel` (`id_sueldo`);

--
-- Indices de la tabla `finiqito`
--
ALTER TABLE `finiqito`
  ADD PRIMARY KEY (`id_finiqito`),
  ADD KEY `immm_idx` (`id_empleados`);

--
-- Indices de la tabla `horas`
--
ALTER TABLE `horas`
  ADD PRIMARY KEY (`id_hora`),
  ADD KEY `empleado_idx` (`id_empleado`);

--
-- Indices de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  ADD PRIMARY KEY (`id_perfil`);

--
-- Indices de la tabla `planilla`
--
ALTER TABLE `planilla`
  ADD PRIMARY KEY (`id_planilla`);

--
-- Indices de la tabla `prestaciones`
--
ALTER TABLE `prestaciones`
  ADD PRIMARY KEY (`id_prestaciones`);

--
-- Indices de la tabla `pruebas`
--
ALTER TABLE `pruebas`
  ADD PRIMARY KEY (`id_pruebas`),
  ADD KEY `candiiio_idx` (`id_candidato`);

--
-- Indices de la tabla `puestos`
--
ALTER TABLE `puestos`
  ADD PRIMARY KEY (`id_puesto`),
  ADD KEY `sueldos_idx` (`id_sueldo`);

--
-- Indices de la tabla `solicitudes`
--
ALTER TABLE `solicitudes`
  ADD PRIMARY KEY (`id_solicitud`),
  ADD KEY `areaa_idx` (`id_area`),
  ADD KEY `puess_idx` (`id_puesto`),
  ADD KEY `per` (`id_perfil`);

--
-- Indices de la tabla `sueldos`
--
ALTER TABLE `sueldos`
  ADD PRIMARY KEY (`id_sueldo`);

--
-- Indices de la tabla `tipo_comisiones`
--
ALTER TABLE `tipo_comisiones`
  ADD PRIMARY KEY (`id_tipo_comisiones`);

--
-- Indices de la tabla `tipo_concepto`
--
ALTER TABLE `tipo_concepto`
  ADD PRIMARY KEY (`id_tipo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `area`
--
ALTER TABLE `area`
  MODIFY `id_area` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `asistencia`
--
ALTER TABLE `asistencia`
  MODIFY `id_asistencia` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `candidatos`
--
ALTER TABLE `candidatos`
  MODIFY `id_candidato` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `categorias`
--
ALTER TABLE `categorias`
  MODIFY `id_categoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `cita`
--
ALTER TABLE `cita`
  MODIFY `id_cita` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `comisiones`
--
ALTER TABLE `comisiones`
  MODIFY `id_comisiones` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `conceptos`
--
ALTER TABLE `conceptos`
  MODIFY `id_concepto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- AUTO_INCREMENT de la tabla `documentos`
--
ALTER TABLE `documentos`
  MODIFY `id_documentos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `id_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT de la tabla `empleos`
--
ALTER TABLE `empleos`
  MODIFY `id_empleos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `finiqito`
--
ALTER TABLE `finiqito`
  MODIFY `id_finiqito` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `horas`
--
ALTER TABLE `horas`
  MODIFY `id_hora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `id_perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `planilla`
--
ALTER TABLE `planilla`
  MODIFY `id_planilla` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT de la tabla `pruebas`
--
ALTER TABLE `pruebas`
  MODIFY `id_pruebas` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `puestos`
--
ALTER TABLE `puestos`
  MODIFY `id_puesto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `solicitudes`
--
ALTER TABLE `solicitudes`
  MODIFY `id_solicitud` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `sueldos`
--
ALTER TABLE `sueldos`
  MODIFY `id_sueldo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tipo_comisiones`
--
ALTER TABLE `tipo_comisiones`
  MODIFY `id_tipo_comisiones` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tipo_concepto`
--
ALTER TABLE `tipo_concepto`
  MODIFY `id_tipo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `asistencia`
--
ALTER TABLE `asistencia`
  ADD CONSTRAINT `emple` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `cita`
--
ALTER TABLE `cita`
  ADD CONSTRAINT `cadi` FOREIGN KEY (`id_candidato`) REFERENCES `candidatos` (`id_candidato`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `comisiones`
--
ALTER TABLE `comisiones`
  ADD CONSTRAINT `fk_empleados_comisiones` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tipo_comisiones_comisiones` FOREIGN KEY (`id_tipo_comisiones`) REFERENCES `tipo_comisiones` (`id_tipo_comisiones`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `conceptos`
--
ALTER TABLE `conceptos`
  ADD CONSTRAINT `aas` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tipo` FOREIGN KEY (`id_tipo`) REFERENCES `tipo_concepto` (`id_tipo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `despidos`
--
ALTER TABLE `despidos`
  ADD CONSTRAINT `assss` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `presss` FOREIGN KEY (`id_prestaciones`) REFERENCES `prestaciones` (`id_prestaciones`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_planilla`
--
ALTER TABLE `detalle_planilla`
  ADD CONSTRAINT `empleo` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `planilla` FOREIGN KEY (`id_planilla`) REFERENCES `planilla` (`id_planilla`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `documentos`
--
ALTER TABLE `documentos`
  ADD CONSTRAINT `candiii` FOREIGN KEY (`id_candidato`) REFERENCES `candidatos` (`id_candidato`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD CONSTRAINT `area` FOREIGN KEY (`id_area`) REFERENCES `area` (`id_area`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `puesto` FOREIGN KEY (`id_puesto`) REFERENCES `puestos` (`id_puesto`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `empleos`
--
ALTER TABLE `empleos`
  ADD CONSTRAINT `soli` FOREIGN KEY (`id_solicitud`) REFERENCES `solicitudes` (`id_solicitud`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `suel` FOREIGN KEY (`id_sueldo`) REFERENCES `sueldos` (`id_sueldo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `finiqito`
--
ALTER TABLE `finiqito`
  ADD CONSTRAINT `immm` FOREIGN KEY (`id_empleados`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `horas`
--
ALTER TABLE `horas`
  ADD CONSTRAINT `empleadosss` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `pruebas`
--
ALTER TABLE `pruebas`
  ADD CONSTRAINT `candiiio` FOREIGN KEY (`id_candidato`) REFERENCES `candidatos` (`id_candidato`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `puestos`
--
ALTER TABLE `puestos`
  ADD CONSTRAINT `sueldos` FOREIGN KEY (`id_sueldo`) REFERENCES `sueldos` (`id_sueldo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `solicitudes`
--
ALTER TABLE `solicitudes`
  ADD CONSTRAINT `areaa` FOREIGN KEY (`id_area`) REFERENCES `area` (`id_area`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `per` FOREIGN KEY (`id_perfil`) REFERENCES `perfiles` (`id_perfil`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `puess` FOREIGN KEY (`id_puesto`) REFERENCES `puestos` (`id_puesto`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
