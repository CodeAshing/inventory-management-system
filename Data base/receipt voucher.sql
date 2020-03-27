use ALROUGI
create table recived(
    رقم_العقد int IDENTITY(1,1) primary key,
    ااسم_العميل nvarchar (100)  collate arabic_ci_ai ,
    تاريخ  nvarchar(100) collate arabic_ci_ai,
    مستلم_من nvarchar(100) collate arabic_ci_ai,
    نوع_الدفع nvarchar(150)collate arabic_ci_ai,
    كمية BIGint  ,
    المبلغ_بالكلمات nvarchar (100) collate arabic_ci_ai ,
    وصف  nvarchar (100) collate arabic_ci_ai 
    ); 
	
	select * from recived
	union all	
	select '','','','',N'المبلغ الإجمالي',sum(كمية) ,'','' from recived