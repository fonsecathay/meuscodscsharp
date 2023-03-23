//No exemplo abaixo, usamos o + operador para somar dois valores:
int x = 100 + 50;
//ele também pode ser usado para somar uma variável e um valor, ou uma variável e outra variável:
//Exemplo

int sum1 = 100 + 50;        // 150 (100 + 50)
int sum2 = sum1 + 250;      // 400 (150 + 250)
int sum3 = sum2 + sum2;     // 800 (400 + 400)
//No exemplo abaixo, utilizamos o operador de atribuição= ( ) para atribuir o valor 10 a uma variável chamada x :
//Exemplo

int x = 10;
O operador de atribuição de adição ( +=) adiciona um valor a uma variável:

Exemplo
int x = 10;
x += 5;

//atribuição
/*=	x = 5	x = 5	
+=	x += 3	x = x + 3	
-=	x -= 3	x = x - 3	
*=	x *= 3	x = x * 3	
/=	x /= 3	x = x / 3	
%=	x %= 3	x = x % 3	
&=	x &= 3	x = x & 3	
|=	x |= 3	x = x | 3	
^=	x ^= 3	x = x ^ 3	
>>=	x >>= 3	x = x >> 3	
<<=	x <<= 3	x = x << 3	
*/

/*Uma lista de todos os operadores de comparação:

Operator	Name	      Example	
==	       Equal to	       x == y	
!=	      Not equal	       x != y	
>	     Greater than	    x > y	
<	      Less than	        x < y	
>=	    Greater than or equal to	x >= y	
<=	   Less than or equal to	   x <= y*/

/*&& 	Logical and	Returns True if both statements are true	x < 5 &&  x < 10	
|| 	Logical or	Returns True if one of the statements is true	x < 5 || x < 4	
!	Logical not	Reverse the result, returns False if the result is true	!(x < 5 && x < 10)*/