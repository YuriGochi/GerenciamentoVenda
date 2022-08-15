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

Agora eu precisava obter alguns dados desse JSON gerado por esse GET, então criei um método dentro de Oportunidade para obter essas informações direto do CNPJ que eu cadastrei a oportunidade

![image](https://user-images.githubusercontent.com/78967490/184721640-296a8453-a14f-43b6-9ae1-c680b2c8f0df.png)

Fui então para o método POST da oportunidade para retornar todos esses dados logo quando eu cadastrasse a oportunidade

![image](https://user-images.githubusercontent.com/78967490/184721907-a35b3172-b87e-4564-8909-65c69b225520.png)

Mas um dos dados mais importante é o dado do Estado

![image](https://user-images.githubusercontent.com/78967490/184722010-ad2cc9c0-12a6-4367-aced-561593306283.png)

Eu preciso desse ibge_id, para pegar o primeiro caractere e associar a região, e para isso criei uma viriável dentro desse método POST

![image](https://user-images.githubusercontent.com/78967490/184722170-6b024dc1-4245-4907-baf5-0338f34c4347.png)

Dentro dessa variável eu chamo o método que eu criei no modelo Estado

![image](https://user-images.githubusercontent.com/78967490/184722404-4feaa837-c036-4d8f-8cbf-f1443f6d1c88.png)

Que me retorna exatamente o número da região 

![image](https://user-images.githubusercontent.com/78967490/184722303-eb15507a-0c8a-404c-9305-bac9f0c91b4a.png)

Esse é um ótimo teste e fiquei extramente contente de ter tentado, infelizmente não consegui entregar finalizado, ainda há regras de negócio para entrar, refatoração do código e também meu próximo passo era incluir o banco de dados seguindo esse artigo https://www.macoratti.net/17/05/efcore_dbf1.htm.


