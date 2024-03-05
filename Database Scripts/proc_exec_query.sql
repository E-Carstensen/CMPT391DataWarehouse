create proc proc_exec_query @query nvarchar(32) AS
BEGIN
	EXEC(@query)
END
