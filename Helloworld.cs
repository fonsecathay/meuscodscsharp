using System;//Linha 1: using System significa que podemos usar classes do Systemnamespace.
//Linha 2: Uma linha em branco. C# ignora o espaço em branco. No entanto, várias linhas tornam o código mais legível.					
public class Program//Linha 3: namespace é usada para organizar seu código e é um contêiner para classes e outros namespaces.
{//Linha 4: As chaves {}marcam o início e o fim de um bloco de código.
	public static void Main()//Linha 5: class é um container para dados e métodos, que traz funcionalidade ao seu programa. 
//Cada linha de código executada em C# deve estar dentro de uma classe. Em nosso exemplo, nomeamos a classe Program.
	{//Linha 7: Outra coisa que sempre aparece em um programa C#, é o Mainmétodo. Qualquer código dentro de suas chaves {}será executado. Você não precisa entender as palavras-chave antes e depois de Main. 
		//Você os conhecerá pouco a pouco enquanto lê este tutorial.
		Console.WriteLine("Hello World!");//Linha 9: Console é uma classe do Systemnamespace, que possui um WriteLine()método que é utilizado para saída/impressão de texto. 
		//Em nosso exemplo, a saída será "Hello World!".
		//Se você omitir a using Systemlinha, terá que escrever System.Console.WriteLine()para imprimir/sair do texto.
	}
}