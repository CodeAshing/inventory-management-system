use ALROUGI
 create table Ipay(
    رقم_الهوية int IDENTITY(1,1) primary key,
    رقم_العقد int  FOREIGN KEY REFERENCES التركيب(رقم_العقد),	
	ااسم_العميل nvarchar (100)  collate arabic_ci_ai ,
    التيليفون  nvarchar (100) collate arabic_ci_ai,
    القسط BIGint  ,
    قيمة_العقد BIGint,
    النسبة_المئوية float ,
    تاريخ varchar(100) ,
    ديسكريبشن  nvarchar (1000)collate arabic_ci_ai,
    مدفوع nvarchar(100) collate arabic_ci_ai
    ); 
	
	select * from Ipay
	union all	
	select '','','',N'المبلغ الإجمالي',SUM(القسط),sum(قيمة_العقد), sum(النسبة_المئوية),'','','' from Ipay where


	--cache
	create table ICpay(
	
    رقم_الهوية int IDENTITY(1,1) primary key,	
	ااسم_العميل nvarchar (100)  collate arabic_ci_ai ,
    القسط BIGint  ,
    قيمة_العقد BIGint,
    النسبة_المئوية float ,
    تاريخ varchar(100) ,
    ديسكريبشن  nvarchar (1000)collate arabic_ci_ai,
    مدفوع nvarchar(100) collate arabic_ci_ai
    ); 
	
	select * from ICpay
	union all	
	select '',N'المبلغ الإجمالي',SUM(القسط),sum(قيمة_العقد), sum(النسبة_المئوية),'','','' from ICpay

	
    