create database gym
use gym 
create table gymtable (
firstname varchar(30),
startdate varchar(150) not null ,
enddate varchar(150) not null ,
mobile varchar(30),
price varchar(30)
);
DROP TABLE gymtable;
insert into gymtable values('ahmed','01/03/2020','02/04/2020','01118877375','600')
insert into gymtable values('mandy','01/03/2020','12/12/2020','01118877375','500')

select * from gymtable
delete  from gymtable
SELECT FORMAT (getdate(), 'MM/dd/yyyy ') as date

delete from gymtable where ( SELECT FORMAT (getdate(), 'MM/dd/yyyy ')   ) > ( SELECT CAST(enddate AS datetime))


select * from gymtable where ( SELECT FORMAT (getdate(), 'MM/dd/yyyy ')   ) > ( SELECT CAST(enddate AS datetime))

select * from gymtable where firstname = 'ahmed'

create table deletegymtable (
firstname varchar(30),
startdate varchar(150) not null ,
enddate varchar(150) not null ,
mobile varchar(30),
price varchar(30)
);


INSERT INTO deletegymtable
select * from gymtable where ( SELECT FORMAT (getdate(), 'MM/dd/yyyy ')   ) > ( SELECT CAST(enddate AS datetime))

 Drop table deletegymtable

select * into deletegymtable from gymtable

delete  from deletegymtable
select DISTINCT * from deletegymtable