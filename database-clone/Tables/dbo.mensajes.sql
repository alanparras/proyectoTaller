CREATE TABLE [dbo].[mensajes] (
  [id] [int] NOT NULL,
  [nombre] [varchar](255) NOT NULL,
  [correo] [varchar](255) NOT NULL,
  [mensaje] [varchar](max) NOT NULL,
  [leido] [bit] NULL,
  [created_at] [datetime] NULL,
  [updated_at] [datetime] NULL
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO