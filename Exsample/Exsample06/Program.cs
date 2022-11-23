
// Код для персонального приветствия
// Начало
// Имя пользователя 
// ЕСЛИ имя пользователя совпадает с «Маша», то будем приветствовать его по-особенному.
// ИНАЧЕ — поприветствовать по-обычному (если, например, имя пользователя программа просто напишет «Привет» и соответствующее имя)
// Конец приложения 

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username == "Mаша")
{
    Console.WriteLine("Ура, этоже Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

// Изменим все буквы на нижний регистр 

Console.Write("Введите имя пользователя: ");
string username1 = Console.ReadLine();

if(username1.ToLower() == "маша1")
{
    Console.WriteLine("Ура, этоже МАША1");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username1);
}