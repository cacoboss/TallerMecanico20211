
CREATE TABLE [dbo].[ProveedorProductos](
	[Consecutivo] [int] IDENTITY(1,1) NOT NULL,
	[CodigoProveedor] [int] NULL,
	[CodigoProducto] [int] NULL,
	[FechaCreacion] [datetime] NULL,
	[FechaModificacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Consecutivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ProveedorProductos]  WITH CHECK ADD  CONSTRAINT [FK_ProveedorProductos_Producto] FOREIGN KEY([CodigoProducto])
REFERENCES [dbo].[Productos] ([CodigoProducto])
GO

ALTER TABLE [dbo].[ProveedorProductos] CHECK CONSTRAINT [FK_ProveedorProductos_Producto]
GO

ALTER TABLE [dbo].[ProveedorProductos]  WITH CHECK ADD  CONSTRAINT [FK_ProveedorPRoductos_Proveedor] FOREIGN KEY([CodigoProveedor])
REFERENCES [dbo].[Proveedor] ([CodigoProveedor])
GO

ALTER TABLE [dbo].[ProveedorProductos] CHECK CONSTRAINT [FK_ProveedorPRoductos_Proveedor]
GO





ALTER PROCEDURE [dbo].[SP_ProveedorProducto_Insertar]
	@CODIGOPRODUCTO				INT,
	@CODIGOPROVEEDOR			INT

AS
INSERT INTO 
ProveedorProductos (
	CodigoProducto,
	CodigoProveedor,
	FechaCreacion,
	FechaModificacion

)
VALUES
(	@CODIGOPRODUCTO,
	@CODIGOPROVEEDOR,
	GETDATE(),
	GETDATE()
)



ALTER PROCEDURE [dbo].[SP_ProveedorProducto_Actualizar]
	@ID					INT,
	@CODIGOPRODUCTO		INT,
	@CODIGOPROVEEDOR	INT

AS
UPDATE ProveedorProductos
SET
	CodigoProducto = @CODIGOPRODUCTO,
	CodigoProveedor = @CODIGOPROVEEDOR

	
WHERE
	Consecutivo = @ID




ALTER PROCEDURE [dbo].[SP_ListarProveedorProducto]
AS
SELECT
	Consecutivo,
	ISNULL(CodigoProveedor, 0) AS CodigoProveedor,
	ISNULL(CodigoProducto, 0) AS CodigoProducto


FROM ProveedorProductos


ALTER PROCEDURE [dbo].[SP_EliminarProductoProveedor]
	@ID			INT
AS
DELETE FROM ProveedorProductos
WHERE Consecutivo = @ID



ALTER PROCEDURE [dbo].[SP_TraerProductoProveedorPorId]
	@ID			INT
AS
SELECT
	Consecutivo,
	ISNULL(CodigoProveedor, 0) AS CodigoProveedor,
	ISNULL(CodigoProducto, 0) AS CodigoProducto

FROM ProveedorProductos
WHERE Consecutivo = @ID
