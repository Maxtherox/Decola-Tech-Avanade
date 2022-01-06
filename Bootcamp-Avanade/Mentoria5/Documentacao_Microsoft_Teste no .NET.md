# Teste no .NET

 

Este artigo apresenta o conceito de teste e ilustra como diferentes tipos de testes podem ser usados para validar o código. Há várias ferramentas disponíveis para testar aplicativos .NET, como a [CLI](https://docs.microsoft.com/pt-br/dotnet/core/testing/#net-cli) do .NET ou [IDEs (Ambientes](https://docs.microsoft.com/pt-br/dotnet/core/testing/#ide)de Desenvolvimento Integrado).

## Tipos de teste

Ter testes automatizados é uma ótima maneira de garantir que o código do aplicativo faça o que seus autores pretendem fazer. Este artigo aborda testes de unidade, testes de integração e testes de carga.

### Testes de unidade

Um *teste de unidade* é um teste que exercícios individuais de componentes de software ou métodos, também conhecidos como "unidade de trabalho". Os testes de unidade só devem testar o código dentro do controle do desenvolvedor. Eles não testam preocupações com a infraestrutura. As preocupações com a infraestrutura incluem a interação com bancos de dados, sistemas de arquivos e recursos de rede.

Para obter mais informações sobre como criar testes de unidade, consulte [Ferramentas de teste](https://docs.microsoft.com/pt-br/dotnet/core/testing/#testing-tools).

### Testes de integração

Um *teste de integração* é diferente de um teste de unidade, pois ele tem a capacidade de dois ou mais componentes de software de funcionar juntos, também conhecido como "integração". Esses testes operam em um espectro mais amplo do sistema em teste, enquanto os testes de unidade se concentram em componentes individuais. Geralmente, os testes de integração incluem preocupações com a infraestrutura.

### Testes de carga

Um *teste de* carga tem como objetivo determinar se um sistema pode ou não lidar com uma carga especificada, por exemplo, o número de usuários simultâneos usando um aplicativo e a capacidade do aplicativo de lidar com interações responsivas. Para obter mais informações sobre o teste de carga de aplicativos Web, [consulte ASP.NET Core teste de carga/estresse.](https://docs.microsoft.com/pt-br/aspnet/core/test/load-tests)

## Considerações sobre teste

Tenha em mente que há [melhores práticas para](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-best-practices) escrever testes. Por exemplo, [TDD (Desenvolvimento](https://deviq.com/test-driven-development) Orientado por Teste) é quando um teste de unidade é escrito antes do código que ele deve verificar. O TDD é como criar um contorno para um livro antes de você escrevê-lo. Ele destina-se a ajudar os desenvolvedores a escrever código mais legível, simples e eficiente.

## Ferramentas de teste

O .NET é uma plataforma de desenvolvimento de várias linguagens e você pode escrever vários tipos de teste para [C#,](https://docs.microsoft.com/pt-br/dotnet/csharp/) [F#](https://docs.microsoft.com/pt-br/dotnet/fsharp/) [e Visual Basic](https://docs.microsoft.com/pt-br/dotnet/visual-basic/). Para cada um desses idiomas, você pode escolher entre várias estruturas de teste.

### xUnit

[O xUnit](https://xunit.net/) é uma ferramenta gratuita de teste de unidade voltada para a comunidade para .NET. Escrito pelo inventor original do NUnit v2, o xUnit.net é a tecnologia mais recente para aplicativos .NET de teste de unidade. xUnit.net funciona com ReSharper, CodeRong, TestDriven.NET e [Xamarin.](https://dotnet.microsoft.com/apps/xamarin) É um projeto do [.NET Foundation](https://dotnetfoundation.org/) e opera sob seu código de conduta.

Para saber mais, consulte os recursos a seguir:

- [Teste de unidade com C #](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-dotnet-test)
- [Teste de unidade com F #](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-fsharp-with-dotnet-test)
- [Teste de unidade com Visual Basic](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-visual-basic-with-dotnet-test)

### NUnit

[NUnit é](https://nunit.org/) uma estrutura de teste de unidade para todas as linguagens .NET. Inicialmente portada da JUnit, a versão de produção atual foi reescrita com muitos novos recursos e suporte para uma ampla variedade de plataformas .NET. É um projeto do [.NET Foundation.](https://dotnetfoundation.org/)

Para saber mais, consulte os recursos a seguir:

- [Teste de unidade com C #](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-nunit)
- [Teste de unidade com F #](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-fsharp-with-nunit)
- [Teste de unidade com Visual Basic](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-visual-basic-with-nunit)

### MSTest

[O MSTest](https://github.com/Microsoft/testfx-docs) é a estrutura de teste da Microsoft para todas as linguagens .NET. Ele é extensível e funciona com a CLI do .NET e Visual Studio. Para saber mais, consulte os recursos a seguir:

- [Teste de unidade com C #](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-mstest)
- [Teste de unidade com F #](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-fsharp-with-mstest)
- [Teste de unidade com Visual Basic](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-visual-basic-with-mstest)

### CLI do .NET

Você pode executar testes de unidade de soluções da [CLI do .NET](https://docs.microsoft.com/pt-br/dotnet/core/tools/)com o [comando dotnet test.](https://docs.microsoft.com/pt-br/dotnet/core/tools/dotnet-test) A CLI do .NET expõe a maioria das funcionalidades que [os IDEs (Ambientes](https://docs.microsoft.com/pt-br/dotnet/core/testing/#ide) de Desenvolvimento Integrado) disponibilizam por meio de interfaces do usuário. A CLI do .NET é de plataforma cruzada e está disponível para uso como parte dos pipelines de integração e entrega contínuas. A CLI do .NET é usada com processos com script para automatizar tarefas comuns.

### IDE

Se você estiver usando Visual Studio, Visual Studio para Mac ou Visual Studio Code, há interfaces gráficas do usuário para testar a funcionalidade. Há mais recursos disponíveis para IDEs do que a CLI, por [exemplo, Live Unit Testing](https://docs.microsoft.com/pt-br/visualstudio/test/live-unit-testing). Para obter mais informações, consulte [Incluindo e excluindo testes com Visual Studio](https://docs.microsoft.com/pt-br/visualstudio/test/live-unit-testing#include-and-exclude-test-projects-and-test-methods).

## Consulte também

Para obter mais informações, consulte os seguintes artigos:

- [Melhores práticas de teste de unidade com o .NET](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-best-practices)
- [Testes de integração ASP.NET Core](https://docs.microsoft.com/pt-br/aspnet/core/test/integration-tests#test-app-prerequisites)
- [Executar testes de unidade seletivos](https://docs.microsoft.com/pt-br/dotnet/core/testing/selective-unit-tests)
- [Usar a cobertura de código para teste de unidade](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-code-coverage)

------

## Conteúdo recomendado

- [Código C# de teste de unidade no .NET Core usando dotnet test e xUnit - .NET](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-dotnet-test)

  Aprenda os conceitos de teste de unidade no C# e .NET Core por meio de uma experiência interativa de criação passo a passo de uma solução de exemplo usando dotnet test e xUnit.

- [Teste de unidade em C# com NUnit e .NET Core - .NET](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-nunit)

  Aprenda conceitos de teste de unidade no C# e .NET Core por meio de uma experiência interativa, criando passo a passo uma solução de exemplo, usando dotnet test e NUnit.

- [Melhores práticas para escrever testes de unidade - .NET](https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-best-practices)

  Conheça as melhores práticas para escrever testes de unidade que promovem a qualidade e a resiliência do código em projetos .NET Core e .NET Standard.

- [
    ](https://docs.microsoft.com/pt-br/dotnet/core/extensions/dependency-injection)