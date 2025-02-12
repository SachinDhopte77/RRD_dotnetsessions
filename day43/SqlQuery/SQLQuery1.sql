Create table AppUser(
  id int primary key identity(1,1),
  UserName varchar(50),
  "PASSWORD" varchar(50)
 
)

select * from AppUser

insert into AppUser(UserName,PASSWORD)values('SachinH','Password@3');