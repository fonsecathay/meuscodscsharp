//O WriteLine()método geralmente é usado para exibir valores de variáveis ​​na janela do console.
//Para combinar texto e uma variável, use o + caractere:
using System;
namespace MyApplication{
    class Program{
        static void Main(string[] args){
            string name = "John";
            string firstname = "Gustavo ";
            string lastname = "Guanabara";
            string fullname = firstname + lastname;
            Console.WriteLine(fullname);
            Console.WriteLine("Hello " + name);
            int x = 5, y = 6, z = 50;//Para declarar mais de uma variável do mesmo tipo , use uma lista separada por vírgulas
            //int x = 5;
            //int y = 6;
            Console.WriteLine(x + y); // para números + funciona como operador matemático
            Console.WriteLine(x + y + z);
            /*int x, y, z;
              x = y = z = 50;
             Console.WriteLine(x + y + z);*/
        }
    }
}
