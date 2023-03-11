# Teste Bludata

Esse sistema foi desenvolvido de acordo com o desafio da Bludata Softwares para a vaga de programador C#.

Infelizmente não consegui atender todos os requisitos como:

1- Implementar a regra da idade mínima para UF "PR";
2- Adicionar a propriedade de data do cadastro;
3 - Listar os fornecedores;

Em relação a lista de fornecedores, consigo cadastrar tanto a Empresa quanto o Fornecedor no SQL Server.
Com o Azure Data Studio consigo visualizar os Fornecedores cadastrados, porém algum bug está me impedindo de listar eles na view.

TECNOLOGIAS E FERRAMENTAS UTILIZADAS:                                                                     
1 - Visual Studio;                                           
2 - Azure Data Studio;                                                           
3 - Docker;                                                                                                                                                         
4 - ASP.NET CORE MVC;                                       
5 - Entity Framework;                                            
6 - SQL Server;                                              
7 - Bootstrap;                                                         

INTERFACES:

Tela inicial. Toda vez que iniciado ou que um fornecedor ou empresa é cadastrado retorna para essa view.
![image](https://user-images.githubusercontent.com/107226804/224453472-d7a84a06-fa38-416d-8111-9b8011aefcb5.png)



Tela de cadastro da Empresa.
![image](https://user-images.githubusercontent.com/107226804/224453499-598b4612-dac5-4731-bf64-f23f30e81324.png)



Tela de cadastro do Fornecedor. Nessa tela, tem um bug na qual a tela inicia com a caixa de seleção desmarcada porém mostrando os campos que não deveriam ser mostrado. Após ela ser marcada a primeira vez, passa a funcionar corretamente mostrando os campos somente quando selecionada.
![image](https://user-images.githubusercontent.com/107226804/224453742-06a400fd-7299-4da6-a767-d4d55199d5a1.png)



Tela de consulta de Fornecedores com filtro. Apesar de não listar os fornecedores cadastrados o filtro funciona. Testei com valores fixos dentro do código e ele filtra de acordo com o digitado no campo de texto.
![image](https://user-images.githubusercontent.com/107226804/224453552-37509c03-07ed-4ff7-be4d-402bbb805635.png)



Banco de dados com cadastros fictícios apenas para validar operação de Create.
![image](https://user-images.githubusercontent.com/107226804/224437552-4c55b23e-fc0f-438c-87ca-c5c1861ff7d9.png)

Fico aberto a dúvidas, sugestões e correções de código. Agradeço a oportunidade.
