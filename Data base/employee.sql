use ALROUGI
create table موظف (
    رقم_العقد int IDENTITY(1,1) primary key,
    ااسم_العميل nvarchar (100)  collate arabic_ci_ai ,	
    الجنسية  nvarchar(100) collate arabic_ci_ai,
    تاريخ_الولادة nvarchar (100) collate arabic_ci_ai,
    تعيين nvarchar(100) collate arabic_ci_ai,
    راتب_اساسي bigint,
    أكاما nvarchar(150)collate arabic_ci_ai,
    بدل_الإيجار bigint,
    بدل_طعام  bigint ,
	البدلات_الأخرى  bigint ,                         
    عنوان  nvarchar(1000) collate arabic_ci_ai,
    جنس  nvarchar (100)collate arabic_ci_ai   ,
    التيليفون   nvarchar (100)collate arabic_ci_ai ,
    ديسكريبشن  nvarchar (1000)collate arabic_ci_ai 
    ); 