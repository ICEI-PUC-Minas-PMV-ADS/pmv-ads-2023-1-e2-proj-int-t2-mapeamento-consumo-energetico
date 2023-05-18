# Especificações do Projeto

Com os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

| <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-mapeamento-consumo-energetico/blob/main/docs/img/persona1.png" width="350" height="175"/> | Arnaldo Santos, 45 anos|
| ------------------------------------------------------------------------- | ------------------------------------------------------------------|
| Ocupação:                                                       | Cirurgião dentista, proprietário de uma Clínica cooperativa.                                                                                           |
| Aplicativos:                                                    | Instagram, Linkedin, G1, Amazon.                                                        |
| Motivações:                                                     | Avaliar o  consumo energético total da clínica; Entender quais equipamentos consomem mais energia; Efetuar trocas eficientes desses equipamentos.                    |       
| Frustrações:                                                    | Valor exorbitante das contas de energia; Não entender os valores finais na conta de energia; Não conseguir economizar;                                             |
| Hobbies, História:                                              | Gosta de pesquisar sobre novas; tecnologias e demandas do mercado;Política e economia.                                          |
<div align="center"><sup>Figura 4 - Persona 1</sup></div>
<br/>

| <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-mapeamento-consumo-energetico/blob/main/docs/img/persona2.jpg" width="350" height="175"/> | Carlos Gomes, 36 anos|
| ------------------------------------------------------------------------- | ------------------------------------------------------------------|
| Ocupação:                                                       | Mestre de obras.                                                                                           |
| Aplicativos:                                                    | Whatsapp, Tik-Tok, Mercado Livre, Instagram  |
| Motivações:                                                     | Entender melhor sistemas elétricos e padrões de consumo; Construir imóveis com consumo eficiente; Propor análise entre estimativa e valores das contas para localizar problemas nas redes elétricas.|       
| Frustrações:                                                    | Dificuldade em catalogar seus gastos mensais com seu maquinário de trabalho e aparelhos residenciais; Uso de equipamentos antigos com alto custo energético; Desperdício de energia durante o dia.| 
| Hobbies, História:                                              | Gosta de buscar soluções inovadoras para a construção civil; Música; Pescaria. |

<div align="center"><sup>Figura 5 - Persona 2</sup></div>
<br/>

| <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-pmv-ads-2023-1-e2-proj-int-t4-g2/blob/430d9e0852c7842e337d09434988e9eaabfc36b0/docs/img/imagem_2023-04-08_173214534.png" width="250" height="195"/> | Andrea Soares, 44 anos|
| ------------------------------------------------------------------------- | ------------------------------------------------------------------|
| Ocupação:                                                       | Dona de casa / Cabeleireira |
| Aplicativos:                                                    | Tik-Tok, Youtube, Instagram e Kawai. |
| Motivações:                                                     | Expandir seus negócios; Incentivar sua família a fazer o consumo consciente; Reduzir os gastos com energia elétrica.|       
| Frustrações:                                                    | Não conseguir ter uma estimativa prévia de seu consumo mensal de energia; Desequilíbrio financeiro pelo excesso de gastos;| 
| Hobbies, História:                                              | Artesanato; Caminhada ao ar livre; Desenhista nas horas vagas.|
<div align="center"><sup>Figura 6 - Persona 3</sup></div>
<br/>

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.


|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Arnaldo Santos  | Conhecer o gasto de energia nos equipamentos da clínica. | Para que seja capaz de substituir os equipamentos se conveniente para economia de energia.|
|Arnaldo Santos  | Compreender melhor os gastos com energia.             | Para criar estratégias de economia; |
|Arnaldo Santos  | Prever o gasto anual. | Para dimensionar um sistema de produção de energia fotovoltaica.|
|Carlos Gomes | Analisar o perfil de consumo de seus clientes. | Para indicar instalação de painéis solares |
|Carlos Gomes | Estimar valores de sistemas fotovoltaicos. | Para recomendar aos seus clientes a instalação do sistema fotovoltaico.|
|Carlos Gomes | Comparar valores estimados e reais das contas.| Para detectar possíveis falhas na rede elétrica. |
|Andrea Soares | Fazer uso consciente da eletricidade.| Reduzir os gastos. |
|Andrea Soares | Levantamento de custos de um salão de cabeleireiro.| Abrir seu próprio salão. |
## Requisitos de projeto

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.


### Requisitos Funcionais
A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID        | Descrição do Requisito  | Prioridade         |
|----------|-----------------------------------------|----|
|RF-001    | A aplicação deve permitir que o usuário empresarial inclua dados de consumo, como tempo de uso e gasto em WH dos equipamentos. | ALTA  | 
|RF-002    | A aplicação deve permitir que o usuário crie uma conta e escolha entre perfil residencial ou empresarial.| MÉDIA |
|RF-003    | A aplicação deve apresentar de forma clara para o usuário residencial uma listagem de equipamentos eletroeletrônicos e eletroeletrônicos e sua média de consumo em WH.| ALTA | 
|RF-004    | A aplicação deve permitir ao usuário incluir o tempo de uso médio de cada equipamento ou eletrodoméstico em minutos.| MÉDIA |
|RF-005    | A aplicação deve calcular valores a serem pagos na fatura de energia elétrica.| MÉDIA | 
|RF-006    | A aplicação deve gerar um relatório com estimativa de valores mensais de acordo com equipamentos eletroeletrônicos e eletrodomésticos utilizados pelo usuário. | ALTA  |
|RF-007    | A aplicação deve apresentar uma tabela com os insumos necessários para implementação de um sistema fotovoltaico. | BAIXA | 
|RF-008    | A aplicação deve apresentar um catálogo de empresas parceiras onde o usuário pode solicitar orçamentos para compra do sistema fotovoltaico.| BAIXA |
|RF-009    | A aplicação deve gerar um orçamento dos valores das placas fotovoltaicas. | BAIXA |
|RF-010    | A aplicação deve gerar um informativo sugerindo que o usuário realize a análise de valores reais e estimados pela aplicação, com o intuito de alertar ao cliente sobre possíveis problemas na rede elétrica ou em seus equipamentos eletroeletrônicos. | BAIXA |
|RF-011    | A aplicação deve calcular os valores a partir dos dados de uso dos equipamentos informados pelo usuário empresarial.| ALTA  | 

### Requisitos não Funcionais
A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação interativa deve ser publicada em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku).| ALTA | 
|RNF-002| A aplicação interativa deverá ser responsiva permitindo a visualização em um celular de forma adequada. |  ALTA | 
|RNF-003| A aplicação interativa será programada em HTML, Css, Javascript e SQL. |  MÉDIA | 
|RNF-004| A aplicação interativa deve apresentar design moderno e fácil usabilidade. |  ALTA | 
|RNF-005| A aplicação interativa deve ser compatível com os navegadores Chrome, Opera, Edge, Mozilla Firefox, Brave e Safari. |  ALTA | 

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 09/04/2023.|
|RE-02| O aplicativo deve se restringir às tecnologias básicas da Web no Frontend e Backend.|
|RE-03| A equipe não pode subcontratar o desenvolvimento do trabalho.|


## Diagrama de Casos de Uso
O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t2-mapeamento-consumo-energetico/blob/main/docs/img/Diagrama%20de%20caso%20de%20uso.png" width="1000" height="710"/>
<div align="center"><sup>Figura 7 - Diagrama de casos de uso</sup></div>



