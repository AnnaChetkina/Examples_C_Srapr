// int = integer - целые числа
// в наименовании переменной цифра не д стоять на первом месте, также не принято использовать _ для именования переменных 
int numberA = new Random().Next(1, 10); // 1 2 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int sum = numberA + numberB;
Console.WriteLine(sum);