/*Em C#, existem dois tipos de conversão:

Conversão implícita (automaticamente) - convertendo um tipo menor em um tamanho maior
char-> int-> long-> float->double

Conversão explícita (manualmente) - convertendo um tipo maior em um tipo de tamanho menor
double-> float-> long-> int->char*/
//A conversão implícita é feita automaticamente ao passar um tipo de tamanho menor para um tipo de tamanho maior:
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble)

//A conversão explícita deve ser feita manualmente colocando o tipo entre parênteses na frente do valor:

double myDouble = 9.78;
int myInt = (int) myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9

/*Também é possível converter tipos de dados explicitamente usando métodos integrados, como Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32( int) e Convert.ToInt64( long):*/