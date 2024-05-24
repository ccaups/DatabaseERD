create Procedure [dbo].[spSearchEmployees]
@FirstName nvarchar(100) = NULL,
@LastName nvarchar(100) = NULL,
@Gender nvarchar(50) = NULL,
@Salary int = NULL
As

Begin
	Select * from Employees where
	(FirstName = @FirstName OR @FirstName IS NULL) AND
	(LastName = @LastName OR @LastName IS NULL) AND
	(Gender = @Gender OR @Gender IS NULL) AND
	(Salary = @Salary OR @Salary IS NULL)
End

insert into Employees (FirstName,LastName,Gender,Salary)
values 
('Kaupo', 'Ohlo','Mees', 10000),
('Kaupo1', 'Ohlo','Mees', 10000),
('Kaupo2', 'Ohlo','Mees', 10000),
('Kaupo3', 'Ohlo','Mees', 10000),
('Kaupo5', 'Ohlo','Mees', 10000),
('Kaupo6', 'Ohlo','Mees', 10000),
('Kaupo7', 'Ohlo','Mees', 10000),
('Kaupo8', 'Ohlo','Mees', 10000),
('Kaupo9', 'Ohlo','Mees', 10000),
('Kaupo10', 'Ohlo','Mees', 10000)







