-- Base independiente: no modifica db_sistema_login ni utiliza el archivo de pruebas.
CREATE DATABASE IF NOT EXISTS db_sistema_login_mvp CHARACTER SET utf8mb4;
USE db_sistema_login_mvp;
CREATE TABLE IF NOT EXISTS usuarios (
 id INT AUTO_INCREMENT PRIMARY KEY,
 dsId VARCHAR(50) NOT NULL UNIQUE,
 dsUsuario VARCHAR(50) NOT NULL UNIQUE,
 dsPassword VARCHAR(255) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
 dsEstado CHAR(1) NOT NULL DEFAULT '1',
 dtFechaCreacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);
-- INSERT IGNORE permite volver a ejecutar sin reemplazar usuarios existentes.
INSERT IGNORE INTO usuarios (dsId,dsUsuario,dsPassword,dsEstado) VALUES
('001','admin','PBKDF2-SHA256$600000$N8nKWgTzw+eyUQSgO2x5nw==$Hj9mxjMqkQaXMsE5r9F4YFelfbGOLD0uFuV/mh+3F5Q=','1'),
('002','luis','PBKDF2-SHA256$600000$5cNJm+qdJe7rgAd/t2qnuA==$khuppp1NoRIoY+/NFVCGbyLx/tZNhV2ryeOEE9kUrVM=','1'),
('003','cristell','PBKDF2-SHA256$600000$bmhnffg/9O3j6C9+GwgVew==$Yz3Nk0esIV5z4efplRO9q33oDliOk9acYeMH0EgfIzA=','1'),
('004','carlos','PBKDF2-SHA256$600000$tfyijIY1d12aBWKbU/ZTrQ==$9anBzLgsKZ7/8vk6vbfMkG3r3WYeCpXRP/0T7StkpkA=','0');

-- Perfil de sesión. Actualización aditiva para instalaciones de la versión anterior.
DELIMITER //
DROP PROCEDURE IF EXISTS sp_lab_actualizar_perfil//
CREATE PROCEDURE sp_lab_actualizar_perfil()
BEGIN
 IF NOT EXISTS (SELECT 1 FROM information_schema.COLUMNS WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME='usuarios' AND COLUMN_NAME='nombreCompleto') THEN
  ALTER TABLE usuarios ADD COLUMN nombreCompleto VARCHAR(100) NOT NULL DEFAULT '';
 END IF;
 IF NOT EXISTS (SELECT 1 FROM information_schema.COLUMNS WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME='usuarios' AND COLUMN_NAME='correo') THEN
  ALTER TABLE usuarios ADD COLUMN correo VARCHAR(120) NOT NULL DEFAULT '';
 END IF;
 IF NOT EXISTS (SELECT 1 FROM information_schema.COLUMNS WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME='usuarios' AND COLUMN_NAME='rol') THEN
  ALTER TABLE usuarios ADD COLUMN rol VARCHAR(50) NOT NULL DEFAULT 'Operador';
 END IF;
END//
CALL sp_lab_actualizar_perfil()//
DROP PROCEDURE sp_lab_actualizar_perfil//
DELIMITER ;

-- Datos de ejemplo: completa solo perfiles vacíos; no cambia contraseñas.
UPDATE usuarios SET nombreCompleto='Administrador de demostración', correo='admin@example.com', rol='Administrador'
WHERE dsUsuario='admin' AND nombreCompleto='';
UPDATE usuarios SET nombreCompleto='Luis (demostración)', correo='luis@example.com', rol='Operador'
WHERE dsUsuario='luis' AND nombreCompleto='';
UPDATE usuarios SET nombreCompleto='Cristell (demostración)', correo='cristell@example.com', rol='Operador'
WHERE dsUsuario='cristell' AND nombreCompleto='';
UPDATE usuarios SET nombreCompleto='Carlos (demostración)', correo='carlos@example.com', rol='Operador'
WHERE dsUsuario='carlos' AND nombreCompleto='';

CREATE TABLE IF NOT EXISTS clientes (
 id INT AUTO_INCREMENT PRIMARY KEY,
 nombre VARCHAR(100) NOT NULL,
 documento VARCHAR(30) NOT NULL UNIQUE,
 telefono VARCHAR(30) NOT NULL,
 correo VARCHAR(120) NOT NULL
);
CREATE TABLE IF NOT EXISTS empleados (
 id INT AUTO_INCREMENT PRIMARY KEY,
 nombre VARCHAR(100) NOT NULL,
 cargo VARCHAR(80) NOT NULL,
 telefono VARCHAR(30) NOT NULL,
 correo VARCHAR(120) NOT NULL UNIQUE
);
CREATE TABLE IF NOT EXISTS productos (
 id INT AUTO_INCREMENT PRIMARY KEY,
 codigo VARCHAR(30) NOT NULL UNIQUE,
 nombre VARCHAR(100) NOT NULL,
 categoria VARCHAR(60) NOT NULL,
 precio DECIMAL(10,2) NOT NULL,
 stock INT NOT NULL,
 CONSTRAINT ck_precio CHECK (precio >= 0),
 CONSTRAINT ck_stock CHECK (stock >= 0)
);
-- Todas las personas y contactos siguientes son ficticios.
INSERT IGNORE INTO clientes(nombre,documento,telefono,correo) VALUES
('Ana Torres','DEMO-C001','000-0001','ana.torres@example.com'),
('José Ríos','DEMO-C002','000-0002','jose.rios@example.com'),
('María Pérez','DEMO-C003','000-0003','maria.perez@example.com'),
('Daniel Castillo','DEMO-C004','000-0004','daniel.castillo@example.com'),
('Sofía Mendoza','DEMO-C005','000-0005','sofia.mendoza@example.com'),
('Carlos Vega','DEMO-C006','000-0006','carlos.vega@example.com'),
('Valeria Díaz','DEMO-C007','000-0007','valeria.diaz@example.com'),
('Miguel Sánchez','DEMO-C008','000-0008','miguel.sanchez@example.com');
INSERT IGNORE INTO empleados(nombre,cargo,telefono,correo) VALUES
('Laura Gómez','Administración','000-0101','laura.gomez@example.com'),
('Pedro Moreno','Ventas','000-0102','pedro.moreno@example.com'),
('Camila Ruiz','Inventario','000-0103','camila.ruiz@example.com'),
('Andrés López','Atención al cliente','000-0104','andres.lopez@example.com'),
('Elena Vargas','Contabilidad','000-0105','elena.vargas@example.com');
INSERT IGNORE INTO productos(codigo,nombre,categoria,precio,stock) VALUES
('PROD-001','Coca-Cola 600 ml','Bebidas',1.25,48),
('PROD-002','Coca-Cola 2 L','Bebidas',2.50,24),
('PROD-003','Sprite 600 ml','Bebidas',1.25,36),
('PROD-004','Fanta naranja 600 ml','Bebidas',1.25,30),
('PROD-005','Agua 600 ml','Agua',0.85,60),
('PROD-006','Jugo de naranja 1 L','Jugos',1.75,18),
('PROD-007','Té frío 500 ml','Tés',1.10,20),
('PROD-008','Coca-Cola sin azúcar 355 ml','Bebidas',0.95,42);

SELECT 'Clientes' AS catalogo, COUNT(*) AS registros FROM clientes
UNION ALL SELECT 'Empleados', COUNT(*) FROM empleados
UNION ALL SELECT 'Productos', COUNT(*) FROM productos;
