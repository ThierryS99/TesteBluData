# TesteBluData

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
![image](https://user-images.githubusercontent.com/107226804/224433738-5a8bb67e-7f44-4557-b263-f2da85343f60.png)



Tela de cadastro da Empresa.
![image](https://user-images.githubusercontent.com/107226804/224434836-874be059-1cbd-45ca-88c0-a33f51a1a48d.png)



Tela de cadastro do Fornecedor.
![image](https://user-images.githubusercontent.com/107226804/224434979-663be380-3a67-4f56-9707-9d103a9c55b2.png)



Tela de consulta de Fornecedores com filtro. Apesar de não listar os fornecedores cadastrados o filtro funciona. Testei com valores fixos dentro do código e ele filtra de acordo com o digitado no campo de texto.
![image](https://user-images.githubusercontent.com/107226804/224435055-bde1aeb1-efd8-4e0a-9e9c-cd085ce7fa1f.png)



Banco de dados com cadastros fictícios apenas para validar operação de Create.
![image](https://user-images.githubusercontent.com/107226804/224437552-4c55b23e-fc0f-438c-87ca-c5c1861ff7d9.png)

Fico aberto a dúvidas, sugestões e correções de código. Agradeço a oportunidade.
