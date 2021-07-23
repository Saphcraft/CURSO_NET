--Crear procedimiento para insertarClientes
CREATE PROCEDURE insertarCliente
@Nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
INSERT INTO Clientes (Nombre,Apellido1,Apellido2,Telefno)
VALUES (@Nombre,@Apellido1,@Apellido2,@telefono)
GO
--ejecutar vista
EXEC insertarCliente 'GANDALF','EL', 'OLVIDADO', '123456789';