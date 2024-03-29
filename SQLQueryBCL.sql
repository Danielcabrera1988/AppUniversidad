USE [master]
GO
/****** Object:  Database [DB_Entity_Universidad]    Script Date: 16/7/2022 20:38:10 ******/
CREATE DATABASE [DB_Entity_Universidad]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Entity_Universidad', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_Entity_Universidad.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_Entity_Universidad_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_Entity_Universidad_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_Entity_Universidad] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Entity_Universidad].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Entity_Universidad] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Entity_Universidad] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Entity_Universidad] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_Entity_Universidad] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Entity_Universidad] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_Entity_Universidad] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Entity_Universidad] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Entity_Universidad] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Entity_Universidad] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Entity_Universidad] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_Entity_Universidad] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_Entity_Universidad] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_Entity_Universidad] SET QUERY_STORE = OFF
GO
USE [DB_Entity_Universidad]
GO
/****** Object:  Table [dbo].[Table_Adm]    Script Date: 16/7/2022 20:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Adm](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[Pswd] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
 CONSTRAINT [PK_Table_Adm] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Alumno_DB]    Script Date: 16/7/2022 20:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Alumno_DB](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[Pswd] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[Telefono] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Notas] [int] NULL,
	[Faltas] [int] NULL,
	[id_Materia] [int] NULL,
	[id_Profesor] [int] NULL,
	[id_Carrera] [int] NULL,
 CONSTRAINT [PK_Table_Alumno_DB] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Carrera_Alumno]    Script Date: 16/7/2022 20:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Carrera_Alumno](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[id_Alumno] [int] NULL,
	[id_Carrera] [int] NULL,
 CONSTRAINT [PK_Table_Carrera_Alumno] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Carrera_Materia]    Script Date: 16/7/2022 20:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Carrera_Materia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[id_Materia] [int] NULL,
	[id_Carrera] [int] NULL,
 CONSTRAINT [PK_Table_Carrera_Materia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Carreras]    Script Date: 16/7/2022 20:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Carreras](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Carrera] [varchar](50) NULL,
	[id_Materia] [int] NULL,
	[Materia] [varchar](50) NULL,
	[id_Alumno] [int] NULL,
 CONSTRAINT [PK_Table_Carreras] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Materia__Alumno]    Script Date: 16/7/2022 20:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Materia__Alumno](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[id_Materias] [int] NULL,
	[id_Alumnos] [int] NULL,
	[Nombre_Materia] [varchar](50) NULL,
	[Nombre_Alumno] [varchar](50) NULL,
	[Nota] [varchar](50) NULL,
 CONSTRAINT [PK_Table_Materia__Alumno] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Materias_DB]    Script Date: 16/7/2022 20:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Materias_DB](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[id_Alumno] [int] NULL,
	[id_Profesor] [int] NULL,
	[id_Carrera] [int] NULL,
 CONSTRAINT [PK_Table_Mterias_DB] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Materias_Profe]    Script Date: 16/7/2022 20:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Materias_Profe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[id_Materia] [int] NULL,
	[id_Profesor] [int] NULL,
	[Nombre_Materia] [varchar](50) NULL,
	[Nombre_Profesor] [varchar](50) NULL,
 CONSTRAINT [PK_Table_Materias_Profe] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Profesor_Alumno]    Script Date: 16/7/2022 20:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Profesor_Alumno](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[id_Alumno] [int] NULL,
	[id_Profesor] [int] NULL,
	[Nombre_Profesor] [varchar](50) NULL,
	[Nombre_Alumno] [varchar](50) NULL,
 CONSTRAINT [PK_Table_Profesor_Alumno] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Profesor_DB]    Script Date: 16/7/2022 20:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Profesor_DB](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[Pswd] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[FechaNacimiento] [datetime] NULL,
	[id_Alumno] [int] NULL,
	[id_Materia] [varchar](50) NULL,
 CONSTRAINT [PK_Table_Profesor_DB] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Table_Adm] ON 
GO
INSERT [dbo].[Table_Adm] ([ID], [Nombre], [Apellido], [Usuario], [Pswd], [email], [Telefono], [Direccion]) VALUES (6, N'Administrador', N'ELADMIN', N'admin', N'21232f297a57a5a743894a0e4a801fc3', N'admin@trador.com', N'3624123456', N'DireccionDelAdmin')
GO
INSERT [dbo].[Table_Adm] ([ID], [Nombre], [Apellido], [Usuario], [Pswd], [email], [Telefono], [Direccion]) VALUES (7, N'Daniel', N'Cabrera', N'danielsan', N'21232f297a57a5a743894a0e4a801fc3', N'admin@trador.com', N'3624123456', N'DireccionDelAdmin')
GO
SET IDENTITY_INSERT [dbo].[Table_Adm] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Alumno_DB] ON 
GO
INSERT [dbo].[Table_Alumno_DB] ([ID], [Nombre], [Apellido], [Usuario], [Pswd], [email], [Telefono], [Direccion], [FechaNacimiento], [Notas], [Faltas], [id_Materia], [id_Profesor], [id_Carrera]) VALUES (19, N'Daniel', N'cabrera', N'eldani', N'827ccb0eea8a706c4c34a16891f84e7b', N'dani@utn.com', NULL, NULL, NULL, NULL, NULL, 11, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[Table_Alumno_DB] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Carrera_Alumno] ON 
GO
INSERT [dbo].[Table_Carrera_Alumno] ([ID], [id_Alumno], [id_Carrera]) VALUES (3, 19, 1)
GO
SET IDENTITY_INSERT [dbo].[Table_Carrera_Alumno] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Carreras] ON 
GO
INSERT [dbo].[Table_Carreras] ([ID], [Carrera], [id_Materia], [Materia], [id_Alumno]) VALUES (1, N'Ing. Sistemas', NULL, NULL, NULL)
GO
INSERT [dbo].[Table_Carreras] ([ID], [Carrera], [id_Materia], [Materia], [id_Alumno]) VALUES (2, N'Ing. Electromecanica', NULL, NULL, NULL)
GO
INSERT [dbo].[Table_Carreras] ([ID], [Carrera], [id_Materia], [Materia], [id_Alumno]) VALUES (3, N'Ing. Quimica', NULL, NULL, NULL)
GO
INSERT [dbo].[Table_Carreras] ([ID], [Carrera], [id_Materia], [Materia], [id_Alumno]) VALUES (4, N'Ing. Civil', NULL, NULL, NULL)
GO
INSERT [dbo].[Table_Carreras] ([ID], [Carrera], [id_Materia], [Materia], [id_Alumno]) VALUES (5, N'TUP(Técnico Universitario en Programacion)', NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Table_Carreras] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Materia__Alumno] ON 
GO
INSERT [dbo].[Table_Materia__Alumno] ([ID], [id_Materias], [id_Alumnos], [Nombre_Materia], [Nombre_Alumno], [Nota]) VALUES (1, 11, 19, N'Algebra 1', NULL, NULL)
GO
INSERT [dbo].[Table_Materia__Alumno] ([ID], [id_Materias], [id_Alumnos], [Nombre_Materia], [Nombre_Alumno], [Nota]) VALUES (2, 12, 19, N'Analisis 1', NULL, NULL)
GO
INSERT [dbo].[Table_Materia__Alumno] ([ID], [id_Materias], [id_Alumnos], [Nombre_Materia], [Nombre_Alumno], [Nota]) VALUES (3, 11, 19, N'Algebra 1', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Table_Materia__Alumno] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Materias_DB] ON 
GO
INSERT [dbo].[Table_Materias_DB] ([ID], [Nombre], [id_Alumno], [id_Profesor], [id_Carrera]) VALUES (11, N'Algebra 1', NULL, 14, NULL)
GO
INSERT [dbo].[Table_Materias_DB] ([ID], [Nombre], [id_Alumno], [id_Profesor], [id_Carrera]) VALUES (12, N'Analisis 1', NULL, 14, NULL)
GO
INSERT [dbo].[Table_Materias_DB] ([ID], [Nombre], [id_Alumno], [id_Profesor], [id_Carrera]) VALUES (13, N'Dibujo Técnico', NULL, 14, NULL)
GO
INSERT [dbo].[Table_Materias_DB] ([ID], [Nombre], [id_Alumno], [id_Profesor], [id_Carrera]) VALUES (14, N'Programacion 1', NULL, 14, NULL)
GO
INSERT [dbo].[Table_Materias_DB] ([ID], [Nombre], [id_Alumno], [id_Profesor], [id_Carrera]) VALUES (15, N'Laboratorio 1', NULL, NULL, NULL)
GO
INSERT [dbo].[Table_Materias_DB] ([ID], [Nombre], [id_Alumno], [id_Profesor], [id_Carrera]) VALUES (16, N'Matemática 1', NULL, NULL, NULL)
GO
INSERT [dbo].[Table_Materias_DB] ([ID], [Nombre], [id_Alumno], [id_Profesor], [id_Carrera]) VALUES (17, N'Discreta', NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Table_Materias_DB] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Materias_Profe] ON 
GO
INSERT [dbo].[Table_Materias_Profe] ([ID], [id_Materia], [id_Profesor], [Nombre_Materia], [Nombre_Profesor]) VALUES (16, 11, 14, N'Algebra 1', N'Placido')
GO
SET IDENTITY_INSERT [dbo].[Table_Materias_Profe] OFF
GO
SET IDENTITY_INSERT [dbo].[Table_Profesor_DB] ON 
GO
INSERT [dbo].[Table_Profesor_DB] ([ID], [Nombre], [Apellido], [Usuario], [Pswd], [email], [Telefono], [Direccion], [FechaNacimiento], [id_Alumno], [id_Materia]) VALUES (14, N'Placido', N'Maidana', N'placido', N'e120ea280aa50693d5568d0071456460', N'placido@maidana.com', N'3624696969', N'Av Siempre Viva 69', CAST(N'1980-07-13T23:35:29.000' AS DateTime), NULL, N'14')
GO
INSERT [dbo].[Table_Profesor_DB] ([ID], [Nombre], [Apellido], [Usuario], [Pswd], [email], [Telefono], [Direccion], [FechaNacimiento], [id_Alumno], [id_Materia]) VALUES (16, N'German', N'Gaona', NULL, N'd41d8cd98f00b204e9800998ecf8427e', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Table_Profesor_DB] ([ID], [Nombre], [Apellido], [Usuario], [Pswd], [email], [Telefono], [Direccion], [FechaNacimiento], [id_Alumno], [id_Materia]) VALUES (19, N'Blas', N'Cabas', N'cabas', N'e120ea280aa50693d5568d0071456460', NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Table_Profesor_DB] OFF
GO
ALTER TABLE [dbo].[Table_Carrera_Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Table_Alumno_Carrera] FOREIGN KEY([id_Alumno])
REFERENCES [dbo].[Table_Alumno_DB] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Table_Carrera_Alumno] CHECK CONSTRAINT [FK_Table_Alumno_Carrera]
GO
ALTER TABLE [dbo].[Table_Carrera_Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Table_Carrera_Alumno] FOREIGN KEY([id_Carrera])
REFERENCES [dbo].[Table_Carreras] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Table_Carrera_Alumno] CHECK CONSTRAINT [FK_Table_Carrera_Alumno]
GO
ALTER TABLE [dbo].[Table_Carrera_Materia]  WITH CHECK ADD  CONSTRAINT [FK_Table_Carrera_Materia] FOREIGN KEY([id_Materia])
REFERENCES [dbo].[Table_Carreras] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Table_Carrera_Materia] CHECK CONSTRAINT [FK_Table_Carrera_Materia]
GO
ALTER TABLE [dbo].[Table_Carrera_Materia]  WITH CHECK ADD  CONSTRAINT [FK_Table_Materia_Carrera] FOREIGN KEY([id_Materia])
REFERENCES [dbo].[Table_Materias_DB] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Table_Carrera_Materia] CHECK CONSTRAINT [FK_Table_Materia_Carrera]
GO
ALTER TABLE [dbo].[Table_Materia__Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Table__Alumno_Materia] FOREIGN KEY([id_Alumnos])
REFERENCES [dbo].[Table_Alumno_DB] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Table_Materia__Alumno] CHECK CONSTRAINT [FK_Table__Alumno_Materia]
GO
ALTER TABLE [dbo].[Table_Materia__Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Table_Materia__Alumno] FOREIGN KEY([id_Materias])
REFERENCES [dbo].[Table_Materias_DB] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Table_Materia__Alumno] CHECK CONSTRAINT [FK_Table_Materia__Alumno]
GO
ALTER TABLE [dbo].[Table_Materias_Profe]  WITH CHECK ADD  CONSTRAINT [FK_Table_Materias_Profe] FOREIGN KEY([id_Profesor])
REFERENCES [dbo].[Table_Profesor_DB] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Table_Materias_Profe] CHECK CONSTRAINT [FK_Table_Materias_Profe]
GO
ALTER TABLE [dbo].[Table_Materias_Profe]  WITH CHECK ADD  CONSTRAINT [FK_Table_Profe_Materias] FOREIGN KEY([id_Materia])
REFERENCES [dbo].[Table_Materias_DB] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Table_Materias_Profe] CHECK CONSTRAINT [FK_Table_Profe_Materias]
GO
ALTER TABLE [dbo].[Table_Profesor_Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Table_Alumno_Profesor] FOREIGN KEY([id_Alumno])
REFERENCES [dbo].[Table_Alumno_DB] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Table_Profesor_Alumno] CHECK CONSTRAINT [FK_Table_Alumno_Profesor]
GO
ALTER TABLE [dbo].[Table_Profesor_Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Table_Profesor_Alumno] FOREIGN KEY([id_Profesor])
REFERENCES [dbo].[Table_Profesor_DB] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Table_Profesor_Alumno] CHECK CONSTRAINT [FK_Table_Profesor_Alumno]
GO
USE [master]
GO
ALTER DATABASE [DB_Entity_Universidad] SET  READ_WRITE 
GO
