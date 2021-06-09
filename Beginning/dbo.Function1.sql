CREATE FUNCTION User_Item
(
	@login nchar(15)
)
RETURNS INT
AS
BEGIN
	SELECT id_v from Viewers where login=@login;	
	RETURN id_v;
END