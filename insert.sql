INSERT INTO `sueldos` (`id_sueldo`, `salario`, `estado`) VALUES (NULL, '6000', '1');
INSERT INTO `sueldos` (`id_sueldo`, `salario`, `estado`) VALUES (NULL, '5000', '1');
INSERT INTO `sueldos` (`id_sueldo`, `salario`, `estado`) VALUES (NULL, '3000', '1');

INSERT INTO `puestos` (`id_puesto`, `nombre`, `id_sueldo`, `estado`) VALUES (NULL, 'Desarollador', '3', '1');
INSERT INTO `puestos` (`id_puesto`, `nombre`, `id_sueldo`, `estado`) VALUES (NULL, 'Secretaria', '3', '1');
INSERT INTO `puestos` (`id_puesto`, `nombre`, `id_sueldo`, `estado`) VALUES (NULL, 'Gerente', '2', '1');

INSERT INTO `area` (`id_area`, `nombre`, `estado`) VALUES (NULL, 'Recursos Humanos', '1');
INSERT INTO `area` (`id_area`, `nombre`, `estado`) VALUES (NULL, 'Producción', '1');
INSERT INTO `area` (`id_area`, `nombre`, `estado`) VALUES (NULL, 'Contabilidad', '1');

INSERT INTO `empleados` (`id_empleado`, `nombre`, `apellido`, `sexo`, `fecha_de_nacimiento`, `cui`, `correo`, `id_puesto`, `id_area`, `nit`, `direccion`, `estado`) VALUES (NULL, 'Juan Jose', 'Gamez Blanco', 'Masculino', '1997-11-23', '555465466', 'juan@hotmail.com', '1', '1', '6161654-4', 'BDM', '1');
INSERT INTO `empleados` (`id_empleado`, `nombre`, `apellido`, `sexo`, `fecha_de_nacimiento`, `cui`, `correo`, `id_puesto`, `id_area`, `nit`, `direccion`, `estado`) VALUES (NULL, 'Edgar', 'Casasola Baches', 'Masculino', '1997-04-13', '458615318', 'juan@hotmail.com', '1', '2', '6161654-5', 'zona 21', '1');

INSERT INTO `tipo_concepto` (`id_tipo`, `nombre`, `estado`) VALUES (NULL, 'Bonificación', '1');
INSERT INTO `tipo_concepto` (`id_tipo`, `nombre`, `estado`) VALUES (NULL, 'IGSS', '1');
INSERT INTO `tipo_concepto` (`id_tipo`, `nombre`, `estado`) VALUES (NULL, 'Bono 14', '1');


INSERT INTO `planilla` (`id_planilla`, `fecha_inicio`, `fecha_fin`, `Nombre`, `estado`) VALUES (NULL, '2020-04-01', '2020-04-30', 'Bienestar S.A', '1');

