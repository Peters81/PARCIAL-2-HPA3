-- Ejecutar como root después de 01_instalar.sql.
-- Cuenta de la práctica local. Usa la misma contraseña en la variable de entorno.
-- IF NOT EXISTS permite repetirlo sin el error "usuario ya existe".
-- Si la cuenta ya existe, su contraseña se conserva (en tu instalación es peters).
CREATE USER IF NOT EXISTS 'lab_capas_app'@'localhost' IDENTIFIED BY 'peters';
GRANT SELECT (id,dsId,dsUsuario,dsPassword,dsEstado,nombreCompleto,correo,rol)
ON db_sistema_login_mvp.usuarios TO 'lab_capas_app'@'localhost';
GRANT SELECT ON db_sistema_login_mvp.clientes TO 'lab_capas_app'@'localhost';
GRANT SELECT ON db_sistema_login_mvp.empleados TO 'lab_capas_app'@'localhost';
GRANT SELECT ON db_sistema_login_mvp.productos TO 'lab_capas_app'@'localhost';
SHOW GRANTS FOR 'lab_capas_app'@'localhost';
