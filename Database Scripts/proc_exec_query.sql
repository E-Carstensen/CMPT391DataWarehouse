alter proc proc_exec_query @query nvarchar(512) AS
BEGIN
	EXEC(@query)
END
