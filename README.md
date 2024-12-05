# Calculadora em C#

Este é um programa de calculadora baseado no **padrão de projeto Strategy**, escrito em C#. Ele permite realizar as operações básicas de adição, subtração, multiplicação e divisão.

## 📋 Funcionalidades

- Soma
- Subtração
- Multiplicação
- Divisão
- Sair do programa

O programa utiliza uma abordagem modular com o padrão Strategy para separar a lógica das operações matemáticas.

## 🛠️ Estrutura do Projeto

O projeto segue a seguinte estrutura:

- **`Calculator.Context`**: Contém a lógica principal da calculadora, usando o contexto para executar a operação escolhida.
- **`Calculator.Strategy`**: Define as interfaces e implementações específicas para cada operação matemática.
- **`Strategy`**: Implementação de operações específicas (adição, subtração, multiplicação, divisão).

## 🚀 Como executar o programa

### Pré-requisitos

- .NET SDK 8

### Passos

1. Clone este repositório:
   ```bash
   git clone https://github.com/carlosrsantos/strategy_pattern_csharp.git

2. Para executar o projeto, abra um terminal e digite o seguinte:
  ```bash
   dotnet run
