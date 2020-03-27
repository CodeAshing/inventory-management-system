use ALROUGI
create table payment(
    رقم_العقد int IDENTITY(1,1) primary key,
    ااسم_العميل nvarchar (100)  collate arabic_ci_ai ,
    تاريخ nvarchar(100) collate arabic_ci_ai,
    الفئة nvarchar(100) collate arabic_ci_ai,
    نوع_الدفع nvarchar(150)collate arabic_ci_ai,   
    وصف  nvarchar (100) collate arabic_ci_ai ,
    المبلغ_بالكلمات nvarchar (100) collate arabic_ci_ai ,
	 مدفوع BIGint  ,
	 تسلم BIGint  , 
	 المجموع as	  مدفوع-تسلم  
	 ); 

	 
	 
	select * from payment
	union all	
	select '','','','','','',N'المبلغ الإجمالي',SUM(مدفوع), sum(تسلم),'' from payment 



	-- show in grid

	select  t1.ااسم_العميل , t1.تاريخ , t1.الفئة, t1.نوع_الدفع , t1.وصف ,t1.المبلغ_بالكلمات  , t1.مدفوع  , t1.تسلم  ,SUM(t2.المجموع) as المجموع
	from payment t1
	inner join payment t2 on t1.رقم_العقد >= t2.رقم_العقد and t1.ااسم_العميل = t2.ااسم_العميل
	group by t1.رقم_العقد, t1.المجموع, t1.ااسم_العميل , t1.تاريخ , t1.الفئة, t1.نوع_الدفع , t1.وصف ,t1.المبلغ_بالكلمات  , t1.مدفوع  , t1.تسلم  
