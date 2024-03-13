# Calculadora Científica com Memória de Pilha

Este é um programa simples em C# que simula o funcionamento de uma calculadora científica com memória de pilha. Ele permite que o usuário insira números inteiros e realize operações matemáticas básicas (+, -, *, /), manipulando a pilha conforme necessário.

## Funcionamento do Programa

- O usuário pode inserir números inteiros, que serão empilhados.
- Se um dos quatro operadores matemáticos (+, -, *, /) for digitado, o programa realizará a operação correspondente, desempilhando os dois últimos valores e empilhando o resultado.
- O programa exibirá mensagens de erro caso a pilha esteja cheia ou vazia.
- O tamanho máximo da pilha é de 100 valores.

## Exemplo de Uso

Para usar o programa, siga este exemplo:

4<enter> (estado da pilha: 4)  
6<enter> (estado da pilha: 6, 4)  
2<enter> (estado da pilha: 2, 6, 4)  
+<enter> (estado da pilha: 8, 4)  
*<enter> (estado da pilha: 32)  

E um teste completo:

5  
2  
/  
4  
*  
60  
4  
/  
+  
8  
3  
5  
+  
8  
+  
/  
5  
-  
+  
O resultado final será `18`.

## Notas

Este programa foi desenvolvido como um exercício para demonstrar o conceito de uma calculadora com memória de pilha em C#.

---

Espero que este README ajude a entender o funcionamento do programa. Se precisar de mais alguma informação, não hesite em perguntar!
