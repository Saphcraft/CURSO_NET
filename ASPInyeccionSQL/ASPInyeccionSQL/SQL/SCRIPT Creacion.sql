CREATE DATABASE base1
GO

USE base1
GO
CREATE TABLE usuarios(
nombre NVARCHAR(30) PRIMARY KEY,
clave NVARCHAR(30),
mail NVARCHAR(70)
)
GO