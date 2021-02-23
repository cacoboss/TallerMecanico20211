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
CREATE PROCEDURE InsetarCategoria
	@CODIGO VARCHAR(8),
	@NOMBRE VARCHAR(100),
	@OBSERVACION TEXT
AS
INSERT INTO 
Categoria(CodigoCategoria,Nombre,Observacion)
VALUES(@CODIGO,@NOMBRE,@OBSERVACION)
GO