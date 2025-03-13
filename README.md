# Jogo da Forca 
![](https://i.imgur.com/m4W3oMo.gif)
## Detalhes

O computador ir� escolher de forma aleat�ria uma palavra, e cabe ao usuario chutar, letra por letra, at� acertar, caos ele erre mais de 5 vezes, ele perde o jogo

## Entrada 

Os usu�rios s�o solicitados para digitar uma letra no console, caso essa letra exista na palavra secreta, ela � mostrada no console

## Funcionalidades
**Palavra Secreta** - O computador escolhe uma palavra secreta aleat�ria

**Desenho da forca** - A forca � desenhada progressivamente a medida dos erros do jogador

**Feedback Visual** - as letras advinhadas corretamente s�o escritas nos seus respectivos espa�os da palavra, a cada tentativa do jogador

**Contagem de Erros** - O programa conta com uma contagem de erros, onde � avisado para o jogador no console quantas vezes ele errou 

## Como Utilizar 

1. Clone o Reposit�rio
```
git clone https://github.com/bernardo-dos-santos/jogo-da-forca.git
```
2. Navegue at� a pasta paiz da solu��o
```
cd jogo-da-forca
```
3. Restaure as depend�ncias
```
dotnet restore
```
4. Navegue at� a pasta do projeto
```
cd JogoDaForca.ConsoleApp
```
5. Execute o projeto
```
dotnet run
```