create procedure UpdateClient
	(
		@Id int,
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
	update Cliente set Cliente=@Cliente, TipoCliente=@TipoCliente, NomeContato=@NomeContato, TelefoneContato=@TelefoneContato, Cidade=@Cidade, Bairro=@Bairro, Logradouro=@Logradouro where ClienteId = @Id;
end