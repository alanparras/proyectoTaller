CREATE TABLE [dbo].[ventas_cabecera] (
  [id] [int] NOT NULL,
  [fecha] [date] NOT NULL,
  [usuario_id] [int] NOT NULL,
  [total_venta] [decimal](10, 2) NOT NULL
)
ON [PRIMARY]
GO