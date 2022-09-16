int SumResultArray(string[]array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) sum ++;
    }
    return sum;
}
string[] ChooseThreeCharacters(string[] array,int len){
    string[] resultArr = new string[len];
    int indexResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i].Length <= 3){
            resultArr[indexResult] = array[i];
            indexResult++;
       }
    }
    return resultArr;
}
void PrintArray(string[]array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}


string[] array = {"Книга","Кот","2131","Смайлик","Ник","Страна","Чай","09"};
PrintArray(ChooseThreeCharacters(array,SumResultArray(array)));

