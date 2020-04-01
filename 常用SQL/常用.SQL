--查詢是否存在TEMP TABLE 並刪除
IF OBJECT_ID('tempdb..#ROY123') IS NOT NULL
BEGIN
	--PRINT'ok'
	DROP TABLE #ROY123
END

--清除執行計劃
dbcc  freeproccache ; 

--查詢語法
SELECT
    'dbcc  freeproccache (' as 清除執行計畫_前,plan_handle as 清除執行計畫_編號,');' as 清除執行計畫_後
    ,st.text as 語法
FROM sys.dm_exec_cached_plans
CROSS APPLY sys.dm_exec_sql_text(plan_handle) AS st
WHERE text LIKE N'SELECT * FROM Trans_Account_Raw%';
