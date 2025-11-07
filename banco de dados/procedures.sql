USE GestaoChamadosDB;
GO

CREATE OR ALTER PROCEDURE InserirChamado
    @Titulo NVARCHAR(100),
    @Descricao NVARCHAR(MAX),
    @Prioridade NVARCHAR(20),
    @Usuario NVARCHAR(100)
AS
BEGIN
    INSERT INTO Chamados (Titulo, Descricao, Status, Prioridade, Usuario, DataAbertura)
    VALUES (@Titulo, @Descricao, 'Aberto', @Prioridade, @Usuario, GETDATE());
END
GO

CREATE OR ALTER PROCEDURE ListarChamados
AS
BEGIN
    SELECT * FROM Chamados ORDER BY DataAbertura DESC;
END
GO

CREATE OR ALTER PROCEDURE EncerrarChamado
    @Id INT
AS
BEGIN
    UPDATE Chamados
    SET Status = 'Fechado', DataFechamento = GETDATE()
    WHERE Id = @Id;
END
GO
