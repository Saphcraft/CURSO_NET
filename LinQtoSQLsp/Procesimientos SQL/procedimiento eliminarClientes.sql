--Crear procedimiento eliminarClientes
CREATE PROCEDURE eliminarClientes
@Nombre varchar(50)
AS
DELETE FROM Clientes 
WHERE Nombre=@Nombre
--ejercutar vista
EXEC eliminarClientes 'PEPE';