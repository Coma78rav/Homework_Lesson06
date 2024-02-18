void Print(char[,] charsArray){
  string result = "";
foreach (char element in charsArray){
    result += element;
}
Console.WriteLine(result);  
}

Console.Write("Кол-во строк: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов: ");
int m = int.Parse(Console.ReadLine()!);
char[,] charsArray = new char[n,m];
for (int i = 0; i < charsArray.GetLength(0); i++){
    for (int j = 0; j < charsArray.GetLength(1); j++){
        Console.Write("Введите элемент массива: ");
        charsArray[i,j] = char.Parse(Console.ReadLine()!);
    }
}
Print(charsArray);
