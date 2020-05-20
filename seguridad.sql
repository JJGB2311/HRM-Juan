CREATE DATABASE IF NOT EXISTS `seguridad` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `seguridad`;
--
-- Base de datos: `seguridad`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `procedimientoLogin` (IN `usuario` VARCHAR(25), IN `clave` VARCHAR(25))  NO SQL
Select tbl_usuario.PK_id_Usuario FROM tbl_usuario where tbl_usuario.PK_id_Usuario = usuario and tbl_usuario.password_usuario = MD5(clave) AND tbl_usuario.estado_usuario=1$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_aplicacion`
--

CREATE TABLE `tbl_aplicacion` (
  `PK_id_aplicacion` int(11) NOT NULL,
  `PK_id_modulo` int(11) NOT NULL,
  `nombre_aplicacion` varchar(45) DEFAULT NULL,
  `descripcion_aplicacion` varchar(200) DEFAULT NULL,
  `estado_aplicacion` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_aplicacion`
--

INSERT INTO `tbl_aplicacion` (`PK_id_aplicacion`, `PK_id_modulo`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1, 1, 'HRM-Juan', 'DESAROLLADOR', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bitacora`
--

CREATE TABLE `tbl_bitacora` (
  `PK_id_bitacora` int(11) NOT NULL,
  `PK_id_usuario` varchar(25) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `host` varchar(45) DEFAULT NULL,
  `ip` varchar(25) DEFAULT NULL,
  `accion` varchar(50) DEFAULT NULL,
  `tabla` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_bitacora`
--

INSERT INTO `tbl_bitacora` (`PK_id_bitacora`, `PK_id_usuario`, `fecha`, `hora`, `host`, `ip`, `accion`, `tabla`) VALUES
(1, 'jjgb', '2020-05-11', '08:17:38', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(2, 'jjgb', '2020-05-11', '08:17:50', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a modulos', 'tbl_modulos'),
(3, 'jjgb', '2020-05-11', '08:18:02', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a modulos', 'tbl_modulos'),
(4, 'jjgb', '2020-05-11', '08:18:16', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Inserto un nuevo modulo: 1 - HRM', 'tbl_modulo'),
(5, 'jjgb', '2020-05-11', '08:18:21', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a modulos', 'tbl_modulos'),
(6, 'jjgb', '2020-05-11', '08:18:50', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Inserto un nuevo perfil: 1 - ADMIN', 'tbl_perfil'),
(7, 'jjgb', '2020-05-11', '08:18:55', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(8, 'jjgb', '2020-05-11', '08:18:55', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a modulos', 'tbl_modulos'),
(9, 'jjgb', '2020-05-11', '08:19:00', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(10, 'jjgb', '2020-05-11', '08:19:11', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Asigno aplicacion: HRM-Juan a usuario: jjgb', 'tbl_usuario_aplicacion'),
(11, 'jjgb', '2020-05-11', '08:19:18', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(12, 'jjgb', '2020-05-11', '08:19:18', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(13, 'jjgb', '2020-05-11', '08:19:20', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(14, 'jjgb', '2020-05-11', '08:19:36', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(15, 'jjgb', '2020-05-11', '08:19:37', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a modulos', 'tbl_modulos'),
(16, 'jjgb', '2020-05-11', '08:19:40', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(17, 'jjgb', '2020-05-11', '08:19:49', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Asigno permiso: HRM-Juan a perfil: ADMIN', 'tbl_usuario_aplicacion'),
(18, 'jjgb', '2020-05-11', '08:19:54', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(19, 'jjgb', '2020-05-11', '08:19:54', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(20, 'jjgb', '2020-05-11', '08:20:26', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se creó un nuevo registro', 'area'),
(21, 'jjgb', '2020-05-11', '08:20:47', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se creó un nuevo registro', 'sueldos'),
(22, 'jjgb', '2020-05-11', '08:21:15', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se creó un nuevo registro', 'puestos'),
(23, 'jjgb', '2020-05-11', '08:21:24', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se actualizó un registro', 'puestos'),
(24, 'jjgb', '2020-05-11', '08:21:36', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se actualizó un registro', 'puestos'),
(25, 'jjgb', '2020-05-11', '08:21:50', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se creó un nuevo registro', 'puestos'),
(26, 'jjgb', '2020-05-11', '08:28:43', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(27, 'jjgb', '2020-05-11', '08:31:50', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(28, 'jjgb', '2020-05-11', '08:34:09', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(29, 'jjgb', '2020-05-11', '08:37:41', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(30, 'jjgb', '2020-05-11', '08:39:22', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(31, 'jjgb', '2020-05-11', '08:40:43', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(32, 'jjgb', '2020-05-11', '08:48:41', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(33, 'jjgb', '2020-05-11', '08:54:09', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(34, 'jjgb', '2020-05-11', '08:56:41', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(35, 'jjgb', '2020-05-11', '09:00:08', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(36, 'jjgb', '2020-05-11', '09:01:00', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(37, 'jjgb', '2020-05-11', '09:04:14', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(38, 'jjgb', '2020-05-11', '09:09:49', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(39, 'jjgb', '2020-05-11', '09:16:12', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(40, 'jjgb', '2020-05-11', '10:13:45', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(41, 'jjgb', '2020-05-11', '10:20:54', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(42, 'jjgb', '2020-05-11', '10:28:39', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(43, 'jjgb', '2020-05-12', '10:17:23', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(44, 'jjgb', '2020-05-13', '09:50:20', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(45, 'jjgb', '2020-05-13', '09:53:06', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se creó un nuevo registro', 'tipo_concepto'),
(46, 'jjgb', '2020-05-17', '01:28:36', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(47, 'jjgb', '2020-05-17', '02:02:19', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(48, 'jjgb', '2020-05-17', '02:05:11', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(49, 'jjgb', '2020-05-17', '02:06:14', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(50, 'jjgb', '2020-05-17', '02:07:50', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(51, 'jjgb', '2020-05-17', '02:09:26', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(52, 'jjgb', '2020-05-17', '02:10:14', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(53, 'jjgb', '2020-05-17', '02:22:23', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(54, 'jjgb', '2020-05-17', '02:33:31', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(55, 'jjgb', '2020-05-17', '03:05:45', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(56, 'jjgb', '2020-05-17', '03:09:44', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(57, 'jjgb', '2020-05-17', '03:22:13', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(58, 'jjgb', '2020-05-17', '04:25:28', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(59, 'jjgb', '2020-05-17', '04:34:03', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(60, 'jjgb', '2020-05-17', '04:45:23', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(61, 'jjgb', '2020-05-17', '05:11:34', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(62, 'jjgb', '2020-05-17', '06:07:46', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(63, 'jjgb', '2020-05-17', '06:34:28', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(64, 'jjgb', '2020-05-17', '06:35:23', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(65, 'jjgb', '2020-05-17', '06:47:25', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(66, 'jjgb', '2020-05-17', '06:55:01', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(67, 'jjgb', '2020-05-17', '07:54:36', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(68, 'jjgb', '2020-05-17', '07:58:30', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(69, 'jjgb', '2020-05-17', '08:01:38', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(70, 'jjgb', '2020-05-17', '08:05:15', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(71, 'jjgb', '2020-05-17', '08:07:29', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(72, 'jjgb', '2020-05-17', '08:08:16', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(73, 'jjgb', '2020-05-17', '08:10:00', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(74, 'jjgb', '2020-05-17', '08:11:16', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(75, 'jjgb', '2020-05-18', '03:55:23', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(76, 'jjgb', '2020-05-18', '06:27:36', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(77, 'jjgb', '2020-05-18', '09:29:06', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(78, 'jjgb', '2020-05-18', '09:47:50', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(79, 'jjgb', '2020-05-18', '09:50:28', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(80, 'jjgb', '2020-05-18', '09:53:55', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(81, 'jjgb', '2020-05-18', '09:57:12', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(82, 'jjgb', '2020-05-18', '09:58:05', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(83, 'jjgb', '2020-05-19', '03:40:25', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(84, 'jjgb', '2020-05-19', '04:19:30', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login'),
(85, 'jjgb', '2020-05-19', '04:38:42', 'DESKTOP-45JAI7Q', '192.168.0.8', 'Se logeo al sistema', 'Login');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_modulo`
--

CREATE TABLE `tbl_modulo` (
  `PK_id_Modulo` int(11) NOT NULL,
  `nombre_modulo` varchar(45) DEFAULT NULL,
  `descripcion_modulo` varchar(200) DEFAULT NULL,
  `estado_modulo` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_modulo`
--

INSERT INTO `tbl_modulo` (`PK_id_Modulo`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1, 'HRM', 'DESAROLLADOR', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfil_detalle`
--

CREATE TABLE `tbl_perfil_detalle` (
  `PK_id_perfil` int(11) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(4) DEFAULT NULL,
  `consultar` tinyint(4) DEFAULT NULL,
  `modificar` tinyint(4) DEFAULT NULL,
  `eliminar` tinyint(4) DEFAULT NULL,
  `imprimir` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_perfil_detalle`
--

INSERT INTO `tbl_perfil_detalle` (`PK_id_perfil`, `PK_id_aplicacion`, `ingresar`, `consultar`, `modificar`, `eliminar`, `imprimir`) VALUES
(1, 1, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfil_encabezado`
--

CREATE TABLE `tbl_perfil_encabezado` (
  `PK_id_perfil` int(11) NOT NULL,
  `nombre_perfil` varchar(45) DEFAULT NULL,
  `descripcion_perfil` varchar(200) DEFAULT NULL,
  `estado_perfil` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_perfil_encabezado`
--

INSERT INTO `tbl_perfil_encabezado` (`PK_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'ADMIN', 'TODO', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario`
--

CREATE TABLE `tbl_usuario` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `nombre_usuario` varchar(45) DEFAULT NULL,
  `apellido_usuarios` varchar(45) DEFAULT NULL,
  `password_usuario` varchar(45) DEFAULT NULL,
  `cambio_contrasena` tinyint(4) DEFAULT NULL,
  `estado_usuario` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_usuario`
--

INSERT INTO `tbl_usuario` (`PK_id_usuario`, `nombre_usuario`, `apellido_usuarios`, `password_usuario`, `cambio_contrasena`, `estado_usuario`) VALUES
('jjgb', 'juan', 'gamez', '046ddf96c233a273fd390c3d0b1a9aa4', 1, 1),
('MiUsuario', 'Usuario', 'Prueba', 'e19d5cd5af0378da05f63f891c7467af', 0, 1);

--
-- Disparadores `tbl_usuario`
--
DELIMITER $$
CREATE TRIGGER `actualizarClave` BEFORE UPDATE ON `tbl_usuario` FOR EACH ROW IF NEW.password_usuario <> OLD.password_usuario THEN
SET NEW.password_usuario = MD5(NEW.password_usuario);
END IF
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `encriptarClave` BEFORE INSERT ON `tbl_usuario` FOR EACH ROW BEGIN
SET NEW.password_usuario = MD5(NEW.password_usuario);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario_aplicacion`
--

CREATE TABLE `tbl_usuario_aplicacion` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(4) DEFAULT NULL,
  `consultar` tinyint(4) DEFAULT NULL,
  `modificar` tinyint(4) DEFAULT NULL,
  `eliminar` tinyint(4) DEFAULT NULL,
  `imprimir` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_usuario_aplicacion`
--

INSERT INTO `tbl_usuario_aplicacion` (`PK_id_usuario`, `PK_id_aplicacion`, `ingresar`, `consultar`, `modificar`, `eliminar`, `imprimir`) VALUES
('jjgb', 1, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario_perfil`
--

CREATE TABLE `tbl_usuario_perfil` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_aplicacion`
--
ALTER TABLE `tbl_aplicacion`
  ADD PRIMARY KEY (`PK_id_aplicacion`,`PK_id_modulo`),
  ADD KEY `fk_Aplicacion_Modulo` (`PK_id_modulo`);

--
-- Indices de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD PRIMARY KEY (`PK_id_bitacora`,`PK_id_usuario`),
  ADD KEY `fk_Bitacora_Usuario1` (`PK_id_usuario`);

--
-- Indices de la tabla `tbl_modulo`
--
ALTER TABLE `tbl_modulo`
  ADD PRIMARY KEY (`PK_id_Modulo`);

--
-- Indices de la tabla `tbl_perfil_detalle`
--
ALTER TABLE `tbl_perfil_detalle`
  ADD PRIMARY KEY (`PK_id_perfil`,`PK_id_aplicacion`),
  ADD KEY `fk_Perfil_detalle_Aplicacion1` (`PK_id_aplicacion`);

--
-- Indices de la tabla `tbl_perfil_encabezado`
--
ALTER TABLE `tbl_perfil_encabezado`
  ADD PRIMARY KEY (`PK_id_perfil`);

--
-- Indices de la tabla `tbl_usuario`
--
ALTER TABLE `tbl_usuario`
  ADD PRIMARY KEY (`PK_id_usuario`);

--
-- Indices de la tabla `tbl_usuario_aplicacion`
--
ALTER TABLE `tbl_usuario_aplicacion`
  ADD PRIMARY KEY (`PK_id_usuario`,`PK_id_aplicacion`),
  ADD KEY `fk_tbl_usuario_aplicacion_tbl_aplicacion1` (`PK_id_aplicacion`);

--
-- Indices de la tabla `tbl_usuario_perfil`
--
ALTER TABLE `tbl_usuario_perfil`
  ADD PRIMARY KEY (`PK_id_usuario`,`PK_id_perfil`),
  ADD KEY `fk_Usuario_perfil_Perfil1` (`PK_id_perfil`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  MODIFY `PK_id_bitacora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=86;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_aplicacion`
--
ALTER TABLE `tbl_aplicacion`
  ADD CONSTRAINT `fk_Aplicacion_Modulo` FOREIGN KEY (`PK_id_modulo`) REFERENCES `tbl_modulo` (`PK_id_Modulo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD CONSTRAINT `fk_Bitacora_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_perfil_detalle`
--
ALTER TABLE `tbl_perfil_detalle`
  ADD CONSTRAINT `fk_Perfil_detalle_Aplicacion1` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Perfil_detalle_Perfil1` FOREIGN KEY (`PK_id_perfil`) REFERENCES `tbl_perfil_encabezado` (`PK_id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_usuario_aplicacion`
--
ALTER TABLE `tbl_usuario_aplicacion`
  ADD CONSTRAINT `fk_Usuario_aplicacion_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tbl_usuario_aplicacion_tbl_aplicacion1` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_usuario_perfil`
--
ALTER TABLE `tbl_usuario_perfil`
  ADD CONSTRAINT `fk_Usuario_perfil_Perfil1` FOREIGN KEY (`PK_id_perfil`) REFERENCES `tbl_perfil_encabezado` (`PK_id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Usuario_perfil_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