INSERT INTO `conceptos` (`id_concepto`, `id_empleado`, `fecha_inicio`, `fecha_fin`, `id_tipo`, `monto`, `debe_Haber`, `estado`) VALUES (NULL, '1', '2020-04-13', '2020-04-18', '1', '300', '1', '1');
CREATE TABLE `ayuda` (
  	`Id_ayuda` int(11) NOT NULL,
  	`Ruta` text COLLATE utf8_unicode_ci NOT NULL,
 	`indice` text COLLATE utf8_unicode_ci NOT NULL
	) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

	INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`) VALUES
	(1, 'Página web ayuda/ayuda.chm', 'menu.html'),
	(2, 'Página web ayuda/ayuda.chm', 'Menúboletos.html');
*----*planilla *--*
  SELECT empleados.id_empleado, empleados.nombre, empleados.apellido, 
  comisiones.id_factura, tipo_comisiones.nombre, 
  tipo_comisiones.isPercentage, tipo_comisiones.valor
  FROM empleados
  INNER JOIN comisiones
  ON empleados.id_empleado = comisiones.id_empleado
  INNER JOIN tipo_comisiones
  ON comisiones.id_tipo_comisiones = tipo_comisiones.id_tipo_comisiones;


/***//**
SELECT empleados.id_empleado, empleados.nombre, empleados.apellido, tipo_comisiones.nombre, tipo_comisiones.valor FROM empleados INNER JOIN comisiones ON empleados.id_empleado = comisiones.id_empleado INNER JOIN tipo_comisiones ON comisiones.id_tipo_comisiones = tipo_comisiones.id_tipo_comisiones

SELECT empleados.id_empleado, empleados.nombre, empleados.apellido, conceptos.fecha_inicio, conceptos.fecha_fin ,conceptos.monto,conceptos.debe_Haber FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado


/**prototipo casi final***/
SELECT empleados.id_empleado, empleados.nombre, empleados.apellido, conceptos.fecha_inicio, conceptos.fecha_fin ,conceptos.monto,conceptos.debe_Haber,tipo_comisiones.nombre, tipo_comisiones.valor FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado INNER JOIN comisiones ON empleados.id_empleado = comisiones.id_empleado INNER JOIN tipo_comisiones ON comisiones.id_tipo_comisiones = tipo_comisiones.id_tipo_comisiones

////////////////////////////////////////////////////////////////////////////////////////////////
respaldo
SELECT empleados.id_empleado, empleados.nombre, empleados.apellido, conceptos.fecha_inicio, conceptos.fecha_fin ,conceptos.monto,conceptos.debe_Haber,tipo_comisiones.nombre, tipo_comisiones.valor FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado INNER JOIN comisiones ON empleados.id_empleado = comisiones.id_empleado INNER JOIN tipo_comisiones ON comisiones.id_tipo_comisiones = tipo_comisiones.id_tipo_comisiones


/**///pruebas planilla

SELECT empleados.id_empleado, empleados.nombre, empleados.apellido,sueldos.salario,area.nombre, conceptos.fecha_inicio, conceptos.fecha_fin ,conceptos.monto,conceptos.debe_Haber FROM empleados INNER JOIN conceptos ON empleados.id_empleado = conceptos.id_empleado INNER JOIN area ON area.id_area = empleados.id_area INNER JOIN puestos ON puestos.id_puesto = empleados.id_puesto INNER JOIN sueldos ON sueldos.id_sueldo = puestos.id_sueldo AND empleados.id_empleado=1;

/////////////////////////////////////////////////////////
*----------------------------*
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
  `estatus` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `comisiones`
--

INSERT INTO `comisiones` (`id_comisiones`, `id_tipo_comisiones`, `id_empleado`, `id_factura`, `estatus`) VALUES
(1, 1, 1, 1, 1),
(2, 1, 1, 2, 1);

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
(12, 9, '1111-11-11', '1111-11-11', 1, 300, 1, 1),
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
(25, 22, '2020-05-02', '2020-05-02', 1, 300, 1, 1);

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
(3, 13, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 14, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 15, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 16, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 17, 4, 3000, 3000, 3000, 0, 6000, 1),
(3, 18, 4, 3000, 3000, 3000, 0, 6000, 1),
(4, 13, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 14, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 15, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 16, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 17, 5, 3000, 3000, 3000, 0, 6000, 1),
(4, 18, 5, 3000, 3000, 3000, 0, 6000, 1),
(5, 13, 6, 3000, 3000, 5100, 0, 10200, 1),
(5, 14, 6, 3000, 3000, 3000, 0, 6000, 1),
(5, 15, 6, 3000, 3000, 5100, 0, 10200, 1),
(5, 16, 6, 3000, 3000, 4800, 0, 9600, 1),
(5, 17, 6, 3000, 3000, 4800, 0, 9600, 1),
(5, 18, 6, 3000, 3000, 4800, 0, 9600, 1),
(6, 13, 7, 3000, 3000, 3000, 0, 6000, 1),
(6, 15, 7, 3000, 3000, 3000, 0, 6000, 1),
(6, 16, 7, 3000, 3000, 3000, 0, 6000, 1),
(6, 17, 7, 3000, 3000, 3000, 0, 6000, 1),
(6, 18, 7, 3000, 3000, 3000, 0, 6000, 1),
(7, 13, 8, 3000, 3000, 3000, 0, 6000, 1),
(7, 15, 8, 3000, 3000, 3000, 0, 6000, 1),
(7, 16, 8, 3000, 3000, 3000, 0, 6000, 1),
(7, 17, 8, 3000, 3000, 3000, 0, 6000, 1),
(7, 18, 8, 3000, 3000, 3000, 0, 6000, 1),
(8, 13, 9, 3000, 3000, 3300, 0, 6600, 1),
(8, 15, 9, 3000, 3000, 3300, 0, 6600, 1),
(8, 16, 9, 3000, 3000, 3300, 0, 6600, 1),
(8, 17, 9, 3000, 3000, 3300, 0, 6600, 1),
(8, 18, 9, 3000, 3000, 3300, 0, 6600, 1),
(9, 13, 10, 3000, 3000, 3000, 0, 6000, 1),
(9, 15, 10, 3000, 3000, 3000, 0, 6000, 1),
(9, 16, 10, 3000, 3000, 3000, 0, 6000, 1),
(9, 17, 10, 3000, 3000, 3000, 0, 6000, 1),
(9, 18, 10, 3000, 3000, 3000, 0, 6000, 1),
(10, 13, 11, 3000, 3000, 3000, 0, 6000, 1),
(10, 15, 11, 3000, 3000, 3000, 0, 6000, 1),
(10, 16, 11, 3000, 3000, 3000, 0, 6000, 1),
(10, 17, 11, 3000, 3000, 3000, 0, 6000, 1),
(10, 18, 11, 3000, 3000, 3000, 0, 6000, 1),
(11, 13, 12, 3000, 3000, 3000, 0, 6000, 1),
(11, 15, 12, 3000, 3000, 3000, 0, 6000, 1),
(11, 16, 12, 3000, 3000, 3000, 0, 6000, 1),
(11, 17, 12, 3000, 3000, 3000, 0, 6000, 1),
(11, 18, 12, 3000, 3000, 3000, 0, 6000, 1),
(12, 13, 13, 5000, 5000, 5000, 0, 10000, 1),
(12, 15, 13, 5000, 5000, 5000, 0, 10000, 1),
(12, 16, 13, 5000, 5000, 5000, 0, 10000, 1),
(12, 17, 13, 5000, 5000, 5000, 0, 10000, 1),
(12, 18, 13, 5000, 5000, 5000, 0, 10000, 1),
(13, 13, 14, 3000, 3000, 3000, 0, 6000, 1),
(13, 15, 14, 3000, 3000, 3000, 0, 6000, 1),
(13, 16, 14, 3000, 3000, 3000, 0, 6000, 1),
(13, 17, 14, 3000, 3000, 3000, 0, 6000, 1),
(13, 18, 14, 3000, 3000, 3000, 0, 6000, 1),
(14, 13, 15, 3000, 3000, 3000, 0, 6000, 1),
(14, 15, 15, 3000, 3000, 3000, 0, 6000, 1),
(14, 16, 15, 3000, 3000, 3000, 0, 6000, 1),
(14, 17, 15, 3000, 3000, 3000, 0, 6000, 1),
(14, 18, 15, 3000, 3000, 3000, 0, 6000, 1),
(15, 13, 16, 3000, 3000, 3000, 0, 6000, 1),
(15, 15, 16, 3000, 3000, 3000, 0, 6000, 1),
(15, 16, 16, 3000, 3000, 3000, 0, 6000, 1),
(15, 17, 16, 3000, 3000, 3000, 0, 6000, 1),
(15, 18, 16, 3000, 3000, 3000, 0, 6000, 1),
(16, 13, 17, 3000, 3000, 3500, 0, 7000, 1),
(16, 15, 17, 3000, 3000, 3500, 500, 6500, 1),
(16, 16, 17, 3000, 3000, 3500, 500, 6500, 1),
(16, 17, 17, 3000, 3000, 3500, 500, 6500, 1),
(16, 18, 17, 3000, 3000, 3500, 500, 6500, 1),
(17, 13, 18, 3000, 3000, 3300, 0, 6600, 1),
(17, 15, 18, 3000, 3000, 3300, 0, 6600, 1),
(17, 16, 18, 3000, 3000, 3300, 0, 6600, 1),
(17, 17, 18, 3000, 3000, 3300, 0, 6600, 1),
(17, 18, 18, 3000, 3000, 3300, 0, 6600, 1),
(18, 15, 19, 5000, 5000, 6060, 700, 11420, 1),
(18, 16, 19, 5000, 5000, 6060, 700, 11420, 1),
(18, 17, 19, 5000, 5000, 6060, 700, 11420, 1),
(18, 18, 19, 5000, 5000, 6060, 700, 11420, 1),
(19, 16, 20, 3000, 3000, 4500, 0, 9000, 1),
(19, 17, 20, 3000, 3000, 4500, 0, 9000, 1),
(19, 18, 20, 3000, 3000, 4500, 0, 9000, 1);

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
(1, 'Juan Jose', 'Gamez Blanco', 'Masculino', '1997-11-23', '555465466', 'juan@hotmail.com', 1, 1, '6161654-4', 'BDM', 1),
(2, 'Edgar ruben', 'Baches', 'Masculinos', '1997-04-14', '4586153176', 'juan@hotmail.com', 3, 2, '6161654-3', 'zona 21', 1),
(3, 'josue', 'Rodas', 'Masculino', '2020-04-21', '23423423', 'juan@hotmail.com', 1, 3, '6161654-4', 'Solola', 0),
(4, 's', 's', 'Masculino', '2020-04-15', '44', 'juan@hotmail.com', 1, 1, '33', 'ff', 1),
(5, 's', 's', 'Masculino', '2020-04-15', '44', 'juan@hotmail.com', 1, 1, '33', 'ff', 1),
(6, '1', '2', 'Masculino', '2020-04-15', '1', '1', 1, 1, '1', '1', 1),
(7, '1', '1', 'Masculino', '2020-04-15', '1', '1', 1, 1, '1', '1', 1),
(8, '1', '1', 'Femenino', '2020-04-15', '1', '1', 1, 1, '1', '1', 1),
(9, '2', '2', 'Femenino', '2020-04-23', '2', '2', 1, 1, '2', '2', 1),
(10, '2', '2', 'Femenino', '2020-04-22', '2', '2', 1, 1, '4', '4', 1),
(11, '2', '2', 'Masculino', '2020-04-22', '2', '2', 2, 1, '2', '2', 1),
(12, 'jj', 'jj', 'Masculino', '2020-04-01', '32333', 'juan', 1, 1, '4444', 'BDM', 1),
(13, '5', '5', 'Femenino', '2020-04-19', '5', '55', 3, 3, '55', '55', 1),
(14, '33', '33', 'Masculino', '2020-04-19', '33', '33', 2, 3, '33', '33', 1),
(15, 'jj', 'jj', 'Masculino', '2020-04-24', '66', 'jj', 1, 1, '66', '66', 1),
(16, '2311', '2311', 'Masculino', '2020-04-22', '12', '123', 2, 3, '12', '12', 1),
(17, '', '', '', '2020-04-22', '', '', 1, 2, '', '', 1),
(18, 'paco', 'tobillas', 'Femenino', '2020-04-01', '0888', 'jgambeb', 1, 3, '56644', 'BDM', 1),
(19, 'juan', 'Gamez', 'Masculino', '2020-04-24', '566665544', 'juan@hotmail.com', 3, 1, '444454-5', 'Zona1', 1),
(20, 'Gustavo', 'Perez', 'Masculino', '2020-04-24', '5599669', 'gus657@gmail.com', 1, 2, '55266-5', 'zona 6', 1),
(21, 'jj', 'jj', 'Masculino', '1997-11-23', '333233134134', 'juan@hotmail', 1, 2, '5588966-8', '444', 1),
(22, 'jjj', 'jjj', 'Masculino', '2020-05-13', '55444', 'jjj', 1, 3, '55252', 'gg', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleos`
--

