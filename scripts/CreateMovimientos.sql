SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimientos](
	[Id] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Valor] [decimal](18, 0) NULL,
	[Saldo] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Movimientos] ADD  CONSTRAINT [PK_Movimientos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO