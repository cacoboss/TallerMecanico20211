/*--------------------------------
    Creación de Tabla y Relaciones
--------------------------------*/

CREATE TABLE DetalleCompra (
    IdRegistro      INT PRIMARY KEY IDENTITY ,
    MaestroCompra   INT,
    Nombre          NVARCHAR(50),
    IdProducto      INT NOT NULL,
    Cantidad        INT NOT NULL,
    ValorUnitario   REAL NOT NULL,
    ValorTotal      REAL,
    FechaCreacion   DATETIME,
    FechaModificacion   DATETIME
);

ALTER TABLE DetalleCompra
    ADD CONSTRAINT FK_DetalleCompra_Producto
    FOREIGN KEY (IdProducto)
    REFERENCES Productos(CodigoProducto);

ALTER TABLE DetalleCompra
    ADD CONSTRAINT FK_DetalleCompra_MaestroCompra
    FOREIGN KEY (MaestroCompra)
    REFERENCES MaestroCompra(IdRegistro);

/*--------------------------------
    Procedimientos y Funciones
--------------------------------*/
/*CREATE FUNCTION FN_DetalleCompra_ActualizarTotal(@NUMMAESTRO INT)
RETURNS REAL
    
AS
BEGIN
    DECLARE @RESULTADO  REAL;

    SELECT @RESULTADO = SUM(ValorUnitario * DetalleCompra.Cantidad) AS Resultado
    FROM DetalleCompra
    WHERE MaestroCompra = @NUMMAESTRO;
    
    RETURN @RESULTADO;
END*/


/*--------------------------------
    Triggers
--------------------------------*/
CREATE TRIGGER TR_DetalleCompra_ActualizarMaestro
    ON dbo.DetalleCompra
    AFTER INSERT , UPDATE  
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @NUMEROMAESTRO       INT;
    DECLARE @RESULTADO           REAL;

    IF 
        EXISTS (SELECT * FROM inserted) AND NOT EXISTS (SELECT * FROM deleted)
        OR
        EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        SELECT @NUMEROMAESTRO = i.MaestroCompra
        FROM inserted i;

        SELECT @RESULTADO = SUM(ValorUnitario * DetalleCompra.Cantidad) AS Resultado
        FROM DetalleCompra
        WHERE MaestroCompra = @NUMEROMAESTRO;
        
        UPDATE MaestroCompra
        SET TotalFactura = @RESULTADO
        WHERE IdRegistro = @NUMEROMAESTRO;
    END
   
   /*
    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
 
    END
   
    IF NOT EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
    BEGIN
        
    END
    */
    
END
go

/*--------------------------------
    Pruebas con la tabla
--------------------------------*/

INSERT INTO DetalleCompra
(IdProducto, Cantidad, ValorUnitario,MaestroCompra)
VALUES 
(1,3,450,2),
(2,2,150,2),
(4,3,800,2);

SELECT * FROM Productos;

SELECT SUM(ValorUnitario * DetalleCompra.Cantidad) AS Resultado
FROM DetalleCompra
WHERE MaestroCompra = 2;

