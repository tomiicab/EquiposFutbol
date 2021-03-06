USE [EquipoFutbol]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 6/10/2021 20:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[id_equipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_equipo] [varchar](50) NOT NULL,
	[director_tecnico] [varchar](50) NOT NULL,
 CONSTRAINT [pk_equipo] PRIMARY KEY CLUSTERED 
(
	[id_equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 6/10/2021 20:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[id_jugador] [int] IDENTITY(1,1) NOT NULL,
	[num_camiseta] [int] NOT NULL,
	[id_persona] [int] NOT NULL,
	[id_posicion] [int] NOT NULL,
	[id_equipo] [int] NOT NULL,
 CONSTRAINT [pk_jugadores] PRIMARY KEY CLUSTERED 
(
	[id_jugador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 6/10/2021 20:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[id_persona] [int] IDENTITY(1,1) NOT NULL,
	[nombre_completo] [varchar](50) NOT NULL,
	[dni] [int] NOT NULL,
	[fecha_nac] [date] NOT NULL,
 CONSTRAINT [pk_personas] PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posiciones]    Script Date: 6/10/2021 20:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posiciones](
	[id_posicion] [int] NOT NULL,
	[nombre_posicion] [varchar](20) NOT NULL,
 CONSTRAINT [pk_posiciones] PRIMARY KEY CLUSTERED 
(
	[id_posicion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Jugadores]  WITH CHECK ADD  CONSTRAINT [fk_jugador_equipo] FOREIGN KEY([id_equipo])
REFERENCES [dbo].[Equipos] ([id_equipo])
GO
ALTER TABLE [dbo].[Jugadores] CHECK CONSTRAINT [fk_jugador_equipo]
GO
ALTER TABLE [dbo].[Jugadores]  WITH CHECK ADD  CONSTRAINT [fk_jugador_persona] FOREIGN KEY([id_persona])
REFERENCES [dbo].[Personas] ([id_persona])
GO
ALTER TABLE [dbo].[Jugadores] CHECK CONSTRAINT [fk_jugador_persona]
GO
ALTER TABLE [dbo].[Jugadores]  WITH CHECK ADD  CONSTRAINT [fk_jugador_posicion] FOREIGN KEY([id_posicion])
REFERENCES [dbo].[Posiciones] ([id_posicion])
GO
ALTER TABLE [dbo].[Jugadores] CHECK CONSTRAINT [fk_jugador_posicion]
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_JUGADOR]    Script Date: 6/10/2021 20:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTAR_JUGADOR]
@nombre varchar(50),
@dni int,
@fecha_nac date,
@num_cami int,
@id_posicion int,
@id_equipo int
AS
BEGIN
INSERT INTO Personas(nombre_completo, dni , fecha_nac)
VALUES				(@nombre,@dni,@fecha_nac)

declare @proximo int
SET @proximo = (SELECT MAX(id_persona) FROM Personas)

INSERT INTO Jugadores(num_camiseta,id_persona,id_posicion,id_equipo)
VALUES (@num_cami, @proximo, @id_posicion, @id_equipo)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_EQUIPOS]    Script Date: 6/10/2021 20:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_EQUIPOS]
AS
BEGIN
	
	SELECT * FROM Equipos;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_POSICIONES]    Script Date: 6/10/2021 20:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_POSICIONES]
AS
BEGIN
	
	SELECT * FROM Posiciones;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PROXIMO_ID_PERSONA]    Script Date: 6/10/2021 20:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID_PERSONA]
@proximo int OUTPUT
AS
BEGIN

	SET @proximo = (SELECT MAX(id_persona)+1  FROM Personas);

END
GO
