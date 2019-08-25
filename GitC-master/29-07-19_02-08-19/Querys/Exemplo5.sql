﻿CREATE TABLE [dbo].[Turmas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nome] VARCHAR(100) NOT NULL
)

GO

CREATE TABLE [dbo].[Alunos]
(
   [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
   [Nome] VARCHAR(100) NOT NULL,
   [Turma] INT NOT NULL,
   CONSTRAINT [FK_Alunos_Turmas] FOREIGN KEY ([Turma]) REFERENCES [Turmas]([Id])
)

GO

CREATE TABLE [dbo].[Notas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Aluno] INT NOT NULL,
	[Nota] INT NOT NULL,

	CONSTRAINT [FK_Notas_Alunos] FOREIGN KEY ([Aluno]) REFERENCES [Alunos]([Id])
)

GO

CREATE TABLE [dbo].[Frequencia]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Aluno] INT NOT NULL,
	[Ativo] BIT NOT NULL,
	[Data] DATETIME NOT NULL DEFAULT GETDATE(),
	CONSTRAINT [FK_Frequencia_Alunos] FOREIGN KEY ([Aluno]) REFERENCES [Alunos]([Id])
)
