--查詢是否存在TEMP TABLE 並刪除
IF OBJECT_ID('tempdb..#ROY123') IS NOT NULL
BEGIN
	--PRINT'ok'
	DROP TABLE #ROY123
END

--清除執行計劃
dbcc  freeproccache ; 
