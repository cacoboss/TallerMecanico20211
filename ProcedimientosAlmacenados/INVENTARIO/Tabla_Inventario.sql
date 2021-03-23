/*
	Creación de la tabla y relaciones
*/

--Tabla Inventario
CREATE TABLE Inventarios(
	Consecutivo			INT PRIMARY KEY IDENTITY,
	IdProducto			INT NOT NULL,		--FK
	IdProveedor			INT NULL,			--FK
	ValorUnitario		REAL NOT NULL,
	Cantidad			INT NOT NULL,
	FechaOperacion		DATETIME NOT NULL,
	CompraVenta			BIT);

ALTER TABLE Inventarios
	ADD CONSTRAINT FK_Inventarios_Proveedor
	FOREIGN KEY (IdProveedor)
	REFERENCES Proveedor(CodigoProveedor)
	ON UPDATE CASCADE
	ON DELETE NO ACTION;

ALTER TABLE Inventarios
	ADD CONSTRAINT FK_Inventarios_Producto
	FOREIGN KEY (IdProducto)
	REFERENCES Productos(CodigoProducto)
	ON UPDATE CASCADE
	ON DELETE NO ACTION;

/*
	Procedimientos almacenados sobre la tabla
*/
--Procedimiento (Insertar Operación): Permite insertar una nueva operación dentro de la tabla.
CREATE PROCEDURE SP_Inventarios_InsertarOperacion
	@IDPRODUCTO	INT,
	@VALOR		REAL,
	@CANTIDAD	INT,
	@TIPO		BIT
AS
INSERT INTO Inventarios
(IdProducto, ValorUnitario, Cantidad, FechaOperacion, CompraVenta)
VALUES
(@IDPRODUCTO, @VALOR, @CANTIDAD, GETDATE(), @TIPO)
GO


/*
	Consultas de pruabas y funcionamiento
*/
--Operacion de Compra Venta para pruebas
INSERT INTO Inventarios
(IdProducto, ValorUnitario, Cantidad, FechaOperacion, CompraVenta)
VALUES
(2,426800.30,3,GETDATE(),1),	--Operacion Compra
(2,426800.30,-2,GETDATE(),0),
(6,25684000,3,GETDATE(),1),	--Operacion Compra
(6,3000000,-1,GETDATE(),0)

--Seleccion de conteo
SELECT 
	SUM(Cantidad) AS Subtotal,
	Productos.NombreProducto
FROM INVENTARIOS, Productos
WHERE Productos.CodigoProducto = Inventarios.IdProducto
GROUP BY Productos.NombreProducto

SELECT
	Inventarios.Cantidad, Productos.NombreProducto
FROM Inventarios
INNER JOIN Productos ON Inventarios.IdProducto = Productos.CodigoProducto