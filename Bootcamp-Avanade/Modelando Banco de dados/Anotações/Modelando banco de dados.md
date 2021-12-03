# Modelando banco de dados

Esse readme é uma continuação da primeira aula de SQL Server, aqui sera salvos os comandos usados na modelagem do banco de dados



DB: EstrelaDaMorte

```


CREATE TABLE Planetas(

​		IdPlaneta int NOT NULL,

​		Nome varchar(50) NOT NULL,

​		Rotacao float NOT NULL,

​		Orbita float NOT NULL,

​		Diametro float NOT NULL,

​		Clima varchar(50) NOT NULL,

​		Populacao int NOT NULL,

)

GO

ALTER TABLE Planetas ADD CONSTRAINT PK_Planetas PRIMARY KEY (IdPlaneta);


```

//



```
CREATE TABLE Pilotos(

​	IdPiloto int NOT NULL,

​	Nome varchar(200) NOT NULL,

​	AnoNascimento var char(10) NOT NULL,

​	IdPlaneta

)

GO

ALTER TABLE Pilotos ADD CONSTRAINT PK_Pilotos PRIMARY KEY (IdPiloto);

GO

ALTER TABLE Pilotos ADD CONSTRAINT FK_Pilotos_Planetas FOREIGN KEY (IdPlaneta)

REFERENCES Planetas (IdPlaneta)
```



```
CREATE TABLE PilotosNaves(

	IdPiloto int NOT NULL,
	
	IdNave int NOT NULL,
	
	FlagAutorizado bit NOT NULL,

)

GO 

ALTER TABLE PilotosNaves ADD CONSTRAINT PK_PilotosNaves PRIMARY KEY(IdPiloto, IdNave);

GO

ALTER TABLE PilotosNaves ADD CONSTRAINT FK_PilotosNaves_Pilotos FOREIGN KEY(IdPiloto)

REFERENCES Pilotos(IdPiloto)

GO

ALTER TABLE PilotosNaves ADD CONSTRAINT FK_PilotosNaves_Naves FOREIGN KEY(IdNave)

REFERENCES Naves (IdNave)

GO

ALTER TABLE PilotosNaves ADD CONSTRAINT DF_PilotosNaves_FlagAutorizado DEFAULT(1) FOR FlagAutorizado
```

```
CREATE TABLE HistoricoViagens(

	IdNave Int NOT NULL,
	
	IdPiloto int NOT NULL,
	
	DtSaida datetime NOT NULL,
	
	DtChegada datetime NULL

)
GO



ALTER TABLE HistoricoViagens ADD CONSTRAINT FK_HistoricoViagens_PilotosNaves FOREIGN KEY (IdPiloto, IdNave)

REFERENCES PilotosNaves (IdPiloto, IdNave)

GO

ALTER TABLE HistoricoViagens CHECK CONSTRAINT FK_HistoricoViagens_PilotosNaves
```

Comando de busca  "like"

```
select * from Pilotos where Nome like 'dart%'



select *
from HistoricoViagens t1
inner join Pilotos t2
on t1.IdPiloto = t2.IdPiloto
inner join Naves t3
on t1.IdNave = t3.IdNave
```



//

```
select t1.*,
		t2.Nome,
		t3.Nome
from HistoricoViagens t1
inner join Pilotos t2
on t1.IdPiloto = t2.IdPiloto
inner join Naves t3
on t1.IdNave = t3.IdNave


```



### **Algumas boas praticas:**

- Colocar nomes no plural
- Colocar nomes que sejam claros