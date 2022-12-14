// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// Например:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int count = 0;
while (true)
{
    string s = Console.ReadLine(); // бесконечно считываем числа пользователя и записываем в переменную тип "строка"
    if(s == "stop") // если пользователь пишет слово stop, то выходим из цикла
    {
        break;
    }
    if(s != "stop") // если пользователь не пишет слово stop
    {
        int num = Convert.ToInt32(s); // записываем значение из переменной s в переменную num при этом конвертурем в тип int
        if(num>0) // приверяем больше ли число 0
        {
            count++; // если больше, то скдаживыем и копим в переменной count
        }
    }
}
Console.WriteLine($"Количество введёных чисел больше 0 = {count}"); // вывод
