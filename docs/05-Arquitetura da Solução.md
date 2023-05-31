# Arquitetura da Solução
Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes
O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.
<div align="center"> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-mapeamento-consumo-energetico/blob/main/docs/img/Diagrama%20de%20classe.png"> </div>
<div align="center"><sup>Figura 19 - Diagrama de classes </sup></div>

## Modelo ER (Projeto Conceitual)
O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.
<div align="center"> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-pmv-ads-2023-1-e2-proj-int-t4-g2/blob/main/docs/img/entidadesErelacionamentos.png"></div>
<div align="center"><sup>Figura 20 - Diagrama de entidades e relacionamentos </sup></div>


## Projeto da Base de Dados
O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
<div align="center"> <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-mapeamento-consumo-energetico/blob/347b3b803bf261c5ef2d46ba94b0324fae29f6e1/docs/img/Projeto%20da%20Base%20de%20Dados.png"></div>
<div align="center"><sup>Figura 21 - Projeto da Base de Dados </sup></div>
 

## Tecnologias Utilizadas
Segue as tecnologias que foram utilizadas para a realização (desenvolvimento) desta aplicação web backend.

### Linguagens de programação utilizadas:
#### Desenvolvimento do backend:
> - **[C#](https://learn.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/): Linguagem de programação usada para o desenvolvimento do backend da solução. Juntamente com o framework web da Microsoft o ASP.NET.**

#### Desenvolvimento do frontend:
> - **[HTML](https://developer.mozilla.org/pt-BR/docs/Web/HTML): Linguagem de marcação utilizada para estruturar e criar o conteúdo da web.**
> - **[CSS](https://developer.mozilla.org/pt-BR/docs/Web/CSS): Linguagem de folha de estilo utilizada para formatar e estilizar páginas criadas com HTML.**
> - **[JavaScript](https://developer.mozilla.org/pt-BR/docs/Web/JavaScript): Linguagem utilizada para adcionar interatividade e dinamismo da página web.**

#### API utilizada na aplicação:
> - **[ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-7.0&tabs=visual-studio): API utilizada para a implementação e autenticação dos usuários que estão logando e se cadastrando no sistema, devido à sua facilidade de uso e integração com outros recursos do ASP.NET Core.**

#### IDE utilizada:
> - **[Visual Studio Community](https://visualstudio.microsoft.com/pt-br/): Foi escolhido devido a sua integração com o framework ASP.NET.**

#### SGBD utilizado:
> - **[Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads): Escolhemos este software devido ao fato de que cuida do armazenamento, atualização e recuperação de dados computacionais, incluindo os relacionamentos, permitindo toda esta administração de forma remota (através de rede / internet).**

#### Outras tecnologias utilizadas:
> - **[Razor Pages](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-7.0&tabs=visual-studio): Sintaxe de marcação onde possui a camada de "Views" e "Controller" unificadas, ele cria páginas web dinâmicas no framework ASP.NET da Microsoft.**
> - **[ASP.NET CORE MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-7.0): Foi utilizada esta tecnologia, pois implementa o padrão Model-View-Controller e oferece uma base padronizada e organizada para o desenvolvimento desta solução.**
> - **[Lucidchart](https://www.lucidchart.com/pages/): Ferramenta utilizada para o design dos diagramas.**
> - **[GitProjects](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-mapeamento-consumo-energetico/projects?query=is%3Aopen): Ferramenta utilizada para realizar a gestão das tarefas do projeto.**
> - **[Marvel App](https://marvelapp.com/): Ferramenta utilizada para criar os wireframes do projeto.**


## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
