# Tipos de construtores

## Objetivos do curso

Apresentar como funciona um construtor, seu uso e funcionalidades, tipos e modos de usar na linguagem C#.Apresentar também delegates e eventos.

### Percurso

Aula 1: Construtores

Aula 2: Getters e Setter

Aula 3: Modificadores 

Aula 4:  Delegates

Aula 5: Eventos



# Construtores

Um construtor é um método especial que contem o mesmo nome do seu tipo de classe, e tem o objetivo de definir valores padrão, limitar uma instancia e facilitar a instanciação de um objeto.

- Um construtor não possui um retorno.
- Um construtor padrão é sempre definido quando não declaramos nenhum para sua classe
- Uma classe pode ter mais de um construtor 

![image-20211127231133537](C:\Users\gui-r\AppData\Roaming\Typora\typora-user-images\image-20211127231133537.png)



# Get e Set

O Get e Set serve para que você possa atribuir um valor em uma variável de maneira controlada e com validações.

![image-20211127231243707](C:\Users\gui-r\AppData\Roaming\Typora\typora-user-images\image-20211127231243707.png)



# Modificadores

O modificador reandonly(Somente leitura) bloqueia um campo contra alterações que não sejam em sua inicialização ou pelo próprio construtor.

![image-20211127231408143](C:\Users\gui-r\AppData\Roaming\Typora\typora-user-images\image-20211127231408143.png)



# Constante

Uma constante representa um valor que somente pode ser atribuído no momento de sua inicialização, e não pode ser modificado posteriormente.

![image-20211127231455458](C:\Users\gui-r\AppData\Roaming\Typora\typora-user-images\image-20211127231455458.png)



# Delegates

Um delegate é uma maneira de passar um método como referência, podendo ser usado como um callback, aceitando qualquer método que contenha a mesma assinatura.

![image-20211127231604134](C:\Users\gui-r\AppData\Roaming\Typora\typora-user-images\image-20211127231604134.png)

# Eventos

Eventos é um mecanismo de comunicação entre objetos, onde existe um publisher, que realiza o evento e subscriber, que se inscreve em um evento.

![image-20211127231709461](C:\Users\gui-r\AppData\Roaming\Typora\typora-user-images\image-20211127231709461.png)

**Aprofundar os conhecimentos em:** 

- Construtores

- Delegates e eventos

- Modificadores

- Propriedades

  