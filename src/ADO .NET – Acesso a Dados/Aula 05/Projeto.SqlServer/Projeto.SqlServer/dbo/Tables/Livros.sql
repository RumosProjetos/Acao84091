CREATE TABLE [dbo].[Livros] (
    [Id]            INT           NOT NULL,
    [Titulo]        VARCHAR (100) NOT NULL,
    [AnoPublicacao] INT           NULL,
    [Genero]        VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

