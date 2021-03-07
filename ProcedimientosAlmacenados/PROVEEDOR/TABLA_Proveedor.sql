--Crear Tabla Proveedor
CREATE TABLE Proveedor (
	CodigoProveedor				INT PRIMARY KEY IDENTITY,
	NombreProveedor				NVARCHAR(50),
	DescripcionProveedor		TEXT,
	FechaCreacion				DATETIME,
	FechaModificacion			DATETIME
);