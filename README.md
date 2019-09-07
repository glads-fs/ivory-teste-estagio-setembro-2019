# ivory-teste-estagio-setembro-2019

## Questão 1

## Calcular Fatorial

Este projeto calcula o fatorial do número escolhido.

A IDE utilizada para executar o projeto foi a VisualStudio 2019 e foi escrito na linguagem C#.

Foi criado pela Empresa Ivory It.

### Execução

É criado duas variáveis inteiras, número e resultado, onde número recebe um valor e resultado receberá o valor do fatorial do número escolhido.
Após é criado a função recursiva Calcular que recebe como parâmetro a variável número e retorna o valor do fatorial desse número.
A variável resultado irá receber o que a função Calcular retornar.
Por fim, é mostrado na tela o resultado.

### Resultado em tela

![ResultadoTELA](https://user-images.githubusercontent.com/52072672/64475665-fab66f80-d15b-11e9-8ba6-fc8739ac0ba0.png)

### Outras informações

Por utilizar o tipo primitivo int, o programa não retorna o resultado certo de números maiores que 12.

Uma solução é trocar o tipo da variável para ulong. Pois como o resultado sempre será positivo, este tipo de variável aceita números muito grandes e apenas positivos, assim aumentando a margem para receber o resultado.



