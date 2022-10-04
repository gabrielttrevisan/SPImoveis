use [dbTeste]
go
DECLARE @i INT, 
@ClienteValue varchar(64), 
@TipoClienteValue varchar(64), 
@NomeContatoValue varchar(64), 
@CidadeValue varchar(64),
@BairroValue varchar(64),
@LogradouroValue varchar(64)
SET @i = 0;
while (@i < 5000)
begin
	set @ClienteValue = 'Teste' + convert(varchar(10), @i)
	set @TipoClienteValue = 'TipoCliente' + convert(varchar(10), @i)
	set @NomeContatoValue = 'Nome Contato ' + convert(varchar(10), @i)
	set @CidadeValue = 'Cidade' + convert(varchar(10), @i)
	set @BairroValue = 'Bairro' + convert(varchar(10), @i)
	set @LogradouroValue = 'Rua Teste ' + convert(varchar(10), @i)

	exec [dbo].[InsertClients]
		@Cliente = @ClienteValue, 
		@TipoCliente = @TipoClienteValue,
		@NomeContato = @NomeContatoValue,
		@TelefoneContato = '31222224444',
		@Cidade = @CidadeValue,
		@Bairro = @BairroValue,
		@Logradouro = @LogradouroValue
	SET @i = @i + 1
end