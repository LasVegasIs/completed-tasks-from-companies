use [StaffSelection]
GO
with cte (NAME, ID, level, pathstr)
as ( select t.NAME, t.ID, 0 as level, cast('' as nvarchar(500))
   from [StaffSelection].[dbo].[tbSkills] t
   where t.PID = 0
union all
   select t.NAME, t.ID, level + 1, cast ((cte.pathstr + t.NAME) as nvarchar(500))
   from [StaffSelection].[dbo].[tbSkills] t
     inner join cte on t.PID = cte.ID ) 
select ID, space( level ) + NAME as NAME
from cte 
order by pathstr