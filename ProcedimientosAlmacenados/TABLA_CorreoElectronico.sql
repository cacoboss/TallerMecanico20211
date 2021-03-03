--SP: Buscar para el Login según Usuario/Contraseña
--Nombre: CorreoElectronico_InicioSesion
ALTER PROCEDURE CorreoElectronico_InicioSesion
	@CORREOUSADO NVARCHAR(50),
	@CLAVEUSADA	 NVARCHAR(50)
AS
	--DECLARE @ID_CORREO INT;
	
	SELECT 
		 [TallerMecanico].[dbo].[CorreoElectronico].IdentificadorCorreo [Id_Mail]
	FROM
		[TallerMecanico].[dbo].[CorreoElectronico]
	WHERE
		[TallerMecanico].[dbo].[CorreoElectronico].DireccionCorreoElectronico = @CORREOUSADO
		AND
		[TallerMecanico].[dbo].[CorreoElectronico].Contraseña = @CLAVEUSADA
GO

--SP: Buscar para el Login según Usuario/Contraseña
--Nombre: CorreoElectronico_InicioSesion {Prueba}
EXEC CorreoElectronico_InicioSesion 'ccobossa@uninpahu.edu.co','1234';