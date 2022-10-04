create procedure InsertClients
	(
		@Cliente varchar(128),
		@TipoCliente varchar(64),
		@NomeContato varchar(128),
		@TelefoneContato varchar(12) = NULL,
		@Cidade varchar(64) = NULL,
		@Bairro varchar(64) = NULL,
		@Logradouro varchar(128) = NULL
	)
as
begin
	set nocount on
	insert into Cliente (Cliente, TipoCliente, NomeContato, TelefoneContato, Cidade, Bairro, Logradouro) values (@Cliente, @TipoCliente, @NomeContato, @TelefoneContato, @Cidade, @Bairro, @Logradouro);
end