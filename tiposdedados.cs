using System;
namespace MyApplication{
    class Program{
        static void Main(string[] args){
         int myNum = 100000;//int para num inteiros + or -.
         Console.WriteLine(myNum);
         long myNum = 15000000000L;//long para numeros maiores q o int pode suportar.necessario botar o L no final
         Console.WriteLine(myNum);
         float myNum = 5.75F;
         Console.WriteLine(myNum);
         double myNum = 19.99D;
         Console.WriteLine(myNum);
         //Um número de ponto flutuante também pode ser um número científico com um "e" para indicar a potência de 10:
         float f1 = 35e3F;
         double d1 = 12E4D;
         Console.WriteLine(f1);
         Console.WriteLine(d1);
         //Um tipo de dados booleano é declarado com a boolpalavra-chave e só pode receber os valores trueou false
         bool isCSharpFun = true;
         bool isFishTasty = false;
         Console.WriteLine(isCSharpFun);   // Outputs True
         Console.WriteLine(isFishTasty);   // Outputs False
         //O chartipo de dados é usado para armazenar um único caractere. O caractere deve estar entre aspas simples, como 'A' ou 'c':
         char myGrade = 'B';
         Console.WriteLine(myGrade);
         string greeting = "Hello World";
         Console.WriteLine(greeting);
        }
    }
}
/*A precisão de um valor de ponto flutuante indica quantos dígitos o valor pode ter após o ponto decimal. A precisão de floaté de apenas seis ou sete dígitos decimais, enquanto doubleas variáveis ​​têm uma precisão de cerca de 15 dígitos. Portanto, é mais seguro usar doublepara a maioria dos cálculos.*/