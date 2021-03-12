--SP: Buscar Según Correo/Contraseña
--Nombre: Trabajador_TraerTrabajadorPorCorreo
CREATE PROCEDURE Trabajador_TraerTrabajadorPorCorreo
	@CORREO NVARCHAR(50),
	@CLAVE	NVARCHAR(50)
AS
	SELECT
		Cedula, 
		Nombres, 
		Apellidos, 
		Celular, 
		TipoTrabajador
	FROM
		[dbo].Trabajador
	WHERE
		DireccionCorreoElectronico = @CORREO
		AND
		Contraseña = @CLAVE
GO

--Metodo Detectar que haya el correo
/*CREATE PROCEDURE SP_Trabajador_DetectarPresenciaDeClave
	@CORREO			NVARCHAR(50),
	@CLAVE			NVARCHAR(50)
AS*/


SELECT 
	CASE WHEN EXISTS
		(
			SELECT Cedula 
			FROM Trabajador 
			WHERE DireccionCorreoElectronico = 'ccobossa@uninpahu.edu.co'
				AND
			Contraseña = '12345'
		)
	THEN 'TRUE'
	ELSE 'FALSE'
END

SELECT
		Cedula, 
		Nombres, 
		Apellidos, 
		Celular, 
		TipoTrabajador
	FROM
		[dbo].Trabajador
	WHERE
		DireccionCorreoElectronico = 'ccobossa@uninpahu.edu.co'
		AND
		Contraseña = '1234'

-------------------------------------------
--Metodo: Insertar Trabajador
CREATE PROCEDURE SP_Trabajador_Insertar
	@CEDULA		BIGINT,
	@NOMBRES	NVARCHAR(50),
	@APELLIDOS	NVARCHAR(50),
	@CELULAR	BIGINT,
	@TIPO		INT,
	@CORREO		NVARCHAR(50),
	@CLAVE		NVARCHAR(50)
AS
INSERT INTO
Trabajador (
	Cedula,
	Nombres,
	Apellidos,
	Celular,
	TipoTrabajador,
	FechaCreacion,
	FechaModificacion,
	DireccionCorreoElectronico,
	Contraseña
)
VALUES (
	@CEDULA,
	@NOMBRES,
	@APELLIDOS,
	@CELULAR,
	@TIPO,
	GETDATE(),
	GETDATE(),
	@CORREO,
	@CLAVE
)
GO

--Metodo Listar
CREATE PROCEDURE SP_Trabajador_Listar
AS
SELECT
	Cedula,
	Nombres,
	Apellidos,
	Celular,
	TipoTrabajador,
	DireccionCorreoElectronico AS Correo,
	Contraseña AS Clave
FROM 
	Trabajador
GO

-- Metodo Traer Trabajador por ID
CREATE PROCEDURE SP_Trabajador_TraerPorID
	@ID			BIGINT
AS
SELECT
	Cedula,
	Nombres,
	Apellidos,
	Celular,
	TipoTrabajador,
	DireccionCorreoElectronico AS Correo,
	Contraseña AS Clave
FROM 
	Trabajador
WHERE
	Cedula = @ID;

--Metodo Actualizar
CREATE PROCEDURE SP_Trabajador_Actualizar
	@CEDULA		BIGINT,
	@NOMBRES	NVARCHAR(50),
	@APELLIDOS	NVARCHAR(50),
	@CELULAR	BIGINT,
	@TIPO		INT,
	@CORREO		NVARCHAR(50),
	@CLAVE		NVARCHAR(50)
AS
UPDATE Trabajador
SET 
	Cedula						= @CEDULA,
	Nombres						= @NOMBRES,
	Apellidos					= @APELLIDOS,
	Celular						= @CELULAR,
	TipoTrabajador				= @TIPO,
	Contraseña					= @CLAVE,
	DireccionCorreoElectronico = @CORREO,
	FechaModificacion			= GETDATE()
WHERE
	Cedula = @CEDULA;

--Metodo Eliminar
CREATE PROCEDURE SP_Trabajador_Eliminar
	@ID			BIGINT
AS
DELETE 
	FROM Trabajador
WHERE
	Cedula = @ID;