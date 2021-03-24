--Crear Tabla Productos
CREATE TABLE Productos(
	CodigoProducto			INT PRIMARY KEY IDENTITY,
	CodigoCategoria			INT,
	DescripcionProducto		TEXT,
	ValorUnitarioCompra		REAL,
	Marca					NVARCHAR(50),
	FechaCreacion			DATETIME,
	FechaModificacion		DATETIME,
	NombreProducto			varchar(50),
	CodigoProveedor			int,


	CONSTRAINT FK_Productos_Categoria
		FOREIGN KEY (CodigoCategoria) REFERENCES Categoria (IdCategoria),

	CONSTRAINT FK_Productos_Proveedor
	FOREIGN KEY (CodigoProveedor) REFERENCES Proveedor (CodigoProveedor)

);
--  -> Falta la Relacion 1:N de Producto Con Proveedores

-- Agregar Nombre Producto
ALTER TABLE Productos
ADD
	NombreProducto		NVARCHAR(50) NOT NULL;