create database dbTeste;

use dbTeste;

create table Cliente (
	ClienteId int not null identity,
	Cliente varchar(128),
	TipoCliente varchar(64),
	NomeContato varchar(128),
	TelefoneContato varchar(12),
	Cidade varchar(64),
	Bairro varchar(64),
	Logradouro varchar(128),
	DataCadastro datetime default current_timestamp,
	DataAtualizacao datetime default current_timestamp
);



