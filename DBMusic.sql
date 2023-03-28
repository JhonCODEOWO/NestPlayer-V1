USE master
GO

if exists (SELECT * FROM sysdatabases where name='DBMusic')
DROP DATABASE DBMusic
GO

CREATE DATABASE DBMusic
go

USE DBMusic

CREATE TABLE Canci�n(
T�tulo nvarchar(500),
Album nvarchar(50),
Artistas nvarchar(80),
Ruta nvarchar(500)
)

GO

CREATE PROC PushSong(
@T�tulo nvarchar(100),
@Album nvarchar(50),
@Artistas nvarchar(80),
@Ruta nvarchar(500)
)
AS
INSERT INTO Canci�n VALUES (@T�tulo, @Album, @Artistas, @Ruta)
GO

CREATE PROC ShowSongs AS SELECT * FROM Canci�n
GO

CREATE PROC SearchSong(
@TextoRecibido nvarchar(40)
)
AS
SELECT * FROM Canci�n WHERE T�tulo LIKE '%'+@TextoRecibido+'%'
GO

CREATE PROC EraseALL AS DELETE FROM Canci�n
GO

CREATE PROC EraseFile(
@NombreCanci�n nvarchar (80)
)
AS
DELETE FROM Canci�n WHERE T�tulo LIKE @NombreCanci�n
GO

