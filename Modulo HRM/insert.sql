
INSERT INTO `sueldos` (`id_sueldo`, `salario_por_hora`, `salario`, `estado`) VALUES (NULL, '90', '5000', '1');
INSERT INTO `sueldos` (`id_sueldo`, `salario_por_hora`, `salario`, `estado`) VALUES (NULL, '95', '6000', '1');

INSERT INTO `puestos` (`id_puesto`, `nombre`, `id_sueldo`, `estado`) VALUES (NULL, 'Gerente', '1', '1');


INSERT INTO `area` (`id_area`, `nombre`, `estado`) VALUES (NULL, 'Recursos Humanos ', '1');

INSERT INTO `empleados` (`id_empleado`, `nombre`, `apellido`, `sexo`, `edad`, `correo`, `id_puesto`, `id_area`, `estado`) VALUES (NULL, 'juan jose', 'Gamez Blanco', 'Masculino', '22', 'juan@hotmail.com', '1', '1', '1');


INSERT INTO `tipo_concepto` (`id_tipo`, `nombre`, `estado`) VALUES (NULL, 'Bonificacion', '1');

INSERT INTO `conceptos` (`id_concepto`, `id_empleado`, `fecha`, `id_tipo`, `monto`, `debe_Haber`, `estado`) VALUES (NULL, '1', '1111-11-11', '1', '300', '1', '1');
