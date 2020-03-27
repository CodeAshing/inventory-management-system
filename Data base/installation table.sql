use ALROUGI
create table التركيب(
    رقم_العقد int IDENTITY(1,1) primary key,
    ااسم_العميل nvarchar (100)  collate arabic_ci_ai ,
    التيليفون  nvarchar (100) collate arabic_ci_ai,
    نوع_المصعد  nvarchar(100) collate arabic_ci_ai,
    تاريخ_توقيع_العقد nvarchar(100) collate arabic_ci_ai,
    قيمة_العقد BIGint  ,
    عدد_الطوابق nvarchar(150)collate arabic_ci_ai,
    عدد_الوقفات nvarchar (100) collate arabic_ci_ai ,
    نهاية_الضمان  nvarchar (100) collate arabic_ci_ai,
    عقد_التسليم  nvarchar(100)collate arabic_ci_ai ,
    الموقع  nvarchar(1000) collate arabic_ci_ai,
    ملاحظه  nvarchar (100)collate arabic_ci_ai ,
    الماكينة nvarchar(150)collate arabic_ci_ai,	
    مقاس_وطبيعه_الابواب  nvarchar (100) collate arabic_ci_ai ,
    الارضيه  nvarchar (100) collate arabic_ci_ai,
    نوع_الاستيل nvarchar(100)collate arabic_ci_ai ,
    لكابينة  nvarchar(100) collate arabic_ci_ai,
    ديسكريبشن  nvarchar (1000)collate arabic_ci_ai 
    ); 
	