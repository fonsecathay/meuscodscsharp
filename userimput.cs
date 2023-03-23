// Type your username and press enter
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);

/*O Console.ReadLine()método retorna um arquivo string. Portanto, você não pode obter informações de outro tipo de dados, como int. O seguinte programa causará um erro:*/

//Exemplo
Console.WriteLine("Enter your age:");
int age = Console.ReadLine();
Console.WriteLine("Your age is: " + age);

/*Felizmente, para você, você acabou de aprender no capítulo anterior (Conversão de tipo) , que pode converter qualquer tipo explicitamente, usando um dos Convert.Tométodos:*/

//Exemplo
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);