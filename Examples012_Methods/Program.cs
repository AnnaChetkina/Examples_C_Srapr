// Метод ничего не принимает, ничего не возвращает
void Method1(){
    Console.WriteLine("Автор...");
}

// Method1();

// Метод принимает какой-то аргумент, ничего не возвращает
void Method2(string msg){
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");

// именованные аргументы
void Method2_1(string msg, int count){
    int i = 0;
    while(i < count){
        Console.WriteLine(msg);
        i++;
    }
}
// Method2_1("ТЕКСТ", 4);
// Method2_1(count: 2, msg: "Вывод текста с помощью именованных аргументов...");

// Метод ничего не принимает, но что-то возвращает
int Method3(){
    return DateTime.Now.Year;
}
// Console.WriteLine(Method3());

// Метод что-то принимает и что-то возвращает
string Method4(int count, string text){
    // int i = 0;
    string result = String.Empty;
    for (int i = 0; i < count; i++){
        result = result + text;
    }
    // while (i < count){
    //     result = result + text;
    //     i++;
    // }
    return result;
}
// Console.WriteLine(Method4(5, "Метод 4 "));


// цикл for
// for (int i = 2; i <= 10; i++){
//     for (int j = 2; j <= 10; j++){
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Задача - дан текст, в нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде, "
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "123", s[0]
string Replace(string text, char oldVal, char newVal){
    string res = String.Empty;
    for (int i = 0; i < text.Length; i++) {
        if (text[i] == oldVal) res = res + $"{newVal}";
        else res = res + $"{text[i]}";
    }
    return res;
}
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array){
    int count = array.Length;
    for (int i = 0; i < count; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMin(int[] array){
    for (int i = 0; i < array.Length - 1; i++){
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] < array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}
void SelectionSortMax(int[] array){
    for (int i = 0; i < array.Length - 1; i++){
        int maxPos = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] > array[maxPos]) maxPos = j;
        }
        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;
    }
}
// SelectionSortMin(arr);
SelectionSortMax(arr);
PrintArray(arr);
