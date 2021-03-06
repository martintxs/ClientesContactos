USE [Clientes]
GO
/****** Object:  StoredProcedure [dbo].[spContacto_Save]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[spContacto_Save]
GO
/****** Object:  StoredProcedure [dbo].[spContacto_ReadId]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[spContacto_ReadId]
GO
/****** Object:  StoredProcedure [dbo].[spContacto_ReadAll]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[spContacto_ReadAll]
GO
/****** Object:  StoredProcedure [dbo].[spContacto_Delete]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[spContacto_Delete]
GO
/****** Object:  StoredProcedure [dbo].[spCliente_Save]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[spCliente_Save]
GO
/****** Object:  StoredProcedure [dbo].[spCliente_Reporte]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[spCliente_Reporte]
GO
/****** Object:  StoredProcedure [dbo].[spCliente_ReadId]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[spCliente_ReadId]
GO
/****** Object:  StoredProcedure [dbo].[spCliente_ReadAll]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[spCliente_ReadAll]
GO
/****** Object:  StoredProcedure [dbo].[spCliente_Delete]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP PROCEDURE IF EXISTS [dbo].[spCliente_Delete]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contactos]') AND type in (N'U'))
ALTER TABLE [dbo].[Contactos] DROP CONSTRAINT IF EXISTS [FK_Contactos_Clientes]
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Contactos]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP TABLE IF EXISTS [dbo].[Clientes]
GO
USE [master]
GO
/****** Object:  Database [Clientes]    Script Date: 15/05/2021 05:56:13 p. m. ******/
DROP DATABASE IF EXISTS [Clientes]
GO
/****** Object:  Database [Clientes]    Script Date: 15/05/2021 05:56:13 p. m. ******/
CREATE DATABASE [Clientes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clientes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Clientes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Clientes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Clientes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clientes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Clientes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Clientes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Clientes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Clientes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Clientes] SET ARITHABORT OFF 
GO
ALTER DATABASE [Clientes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Clientes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Clientes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Clientes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Clientes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Clientes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Clientes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Clientes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Clientes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Clientes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Clientes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Clientes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Clientes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Clientes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Clientes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Clientes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Clientes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Clientes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Clientes] SET  MULTI_USER 
GO
ALTER DATABASE [Clientes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Clientes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Clientes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Clientes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Clientes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Clientes] SET QUERY_STORE = OFF
GO
USE [Clientes]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 15/05/2021 05:56:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[RazonSocial] [nvarchar](250) NOT NULL,
	[NombreComercial] [nvarchar](250) NOT NULL,
	[RFC] [nvarchar](15) NOT NULL,
	[CURP] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](350) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 15/05/2021 05:56:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[IdContacto] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Nombre] [nvarchar](80) NOT NULL,
	[ApellidoPaterno] [nvarchar](80) NOT NULL,
	[ApellidoMaterno] [nvarchar](80) NOT NULL,
	[Telefono] [nvarchar](15) NOT NULL,
	[Direccion] [nvarchar](350) NOT NULL,
	[Puesto] [nvarchar](90) NOT NULL,
 CONSTRAINT [PK_Contactos] PRIMARY KEY CLUSTERED 
