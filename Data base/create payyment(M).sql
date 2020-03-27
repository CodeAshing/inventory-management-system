use ALROUGI
 create table Mpay(
    رقم_الهوية int IDENTITY(1,1) primary key,
    رقم_العقد int  FOREIGN KEY REFERENCES صيانة(رقم_العقد),	
	ااسم_العميل nvarchar (100)  collate arabic_ci_ai ,
    التيليفون  nvarchar (100) collate arabic_ci_ai,
    القسط BIGint  ,
    قيمة_العقد BIGint,
    النسبة_المئوية float ,
    تاريخ nvarchar(100) collate arabic_ci_ai,
    ديسكريبشن  nvarchar (1000)collate arabic_ci_ai,
    مدفوع nvarchar(100) collate arabic_ci_ai
    ); 

	
	select * from Mpay
	union all	
	select '','','',N'المبلغ الإجمالي',SUM(القسط),sum(قيمة_العقد), sum(النسبة_المئوية),'','','' from Mpay

	--cache
	create table MCpay(
	
    رقم_الهوية int IDENTITY(1,1) primary key,	
	ااسم_العميل nvarchar (100)  collate arabic_ci_ai ,
    القسط BIGint  ,
    قيمة_العقد BIGint,
    النسبة_المئوية float ,
    تاريخ nvarchar(100) collate arabic_ci_ai,
    ديسكريبشن  nvarchar (1000)collate arabic_ci_ai,
    مدفوع nvarchar(100) collate arabic_ci_ai
    ); 

	
	select * from MCpay
	union all	
	select '',N'المبلغ الإجمالي',SUM(القسط),sum(قيمة_العقد), sum(النسبة_المئوية),'','','' from MCpay
    