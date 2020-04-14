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


INSERT INTO `planilla` (`id_planilla`, `fecha`, `Nombre`, `estado`) VALUES (NULL, '2020-04-13', 'Bienestar S.A', '1');

CREATE TABLE `ayuda` (
  	`Id_ayuda` int(11) NOT NULL,
  	`Ruta` text COLLATE utf8_unicode_ci NOT NULL,
 	`indice` text COLLATE utf8_unicode_ci NOT NULL
	) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

	INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`) VALUES
	(1, 'Página web ayuda/ayuda.chm', 'menu.html'),
	(2, 'Página web ayuda/ayuda.chm', 'Menúboletos.html');