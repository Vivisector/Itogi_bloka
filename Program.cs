string[] m1 = { "abrakadabra", "hi", "paste", "thor", "tor", "234" }; // задали массив на 6 элементов
Console.WriteLine("Исходный массив:");
ShowArr(m1);

/////// вариант решения с двумя циклами
int cnt = 0; // счетчик нужных элементов для заготовки нового массива
for (int i = 0; i < m1.Length; i++)
{ if (m1[i].Length <= 3) cnt++; }
string[] m2 = new string[cnt];
cnt = 0;// новый счетчик для перебора элементов во втором строчном массиве m2
for (int i = 0; i < m1.Length; i++)
{
    if (m1[i].Length <= 3)
    {
        m2[cnt] = m1[i];
        cnt++;
    }
}
///////////// окончание варианта с двумя циклами

// вариант решения с одним циклом (через набор элементов в строку) - предпочтительнее
string s = String.Empty; //заготовили пустую строку
for (int i = 0; i < m1.Length; i++)
{
    if (m1[i].Length <= 3) s = s + m1[i] + " ";
}
string[] ss = s.Split(); // строку превратили в массив

void ShowArr(string[] m)
{
    for (int k = 0; k < m.Length; k++)
        Console.Write(m[k] + " ");
}

Console.WriteLine("\nНовый массив (из старого отобраны элементы с длинной строки до 3 символов):");
// ShowArr(m2);

// теперь или показываем полученную строку
// Console.WriteLine(s);
// или показываем созданный по строке массив
ShowArr(ss); 

