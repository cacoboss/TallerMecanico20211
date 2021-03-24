--SP: InsertarProveedor
CREATE PROCEDURE SP_Proveedor_Insertar
	@NOMBRE			NVARCHAR(50),
	@DESCRIPCION	TEXT
AS
INSERT INTO 
	Proveedor (NombreProveedor, DescripcionProveedor, FechaCreacion, FechaModificacion)
VALUES
	(@NOMBRE,@DESCRIPCION, GETDATE(), GETDATE());

--SP: Actualizar Proveedor
CREATE PROCEDURE SP_Proveedor_Actualizar
	@ID				INT,
	@NOMBRE			NVARCHAR(50),
	@DESCRIPCION	TEXT
AS
UPDATE Proveedor
SET
	NombreProveedor			= @NOMBRE,
	DescripcionProveedor	= @DESCRIPCION,
	FechaModificacion		= GETDATE()
WHERE
	CodigoProveedor			= @ID;

--SP: Eliminar Proveedor
CREATE PROCEDURE SP_Proveedor_Eliminar
	@ID			INT
AS
DELETE FROM Proveedor
WHERE CodigoProveedor = @ID;

--SP: Listar Proveedores
CREATE PROCEDURE SP_Proveedor_Listar
AS
SELECT
	CodigoProveedor, 
	ISNULL(NombreProveedor,'Nombre Vacio'),
	ISNULL(DescripcionProveedor,'Descripcion Vacia')
FROM Proveedor;

ALTER PROCEDURE SP_Proveedor_Listar
AS
SELECT
	CodigoProveedor, 
	ISNULL(NombreProveedor,'Nombre Vacio') AS NombreProveedor,
	ISNULL(DescripcionProveedor,'Descripcion Vacia') AS DescripcionProveedor
FROM Proveedor;

-- SP: Traer por ID Proveedor
ALTER PROCEDURE SP_Proveedor_TraerPorID
	@ID		INT
AS
SELECT 
	CodigoProveedor,
	ISNULL(NombreProveedor,'Nombre Vacio') AS NombreProveedor,
	ISNULL(DescripcionProveedor,'Descripcion Vacia') AS DescripcionProveedor
FROM
	Proveedor
WHERE
	CodigoProveedor = @ID;


	select * from Proveedor