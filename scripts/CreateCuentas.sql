SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuentas](
	[Id] [int] IDENTITY(10000,1) NOT NULL,
	[NumeroCuenta] [int] NOT NULL,
	[SaldoInicial] [decimal](18, 0) NULL,
	[Estado] [nvarchar](50) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cuentas] ADD  CONSTRAINT [PK_Cuentas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF,  IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
