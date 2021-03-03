--SP:
--Nombre: TipoTrabajador_TraerTipoPorID
CREATE PROCEDURE TipoTrabajador_TraerTipoPorID
	@ID	INT
AS
SELECT 
	NombreCargo,
	DescripcionCargo,
	Permiso_FichaTecnica,
	Permiso_ListadoClientes,
	Permiso_ListadoCompras,
	Permiso_ListadoVentas,
	Permiso_Facturas,
	Permiso_Inventarios,
	Permiso_CreacionUsuarios
FROM
	[TallerMecanico].[dbo].[TipoTrabajador]
WHERE
	CodigoTrabajador = @ID
GO