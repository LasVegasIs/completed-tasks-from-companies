use [StaffSelection]
GO
Create VIEW vPersonSkills
AS
select p.FIRSTNAME, p.LASTNAME, s.NAME  
from dbo.tbPersonalData p,  dbo.tbSkills s, dbo.tbExperience e
where 
 p.ID = e.ID_PERSON AND
 s.id = e.ID_SKILL
go
select * from vPersonSkills