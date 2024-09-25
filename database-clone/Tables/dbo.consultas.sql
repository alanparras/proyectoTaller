CREATE TABLE [dbo].[consultas] (
  [id] [int] NOT NULL,
  [usuario] [varchar](50) NOT NULL,
  [nombre] [varchar](255) NOT NULL,
  [apellido] [varchar](50) NOT NULL,
  [correo] [varchar](255) NOT NULL,
  [mensaje] [varchar](max) NOT NULL,
  [leido] [bit] NULL,
  [created_at] [datetime] NULL,
  [updated_at] [datetime] NULL
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO