--5?) Crear un procedimiento almacenado para a?adir clientes
CREATE PROCEDURE spAddCustomer
@IDCLIENTE VARCHAR(5),
@APELLIDOS VARCHAR(30),
@NOMBRES VARCHAR(30)
AS
INSERT INTO CLIENTE(IDCLIENTE,APELLIDOS,NOMBRES)
VALUES(@IDCLIENTE,@APELLIDOS,@NOMBRES);