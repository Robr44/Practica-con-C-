
USE [BDDesarrollo]
GO

 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marca](
	[IDMarca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Descripcion] [varchar](300) NULL,
	[RegMarca] [int] NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[IDMarca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Descripcion] [varchar](200) NULL,
	[Precio] [numeric](15, 2) NOT NULL,
	[Existencia] [int] NOT NULL,
	[IdMarca] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
   
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarMarca]
	@Nombre			VARCHAR (200),
	@Descripcion	VARCHAR (300),
	@RegMarca		INT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Marca (Nombre, Descripcion, RegMarca)
	VALUES (@nOMBRE, @Descripcion, @RegMarca)
END
GO
  
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarMarcaNombre]
	@Nombre varchar (200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT IdMarca, Nombre, Descripcion, RegMarca  FROM Marca 
	WHERE Nombre LIKE '%' + @Nombre + '%'
END
GO
  
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarMarca]
	@IdMarca		INT,
	@Nombre			VARCHAR(200),
	@Descripcion	VARCHAR(300),
	@RegMarca		INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Marca
	SET Nombre = @Nombre, Descripcion = @Descripcion, RegMarca = @RegMarca
	WHERE IDMarca = @IdMarca
	 
END
GO
  
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarProducto]
	@Nombre			VARCHAR (150),
	@Descripcion	VARCHAR (200),
	@Precio			NUMERIC (15,2),
	@Existencia		INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Producto (Nombre, Descripcion, Precio, Existencia)
	VALUES (@Nombre, @Descripcion, @Precio, @Existencia)
END
GO
   
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Marca] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[Marca] ([IDMarca])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Marca]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarMarca]
	@IdMarca INT
AS
BEGIN
	SET NOCOUNT ON;

	 DELETE FROM Marca
        WHERE IdMarca = @IdMarca;
END
GO

