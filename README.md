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

Criei 2 usuários e dei um GET nessa URL para retornar os usuários criados.

![image](https://user-images.githubusercontent.com/78967490/184718800-555ac583-53ac-4b36-8ca0-f001d7cf3021.png)

Então fiz o mesmo processo que fiz para usuários para a entidade Oportunidade

Criei o modelo de Oportunidade:

![image](https://user-images.githubusercontent.com/78967490/184720313-a3b2f638-85a7-4598-9daf-3b4760d47285.png)

E então a controller

![image](https://user-images.githubusercontent.com/78967490/184720393-b55d9bcc-0b8c-4de0-bb4d-a585a07bfd46.png)

Então fui no postman e cadastrei uma oportunidade 

![image](https://user-images.githubusercontent.com/78967490/184720548-d05cb4a9-1779-470b-bc06-caea4cadcd1b.png)

E o Get me retornou essa oportunidade.

![image](https://user-images.githubusercontent.com/78967490/184720669-a2069501-30eb-43aa-9c3d-dbe60f45f0b5.png)

Agora tenho que retornar os dados da API pública https://publica.cnpj.ws/cnpj/{cnpj}, então criei o modelo

![image](https://user-images.githubusercontent.com/78967490/184720947-3d14fc52-9d95-4543-ac1b-0b7942cf5180.png)

Dentro de estabelecimento tem

![image](https://user-images.githubusercontent.com/78967490/184720984-c09f830a-2ac5-436c-b60d-dd2bee6fa8f3.png)

Analisei como essa api pública funcionava e precisava então passar um cnpj para dentro dessa uri, decidi usar o cnpj do google para testes e me retornou todos os dados da empresa google 

![image](https://user-images.githubusercontent.com/78967490/184721225-7830b5c1-e382-4e06-ace2-eae8cd308721.png)




