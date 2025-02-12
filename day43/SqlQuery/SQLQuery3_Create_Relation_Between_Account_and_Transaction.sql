create table Account(
id int primary key identity(1,1),
name varchar(20) not null ,
AccountNumber int,
Balance  money not null,
)


insert into Account (name,AccountNumber,Balance) values('Sachin',1001,25000);
insert into Account (name,AccountNumber,Balance) values('Akhilesh',1002,250000);
insert into Account (name,AccountNumber,Balance) values('Sachin Hulawale',1003,260000);

create table Transactions(
id int primary key identity(1,1),
AccountNumber int,
TxnDate DateTime,
TxnType varchar(80),
Amount money not null,
Account_AccountNumber int references Account(id) 
)

select * from Transactions
insert into Account (name,AccountNumber,Balance) values('Sachin',1001,25000);
insert into Transactions (AccountNumber,TxnDate,TxnType,Amount,Account_AccountNumber) values(1001,CURRENT_TIMESTAMP,'Credit',250000,1);
insert into Transactions (AccountNumber,TxnDate,TxnType,Amount,Account_AccountNumber) values(1001,CURRENT_TIMESTAMP,'Debit',15000,1);

insert into Account (name,AccountNumber,Balance) values('Akhilesh',1002,250000);
insert into Transactions (AccountNumber,TxnDate,TxnType,Amount,Account_AccountNumber) values(1001,CURRENT_TIMESTAMP,'Credit',20000,2);
insert into Transactions (AccountNumber,TxnDate,TxnType,Amount,Account_AccountNumber) values(1001,CURRENT_TIMESTAMP,'Debit',35000,2);

insert into Account (name,AccountNumber,Balance) values('Venkat',1003,20000);
insert into Transactions (AccountNumber,TxnDate,TxnType,Amount,Account_AccountNumber) values(1001,CURRENT_TIMESTAMP,'Credit',250000,3);
insert into Transactions (AccountNumber,TxnDate,TxnType,Amount,Account_AccountNumber) values(1001,CURRENT_TIMESTAMP,'Debit',40000,3);