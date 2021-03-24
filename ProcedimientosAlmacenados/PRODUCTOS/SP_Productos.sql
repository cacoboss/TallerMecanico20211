--Metodo Producto Insertar
CREATE PROCEDURE SP_Productos_Insertar
	@CODIGOCAT			INT,
	@DESCRIPCION		TEXT,
	@VALORCOMPRA		REAL,
	@MARCA				NVARCHAR(50),
	@NOMBRE				NVARCHAR(50),
	@PROVEEDOR			INT
AS
INSERT INTO 
Productos (
	CodigoCategoria,
	DescripcionProducto,
	ValorUnitarioCompra,
	Marca,
	FechaCreacion,
	FechaModificacion,
	NombreProducto,
	CodigoProveedor

)
VALUES
(	@CODIGOCAT,
	@DESCRIPCION,
	@VALORCOMPRA,
	@MARCA,
	GETDATE(),
	GETDATE(),
	@NOMBRE,
	@PROVEEDOR
)
GO


--Metodo Producto Actualizar
CREATE PROCEDURE SP_Productos_Actualizar
	@ID					INT,
	@CODIGOCAT			INT,
	@DESCRIPCION		TEXT,
	@VALORCOMPRA		REAL,
	@MARCA				NVARCHAR(50),
	@NOMBRE				NVARCHAR(50),
	@PROVEEDOR			INT
AS
UPDATE Productos
SET
	CodigoCategoria = @CODIGOCAT,
	DescripcionProducto = @DESCRIPCION,
	ValorUnitarioCompra = @VALORCOMPRA,
	Marca = @MARCA,
	FechaModificacion = GETDATE(),
	NombreProducto = @NOMBRE,
	CodigoProveedor = @PROVEEDOR
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
create PROCEDURE SP_Productos_Listar
AS
SELECT
	CodigoProducto,
	ISNULL(CodigoCategoria, 0) AS CodigoCategoria,
	ISNULL(DescripcionProducto, 'Valor Nulo') AS DescripcionProducto,
	ISNULL(ValorUnitarioCompra, 0) AS ValorUnitarioCompra,
	ISNULL(Marca, 'Valor Nulo') as Marca,
	ISNULL(NombreProducto, 'Valor Nulo') AS NombreProducto,
	ISNULL(CodigoProveedor, 'Valor Nulo') AS CodigoProveedor

FROM Productos
GO

--Metodo Productos 
create PROCEDURE SP_Productos_TraerPorID
	@ID			INT
AS
SELECT
	CodigoProducto,
	ISNULL(CodigoCategoria, 0) AS CodigoCategoria,
	ISNULL(DescripcionProducto, 'Valor Nulo') AS DescripcionProducto,
	ISNULL(ValorUnitarioCompra, 0) AS ValorUnitarioCompra,
	ISNULL(Marca, 'Valor Nulo') as Marca,
	ISNULL(NombreProducto, 'Valor Nulo') AS NombreProducto,
	ISNULL(CodigoProveedor, 'Valor Nulo') AS CodigoProveedor

FROM Productos
WHERE CodigoProducto = @ID
GO
