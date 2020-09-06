create database gym
use gym 
create table gymtable (
id int primary key,
firstname varchar(30),
lastname varchar(30),
startdate varchar(100) not null ,
enddate varchar(100) not null ,
mobile bigint not null ,
price int not null
);
insert into gymtable values(1,'ahmed','mohamed','1/3/2020','2/3/2020','01118877375',600)
insert into gymtable values(2,'mandy','mohamed','1/3/2020','2/3/2020','01118877375',500)

select * from gymtable