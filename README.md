# repo

Instruções básicas de como executar o projeto

 - Projeto está executando com o swagger, então basta baixar o código, buildar e rodar que já é exibido a API PasswordValidation e um metodo GET.
 - A API tem retorno 200 e volta um JSON com 2 campos, o isValid que retorna se aquela senha é válida ou não e o campo Message, que volta quais são os pontos de falha

Detalhes sobre a solução

  Fiz uma API Restfull habilitada no swagger para facilitar execução e testes, onde ela chama um projeto de dominio, com isso eu separo as cascas e tenho a possibilidade de reutulização das regras de negócio por outra aplicação. Fiz uma interface onde facilita a implementação do metodo caso seja necessária uma herança futura assim como fiz o encapsulamento das validações utilizando o FluentValidation, assim além de utilizar seus recursos, fica uma classe com todas as validações explicitas com suas devidas mensagens.     
  Outro ponto que me preocupei foi obedecer o SOLID dividindo bem as resposabilidades de cada camada e a separação clara e evitando deixar os metodos fazendo mais de uma coisa e com isso deixando tudo reaproveitavel a qualquer nivel do código. Por fim, fiz os testes unitários validando minha camada de negócio e garantindo todos os cenários válidos e inválidos.

  A minha maior premissa foi deixar separado a camada de aplicação das regras de negócio, assim caso por exemplo queira montar uma pagina MVC utilizando as regras de password, consigo somente acoplar a domonio e já fica disponivel o recurso.
