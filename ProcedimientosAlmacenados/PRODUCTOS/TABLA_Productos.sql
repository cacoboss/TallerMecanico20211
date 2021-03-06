--Crear Tabla Productos
CREATE TABLE Productos(
	CodigoProducto			INT PRIMARY KEY IDENTITY,
	CodigoCategoria			INT,
	DescripcionProducto		TEXT,
	ValorUnitarioCompra		REAL,
	ValorUnitarioVenta		REAL,
	Marca					NVARCHAR(50),
	FechaCreacion			DATETIME,
	FechaModificacion		DATETIME

	CONSTRAINT FK_Productos_Categoria
		FOREIGN KEY (CodigoCategoria) REFERENCES Categoria (IdCategoria)
);
--  -> Falta la Relacion 1:N de Producto Con Proveedores

-- Agregar Nombre Producto
ALTER TABLE Productos
ADD
	NombreProducto		NVARCHAR(50) NOT NULL;