create database Loja
IF exists(SELECT 1 FROM sys.dataBases where name = 'Loja')



GO
create database Loja
GO

CREATE TABLE USUARIO
(
	ID INT PRIMARY KEY IDENTITY(1,1),
	NomeUsuario varchar(150),
	Senha varchar(100),
	Ativo BIT
)
GO

   CREATE procedure SP_InserirUsuario
   @Id INT output,
	@NomeUsuario varchar(150),
	@Senha varchar(100),
	@Ativo BIT

AS


INSERT INTO USUARIO(Ativo, NomeUsuario, Senha)
VALUES(@ATIVO, @NomeUsuario, @Senha)
set @Id = (select @@IDENTITY)
--select @@IDENTITY

Go

EXEC SP_InserirUsuario 0, 'Teste', '123', 1 
EXEC SP_InserirUsuario 0, 'Wanderson', '123456', 1

SELECT * FROM USUARIO  

