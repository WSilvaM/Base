create database Loja
IF exists(SELECT 1 FROM sys.dataBases where name = 'Loja')

drop database Loja

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
   


	Insert into Usuario(Ativo, NomeUsuario, senha )
	Values(@Ativo, @NomeUsuario,@Senha)
	select @@IDENTITY

GO

