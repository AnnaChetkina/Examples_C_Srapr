// ключевое слово void - говорит о том, что метод ничего не возвращает (не нужно использ return в теле метода)
void FillArr(int[] collection) 
{
    int Length = collection.Length;
    int ind = 0;

    while (ind < Length){
        collection[ind] = new Random().Next(1, 10);
        ind++;
    }
}

void PrintArr(int[] col) 
{
    int count = col.Length;
    int pos = 0;
    while (pos < count){
        Console.Write(col[pos] + " ");
        pos++;
    }
}

int IndexOf(int[] collection, int find) {
    int count = 0;
    int pos = -1;
    while (count < collection.Length) {
        if (collection[count] == find){
            pos = count;
            break;
            // Console.WriteLine(count);
        }
    count++; 
    }
    return pos;
}

int [] arr = new int[10]; // создание нового массива, в котором б 10 элементов, по умолч он б заполнен нулями (0)

FillArr(arr);
arr[2] = 6;
arr[5] = 6;
PrintArr(arr);
Console.WriteLine();
Console.WriteLine(IndexOf(arr, 56));
