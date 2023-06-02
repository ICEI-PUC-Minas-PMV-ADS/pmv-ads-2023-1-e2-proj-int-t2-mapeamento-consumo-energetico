# Plano de Testes de Software

**Os requisitos para realização dos testes de software são:**
- **Site publicado na Internet;**
- **Navegador da Internet - Chrome, Firefox ou Edge;**
- **Conectividade de Internet para acesso às plataformas (APISs).**

 **Os testes funcionais a serem realizados no aplicativo são descritos a seguir.:**
 <br>
 

 |**Caso de Teste** 	| **CT-3 – Ver listagem de equipamentos** 	|
|:---:	|:---:	|
|Requisito Associado 	|RF-001 - A aplicação deve permitir ao usuário incluir o tempo de uso médio de cada equipamento ou eletrodoméstico em Minutos. |
|Objetivo do Teste 	| Verificar se o sistema permite que o usuário veja a lista de equipamentos que o mesmo criou.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Adicionar Equipamento". <br> |
|Critério de Êxito | - A listagem deve ser dinamica e o usuário pode adicionar, excluir, editar e ver essa listagem. |
|  	|  	|
<br>

|**Caso de Teste** 	| **CT-11 –Calculo de uso de Equipamento** 	|
|:---:	|:---:	|
|Requisito Associado 	|RF-011	A aplicação deve calcular os valores a partir dos dados de uso dos equipamentos informados pelo usuário empresarial. |
|Objetivo do Teste 	| Verificar se o usuário consegue incluir dados de consumo de equipamento para cadstrar um novo equipamento.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Cadastrar novo aparelho"; <br> 4) Preencher os campos obrigatórios (Nome do equipamento, potência e uso em horas); <br> 5) Clicar em "Registrar Equipamento". |
|Critério de Êxito | - Deve ser exibido o resultado do calculo do Equipamento. |
|  	|  	|
<br>
 
|**Caso de Teste** 	| **CT-12 – Cadastrar perfil** 	|
|:---:	|:---:	|
|Requisito Associado 	| RF-012 - A aplicação deve apresentar na página principal a funcionalidade de cadastro de usuários, para que consigam criar e gerenciar seu perfil. |
|Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. E alterar os dados do perfil que foram salvos.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Registrar"; <br> 4) Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, senha, confirmação de senha); <br> 5) Clicar em "Registrar". |
|Critério de Êxito | - O perfil deve ser cadastrado com os dados salvos. <br> - Apresentar as alterações que podem ser feitas no dados gravados do perfil cadastrado. |
|  	|  	|
<br>
 
|**Caso de Teste** 	| **CT-13– Realizar o login** 	|
|:---:	|:---:	|
|Requisito Associado 	| RF-012 - A aplicação deve apresentar na página principal a funcionalidade de login de usuário, para que consigam logar e gerenciar seu perfil. |
|Objetivo do Teste 	| Verificar se o usuário consegue logar na aplicação. E alterar os dados do perfil que foram salvos.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "Login" <br>4) Preencher os campos obrigatórios (usuário e senha); <br> 4) Clicar em "Entrar". |
|Critério de Êxito | - O perfil deve conseguir realizar o login com sucesso; <br> - Apresentar as configurações que podem ser alteradas do perfil. |
|  	|  	|
<br>

|**Caso de Teste** 	| **CT-05 – Calcular Valores** 	|
|:---:	|:---:	|
|Requisito Associado 	| RF-05 - A aplicação deve apresentar na página principal a funcionalidade de cadastro de usuários, para que consigam calcular seus gastos. |
|Objetivo do Teste 	| Verificar se o usuário consegue logar na aplicação. E alterar os dados do perfil que foram salvos.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Visualizar a página e clicar em "calcular"; <br> 4) Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, senha, confirmação de senha); <br> 5) Clicar em "Calcular".  |
|Critério de Êxito | - O perfil deve ser cadastrado com os dados salvos. <br> - Apresentar as alterações que podem ser feitas no dados gravados do perfil cadastrado. |
|  	|  	|
<br>
|**Caso de Teste** 	| **CT-09– A aplicação deve gerar um orçamentodos valores das plascas fotovoltaicas** 	|
|:---:	|:---:	|
|Requisito Associado 	| RF-09 - A aplicação deve apresentar na página principal um orçamento de valores das placas fotovoltaicas. |
|Objetivo do Teste 	| Verificar se a aplicação é capaz de gerar corretamente um orçamento com os valores das placas fotovoltaicas.|
|Passos 	| 1) Acessar o navegador; <br> 2) Informar o endereço do site; <br> 3) Abrir a aplicação de geração de orçamento de placas fotovoltaicas.<br>4) Preencher os critérios necessários para o cálculo do orçamento, como potência<br> 5) Clicar no botão "Gerar Orçamento". |6) Verificar se a aplicação exibe um orçamento com os valores das placas fotovoltaicas com base nos critérios informados.| 7) Verificar se o orçamento exibido inclui as informações relevantes, como quantidade de placas necessárias, custo unitário das placas.| 8) Comparar os valores do orçamento gerado pela aplicação com os valores esperados com base nos critérios informados.| 9) Verificar se os valores do orçamento estão corretamente formatados e exibidos de acordo com as convenções estabelecidas pela aplicação.|
|Critério de Êxito | - A aplicação deve ser capaz de gerar um orçamento corretamente com base nos critérios informados.<br> -Os valores do orçamento devem ser consistentes e precisos de acordo com os critérios informados.|
|  	|  	|
<br>
