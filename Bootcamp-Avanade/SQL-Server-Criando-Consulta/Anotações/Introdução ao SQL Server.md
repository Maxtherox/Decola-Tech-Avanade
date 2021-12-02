# Introdução ao SQL Server

O SQL Server é um sistema gerenciador de Banco de dados relacional desenvolvido pela Sybase em parceria com a Microsoft. Esta parceria durou até 1994, com o lançamento da versão para Windows NT e desde então a Microsoft mantém a manutenção do produto.



## Por que armazenar dados?

armazenar dados é uma forma de guardar informações que produzimos hoje para serem reaproveitadas no futuro



## O'que são bancos de dados?

São dados armazenados em algum lugar, exemplo: Planilha do excel, são dados que você pode reaproveitar em algum momento.



## O'que são SGBDs

SGBDs são Softwares que padronizam os bancos de dados, existem diversas formas de armazenas dados como texto, planilhas etc os SGBDs vieram para normalizar esses dados no qual possue uma interface aonde é possivel inserir um dado e você não sabe aonde esse dado é armazenado você apenas sabe a representação dele, como manipular ele atraves da interface do SGBD.



## Tipos de banco de dados:

| Relacionais |  NoSQL   |
| :---------: | :------: |
| SQL Server  | MongoDB  |
|   Oracle    |  Neo4J   |
|    MySQL    | Firebase |

### Diferencia entre as categorias

**Bancos relacionais:** bancos relacionais são para sistemas que precisam de uma confiabilidade muito grande dos dados

**NoSQL:** Os bancos NoSQL são voltados para outros cenarios, como: Melhor perfomance, armazenar grandes quantidades de dados de uma forma mais eficiente



## Representação de banco de dados Relacional

![](https://i.ibb.co/MBm8146/Screen-Dio.png)

[fonte](https://web.dio.me/course/sql-server-criando-suas-primeiras-consultas)

Na imagem acimas temos um **Banco de dados** chamado **E-Commerce** no qual temos essas tabelas que se relacionam entre si (Produtos, vendas, clientes) a estrutura de uma tabela está representada na esquerda da seta.

Uma tabela no banco de dados ela é como uma planilha excel, possui **Linhas**(Registros) e **Colunas**(Informações)





# ACID

Em [ciência da computação](https://pt.wikipedia.org/wiki/Ciência_da_computação), **ACID** (acrônimo de **A**tomicidade, **C**onsistência, **I**solamento e **D**urabilidade - do inglês: *Atomicity, Consistency, Isolation, Durability*) é um conjunto de propriedades de [transação](https://pt.wikipedia.org/wiki/Transação) em [banco de dados](https://pt.wikipedia.org/wiki/Banco_de_dados).



## Atomicidade

Atomicidade é uma caracteristica muito importante dos bancos de dados relacionais, é uma sequência de operações de banco de dados que satisfaz as propriedades ACID e, portanto, pode ser percebida como uma operação lógica única sobre os dados. Por exemplo, uma transferência de fundos de uma conta bancária para outra, mesmo envolvendo múltiplas mudanças, como debitar uma conta e creditar outra, é uma transação única.



## Consistencia dos dados

**Consistência**, no contexto de banco de **dados**, o termo refere-se a transacções que não violem nenhuma restrição de integridade durante a sua execução. Se a transacção deixa a base de **dados** em um estado incorrecto, é abortado e é reportado um erro. É uma das propriedades do acrônimo ACID.



## Isolamento

Em sistemas multi usuários, várias transações podem acessar simultaneamente o mesmo registro (ou parte do registro) no banco de dados. Por exemplo, no mesmo instante é possível que um usuário tente alterar um registro e outro usuário esteja tentando ler este mesmo registro.

O *isolamento* é um conjunto de técnicas que tentam evitar que transações paralelas interfiram umas nas outras, fazendo com que o resultado de várias transações em paralelo seja o mesmo resultado se as mesmas transações fossem executadas sequencialmente (uma após a outra). Operações exteriores a uma dada transação jamais verão esta transação em estados intermediários.

Fornecer isolamento é o objetivo principal do controle de concorrência. Dependendo do método de controle de concorrência (ou seja, se ele usa uma serialização rígida *strict* -- em oposição a *relaxed* --), os efeitos de uma transação incompleta podem não ser visíveis para outra transação.

Por exemplo, considere as duas seguintes transações efetuadas em um banco de dados com informações de funcionários de uma empresa:

> A1 Dar um bônus de 100 reais para o empregado portador do CPF 490.120.530-30, que tem um salário de 1000 reais.

>A2 Dar um bônus de 10% reais para o mesmo empregado (CPF 490.120.530-30, salário de 1000 reais).

Digamos que elas tenham a seguinte forma:

**A1:**

- seleciona funcionário que tenha CPF igual à 490.120.530-30;
- altera o salário somando 100 reais;
- faz o *commit* (confirma a gravação no banco de dados).

**A2:**

- seleciona funcionário que tenha CPF igual à 490.120.530-30;
- altera o salário somando 10%;
- faz o *commit* (confirma a gravação no banco de dados).

Se as duas transações forem executadas sequencialmente, os salário deste funcionário poderá ser:

**A1:** depois **A2:** salário passa a ser 1100 reais e depois, somando 10% de 1100, passa a ser 1210 reais.

**A2:** depois **A1**: salário passa a ser 1100 reais e depois, somando 100 reais, passa a ser 1200 reais.

Então, se executarmos estas duas transações em paralelo, o valor final do salário deste funcionário deve ser de 1200 ou de 1210 reais.

Se as duas transações não estiverem isoladas (uma puder ver os resultados parciais da outra), então, quando executadas em paralelo, pode ocorrer o seguinte:

- **A1** o funcionário;
- **A2** o mesmo funcionário;
- **A1** o salário para 1100 reais;
- **A2** também o salário para 1100 reais;
- **A1** a mudança no banco de dados;
- **A2** grava a mudança no banco de dados.

Assim, no fim, o salário deste funcionário será igual à 1100 reais (valor gravado por {\displaystyle T_{2}}![T_2](https://wikimedia.org/api/rest_v1/media/math/render/svg/d1ba5f12fbb0ff766aec6e22148b429373608555)). Isto ocorreu neste exemplo porque deixamos as duas transações alterarem o mesmo campo (o salário) ao mesmo tempo. A propriedade de isolamento não permite que isto ocorra.

Algumas técnicas de isolamento conhecidas são os [bloqueios bifásicos](https://pt.wikipedia.org/w/index.php?title=Bloqueios_bifásicos&action=edit&redlink=1) e ordenação de marcas de tempo.

**Durabilidade**

Os efeitos de uma transação em caso de sucesso (*commit*) devem persistir no banco de dados mesmo em casos de quedas de energia, travamentos ou erros. Garante que os dados estarão disponíveis em definitivo. Em um banco de dados relacional, por exemplo, quando um grupo de instruções SQL é executado, os resultados precisam ser armazenados permanentemente (mesmo que o banco de dados falhe imediatamente depois). Para se defender contra a perda de energia, as transações (ou seus efeitos) devem ser registradas em uma memória não volátil.

[Fonte: ACID](https://pt.wikipedia.org/wiki/ACID#Isolamento)

