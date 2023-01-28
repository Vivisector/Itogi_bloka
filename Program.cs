string[] m1 = { "abrakadabra", "hi", "paste", "thor", "tor", "234" }; // задали массив на 6 элементов
int cnt = 0; // счетчик нужных элементов
//Console.WriteLine(m[m.Length-1]);

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

void ShowArr(string[] m)
{
    for (int k = 0; k < m.Length; k++)
        Console.Write(m[k] + " ");
}

Console.WriteLine("Исходный массив:");
ShowArr(m1);

Console.WriteLine("\nНовый массив:");
ShowArr(m2);