CREATE TABLE `empleos` (
  `id_empleos` int(11) NOT NULL,
  `id_solicitud` int(11) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `sueldo` varchar(45) DEFAULT NULL,
  `id_perfil` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `tipo` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------



-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `finiqito`
--

CREATE TABLE `finiqito` (
  `id_finiqito` int(11) NOT NULL,
  `id_empleados` int(11) DEFAULT NULL,
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

--
-- Volcado de datos para la tabla `horas`
--

INSERT INTO `horas` (`id_hora`, `cantidad`, `costo`, `fecha`, `id_empleado`, `estado`) VALUES
(1, NULL, NULL, NULL, NULL, 1),
(2, 5, 5, '2020-04-17', 1, 1);

-- --------------------------------------------------------


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfiles`
--

CREATE TABLE `perfiles` (
  `id_perfil` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `perfiles`
--

INSERT INTO `perfiles` (`id_perfil`, `nombre`, `descripcion`, `estado`) VALUES
(2, 'Gerentes', 'Experiencia en programacion ', 1);

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
(4, '2020-04-01', '2020-04-30', 'Prueba3', 1),
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
(19, '2020-04-13', '2020-04-13', '', 1);

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
  `id_empleado` int(11) DEFAULT NULL,
  `id_area` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `detalles` varchar(45) DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `motivo` varchar(45) DEFAULT NULL,
  `id_puesto` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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



-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_comisiones`
--

CREATE TABLE `tipo_comisiones` (
  `id_tipo_comisiones` int(11) NOT NULL,
  `nombre` varchar(65) DEFAULT NULL,
  `isPercentage` bit(1) DEFAULT NULL,
  `valor` decimal(15,2) DEFAULT NULL,
  `estatus` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipo_comisiones`
--

INSERT INTO `tipo_comisiones` (`id_tipo_comisiones`, `nombre`, `isPercentage`, `valor`, `estatus`) VALUES
(1, 'Comision por venta', b'1', '1.00', 5);

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
(3, 'Bono 14', 1);

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
  ADD KEY `perfilss_idx` (`id_perfil`);




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
  ADD KEY `empleead_idx` (`id_empleado`),
  ADD KEY `puess_idx` (`id_puesto`);

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
  MODIFY `id_concepto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT de la tabla `documentos`
--
ALTER TABLE `documentos`
  MODIFY `id_documentos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `id_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT de la tabla `empleos`
--
ALTER TABLE `empleos`
  MODIFY `id_empleos` int(11) NOT NULL AUTO_INCREMENT;




--
-- AUTO_INCREMENT de la tabla `horas`
--
ALTER TABLE `horas`
  MODIFY `id_hora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;


--
-- AUTO_INCREMENT de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `id_perfil` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `planilla`
--
ALTER TABLE `planilla`
  MODIFY `id_planilla` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;


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
-- AUTO_INCREMENT de la tabla `sueldos`
--
ALTER TABLE `sueldos`
  MODIFY `id_sueldo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;



--
-- AUTO_INCREMENT de la tabla `tipo_comisiones`
--
ALTER TABLE `tipo_comisiones`
  MODIFY `id_tipo_comisiones` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tipo_concepto`
--
ALTER TABLE `tipo_concepto`
  MODIFY `id_tipo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

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
  ADD CONSTRAINT `fk_empleados_comisiones` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`id_empleado`),
   ADD CONSTRAINT `fk_tipo_comisiones_comisiones` FOREIGN KEY (`id_tipo_comisiones`) REFERENCES `tipo_comisiones` (`id_tipo_comisiones`);

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
  ADD CONSTRAINT `perfilss` FOREIGN KEY (`id_perfil`) REFERENCES `perfiles` (`id_perfil`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `solicitudd` FOREIGN KEY (`id_solicitud`) REFERENCES `solicitudes` (`id_solicitud`) ON DELETE CASCADE ON UPDATE CASCADE;


--
-- Filtros para la tabla `finiqito`
--
ALTER TABLE `finiqito`
  ADD CONSTRAINT `immm` FOREIGN KEY (`id_empleados`) REFERENCES `despidos` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE;

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
  ADD CONSTRAINT `empleead` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `puess` FOREIGN KEY (`id_puesto`) REFERENCES `puestos` (`id_puesto`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

