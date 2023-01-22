// //Вид 1 (void - ничего не возвращают/возвращают пустоту) и ничего не принимает.
// void Method1()
// {
//     System.Console.WriteLine("Автор...");
// }
// Method1();


// //Вид 2 (void - ничего не возвращают) но принимают.
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; //Инкремент
//     }
// }
// Method21(msg: "Текст", count: 4); //Если именнованные аргументы, то можно не попорядку.


//Вид3 (не принимает аргументов, но возвращает. ПР.: гененрировать случайные данные)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//Вид4 - что-то принимают и что-то возвращают для дальнейшей работы. Наиболее часто используются.
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //"";

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);