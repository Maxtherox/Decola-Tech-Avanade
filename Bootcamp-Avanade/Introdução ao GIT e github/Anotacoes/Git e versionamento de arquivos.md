# Git e versionamento de arquivos

### O'que é git?

**Git** é um sistema de controle de versão de arquivos. Através deles podemos desenvolver projetos na qual diversas pessoas podem contribuir simultaneamente no mesmo, editando e criando novos arquivos e permitindo que os mesmos possam existir sem o risco de suas alterações serem sobrescritas.



## Comandos essenciais

### **Git add**

Este comando adiciona os arquivos solicitados ao ambiente de stage, é uma forma de dizer para o git que você deseja que as modificações daquele arquivo sejam gravadas na próxima remessa. Um exemplo de utilização é: git add . onde o ponto representa todos os arquivos na pasta.

### **Git commit**

Agora fazemos a gravação em si das modificações, desta forma criamos um snapshot do estado atual do nosso projeto. Uma forma muito usada é o git commit -m “descrição das atualizações do projeto” onde o -m é uma flag que aponta para a mensagem de descrição.

### **Git push**

Por fim precisamos subir essas modificações no nosso repositório remoto, para isso basta utilizar o comando git push e, se já estiver tudo devidamente configurado, os arquivos serão salvos no repositório remoto correspondente ao seu repositório local!

### **Git status**

Este comando permite ver quais arquivos estão sendo “rastreados” pelo git e quais modificações já foram enviadas para o stage. É bem útil para quando se tem dúvidas sobre o que está sendo enviado

### **Git branch**

É usado para verificar todas as branches presentes no repositório. Ao utilizar a flag -r no final do comando é possível ver todas as branches presentes no repositório remoto e se você quiser criar uma nova branch basta utilizar este comando: git branch <branch_name>.



### **Git checkout**

É o comando utilizado para trocar de branch passando o nome da branch destino no final do comando. Caso a flag -b seja colocada após o “checkout” é possível criar a branch em questão e já trocar para esta imediatamente.

