--This is Comment
/* Creating a product table

*/
/*DDL */

Create table Product(
  id int primary key identity(1,1),
  name varchar(100),
  quantity int,
  price money
)

--DQL
select * from Product

--DML
insert into Product(name,quantity,price)
           values('Mobile',10,1000);

insert into Product(name,quantity,price)values('Laptop',5,50000);

insert into Product(name,quantity,price)values('Tablet',1,15000);

		   declare @newQuanity int
set @newQuanity=20

update product
set quantity = @newQuanity,name='Tablet'
where id =3

select * from Product

select * from Product 
where name='Tablet'

delete product where id=3

select * from Product