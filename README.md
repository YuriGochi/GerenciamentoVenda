# GerenciamentoVenda

API REST em C#
App que gerencia oportunidades de vendas e seus vendedores

Comecei o projeto criando o contexto do banco de dados, herdando o DbContext do Microsoft Entity Framework e passando seu construtor.
![image](https://user-images.githubusercontent.com/78967490/184716766-ef972066-7bbb-4bc3-9f44-df51e650a4d5.png)

Para rodar o projeto eu troquei o service do Swagger que já vem por default na criação do projeto e "inicialmente" eu usei o banco de dados em Memória.
![image](https://user-images.githubusercontent.com/78967490/184717440-ac7e2ef4-0c3f-4852-b6bd-d3292b012deb.png)

Logo em seguida criei um modelo de Usuário e seus atributos, inclui um ENUM com as regiões do Brasi.
![image](https://user-images.githubusercontent.com/78967490/184716401-546b629a-4326-4d69-932c-d48c4638150c.png)

E criei uma UsuáriosController para usar o métodos HTTP e conectei ao banco.
![image](https://user-images.githubusercontent.com/78967490/184717525-9e5e6838-f905-479c-b1a1-c52154bf51e5.png)

Tendo meus métodos POST e GET criados agora eu posso verificar se toda essa brincadeira tá funcionando. Então utilizei o POSTMAN para validar isso. Fiz um POST na URL de usuários com dados no formato JSON e recebi um status 201 created.
![image](https://user-images.githubusercontent.com/78967490/184718709-c22fc594-fd7b-460c-80f6-ea682a4b3233.png)

Criei 2 usuários e dei um GET nessa URL para retornar os usuários criados
![image](https://user-images.githubusercontent.com/78967490/184718800-555ac583-53ac-4b36-8ca0-f001d7cf3021.png)

