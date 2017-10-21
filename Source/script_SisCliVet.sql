USE [master]
GO
/****** Object:  Database [SISCLIAD_Vet]    Script Date: 01/10/2017 07:50:38 p. m. ******/
IF EXISTS(SELECT name FROM sys.databases
	WHERE name = 'SISCLIAD_Vet')
	DROP DATABASE SISCLIAD_Vet
GO
CREATE DATABASE [SISCLIAD_Vet]
GO
USE [SISCLIAD_Vet]
GO
ALTER DATABASE [SISCLIAD_Vet] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET ARITHABORT OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SISCLIAD_Vet] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SISCLIAD_Vet] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SISCLIAD_Vet] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET  DISABLE_BROKER
GO
ALTER DATABASE [SISCLIAD_Vet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SISCLIAD_Vet] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET RECOVERY FULL
GO
ALTER DATABASE [SISCLIAD_Vet] SET  MULTI_USER
GO
ALTER DATABASE [SISCLIAD_Vet] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SISCLIAD_Vet] SET DB_CHAINING OFF
GO
ALTER DATABASE [SISCLIAD_Vet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO
ALTER DATABASE [SISCLIAD_Vet] SET TARGET_RECOVERY_TIME = 0 SECONDS
GO
EXEC sys.sp_db_vardecimal_storage_format N'SISCLIAD_Vet', N'ON'
GO
USE [SISCLIAD_Vet]
GO
/****** Object:  Table [dbo].[CartaConsentimiento]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CartaConsentimiento](
	[idCarta] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [varchar](6) NOT NULL,
	[carta] [image] NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[tipoCarta] [varchar](15) NOT NULL,
 CONSTRAINT [PK_CartaConsentimiento] PRIMARY KEY CLUSTERED
(
	[idCarta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cita](
	[idCita] [int] IDENTITY(1,1) NOT NULL,
	[fechaCrea] [date] NOT NULL,
	[horaCrea] [time](7) NOT NULL,
	[motivo] [varchar](100) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[idPaciente] [varchar](6) NOT NULL,
	[username] [varchar](10) NOT NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_Cita] PRIMARY KEY CLUSTERED
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ConsultaGral]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConsultaGral](
	[idConsulta] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [varchar](6) NOT NULL,
	[razonConsulta] [varchar](250) NULL,
	[sintomas] [varchar](250) NULL,
	[diagnostico] [varchar](250) NULL,
	[observaciones] [varchar](250) NULL,
	[tratamiento] [varchar](250) NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[username] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ConsultaGral] PRIMARY KEY CLUSTERED
(
	[idConsulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ControlVacunas]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ControlVacunas](
	[idControl] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [varchar](6) NOT NULL,
	[idVacuna] [varchar](6) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[username] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ControlVacunas] PRIMARY KEY CLUSTERED
(
	[idControl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Especie]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Especie](
	[idEspecie] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Especie] PRIMARY KEY CLUSTERED
(
	[idEspecie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[InfoClinica]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[InfoClinica](
	[idClinica] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[ambito] [varchar](50) NULL,
	[telefono] [varchar](8) NULL,
	[direccion] [varchar](150) NULL,
	[logo] [image] NOT NULL,
 CONSTRAINT [PK_InfoClinica] PRIMARY KEY CLUSTERED
(
	[idClinica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paciente](
	[idPaciente] [varchar](6) NOT NULL,
	[idPropietario] [varchar](7) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[idEspecie] [int] NOT NULL,
	[sexo] [char](1) NOT NULL,
	[raza] [varchar](25) NOT NULL,
	[color] [varchar](25) NOT NULL,
	[fechaNac] [date] NULL,
	[peso] [decimal](7, 2) NULL,
	[estadoRep] [varchar](25) NULL,
	[rasgoDist] [varchar](150) NULL,
	[idTipoReg] [int] NOT NULL,
	[ultimaVacuna] [varchar](25) NOT NULL,
	[fechaUltiVac] [date] NOT NULL,
	[fechaReg] [date] NOT NULL,
	[horaReg] [time](7) NOT NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Propietario]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Propietario](
	[idPropietario] [varchar](7) NOT NULL,
	[priNombre] [varchar](25) NOT NULL,
	[segNombre] [varchar](25) NULL,
	[priApellido] [varchar](25) NOT NULL,
	[segApellido] [varchar](25) NULL,
	[dui] [varchar](9) NULL,
	[email] [varchar](50) NOT NULL,
	[sexo] [char](1) NOT NULL,
	[direccion] [varchar](150) NULL,
	[telFijo] [varchar](8) NULL,
	[telMovil] [varchar](8) NULL,
	[fechaReg] [date] NOT NULL,
	[horaReg] [time](7) NOT NULL,
 CONSTRAINT [PK_Propietario] PRIMARY KEY CLUSTERED
(
	[idPropietario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoRegistro]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoRegistro](
	[idTipoReg] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](15) NOT NULL,
 CONSTRAINT [PK_TipoRegistro] PRIMARY KEY CLUSTERED
(
	[idTipoReg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[username] [varchar](10) NOT NULL,
	[passwd] [varchar](15) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[idRol] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vacuna]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vacuna](
	[idVacuna] [varchar](6) NOT NULL,
	[idEspecie] [int] NOT NULL,
	[nombre] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Vacuna] PRIMARY KEY CLUSTERED
(
	[idVacuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vacuna_Paciente]    Script Date: 01/10/2017 07:50:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vacuna_Paciente](
	[correlativo] [int] IDENTITY(1,1) NOT NULL,
	[idVacuna] [varchar](6) NOT NULL,
	[idPaciente] [varchar](6) NOT NULL,
	[fecha] [date] NOT NULL,
 CONSTRAINT [PK_Vacuna_Paciente] PRIMARY KEY CLUSTERED
(
	[correlativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CartaConsentimiento]  WITH CHECK ADD  CONSTRAINT [FK_CartaConsentimiento_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[CartaConsentimiento] CHECK CONSTRAINT [FK_CartaConsentimiento_Paciente]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Paciente]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Usuario] FOREIGN KEY([username])
REFERENCES [dbo].[Usuario] ([username])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Usuario]
GO
ALTER TABLE [dbo].[ConsultaGral]  WITH CHECK ADD  CONSTRAINT [FK_ConsultaGral_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[ConsultaGral] CHECK CONSTRAINT [FK_ConsultaGral_Paciente]
GO
ALTER TABLE [dbo].[ConsultaGral]  WITH CHECK ADD  CONSTRAINT [FK_ConsultaGral_Usuario] FOREIGN KEY([username])
REFERENCES [dbo].[Usuario] ([username])
GO
ALTER TABLE [dbo].[ConsultaGral] CHECK CONSTRAINT [FK_ConsultaGral_Usuario]
GO
ALTER TABLE [dbo].[ControlVacunas]  WITH CHECK ADD  CONSTRAINT [FK_ControlVacunas_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[ControlVacunas] CHECK CONSTRAINT [FK_ControlVacunas_Paciente]
GO
ALTER TABLE [dbo].[ControlVacunas]  WITH CHECK ADD  CONSTRAINT [FK_ControlVacunas_Usuario] FOREIGN KEY([username])
REFERENCES [dbo].[Usuario] ([username])
GO
ALTER TABLE [dbo].[ControlVacunas] CHECK CONSTRAINT [FK_ControlVacunas_Usuario]
GO
ALTER TABLE [dbo].[ControlVacunas]  WITH CHECK ADD  CONSTRAINT [FK_ControlVacunas_Vacuna] FOREIGN KEY([idVacuna])
REFERENCES [dbo].[Vacuna] ([idVacuna])
GO
ALTER TABLE [dbo].[ControlVacunas] CHECK CONSTRAINT [FK_ControlVacunas_Vacuna]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Especie] FOREIGN KEY([idEspecie])
REFERENCES [dbo].[Especie] ([idEspecie])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_Especie]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Propietario] FOREIGN KEY([idPropietario])
REFERENCES [dbo].[Propietario] ([idPropietario])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_Propietario]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_TipoRegistro] FOREIGN KEY([idTipoReg])
REFERENCES [dbo].[TipoRegistro] ([idTipoReg])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_TipoRegistro]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([idRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
ALTER TABLE [dbo].[Vacuna]  WITH CHECK ADD  CONSTRAINT [FK_Vacuna_Especie] FOREIGN KEY([idEspecie])
REFERENCES [dbo].[Especie] ([idEspecie])
GO
ALTER TABLE [dbo].[Vacuna] CHECK CONSTRAINT [FK_Vacuna_Especie]
GO
ALTER TABLE [dbo].[Vacuna_Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Vacuna_Paciente_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[Vacuna_Paciente] CHECK CONSTRAINT [FK_Vacuna_Paciente_Paciente]
GO
ALTER TABLE [dbo].[Vacuna_Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Vacuna_Paciente_Vacuna] FOREIGN KEY([idVacuna])
REFERENCES [dbo].[Vacuna] ([idVacuna])
GO
ALTER TABLE [dbo].[Vacuna_Paciente] CHECK CONSTRAINT [FK_Vacuna_Paciente_Vacuna]
GO
USE [master]
GO
ALTER DATABASE [SISCLIAD_Vet] SET  READ_WRITE
GO
