--Crear procedimiento buscarClientes
CREATE PROCEDURE buscarClientes
@Nombre varchar(50)
AS
SELECT * FROM Clientes 
WHERE Nombre LIKE '%' + @Nombre + '%';
--ejercutar vista
EXEC buscarClientes 'SARUMAN';