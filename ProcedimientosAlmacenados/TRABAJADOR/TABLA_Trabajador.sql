--SP: Buscar seg�n Usuario todos los datos
--Nombre: Trabajador_TraerTrabajadorPorIDCorreo
CREATE PROCEDURE Trabajador_TraerTrabajadorPorIDCorreo
	@ID_CORREO INT
AS
	SELECT * 
	FROM 
		[TallerMecanico].[dbo].[Trabajador]
	WHERE 
		IdentificadorCorreo = @ID_CORREO; 
GO

--ALTER: Modificar tabla para combinar la tabla de 
-- trabajador y correo.
USE TallerMecanico
ALTER TABLE dbo.Trabajador
ADD 
	DireccionCorreoElectronico	NVARCHAR(50),
	Contrase�a					NVARCHAR(50);

USE TallerMecanico
ALTER TABLE dbo.Trabajador
ALTER COLUMN 
	DireccionCorreoElectronico	NVARCHAR(50) NOT NULL

USE TallerMecanico
ALTER TABLE dbo.Trabajador
ALTER COLUMN 
	Contrase�a					NVARCHAR(50) NOT NULL;

USE TallerMecanico
ALTER TABLE dbo.Trabajador
DROP COLUMN IdentificadorCorreo;

--SP: Buscar Seg�n Correo/Contrase�a
--Nombre: Trabajador_TraerTrabajadorPorCorreo
USE TallerMecanico
CREATE PROCEDURE Trabajador_TraerTrabajadorPorCorreo
	@CORREO NVARCHAR(50),
	@CLAVE	NVARCHAR(50)
AS
	SELECT
		Cedula, Nombres, Apellidos, Celular, 
		TipoTrabajador, FechaCreacion, FechaModificacion,
	FROM
		[dbo].Trabajador
	WHERE
		DireccionCorreoElectronico = @CORREO
		AND
		Contrase�a = @CLAVE
GO