# Instruções para Rodar os Testes com C# e Cypress

Este repositório contém a automação de testes para a tela de login, utilizando **Cypress** para os testes end-to-end e **C#** para a execução do comando do Cypress.

## Pré-requisitos

Antes de iniciar os testes, é necessário garantir que o ambiente esteja corretamente configurado. Siga os passos abaixo:

### 1. Instalar o .NET SDK

Certifique-se de que o **.NET SDK** está instalado. Caso não tenha o .NET instalado, baixe e instale a versão mais recente do SDK [aqui](https://dotnet.microsoft.com/download).

Você pode verificar se o .NET está instalado executando o comando:

```bash
dotnet --version
```

### 2. Instalar o Node.js e o Cypress
O Cypress é uma ferramenta baseada em Node.js, então você precisará do Node.js instalado. Caso ainda não tenha, baixe e instale o Node.js [aqui](https://nodejs.org/pt).

Após instalar o Node.js, instale o Cypress localmente no projeto executando o seguinte comando:

```bash
npm init -y
npm install cypress --save-dev
```

## Como Rodar os Testes

Execute o seuginte comando no terminal:
```bash
dotnet run --project LoginProject
```

O resultado dos testes será exibido diretamnete no terminal