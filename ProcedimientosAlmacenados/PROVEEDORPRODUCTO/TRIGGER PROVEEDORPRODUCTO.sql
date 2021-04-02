USE [TallerMecanico]
GO

/****** Object:  Trigger [dbo].[RegistraAuditoria]    Script Date: 2/04/2021 6:21:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[RegistraAuditoria]
   ON  [dbo].[ProveedorProductos]
   AFTER INSERT,DELETE,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	DECLARE @REGISTRO INT
	DECLARE @NUEVO_PROVEEDOR INT 
	DECLARE @ANTERIOR_PROVEEDOR INT 
	DECLARE @NUEVO_PRODUCTO INT 
	DECLARE @ANTERIOR_PRODUCTO INT 
	DECLARE @FECHA_REGISTRO DATETIME
	DECLARE @ACCION VARCHAR (20)
	DECLARE @CAMPO VARCHAR (20)
	DECLARE @CAMPO2 VARCHAR (20)


	if exists (select * from inserted) and not exists (select * from deleted)
		begin 
			SET  @ACCION ='crea'
		

			
			Select @REGISTRO=i.Consecutivo, @NUEVO_PROVEEDOR=i.CodigoProveedor,
				   @NUEVO_PRODUCTO=i.Codigoproducto
		
				from inserted as i 

				insert into [dbo].[Audita] (Accion, Registro, CodigoProveedor, CodigoProducto,Campo,Campo2)
				values (@ACCION,@REGISTRO,@NUEVO_PROVEEDOR,@NUEVO_PRODUCTO, @CAMPO,@CAMPO2)
	end 

	if exists (select * from  inserted) and  exists (select * from deleted)
		begin 
			set @ACCION='Edita'
			select @REGISTRO=i.Consecutivo,
			@NUEVO_PROVEEDOR=i.CodigoProveedor,
			@ANTERIOR_PROVEEDOR=d.CodigoProveedor,
			@NUEVO_PRODUCTO=i.CodigoProducto,
			@ANTERIOR_PRODUCTO=d.CodigoProducto


			from deleted as d 
			join inserted as i 
			on d.Consecutivo=i.Consecutivo
			
			if  @NUEVO_PROVEEDOR<>@ANTERIOR_PROVEEDOR

			begin 

				SET  @CAMPO = 'CodigoProveedor'

			

			insert into [dbo].[Audita] (Accion, Registro,CodigoProveedor,CodigoProducto,campo)
			values (@ACCION,@REGISTRO,@NUEVO_PROVEEDOR,@ANTERIOR_PROVEEDOR, @CAMPO)
			end

			if  @NUEVO_PRODUCTO<>@ANTERIOR_PRODUCTO

			begin 

				SET  @CAMPO2 = 'CodigoProducto'

			

			insert into [dbo].[Audita] (Accion, Registro,CodigoProveedor,CodigoProducto,campo2)
			values (@ACCION,@REGISTRO,@NUEVO_PRODUCTO,@ANTERIOR_PRODUCTO, @CAMPO2)
			end
	end 

	if not exists (select * from inserted) and exists (select * from deleted)
		begin 
			SET  @CAMPO = 'CodigoProveedor'
			SET  @CAMPO2 = 'CodigoProducto'
			SET  @ACCION ='Elimiina'
			select @REGISTRO=d.Consecutivo,
			@NUEVO_PRODUCTO= d.CodigoProveedor,
			@NUEVO_PROVEEDOR=d.CodigoProducto
			from deleted as d 
			insert into [dbo].[Audita] (Accion,Registro,CodigoProveedor,CodigoProducto,campo,Campo2)
			values (
					@ACCION,
					@REGISTRO,
					
					@ANTERIOR_PRODUCTO,
					
					@ANTERIOR_PROVEEDOR,
					@CAMPO,
					@CAMPO2)

end 

END 

--tabla 

CREATE TABLE [dbo].[Audita](
	[idAudita] [int] IDENTITY(1,1) NOT NULL,
	[CodigoProveedor] [int] NULL,
	[CodigoProducto] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[Accion] [varchar](50) NULL,
	[Registro] [int] NULL,
	[Campo] [varchar](50) NULL,
	[Campo2] [varchar](50) NULL,
 CONSTRAINT [PK_Audita] PRIMARY KEY CLUSTERED 
(
	[idAudita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Audita] ADD  CONSTRAINT [DF_Audita_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO

