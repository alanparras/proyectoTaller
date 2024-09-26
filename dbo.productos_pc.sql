CREATE TABLE [dbo].[productos_pc] (
  [id] [int] NOT NULL,
  [nombre] [varchar](100) NOT NULL,
  [descripcion] [varchar](max) NULL,
  [categoria] [varchar](50) NULL,
  [subcategoria] [varchar](50) NULL,
  [marca] [varchar](50) NULL,
  [modelo] [varchar](50) NULL,
  [precio] [decimal](10, 2) NULL,
  [stock] [int] NULL,
  [baja] [varchar](2) NOT NULL,
  [fecha_creacion] [datetime] NOT NULL,
  [visitas] [int] NULL
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO