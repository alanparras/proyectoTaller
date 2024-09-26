CREATE TABLE [dbo].[usuarios] (
  [id] [int] NOT NULL,
  [nombre] [varchar](30) NOT NULL,
  [apellido] [varchar](30) NOT NULL,
  [zipcode] [int] NOT NULL,
  [domicilio] [varchar](80) NOT NULL,
  [email] [varchar](50) NOT NULL,
  [usuario] [varchar](30) NOT NULL,
  [pass] [varchar](300) NOT NULL,
  [perfil_id] [int] NOT NULL,
  [baja] [varchar](2) NOT NULL
)
ON [PRIMARY]
GO