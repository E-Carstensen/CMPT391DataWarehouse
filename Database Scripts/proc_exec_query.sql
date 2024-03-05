create proc proc_exec_query @query nvarchar(128) AS
BEGIN
	EXEC(@query)
END
