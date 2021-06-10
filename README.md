# Sistema ATS

ATS é uma sigla que tem origem do termo em inglês _Applicant Tracking System_ ou, em português, “Sistema de Rastreamento de Candidatos”. 

# Aplicação em .NET Core
Para rodar a aplicação em sua maquina será necessário seguir as seguintes etapas:

 1. Criar um Banco de Dados chamado ***ATS***.
 
 2. No arquivo de ***appsettings.json*** localizado na camada de WebApi, colocar a instância utilizada no SQL Server . Como mostra no exemplo:`"Server=DESKTOP-S9U103C\\SQLExpress; Database=ATS; Trusted_Connection=True;"`
 
 3. Na camada de infra em ***Data*** será preciso rodar os seguintes comandos para que o entity framework possa mapear as classes do ***Domain*** e gerar as tabelas no nosso banco de dados.  Como mostra no exemplo: `Add-Migration`e `Update-Database.`
