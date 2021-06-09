CREATE FUNCTION MySeries
(
	@item int
)
RETURNS TABLE 
AS
	RETURN
	(SELECT * FROM ViewTable WHERE id_v = @item);
