/*--------------------------------
    Creación de Tabla y Relaciones
--------------------------------*/
CREATE TABLE MaestroCompra(
    IdRegistro          INT PRIMARY KEY IDENTITY ,
    FechaCreacion       DATETIME,
    FechaModificacion   DATETIME,
    TotalFactura        REAL,
    CedulaTrabajador    INT,
    EstadoFactura       INT, -- Req de Tabla Estados.
);

ALTER TABLE MaestroCompra
    ADD  Proveedor int;

ALTER TABLE MaestroCompra
    ADD CONSTRAINT FK_MaestroCompra_Proveedores
    FOREIGN KEY (Proveedor)
    REFERENCES Proveedor(CodigoProveedor);
/*--------------------------------
    Creación de Procedimientos Almacenados
--------------------------------*/
ALTER PROCEDURE SP_MaestroCompra_FacturaEnBlanco
AS 
    INSERT INTO MaestroCompra
    (FechaCreacion, FechaModificacion, TotalFactura)
    VALUES 
    (GETDATE(),GETDATE(),0);
    
    SELECT MAX(IdRegistro) AS UltimoRegistro
    FROM MaestroCompra;
GO

CREATE PROCEDURE SP_MaestroCompra_ModificarTotal
    @TOTAL          REAL,
    @NUMREGISTRO    INT
AS
    UPDATE MaestroCompra
    SET TotalFactura = @TOTAL
    WHERE IdRegistro = @NUMREGISTRO
GO
/*--------------------------------
    Pruebas con la tabla
--------------------------------*/

EXEC SP_MaestroCompra_FacturaEnBlanco; 

select * from MaestroCompra;