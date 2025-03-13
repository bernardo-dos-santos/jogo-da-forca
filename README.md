# Jogo da Forca 
![](https://i.imgur.com/m4W3oMo.gif)
## Detalhes

O computador irá escolher de forma aleatória uma palavra, e cabe ao usuario chutar, letra por letra, até acertar, caos ele erre mais de 5 vezes, ele perde o jogo

## Entrada 

Os usuários são solicitados para digitar uma letra no console, caso essa letra exista na palavra secreta, ela é mostrada no console

## Funcionalidades
**Palavra Secreta** - O computador escolhe uma palavra secreta aleatória

**Desenho da forca** - A forca é desenhada progressivamente a medida dos erros do jogador

**Feedback Visual** - as letras advinhadas corretamente são escritas nos seus respectivos espaços da palavra, a cada tentativa do jogador

**Contagem de Erros** - O programa conta com uma contagem de erros, onde é avisado para o jogador no console quantas vezes ele errou 

## Como Utilizar 

1. Clone o Repositório
```
git clone https://github.com/bernardo-dos-santos/jogo-da-forca.git
```
2. Navegue até a pasta paiz da solução
```
cd jogo-da-forca
```
3. Restaure as dependências
```
dotnet restore
```
4. Navegue até a pasta do projeto
```
cd JogoDaForca.ConsoleApp
```
5. Execute o projeto
```
dotnet run
```