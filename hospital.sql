create database hospital;



use hospital;



show tables;



create table paciente(
cod_paciente int primary key,
nome_paciente varchar(12),
idade_paciente int,
poblema_paciente varchar(15),
consulta_paciente varchar(21),
foreign key(consulta_paciente) references consulta
);



create table medico(
codigo_medico int primary key,
nome varchar(90) not null,
consulta_medico varchar(21),
foreign key(consulta_medico) references consulta



);



create table consulta(
cod_consulta int primary key,
tipo_consulta varchar(10),
consulta_medico varchar(21),
consulta_paciente varchar(21),
poblema_paciente varchar (15),
foreign key (poblema_paciente) references paciente
);



show tables