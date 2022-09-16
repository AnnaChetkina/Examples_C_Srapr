string[,] table = new string[2, 5];// 2 - строки, 5 - столбцы
// table[0, 0] table[0, 1] ... table[0, 4]
// table[1, 0] table[1, 1] ... table[1, 4]
table[1, 2] = "word";
// for (int row = 0; row < 2; row++){
//     for (int column = 0; column < 5; column++){
//         Console.WriteLine($"-{table[row, column]}-");
//     }
// }

void PrintMatrix(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillMatrix(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
// matrix.GetLength(0) - получаем количество строк, matrix.GetLength(1) - количество столбцов
// PrintMatrix(matrix);
// Console.WriteLine();
// FillMatrix(matrix);
// PrintMatrix(matrix);


int[,] pic = new int[,] // в случае если есть фиксированные данные, можно не указывать количество строк и столбцов
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};


void PrintHandImg(int[,] handImgArr){
    for (int i = 0; i < handImgArr.GetLength(0); i++){
        for (int j = 0; j < handImgArr.GetLength(1); j++){
            // Console.Write($"{handImgArr[i, j]} ");
            if (handImgArr[i, j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
    Console.WriteLine();
    }
}

void FillHandImg(int row, int col) {
    if (pic[row, col] == 0) {
        pic[row, col] = 1;
        FillHandImg(row - 1, col);
        FillHandImg(row, col - 1);
        FillHandImg(row + 1, col);
        FillHandImg(row, col + 1);
    }
}

// PrintHandImg(pic);
// FillHandImg(13, 13); // Точка д б внутри руки
// PrintHandImg(pic);

int Factorial(int n){
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(5));
Console.WriteLine(Factorial(3));

for (int i = 1; i < 40; i++){
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
} // когда i станет == 17, произойдет переполнение типа (в int не влезает столько информации) и ф-ция Factorial б выдавать отрицательное значение,
// м заменить int на double для возвращаемого результата

double Factorial2(int n){
    if (n == 1) return 1;
    else return n * Factorial2(n - 1);
}
for (int i = 1; i < 40; i++){
    System.Console.WriteLine($"{i}! = {Factorial2(i)}"); // все ок
}

// f(1) = 1, f(2) = 1, f(n) = f(n - 1) + f(n - 2)
int Fibonacci(int n) {
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 10; i++){
    System.Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}"); 
}

// поменяем возвращаемое значение на double
double Fibonacci2(int n) {
    if (n == 1 || n == 2) return 1;
    else return Fibonacci2(n - 1) + Fibonacci2(n - 2);
}

for (int i = 1; i < 50; i++){
    System.Console.WriteLine($"Fibonacci({i}) = {Fibonacci2(i)}"); // начиная с 38 числа ф-ция очень медленно работает
}