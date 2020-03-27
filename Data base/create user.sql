    create database ALROUGI;
     
    use ALROUGI;
    create table Users(
    UserID int  IDENTITY(1,1) primary key,
    LoginName varchar (100) unique not null,
    Password varchar (100) not null,
    FirstName varchar(100) not null,
    LastName varchar(100) not null,
    Position varchar (100) not null,
    Email varchar(150)not null
    ); 
    insert into Users values ('admin','admin','Akber','Aziz','Administrator','@gmail.com');
    