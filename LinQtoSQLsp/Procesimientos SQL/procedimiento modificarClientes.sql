--Crear procedimiento para modificarClientes
CREATE PROCEDURE modificarClientes
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
UPDATE Clientes
SET 
Nombre=@Nombre,
Apellido1=@Apellido1,
Apellido2=@Apellido2,
Telefno=@telefono
WHERE Nombre=@Nombre
GO
--ejecutar vista
EXEC modificarClientes 'PEPE','EL', 'GRIS', 'XXXXXXX';
