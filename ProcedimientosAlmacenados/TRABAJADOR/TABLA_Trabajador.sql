--SP: Buscar según Usuario todos los datos
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
	Contraseña					NVARCHAR(50);

USE TallerMecanico
ALTER TABLE dbo.Trabajador
ALTER COLUMN 
	DireccionCorreoElectronico	NVARCHAR(50) NOT NULL

USE TallerMecanico
ALTER TABLE dbo.Trabajador
ALTER COLUMN 
	Contraseña					NVARCHAR(50) NOT NULL;

USE TallerMecanico
ALTER TABLE dbo.Trabajador
DROP COLUMN IdentificadorCorreo;

--SP: Buscar Según Correo/Contraseña
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
		Contraseña = @CLAVE
GO