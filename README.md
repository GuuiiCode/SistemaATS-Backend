# Sistema ATS

ATS é uma sigla que tem origem do termo em inglês _Applicant Tracking System_ ou, em português, “Sistema de Rastreamento de Candidatos”. 

# Aplicação em .NET Core
Para rodar a aplicação em sua maquina será necessário seguir as seguintes etapas:

 1. Criar um Banco de Dados chamado ***ATS***.
 
 2. No arquivo de ***appsettings.json*** localizado na camada de WebApi, colocar a instância utilizada no seu SQL Server . Como mostra no exemplo: `"Server=DESKTOP-S9U103C\\SQLExpress; Database=ATS; Trusted_Connection=True;"`
 
 3. Na camada de infra em ***Data*** será preciso rodar os seguintes comandos no terminal do Package Manager Console para que o Entity Framework possa mapear as classes do ***Domain*** e gerar as tabelas no nosso banco de dados.  Como mostra no exemplo: `Add-Migration`e `Update-Database.`

# Utilizando o Postman para testar o CRUD

![image](https://user-images.githubusercontent.com/27358198/121503969-f4e86080-c9b7-11eb-94b7-a4d3c1172c34.png)
