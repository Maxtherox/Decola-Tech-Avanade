## Um resumo sobre SQLServer

## Bancos relacionais

Bancos relacionais são altamente tipados

Cada numero de uma das tabelas vai possuir um tipo, isso na pratica significa que você só podera colocar informações alfa númericas



**Diferencias entre varchar e char:** no var char se você colocar que é 50, quando inserir uma informação nesse campo ele vai guardar aquela informação e apenas ela

no **char** ele vai guardar aquela informação e adiocionar varios espaços até lotar a quantidade que você informou de espaço



## **tipos:**

- **int** (armazena numeros inteiros) 
- **bigint** (armazena numeros maiores)
- **varchar** (armazena alfa numericos)
- **char** (armazena alfa numericos porém reserva menos bits melhorando a navegação(mais leve))
- **bit** (0 ou 1 sendo que 0 é falso 1 é verdadeiro)
- **Float**(aceita casas decimais)



## oque é null e not null?

no nosso primeiro caso (descrição) o uso do **null** na frente da tabela indica que ela **aceita nulos** já o **not null** sinigica que ela **não** aceita **nulos**.

Nulos são ausencia de valores.



## Normalizando dados

**Normalização** é o processo de organização de **dados** em um banco de **dados**. Isso inclui a criação de tabelas e o estabelecimento de relações entre essas tabelas de acordo com as regras projetadas para proteger os **dados** e tornar o banco de **dados** mais flexível, eliminando a redundância e a dependência inconsistente.



**Chaves**: Uma chave estrangeira sempre vai ser uma copia de uma chave primária

[Mais informações aqui](https://docs.microsoft.com/pt-br/office/troubleshoot/access/database-normalization-description)



# Comandos importantes SQLServer

```
Create database NomeDoBancoDeDados //criar banco de dados

use NomedoDB > //Alterar local que esta executando os comandos

create table NomeTable // criar tabela
```

```
create table Teste
(
	Descricao varchar(50) null,
	Complemento char(10) not null
	
)
```

**Apagar tabela**: 

```
drop table NomedaTabela
```

**Encontrar informação na tabela**

```
select * from Clientes

select *
from Clientes 
where TipoPessoa = 'J'
```



**Inserir informação dentro de uma tabela**

```
select * from Clientes
insert into Clientes  (codigo, nome, TipoPessoa) values (1, 'Thiago', 'J')
insert into Clientes  (codigo, nome, TipoPessoa) values (2, 'Ronaldo', 'J')
insert into Clientes  (codigo, nome, TipoPessoa) values (3, 'Aristides', 'F')
insert into Clientes  (codigo, nome, TipoPessoa) values (4, 'Oronob', 'F')
```

```
select * from Produtos

insert Produtos values(1, 'Caneca', 'Caneca incrivel', 5.50)
insert Produtos values(2, 'Copo', 'Copo maravilhoso', 3.50)
```

```
insert Pedido values(1, getdate(), 0, 4, 7) 
```



**Apagar Informação em uma coluna**

```
delete 
from Clientes
where Codigo = '3'

ou 

Delete
from Clientes
where Codigo in (1,2,3,4)
```

**Case**

```
select *,
	case
		when TipoPessoa = 'J' then 'Juridica'
		when TipoPessoa = 'F' then 'Fisica'
		else'Pessoa indefinida'
		end
from clientes
```

**Convert**

```
select *,
	case
		when TipoPessoa = 'J' then 'Juridica'
		when TipoPessoa = 'F' then 'Fisica'
		else'Pessoa indefinida'
		end
from clientes


```

**Alter table e constraint** (Normalizando dados)

```
alter table Clientes add constraint pk_cliente primary key (codigo)
```

**Chave estrangeira**(Normalizando dados)

```
alter table PedidoItem add constraint fk_pedido foreign key (CodigoPedido) references pedido(Codigo)
```





## Joins

## Conceitos básicos de junção

Usando junções, é possível recuperar dados de duas ou mais tabelas com base em relações lógicas entre as tabelas. Junções indicam como SQL Server deveria usar dados de uma tabela para selecionar as linhas em outra tabela.

Uma condição de junção define o modo como duas tabelas são relacionadas em uma consulta por:

- Especificando a coluna de cada tabela a ser usada para a junção. Uma condição de junção típica especifica uma chave estrangeira de uma tabela e sua chave associada na outra tabela.
- Especificando um operador lógico (por exemplo, = ou <>) a ser usado na comparação de valores das colunas.

As junções são expressas logicamente por meio da seguinte sintaxe do Transact-SQL:

- INNER JOIN
- LEFT [ OUTER ] JOIN
- RIGHT [ OUTER ] JOIN
- FULL [ OUTER ] JOIN
- CROSS JOIN

As **junções internas** podem ser especificadas nas cláusulas `FROM` ou `WHERE`. As **junções externas** e as **uniões cruzadas** podem ser especificadas apenas na cláusula `FROM`. As condições de junção combinam-se com as condições de pesquisa `WHERE` e `HAVING` para controlar as linhas selecionadas das tabelas base referenciadas na cláusula `FROM`.

Especificar as condições de junção na cláusula `FROM` ajuda a separá-las de qualquer outro critério de pesquisa que possa ser especificado em uma cláusula `WHERE` e é o método recomendado para a especificação de junções. Uma sintaxe de junção de cláusula ISO `FROM` simplificada é:

```
FROM first_table < join_type > second_table [ ON ( join_condition ) ]

```

*join_type* especifica que tipo de junção é executado: uma junção interna, externa ou cruzada. *join_condition* define o predicado a ser avaliado para cada par de linhas unidas. O seguinte exemplo refere-se a uma especificação de junção da cláusula `FROM`:

```
FROM Purchasing.ProductVendor INNER JOIN Purchasing.Vendor
     ON ( ProductVendor.BusinessEntityID = Vendor.BusinessEntityID )
```

O seguinte exemplo refere-se a uma instrução `SELECT` simples que usa esta junção:

```
SELECT ProductID, Purchasing.Vendor.BusinessEntityID, Name
FROM Purchasing.ProductVendor INNER JOIN Purchasing.Vendor
    ON (Purchasing.ProductVendor.BusinessEntityID = Purchasing.Vendor.BusinessEntityID)
WHERE StandardPrice > $10
  AND Name LIKE N'F%'
GO
```

