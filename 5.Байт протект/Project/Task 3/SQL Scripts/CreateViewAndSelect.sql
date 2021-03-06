use [StaffSelection]
GO
Create View PassportViewTask3
 AS 
 SELECT pNo.PASSPORTSERIES as passportSeria,
  pNo.PASSPORTNUBER as passportNumber,
   pName.* 
   FROM [StaffSelection].dbo.PersonPassportTask3  pNo
   INNER JOIN [StaffSelection].dbo.PersonPassportTask3  pName 
     ON (pNo.SECONDNAME = pName.SECONDNAME AND pNo.FIRSTNAME = pName.FIRSTNAME)
GO
select * from PassportViewTask3 vv
where vv.passportSeria = 'MC' and
      vv.passportNumber = 1353436
