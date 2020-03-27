use ALROUGI
create table قائمة(
    رقم_العقد int IDENTITY(1,1) primary key,
    اسم_العنصر nvarchar (100)  collate arabic_ci_ai ,	
      السعر bigint
    ); 