/*Метод 1
void Method1()
{
    Console.Writeline(...);
}

Method1(); // вызов метода
*/

/*Метод2*/
void Method2(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        //Console.WriteLine(msg);
        i++;
    }
}
Method2(msg: "Текст сообщения", count: 4);


/*Метод3*/

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

/*Метод4*/
/*string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
*/

string Method4(int count, string c)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Method4(10, "asdf");
//Console.WriteLine(res);

//Пример с циклом for
for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}