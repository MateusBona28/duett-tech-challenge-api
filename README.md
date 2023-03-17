# duett-tech-challenge-api

## Passo a passo para rodar o projeto Parte 1:
- IMPORTANTE: É crucial você cumprir na ordem correta apresentada
- Passo 1: Clonar este repositório
- Passo 2: Entrar na pasta raiz do projeto [ duett-tech-challenge-api ]
- Passo 3: Configurar a variável "ConnectionStrings" do arquivo appsettings.json ( A string já está marcada onde devem ser feitas as alterações de configuração. )
    - Lembrando que: esta etapa, as configurações tanto em código como dessa string de conexão estão feitas para se ligarem a um banco de dados postgres;
    - Você precisa gerar um banco de dados postgres vazio para colocar seu nome na string de conexão também.
- Passo 4: Agora, a partir de um terminal/powershell/bash rodar os seguintes comandos:
    - dotnet restore ( isso irá instalar as dependências necessárias para o projeto funcionar )
    - dotnet ef database update ( isso irá aplicar as migrações previamente criadas por mim, será adicionado no seu banco a tabela Fruit e alguns valores como requisitado no teste )
    - dotnet run program.cs ( isso irá subir a API para ser consumida )

## Pronto!! Agora o servidor está funcionando
* lembrando que você pode acessar este link: https://localhost:7284/swagger/index.html e testar os endpoints, existe um endpoint de post para caso você queira testar enviar novos dados ao banco.