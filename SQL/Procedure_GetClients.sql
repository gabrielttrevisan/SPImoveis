create procedure GetClients
as
begin
	set nocount on
	select * from Cliente
end