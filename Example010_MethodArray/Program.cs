int [] array = {11, 31, 31, 41, 15, 15, 61, 17, 18, 19};
int n = array.Length;
int find = 15;
int ind = 0;

while (ind < n) {
    if (array[ind] == find){
        Console.WriteLine(ind);
        break;
    }
    ind++;
}