USE master
GO

if exists (SELECT * FROM sysdatabases where name='DBMusic')
DROP DATABASE DBMusic
GO

CREATE DATABASE DBMusic
go

USE DBMusic

CREATE TABLE Canción(
Título nvarchar(500),
Album nvarchar(50),
Artistas nvarchar(80),
Ruta nvarchar(500)
)

GO

CREATE PROC PushSong(
@Título nvarchar(100),
@Album nvarchar(50),
@Artistas nvarchar(80),
@Ruta nvarchar(500)
)
AS
INSERT INTO Canción VALUES (@Título, @Album, @Artistas, @Ruta)
GO

CREATE PROC ShowSongs AS SELECT * FROM Canción
GO

CREATE PROC SearchSong(
@TextoRecibido nvarchar(40)
)
AS
SELECT * FROM Canción WHERE Título LIKE '%'+@TextoRecibido+'%'
GO

CREATE PROC EraseALL AS DELETE FROM Canción
GO

CREATE PROC EraseFile(
@NombreCanción nvarchar (80)
)
AS
DELETE FROM Canción WHERE Título LIKE @NombreCanción
GO

