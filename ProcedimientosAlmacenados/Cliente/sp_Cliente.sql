use TallerMecanicoAssociate20211


CREATE PROCEDURE [dbo].[ActualizarCliente]
    @ID INT,
    @NOMBRES VARCHAR(100),
	@APELLIDOS VARCHAR(100),
	@DIRECCION VARCHAR(100),
	@TELEFONO BIGINT,
	@EMAIL VARCHAR(100)
AS
UPDATE Cliente 
SET 
    Nombres = @NOMBRES,
	Apellidos = @APELLIDOS,
	Direccion = @DIRECCION,
	Telefono=@TELEFONO,
	Email=@EMAIL,
	Fecha_Creacion = GETDATE(),
	Fecha_Modificacion = GETDATE()
WHERE CodigoCliente = @ID


CREATE PROCEDURE [dbo].[ListarClientes]
AS
SELECT CodigoCliente,

    ISNULL(Nombres,'Nombre vacio') AS [Nombres],
	ISNULL(Apellidos,'Vacio') AS [Apellidos],
	ISNULL(Direccion,'') AS [Direccion],
	ISNULL(Telefono,'') AS [Telefono],
	ISNULL(Email,'') AS [Email]
FROM Cliente


CREATE PROCEDURE [dbo].[EliminarCliente]
    @ID INT
AS
DELETE FROM Cliente
WHERE CodigoCliente = @ID



CREATE PROCEDURE [dbo].[InsertarCliente]
	
    @NOMBRES VARCHAR(100),
	@APELLIDOS VARCHAR(100),
	@DIRECCION VARCHAR(100),
	@TELEFONO BIGINT,
	@EMAIL VARCHAR(100)
AS
INSERT INTO Cliente(Fecha_Creacion,Fecha_Modificacion,Nombres,Apellidos,Direccion,Telefono,Email)
VALUES(GETDATE(),GETDATE(),@NOMBRES,@APELLIDOS,@DIRECCION,@TELEFONO,@EMAIL)



CREATE PROCEDURE [dbo].[TraerClientePorId]
@ID int
AS
SELECT 
	CodigoCliente ,	
    ISNULL(Nombres,'')[Nombres],
	ISNULL(Apellidos,'')[Apellidos],
	ISNULL(Direccion,'')[Direccion],
	ISNULL(Telefono,'')[Telefono],
	ISNULL(Email,'')[Email]
FROM Cliente
WHERE CodigoCliente = @ID
