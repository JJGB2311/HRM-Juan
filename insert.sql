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
CREATE TABLE empresa (
  id_empresa INT AUTO_INCREMENT,
  nombre VARCHAR(255),
  NIT VARCHAR(255),
  logo MEDIUMBLOB,
  direccion VARCHAR(255),
  estatus TINYINT(1),
  CONSTRAINT pk_empresa PRIMARY KEY (id_empresa));
  
  INSERT INTO empresa(id_empresa, nombre, estatus) 
  VALUES (1, 'Risko', 1);
  
  CREATE TABLE cliente (
  id_cliente INT AUTO_INCREMENT,
  id_empresa INT,
  CUI VARCHAR(35) UNIQUE,
  NIT VARCHAR(35) UNIQUE,
  nombres VARCHAR(64),
  apellidos VARCHAR(64),
  fecha_nacimiento DATE,
  genero ENUM('F', 'M', 'O'),
  fotografia MEDIUMBLOB,
  nacionalidad VARCHAR(64),
  direccion VARCHAR(255),
  telefono VARCHAR(20),
  correo VARCHAR(255),
  limite_credito DECIMAL(15,2),
  fecha_creacion DATE,
  ocupacion VARCHAR(35),
  empresa VARCHAR(35),
  estatus TINYINT(1),
  CONSTRAINT fk_empresa_cliente FOREIGN KEY (id_empresa) REFERENCES empresa (id_empresa),
  CONSTRAINT pk_cliente PRIMARY KEY (id_cliente));
  
  INSERT INTO cliente(id_cliente, id_empresa, CUI, NIT, nombres, apellidos, direccion) 
  VALUES(1, 1, '41147771212', '1277354-9', 'Victor Lisandro', 'Fernandez Santizo', '2da calle 12-61 Condominio Mariano Galvez, Zona 2');

CREATE TABLE tipo_comisiones (
  id_tipo_comisiones INT AUTO_INCREMENT,
  nombre VARCHAR(65),
  isPercentage BIT, 
  valor DECIMAL(15,2),
  estatus TINYINT(1),
  CONSTRAINT pk_tipo_comisiones PRIMARY KEY (id_tipo_comisiones)
);









CREATE TABLE IF NOT EXISTS `tipos_productos` (
  `id_tipo_producto` INT NOT NULL AUTO_INCREMENT,
  `nombre_tipo_producto` VARCHAR(45) NULL,
  `descripcion_tipo_producto` text NULL,
  `ESTADO` tinyint NULL,
  
  PRIMARY KEY (`id_tipo_producto`))
ENGINE = InnoDB;
INSERT INTO tipos_productos VALUES(1, 'Tipo producto Numero 1', 'No hay', 1);
-- -----------------------------------------------------
-- Table `bienestar_crm1`.`impuestos`
-- -----------------------------------------------------



CREATE TABLE IF NOT EXISTS `impuestos` (
  `id_impuesto` INT NOT NULL AUTO_INCREMENT,
  `nombre_impuesto` VARCHAR(45) NULL,
  `descripcion_impuesto` text NULL,
  `tasa_impuesto` DOUBLE NULL,
  `ESTADO` TINYINT DEFAULT 1,
  PRIMARY KEY (`id_impuesto`))
ENGINE = InnoDB;

INSERT INTO impuestos VALUES(1, 'IVA', 'Impuesto del IVA', 12.5, 1);
-- -----------------------------------------------------
-- Table `bienestar_crm1`.`categorias`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `categorias` ;

CREATE TABLE IF NOT EXISTS `categorias` (
  `id_categoria` INT NOT NULL AUTO_INCREMENT,
  `nombre_categoria` VARCHAR(45) NULL,
  `descripcion_categoria` text NULL,
  `ESTADO` TINYINT DEFAULT 1,
  PRIMARY KEY (`id_categoria`))
ENGINE = InnoDB;

INSERT INTO categorias VALUES (1, 'Categoria Numero 1', 'No hay descripcion', 1);



insert into productos VALUES(1, 1, 1, 1, 'Producto Numero 1', 'Descripcion del producto', 100, 200, 10, 200, 1);

CREATE TABLE IF NOT EXISTS `productos` (
  `id_producto` INT NOT NULL AUTO_INCREMENT,
  `id_tipo_producto` INT NOT NULL,
  `id_impuesto` INT NOT NULL,
  `id_categoria` INT NOT NULL,
  `nombre_producto` VARCHAR(45) NULL,
  `descripcion_producto` text NULL,
  `costo_producto` DOUBLE NULL,
  `precio_producto` DOUBLE NULL,
  `cantidad_maxima_producto` INT NULL,
  `cantidad_minima_producto` INT NULL,
  `ESTADO` TINYINT DEFAULT 1,
  PRIMARY KEY (`id_producto`),
  CONSTRAINT `fk_productos_tipos_productos1`
    FOREIGN KEY (`id_tipo_producto`)
    REFERENCES `tipos_productos` (`id_tipo_producto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_productos_impuestos1`
    FOREIGN KEY (`id_impuesto`)
    REFERENCES `impuestos` (`id_impuesto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_productos_categorias1`
    FOREIGN KEY (`id_categoria`)
    REFERENCES `categorias` (`id_categoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE factura (
  id_factura INT AUTO_INCREMENT,
  id_empresa INT,
  id_cliente INT,
  id_empleado INT,
  numero_factura VARCHAR(36),
  fecha_emision DATETIME,
  total DECIMAL(15,2),
  estatus TINYINT(1),
  CONSTRAINT fk_empresa_factura FOREIGN KEY (id_empresa) REFERENCES empresa (id_empresa),
  CONSTRAINT fk_cliente_factura FOREIGN KEY (id_cliente) REFERENCES cliente (id_cliente),
  CONSTRAINT fk_empleado_factura FOREIGN KEY (id_empleado) REFERENCES empleados (id_empleado),
  CONSTRAINT pk_factura PRIMARY KEY (id_factura));
  
  INSERT INTO factura(id_factura, id_empresa, id_cliente, id_empleado, numero_factura, total, estatus)
  VALUES(1, 1, 1, 1, '1', 100, 1);

  INSERT INTO factura(id_factura, id_empresa, id_cliente, id_empleado, numero_factura, total, estatus)
  VALUES(2, 1, 1, 1, '1', 100, 1);

  INSERT INTO detalle_factura VALUES(2, 2, 1, 1, 20, 20, 1);

CREATE TABLE detalle_factura (
  id_detalle_factura INT,
  id_factura INT,
  id_producto INT,
  cantidad INT,
  precio_unitario DECIMAL(15,2),
  subtotal DECIMAL(15,2),
  estatus TINYINT(1),
  CONSTRAINT fk_factura_detalle_factura FOREIGN KEY (id_factura) REFERENCES factura (id_factura),
  CONSTRAINT fk_producto_detalle_factura FOREIGN KEY (id_producto) REFERENCES productos (id_producto),
  CONSTRAINT pk_detalle_factura PRIMARY KEY (id_factura, id_detalle_factura));
  

  
  INSERT INTO tipo_comisiones VALUES (1, 'Comision por venta', 1, 1, 5);
  
  CREATE TABLE tipo_comisiones (
  id_tipo_comisiones INT AUTO_INCREMENT,
  nombre VARCHAR(65),
  estatus TINYINT(1),
  isPercentage BIT, 
  valor DECIMAL(15,2),
  CONSTRAINT pk_tipo_comisiones PRIMARY KEY (id_tipo_comisiones)
);



CREATE TABLE comisiones (
  id_comisiones INT AUTO_INCREMENT,
  id_tipo_comisiones INT,
  id_empleado INT,
  id_factura INT,
  estatus TINYINT(1),
  CONSTRAINT fk_tipo_comisiones_comisiones FOREIGN KEY (id_tipo_comisiones) REFERENCES tipo_comisiones (id_tipo_comisiones),
  CONSTRAINT fk_empleados_comisiones FOREIGN KEY (id_empleado) REFERENCES empleados (id_empleado),
  CONSTRAINT fk_factura_comisiones FOREIGN KEY (id_factura) REFERENCES factura (id_factura),
  CONSTRAINT pk_comisiones PRIMARY KEY (id_comisiones)
);
INSERT INTO comisiones VALUES(1, 1, 1, 1, 1);


INSERT INTO comisiones VALUES(2, 1, 1, 2, 1);