create database ALROUGI
use ALROUGI
--cache
create table Spare (
    رقم_العقد int IDENTITY(1,1) primary key,
    ااسم_العميل nvarchar (100)  collate arabic_ci_ai ,
    الفئة  nvarchar(100) collate arabic_ci_ai,
    اسم_العنصر  nvarchar (100) collate arabic_ci_ai,	
    سعر_السلعة nvarchar(100) collate arabic_ci_ai,	
    كمية nvarchar(100) collate arabic_ci_ai,	
     مجموع nvarchar(150)collate arabic_ci_ai,
    تاريخ nvarchar(150)collate arabic_ci_ai 
    ); 


	create table قطع_غيار (
    رقم_العقد int IDENTITY(1,1) primary key,
    ااسم_العميل nvarchar (100)  collate arabic_ci_ai ,
    الفئة  nvarchar(100) collate arabic_ci_ai,
    اسم_العنصر  nvarchar (100) collate arabic_ci_ai,	
    سعر_السلعة nvarchar(100) collate arabic_ci_ai,	
    كمية nvarchar(100) collate arabic_ci_ai,	
    مجموع nvarchar(150)collate arabic_ci_ai,
    تاريخ nvarchar(150)collate arabic_ci_ai 
    ); 


	select * from قطع_غيار
	union all	
	select ' ','',N'المبلغ الإجمالي','',sum(cast(سعر_السلعة as int)),'', sum(cast(مجموع as int)),'' from Spare

	select  sum(cast(مجموع as int)) from Spare