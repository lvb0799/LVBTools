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

--查詢DB每個table佔用空間
SELECT  top 300
t.table_name as schema_table
--, t.index_name
, sum(t.used)/1024 as used_in_MB
, sum(t.used)/1024/1024 as used_in_gb
, sum(t.used) as used_in_kb
, sum(t.tbl_rows) as rows
from
(
SELECT o.type_desc,s.Name schema_name
, o.Name table_name
, coalesce(i.Name, 'HEAP') index_name
, p.used_page_count * 8 used
, p.reserved_page_count * 8 reserved
, p.row_count ind_rows
, case when i.index_id in ( 0, 1 ) then p.row_count else 0 end tbl_rows
FROM sys.dm_db_partition_stats p
INNER JOIN sys.objects as o ON o.object_id = p.object_id
INNER JOIN sys.schemas as s
ON s.schema_id = o.schema_id
LEFT OUTER JOIN sys.indexes as i
on i.object_id = p.object_id and i.index_id = p.index_id
WHERE 1=1
and o.is_ms_shipped = 0
) as t
GROUP BY
t.schema_name, t.table_name
--, t.index_name
ORDER BY
2 desc
