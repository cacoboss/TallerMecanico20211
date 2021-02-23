-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE TraerCategoriaPorId
@ID int
AS
SELECT IdCategoria [Id],
	ISNULL(CodigoCategoria,'')[Codigo],
	ISNULL(Nombre,'')[Nombre],
	ISNULL(Observacion,'')[Observacion]	
FROM Categoria
WHERE IdCategoria = @ID
GO
