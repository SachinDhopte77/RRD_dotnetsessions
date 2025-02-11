Create table ToDoList(
  id int primary key identity(1,1),
  task varchar(100),
  taskdescription varchar(200),
  taskPriority varchar(50),
  TodoDate varchar(50)
)


select * from ToDoList