(
	[IdContacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([IdCliente], [RazonSocial], [NombreComercial], [RFC], [CURP], [Direccion]) VALUES (6, N'Soluciones Veracruzanas', N'SAVVER', N'XAXX01010100', N'N/A', N'Canal #45')
INSERT [dbo].[Clientes] ([IdCliente], [RazonSocial], [NombreComercial], [RFC], [CURP], [Direccion]) VALUES (7, N'Soluciones Mexicanas', N'Axtel', N'XAXX01010100', N'N/A', N'Colon No 25')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Contactos] ON 

INSERT [dbo].[Contactos] ([IdContacto], [IdCliente], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [Telefono], [Direccion], [Puesto]) VALUES (4, 6, N'Victoria', N'Secret', N'Perez', N'2291659832', N'Copite #45 Col. Centro', N'Lider de proyecto')
INSERT [dbo].[Contactos] ([IdContacto], [IdCliente], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [Telefono], [Direccion], [Puesto]) VALUES (5, 6, N'Alfredo', N'Hernandez', N'Vazquez', N'2299142536', N'Calle Bolivar #32 Fracc. Reforma', N'Analista')
SET IDENTITY_INSERT [dbo].[Contactos] OFF
GO
ALTER TABLE [dbo].[Contactos]  WITH CHECK ADD  CONSTRAINT [FK_Contactos_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Contactos] CHECK CONSTRAINT [FK_Contactos_Clientes]
GO
/****** Object:  StoredProcedure [dbo].[spCliente_Delete]    Script Date: 15/05/2021 05:56:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCliente_Delete]
@IdCliente INT
AS

BEGIN
SET NOCOUNT ON
	DELETE FROM Clientes WHERE IdCliente = @IdCliente
	SELECT 1 as Estatus, 'Eliminado correctamente' as Mensaje
END
GO
/****** Object:  StoredProcedure [dbo].[spCliente_ReadAll]    Script Date: 15/05/2021 05:56:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCliente_ReadAll]
@RazonSocial NVARCHAR(80) = '',
@NombreComercial NVARCHAR(80) = '',
@RFC NVARCHAR(80) = '',
@CURP NVARCHAR(15) = '',
@Direccion NVARCHAR(350) = ''
AS

BEGIN
SET NOCOUNT ON
	SELECT
		 C.IdCliente,
		 C.RazonSocial,
		 C.NombreComercial,
		 C.RFC,
		 C.CURP,
		 C.Direccion
	FROM 
		Clientes AS C
	WHERE
		(@RazonSocial = '' OR C.RazonSocial LIKE '%'+@RazonSocial+'%')
		AND (@NombreComercial = '' OR C.NombreComercial LIKE '%'+@NombreComercial+'%')
		AND (@RFC = '' OR C.RFC LIKE '%'+@RFC+'%')
		AND (@CURP = '' OR C.CURP LIKE '%'+@CURP+'%')
		AND (@Direccion = '' OR C.Direccion LIKE '%'+@Direccion+'%')

END
GO
/****** Object:  StoredProcedure [dbo].[spCliente_ReadId]    Script Date: 15/05/2021 05:56:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCliente_ReadId]
@IdCliente INT
AS

BEGIN
SET NOCOUNT ON
	SELECT
		 C.IdCliente,
		 C.RazonSocial,
		 C.NombreComercial,
		 C.RFC,
		 C.CURP,
		 C.Direccion
	FROM 
		Clientes AS C
	WHERE
		C.IdCliente = @IdCliente

END
GO
/****** Object:  StoredProcedure [dbo].[spCliente_Reporte]    Script Date: 15/05/2021 05:56:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCliente_Reporte]
@IdCliente INT
AS

BEGIN
SET NOCOUNT ON
	SELECT
		 C.IdCliente,
		 C.RazonSocial,
		 C.NombreComercial,
		 C.RFC,
		 C.CURP,
		 C.Direccion
	FROM 
		Clientes AS C
	WHERE
		C.IdCliente = @IdCliente

	SELECT
		C.IdContacto,
		C.IdCliente,
		C.Nombre,
		C.ApellidoPaterno,
		C.ApellidoMaterno,
		C.Telefono,
		C.Direccion AS DireccionContacto,
		C.Puesto
	FROM
		Contactos AS C
	WHERE
		C.IdCliente = @IdCliente
END
GO
/****** Object:  StoredProcedure [dbo].[spCliente_Save]    Script Date: 15/05/2021 05:56:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCliente_Save]
	@IdCliente INT,
	@RazonSocial NVARCHAR(250),
	@NombreComercial NVARCHAR(250),
	@RFC NVARCHAR(15),
	@CURP NVARCHAR(50),
	@Direccion NVARCHAR(350)
AS
BEGIN
SET NOCOUNT ON
		BEGIN TRAN
		BEGIN TRY
			BEGIN

				MERGE 
					Clientes AS DESTINO
				USING 
					(VALUES(@IdCliente, @RazonSocial, @NombreComercial, @RFC, @CURP, @Direccion)) 
						AS ORIGEN(IdCliente,RazonSocial,NombreComercial,RFC,CURP,Direccion)
				ON 
					DESTINO.IdCliente = ORIGEN.IdCliente
				WHEN MATCHED THEN
				UPDATE SET 
					DESTINO.RazonSocial = Origen.RazonSocial,
					DESTINO.NombreComercial = Origen.NombreComercial,
					DESTINO.RFC = Origen.RFC,
					DESTINO.CURP = Origen.CURP,
					DESTINO.Direccion = Origen.Direccion
				WHEN NOT MATCHED THEN 
					INSERT(RazonSocial, NombreComercial, RFC, CURP, Direccion)
					VALUES(ORIGEN.RazonSocial, Origen.NombreComercial, ORIGEN.RFC, ORIGEN.CURP, ORIGEN.Direccion);

				COMMIT TRANSACTION
				SELECT 1 as Estatus, 'Guardado correctamente' as Mensaje
			END
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
			SELECT 0 as Estatus, ' Error: ' + CAST(ERROR_NUMBER() AS NVARCHAR) + ' Linea: ' + CAST(ERROR_LINE() AS NVARCHAR) + ' => ' + ERROR_MESSAGE() as Mensaje
		END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[spContacto_Delete]    Script Date: 15/05/2021 05:56:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spContacto_Delete]
@IdContacto INT
AS

BEGIN
SET NOCOUNT ON
	DELETE FROM Contactos WHERE IdContacto = @IdContacto
	SELECT 1 as Estatus, 'Eliminado correctamente' as Mensaje
END
GO
/****** Object:  StoredProcedure [dbo].[spContacto_ReadAll]    Script Date: 15/05/2021 05:56:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spContacto_ReadAll]
@IdCliente INT,
@Nombre NVARCHAR(80) = '',
@ApellidoPaterno NVARCHAR(80) = '',
@ApellidoMaterno NVARCHAR(80) = '',
@Telefono NVARCHAR(15) = '',
@Direccion NVARCHAR(350) = '',
@Puesto NVARCHAR(90) = ''
AS

BEGIN
SET NOCOUNT ON
	SELECT
		 C.IdContacto,
		 C.IdCliente,
		 C.Nombre,
		 C.ApellidoPaterno,
		 C.ApellidoMaterno,
		 C.Telefono,
		 C.Direccion,
		 C.Puesto
	FROM 
		Contactos AS C
	WHERE
		C.IdCliente = @IdCliente
		AND (@Nombre = '' OR C.Nombre LIKE '%'+@Nombre+'%')
		AND (@ApellidoPaterno = '' OR C.ApellidoPaterno LIKE '%'+@ApellidoPaterno+'%')
		AND (@ApellidoMaterno = '' OR C.ApellidoMaterno LIKE '%'+@ApellidoMaterno+'%')
		AND (@Telefono = '' OR C.Telefono LIKE '%'+@Telefono+'%')
		AND (@Direccion = '' OR C.Direccion LIKE '%'+@Direccion+'%')
		AND (@Puesto = '' OR C.Puesto LIKE '%'+@Puesto+'%')

END
GO
/****** Object:  StoredProcedure [dbo].[spContacto_ReadId]    Script Date: 15/05/2021 05:56:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spContacto_ReadId]
@IdContacto INT
AS

BEGIN
SET NOCOUNT ON
	SELECT
		 C.IdContacto,
		 C.IdCliente,
		 C.Nombre,
		 C.ApellidoPaterno,
		 C.ApellidoMaterno,
		 C.Telefono,
		 C.Direccion,
		 C.Puesto
	FROM 
		Contactos AS C
	WHERE
		C.IdContacto = @IdContacto

END
GO
/****** Object:  StoredProcedure [dbo].[spContacto_Save]    Script Date: 15/05/2021 05:56:13 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spContacto_Save]
	@IdContacto INT,
	@IdCliente INT,
	@Nombre NVARCHAR(80),
	@ApellidoPaterno NVARCHAR(80),
	@ApellidoMaterno NVARCHAR(80),
	@Telefono NVARCHAR(15),
	@Direccion NVARCHAR(350),
	@Puesto NVARCHAR(90)
AS
BEGIN
SET NOCOUNT ON
		BEGIN TRAN
		BEGIN TRY
			BEGIN

				MERGE 
					Contactos AS DESTINO
				USING 
					(VALUES(@IdContacto, @IdCliente, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @Telefono, @Direccion, @Puesto)) 
						AS ORIGEN(IdContacto,IdCliente,Nombre,ApellidoPaterno,ApellidoMaterno,Telefono,Direccion, Puesto)
				ON 
					DESTINO.IdContacto = ORIGEN.IdContacto
					AND DESTINO.IdCliente = ORIGEN.IdCliente
				WHEN MATCHED THEN
				UPDATE SET 
					DESTINO.Nombre = Origen.Nombre,
					DESTINO.ApellidoPaterno = Origen.ApellidoPaterno,
					DESTINO.ApellidoMaterno = Origen.ApellidoMaterno,
					DESTINO.Telefono = Origen.Telefono,
					DESTINO.Direccion = Origen.Direccion,
					DESTINO.Puesto = Origen.Puesto
				WHEN NOT MATCHED THEN 
					INSERT(IdCliente, Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, Direccion, Puesto)
					VALUES(ORIGEN.IdCliente, Origen.Nombre, ORIGEN.ApellidoPaterno, ORIGEN.ApellidoMaterno, ORIGEN.Telefono, ORIGEN.Direccion, ORIGEN.Puesto);

				COMMIT TRANSACTION
				SELECT 1 as Estatus, 'Guardado correctamente' as Mensaje
			END
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
			SELECT 0 as Estatus, ' Error: ' + CAST(ERROR_NUMBER() AS NVARCHAR) + ' Linea: ' + CAST(ERROR_LINE() AS NVARCHAR) + ' => ' + ERROR_MESSAGE() as Mensaje
		END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [Clientes] SET  READ_WRITE 
GO
