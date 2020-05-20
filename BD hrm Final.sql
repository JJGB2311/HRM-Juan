
CREATE DATABASE IF NOT EXISTS hrm ;
use hrm;
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
(3, 'Contabilidad', 1),
(4, 'Ventas', 1);

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
(1, 2, '2020-05-01', '2020-05-31', 1, 300, 1, 1),
(2, 2, '2020-05-01', '2020-05-31', 2, 200, 0, 1),
(3, 2, '2020-05-01', '2020-05-31', 3, 400, 1, 1),
(4, 1, '1111-11-11', '1111-11-11', 1, 300, 1, 1),
(5, 1, '1111-11-11', '1111-11-11', 2, 250, 0, 1),
(6, 1, '1111-11-11', '1111-11-11', 3, 450, 1, 1);

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
(1, 1, 1, 3000, 3000, 3750, 250, 7250, 1),
(2, 1, 2, 3000, 3000, 3700, 200, 7200, 1);

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
(1, 'Juan', 'Gamez', 'Masculino', '1997-11-23', '1234567891234', 'juan@hotmail.com', 1, 1, '6165141-5', 'Guatemala villa canales', 1),
(2, 'Edgar', 'Casasola', 'Masculino', '2020-05-19', '6519814984189', 'cas01@hotmail.com', 1, 2, '5644614-4', 'Zona 21', 1);

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
(1, 'Recursos Humanos', 'Universitaria', '9no Semestre de ingenieria', '-Conociminetos en c++\r\n-Conocimientos en php\r\n-Conocimientos en SQL', 1);

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
(1, '2020-05-01', '2020-05-31', 'Bienestar', 1);

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
(2, 'Secretaria', 2, 1),
(3, 'Gerente', 4, 1);

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
(1, 1, 1, '2020-05-19', 'Se necesita con urgencia', 1, 'Temporal', 3, 10, 1);

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
(3, 3000, 1),
(4, 8000, 1);

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
(4, 'Aguinaldo', 1),
(5, 'Descuento', 1);

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
  MODIFY `id_area` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

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
  MODIFY `id_concepto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `documentos`
--
ALTER TABLE `documentos`
  MODIFY `id_documentos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `id_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `empleos`
--
ALTER TABLE `empleos`
  MODIFY `id_empleos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `finiqito`
--
ALTER TABLE `finiqito`
  MODIFY `id_finiqito` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `horas`
--
ALTER TABLE `horas`
  MODIFY `id_hora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `id_perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `planilla`
--
ALTER TABLE `planilla`
  MODIFY `id_planilla` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `pruebas`
--
ALTER TABLE `pruebas`
  MODIFY `id_pruebas` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `puestos`
--
ALTER TABLE `puestos`
  MODIFY `id_puesto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `solicitudes`
--
ALTER TABLE `solicitudes`
  MODIFY `id_solicitud` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `sueldos`
--
ALTER TABLE `sueldos`
  MODIFY `id_sueldo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `tipo_comisiones`
--
ALTER TABLE `tipo_comisiones`
  MODIFY `id_tipo_comisiones` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tipo_concepto`
--
ALTER TABLE `tipo_concepto`
  MODIFY `id_tipo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

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
  ADD CONSTRAINT `are` FOREIGN KEY (`id_area`) REFERENCES `area` (`id_area`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `per` FOREIGN KEY (`id_perfil`) REFERENCES `perfiles` (`id_perfil`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `pus` FOREIGN KEY (`id_puesto`) REFERENCES `puestos` (`id_puesto`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;
