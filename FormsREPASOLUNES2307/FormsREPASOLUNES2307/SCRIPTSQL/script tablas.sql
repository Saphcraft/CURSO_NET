--CREAR TABLAS
--cliente
CREATE TABLE CLIENTE (
IDCLIENTE VARCHAR(5),
APELLIDOS VARCHAR(30),
NOMBRES VARCHAR(30)
CONSTRAINT PK_CLIENTE PRIMARY KEY (IDCLIENTE)
);

--cuenta
CREATE TABLE CUENTA(
IDCLIENTE VARCHAR(5),
IDCUENTA VARCHAR(5),
SALDO FLOAT,
DIVISA VARCHAR(20)
CONSTRAINT PK_CUENTA PRIMARY KEY (IDCUENTA),
CONSTRAINT FK_CUENTA_CLIENTE FOREIGN KEY (IDCLIENTE)
REFERENCES CLIENTE (IDCLIENTE)
);

--movimiento
CREATE TABLE MOVIMIENTO(
IDCUENTA VARCHAR(5),
IDMOVIMIENTO VARCHAR(5),
TIPO VARCHAR(20),
MONTO FLOAT,
FECHA DATE,

CONSTRAINT PK_MOVIMIENTO PRIMARY KEY (IDMOVIMIENTO), 
CONSTRAINT FK_MOVIMIENTO_CUENTA FOREIGN KEY (IDCUENTA) 
REFERENCES CUENTA (IDCUENTA)
);

