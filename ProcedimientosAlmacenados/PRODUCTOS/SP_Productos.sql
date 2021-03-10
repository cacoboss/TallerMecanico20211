--Metodo Producto Insertar
ALTER PROCEDURE SP_Productos_Insertar
	@CODIGOCAT			INT,
	@DESCRIPCION		TEXT,
	@VALORCOMPRA		REAL,
	@VALORVENTA			REAL,
	@MARCA				NVARCHAR(50),
	@NOMBRE				NVARCHAR(50)
AS
INSERT INTO 
Productos (
	CodigoCategoria,
	DescripcionProducto,
	ValorUnitarioCompra,
	ValorUnitarioVenta,
	Marca,
	FechaCreacion,
	FechaModificacion,
	NombreProducto
)
VALUES
(	@CODIGOCAT,
	@DESCRIPCION,
	@VALORCOMPRA,
	@VALORVENTA,
	@MARCA,
	GETDATE(),
	GETDATE(),
	@NOMBRE
)
GO

--Metodo Producto Actualizar
ALTER PROCEDURE SP_Productos_Actualizar
	@ID					INT,
	@CODIGOCAT			INT,
	@DESCRIPCION		TEXT,
	@VALORCOMPRA		REAL,
	@VALORVENTA			REAL,
	@MARCA				NVARCHAR(50),
	@NOMBRE				NVARCHAR(50)
AS
UPDATE Productos
SET
	CodigoCategoria = @CODIGOCAT,
	DescripcionProducto = @DESCRIPCION,
	ValorUnitarioCompra = @VALORCOMPRA,
	ValorUnitarioVenta = @VALORVENTA,
	Marca = @MARCA,
	FechaModificacion = GETDATE(),
	NombreProducto = @NOMBRE
WHERE
	CodigoProducto = @ID
GO

--Metodo Productos Eliminar
CREATE PROCEDURE SP_Productos_Eliminar
	@ID			INT
AS
DELETE FROM Productos
WHERE CodigoProducto = @ID
GO

--Metodo Productos Listar
ALTER PROCEDURE SP_Productos_Listar
AS
SELECT
	CodigoProducto,
	ISNULL(CodigoCategoria, 0) AS CodigoCategoria,
	ISNULL(DescripcionProducto, 'Valor Nulo') AS DescripcionProducto,
	ISNULL(ValorUnitarioCompra, 0) AS ValorUnitarioCompra,
	ISNULL(ValorUnitarioVenta, 0) AS ValorUnitarioVenta,
	ISNULL(Marca, 'Valor Nulo') as Marca,
	ISNULL(NombreProducto, 'Valor Nulo') AS NombreProducto
FROM Productos
GO

--Metodo Productos 
ALTER PROCEDURE SP_Productos_TraerPorID
	@ID			INT
AS
SELECT
	CodigoProducto,
	ISNULL(CodigoCategoria, 0) AS CodigoCategoria,
	ISNULL(DescripcionProducto, 'Valor Nulo') AS DescripcionProducto,
	ISNULL(ValorUnitarioCompra, 0) AS ValorUnitarioCompra,
	ISNULL(ValorUnitarioVenta, 0) AS ValorUnitarioVenta,
	ISNULL(Marca, 'Valor Nulo') as Marca,
	ISNULL(NombreProducto, 'Valor Nulo') AS NombreProducto
FROM Productos
WHERE CodigoProducto = @ID
GO