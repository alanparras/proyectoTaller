CREATE TABLE [dbo].[ventas_detalle] (
  [id] [int] NOT NULL,
  [venta_id] [int] NOT NULL,
  [producto_id] [int] NOT NULL,
  [cantidad] [int] NOT NULL,
  [precio] [decimal](10, 2) NOT NULL
)
ON [PRIMARY]
GO