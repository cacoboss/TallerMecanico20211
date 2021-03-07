--Crear Tabla
CREATE TABLE ProveedorProductos (
	Consecutivo				INT PRIMARY KEY IDENTITY,
	CodigoProveedor			INT,
	CodigoProducto			INT,
	FechaCreacion			DATETIME,
	FechaModificacion		DATETIME
);

--Agregar Llave Foranea con Productos
ALTER TABLE ProveedorProductos
	ADD CONSTRAINT FK_ProveedorProductos_Producto
	FOREIGN  KEY (CodigoProducto)
	REFERENCES Productos (CodigoProducto);
ALTER TABLE ProveedorProductos
	ADD CONSTRAINT FK_ProveedorPRoductos_Proveedor
	FOREIGN KEY (CodigoProveedor)
	REFERENCES Proveedor (CodigoProveedor);