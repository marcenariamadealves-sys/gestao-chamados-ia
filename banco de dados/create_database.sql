CREATE DATABASE GestaoChamadosDB;
GO

USE GestaoChamadosDB;
GO

CREATE TABLE Chamados (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Titulo NVARCHAR(100) NOT NULL,
    Descricao NVARCHAR(MAX),
    Status NVARCHAR(50) DEFAULT 'Aberto',
    Prioridade NVARCHAR(20),
    Usuario NVARCHAR(100),
    DataAbertura DATETIME DEFAULT GETDATE(),
    DataFechamento DATETIME NULL
);
GO

INSERT INTO Chamados (Titulo, Descricao, Status, Prioridade, Usuario)
VALUES 
('Erro ao abrir sistema', 'Usuário relata falha ao abrir aplicativo desktop', 'Aberto', 'Alta', 'Lucas Vieira'),
('Problema na senha', 'Colaborador não consegue redefinir senha via portal', 'Em andamento', 'Média', 'Kauan Luiz');
GO
