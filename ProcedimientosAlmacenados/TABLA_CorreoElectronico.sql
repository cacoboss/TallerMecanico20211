--SP: Buscar para el Login según Usuario/Contraseña
--Nombre: CorreoElectronico_InicioSesion
CREATE PROCEDURE CorreoElectronico_InicioSesion
	@CORREOUSADO NVARCHAR(50),
	@CLAVEUSADA	 NVARCHAR(50)
AS
	DECLARE @ID_CORREO INT;
	SELECT 
		@ID_CORREO = [TallerMecanico].[dbo].[CorreoElectronico].IdentificadorCorreo
	FROM
		[TallerMecanico].[dbo].[CorreoElectronico]
	WHERE
		[TallerMecanico].[dbo].[CorreoElectronico].DireccionCorreoElectronico = @CORREOUSADO
		AND
		[TallerMecanico].[dbo].[CorreoElectronico].Contraseña = @CLAVEUSADA
	
	SELECT * 
	FROM 
		[TallerMecanico].[dbo].[Trabajador]
	WHERE 
		IdentificadorCorreo = @ID_CORREO; 
GO

--SP: Buscar para el Login según Usuario/Contraseña
--Nombre: CorreoElectronico_InicioSesion {Prueba}
EXEC CorreoElectronico_InicioSesion 'ccobossa@uninpahu.edu.co','1234';