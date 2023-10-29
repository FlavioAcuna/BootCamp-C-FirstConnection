CREATE DATABASE IF NOT EXISTS PetsDb;
use  PetsDb;

create table IF NOT EXISTS Pets(
 PetId int auto_increment,
 Name varchar(50) not null,
 Type varchar(25) not null,
 Age int not null,
 Hair bool,
 primary key(PetId)
 );
 
insert into Pets(Name,Type,Age,Hair) values("Bruno","Perro",3,true);
insert into Pets(Name,Type,Age,Hair) values("Gaspar","Perro",6,true);
insert into Pets(Name,Type,Age,Hair) values("Fito","Perro",16,true);
insert into Pets(Name,Type,Age,Hair) values("Elvis","Gato",3,true);
insert into Pets(Name,Type,Age,Hair) values("PruebaHair","Prueba",2,false);
select * from Pets;