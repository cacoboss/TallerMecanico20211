
-- Query para modificar una tabla
alter table [TallerMecanico].[dbo].[Trabajador] 
	ADD IdentificadorCorreo INT;

--Query para insertar en la tabla de TipoTrabajador
INSERT INTO [TallerMecanico].[dbo].[TipoTrabajador]
	([NombreCargo]
      ,[DescripcionCargo]
      ,[Permiso_FichaTecnica]
      ,[Permiso_ListadoClientes]
      ,[Permiso_ListadoCompras]
      ,[Permiso_ListadoVentas]
      ,[Permiso_Facturas]
      ,[Permiso_Inventarios]
      ,[Permiso_CreacionUsuarios])
VALUES	
	('Creador de Usuarios',
	'Para crear los otros roles',
	0,0,0,0,0,0,1)

--Query para insertar en la tabla de Trabajador
INSERT INTO [dbo].[Trabajador]
           ([Cedula]
           ,[Nombres]
           ,[Apellidos]
           ,[Celular]
           ,[TipoTrabajador]
           ,[FechaCreacion]
           ,[FechaModificacion]
           ,[CorreoElectronico])
     VALUES
           (1032463301,
           'Ciro Andres',
           'Cobos Sanchez',
           3162269364,
           1,
           GETDATE(),
           GETDATE(),
           'ccobossa@uninpahu.edu.co')
GO

--Query para la consulta del Login
DECLARE @ID_CORREO INT;

SELECT @ID_CORREO = [IdentificadorCorreo]
FROM [TallerMecanico].[dbo].[CorreoElectronico]
WHERE DireccionCorreoElectronico = 'ccobossa@uninpahu.edu.co'
	AND
	Contraseña = 1234;

PRINT @ID_CORREO;


SELECT * 
FROM [TallerMecanico].[dbo].[Trabajador]
WHERE IdentificadorCorreo = @ID_CORREO;



BEGIN

ALTER TABLE [TallerMecanico].[dbo].[CorreoElectronico]
	DROP CONSTRAINT DireccionCorreoElectronico;

ALTER TABLE [TallerMecanico].[dbo].[CorreoElectronico]
	ADD IdentificadorCorreo INT NOT NULL IDENTITY PRIMARY KEY

END