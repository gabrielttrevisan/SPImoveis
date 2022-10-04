create procedure DeleteClient
	(@ID int)
as
begin
	set nocount on
	delete from Cliente where ClienteId = @ID
end