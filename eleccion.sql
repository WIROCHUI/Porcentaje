--select * from 
go

create table tb_calculo(
id int primary key identity(1,1),
voto_cas decimal not null,
voto_fuj decimal not null,
voto_blanco decimal not null,
voto_nulo decimal not null,
voto_inpugnados decimal not null,
voto_total_emitido int not null,
)
go

select * from tb_calculo
insert into tb_calculo(voto_cas,voto_fuj,voto_blanco,voto_nulo,voto_inpugnados,voto_total_emitido)values
(42,12,8,5,1,120)
go

drop table tb_votos
create table tb_votos(
id int primary key identity(1,1),
nombre varchar(100) not null,
votos  DECIMAL(18,2)  not null,
create_datetime date
)
go

select * from tb_votos
insert into tb_votos values('PERU LIBRE', 25.5, GETDATE())
insert into tb_votos values('FUERZA POPULAR', 10,GETDATE())
insert into tb_votos values('VOTO BLANCO', 6,GETDATE())
insert into tb_votos values('VOTO NULO', 5,GETDATE())
insert into tb_votos values('VOTO INPUGNADO', 2,GETDATE())
go

 alter PROCEDURE SP_ACTUALIZAR_VOTOS
 @DC_PE_LIBRE DECIMAL(18,2),
 @DC_FU_POPULAR DECIMAL(18,2),
 @DC_NULO DECIMAL(18,2),
 @DC_BLANCO DECIMAL(18,2),
 @DC_INPUGNADO DECIMAL(18,2)
 AS
 UPDATE tb_votos SET votos= @DC_PE_LIBRE WHERE id=1
 UPDATE tb_votos SET votos= @DC_FU_POPULAR WHERE id=2
 UPDATE tb_votos SET votos= @DC_BLANCO WHERE id=3
 UPDATE tb_votos SET votos= @DC_NULO WHERE id=4
 UPDATE tb_votos SET votos= @DC_INPUGNADO WHERE id=5
 GO