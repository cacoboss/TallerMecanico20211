--SP: Buscar Según Correo/Contraseña
--Nombre: Trabajador_TraerTrabajadorPorCorreo
CREATE PROCEDURE Trabajador_TraerTrabajadorPorCorreo
	@CORREO NVARCHAR(50),
	@CLAVE	NVARCHAR(50)
AS
	SELECT
		Cedula, Nombres, Apellidos, Celular, 
		TipoTrabajador, FechaCreacion, FechaModificacion
	FROM
		[dbo].Trabajador
	WHERE
		DireccionCorreoElectronico = @CORREO
		AND
		Contraseña = @CLAVE
GO