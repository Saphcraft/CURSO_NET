--7º) Crear un procedimiento almacenado para eliminar un cliente
CREATE PROCEDURE spDeleteCustomer
@IDCLIENTE VARCHAR(5)
AS
DELETE FROM CLIENTE
WHERE IDCLIENTE=@IDCLIENTE;