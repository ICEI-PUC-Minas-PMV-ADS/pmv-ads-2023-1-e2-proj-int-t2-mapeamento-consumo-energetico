# Plano de Testes de Software

**Os requisitos para realização dos testes de software são:**
- **Site publicado na Internet;**
- **Navegador da Internet - Chrome, Firefox ou Edge;**
- **Conectividade de Internet para acesso às plataformas (APISs).**

 **Os testes funcionais a serem realizados no aplicativo são descritos a seguir.:**
 <br>
 

 |**Caso de Teste** 	| **CT-1 – Adicionar dados do Equipamento** 	|
|:---:	|:---:	|
|Requisito Associado 	|RF-01 - A aplicação deve permitir ao usuário incluir o tempo de uso médio de cada equipamento ou eletrodoméstico em Minutos. |
|Objetivo do Teste 	| Verificar se o sistema permite que o usuário consegue incluir dados sobre seu equipamento.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Adicionar Equipamento". <br> |
|Critério de Êxito | - O usuário deve conseguir adicionar os dados de seu equipamento com sucesso. |
|  	|  	|
<br>

|**Caso de Teste** 	| **CT-02 – Editar e Apagar Equipamento** 	|
|:---:	|:---:	|
|Requisito Associado 	|RF-002	A aplicação deve permitir que o usuário edite e apague equipamentos. |
|Objetivo do Teste 	| Verificar se o usuário consegue editar e apagar seus equipamentos.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Adicionar Equipamento"; <br> 4) Preencher os campos obrigatórios (Nome do equipamento, potência e uso em horas); <br> 5) Clicar em "Adicionar Equipamento Equipamento"; <br> 6) Editar ou Apagar um equipamento de sua listagem. |
|Critério de Êxito | - Deve ser editado ou apagado o equipamento selecionado |
|  	|  	|
<br>
 
|**Caso de Teste** 	| **CT-03 – Adicionar tempo médio de uso em horas** 	|
|:---:	|:---:	|
|Requisito Associado 	| RF-003	A aplicação deve permitir ao usuário incluir o tempo de uso médio de cada equipamento ou eletrodoméstico em horas. |
|Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. E alterar os dados do perfil que foram salvos.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Adicionar Equipamento"; <br> 4) Preencher os campos obrigatórios (Nome do equipamento, potência e uso em horas); <br> 5) Clicar em "Adicionar Equipamento Equipamento".
|Critério de Êxito | - O equipamento deve ter suas horas de consumo registradas no sistema  |
|  	|  	|
<br>
 
|**Caso de Teste** 	| **CT-04– Estimativa de Consumo Mensal** 	|
|:---:	|:---:	|
|Requisito Associado 	| RF-004	A aplicação deve gerar um relatório com estimativa de valores mensais de acordo com equipamentos eletroeletrônicos e eletrodomésticos utilizados pelo usuário. |
|Objetivo do Teste 	| Verificar se o usuário consegue ver seu resultado de Consumo Total|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Adicionar Equipamento"; <br> 4) Preencher os campos obrigatórios (Nome do equipamento, potência e uso em horas); <br> 5) Clicar em "Adicionar Equipamento Equipamento"; <br> 6) Clicar em "Confirmar".
|Critério de Êxito | - Seu Consumo final deve ser exibido. |
|  	|  	|
<br>

|**Caso de Teste** 	| **CT-05 – Número de placas fotovoltaicas necessárias** 	|
|:---:	|:---:	|
|Requisito Associado 	|RF-005	A aplicação deve apresentar um resultado com os insumos necessários para implementação de um sistema fotovoltaico. |
|Objetivo do Teste 	| Verificar se o usuário consegue ver a estimativa de placas solares necessárias para abster seu consumo.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Adicionar Equipamento"; <br> 4) Preencher os campos obrigatórios (Nome do equipamento, potência e uso em horas); <br> 5) Clicar em "Adicionar Equipamento Equipamento"; <br> 6) Clicar em "Confirmar".
|Critério de Êxito | - Deve ser exibido o número estimado de placas solares. |
|  	|  	|<br>



| Caso de Teste       | CT-06 – Calculo de Consumo                                             |
|---------------------|-----------------------------------------------------------------------------------|
| Requisito Associado | RF-006	A aplicação deve calcular os valores a partir dos dados de uso dos equipamentos informados pelo usuário.|
| Objetivo do Teste   | Verificar se a aplicação é capaz de gerar o consumo total e por equioamento do usuário. |
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Adicionar Equipamento"; <br> 4) Preencher os campos obrigatórios (Nome do equipamento, potência e uso em horas); <br> 5) Clicar em "Adicionar Equipamento"; <br> 6) Clicar em "Confirmar".
| Critério de Êxito   | - A aplicação deve ser capaz de gerar resultados de consumo total e consumo por equipamento ao usuário. |

<br>

|**Caso de Teste** 	| **CT-07 – Login** 	|
|:---:	|:---:	|
|Requisito Associado 	| RF-007	A aplicação deve permitir que o usuário crie uma conta e consiga realizar seu login. |
|Objetivo do Teste 	| Verificar se o usuário consegue logar na aplicação. E alterar os dados do perfil que foram salvos.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "calcular"; <br> 4) Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, senha, confirmação de senha);  |
|Critério de Êxito | - O perfil deve ser cadastrado com os dados salvos. <br> - Apresentar as alterações que podem ser feitas no dados gravados do perfil cadastrado. |
|  	|  	|<br>


|**Caso de Teste** 	| **CT-08 – Calcular Valores** 	|
|:---:	|:---:	|
|Requisito Associado 	| RF-008	A aplicação deve permitir que o usuário inclua seus equipamentos na aplicação. |
|Objetivo do Teste 	| Verificar se o usuário consegue adicionar seus equipamentos na aplicação.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Adicionar Equipamento"; <br> 4) Preencher os campos obrigatórios (Nome do equipamento, potência e uso em horas); <br> 5) Clicar em "Adicionar Equipamento";
|Critério de Êxito | - O usuário deve conseguir ver sua listagem de quipamentos depois de adicionar seu equipamento. |
|  	|  	|<br>


|**Caso de Teste** 	| **CT-09 – Informativo no resultado** 	|
|:---:	|:---:	|
|Requisito Associado 	| RF-009	A aplicação deve conter um infromativo dos benefícios das placas solares no resultado|
|Objetivo do Teste 	| Verificar se o usuário consegue ver o resultado e o texto informativo sobre placas fotovoltaicas.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Adicionar Equipamento"; <br> 4) Preencher os campos obrigatórios (Nome do equipamento, potência e uso em horas); <br> 5) Clicar em "Adicionar Equipamento"; <br> 6) Clicar em "Confirmar".
|Critério de Êxito | - O usuário deve ver seu resultado e um pequeno texto informativo sobre placas solares. |
|  	|  	|<br>
