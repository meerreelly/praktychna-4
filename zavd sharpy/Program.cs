using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Задача 5.3X1
/*Random rand = new Random(2);
for (int i = 0; i < 9; i++)
{
    int number=rand.Next(1, 9);
    if (number %2 == 0)
    {
        Console.Write(number+"\t");
    }else
    {
        Console.Write($"0({number})\t");
    }
}*/

//Задача 5.5
/*int number =int.Parse(Console.ReadLine());
for(int i = 1; i <11; i++)
{
    Console.WriteLine($"{number}x{i}={number*i}");
}*/

//Задача 5.6.
/*while (true)
{
    Console.WriteLine("1-Дюйми в сантиметри\n2-Сантиметри в дюйми\n3-Вихід ");
    int temp = int.Parse(Console.ReadLine());
    switch (temp)
    {
        case 1:
            Console.WriteLine("Введіть дюйми:");
            double dujmy = double.Parse(Console.ReadLine());
            Console.WriteLine($"{dujmy} Дюймів = {dujmy*2.54} Сантиметрів");
            break;
       case 2:
             Console.WriteLine("Введіть сантиметри:");
            double santymetry = double.Parse(Console.ReadLine());
            Console.WriteLine($"{santymetry} Сантиметрів = {santymetry/2.54} Дюймів");
            break;
        case 3:
             return;
        default:
            break;
            }
}*/

//Задача 5.8.
/*string temp = Console.ReadLine();   
double sum=0;
for(int i = 0; i < temp.Length; i++)
{
    sum+=char.GetNumericValue(temp[i]);
    
}
Console.WriteLine(sum);*/

//Задача 5.9.
/*string temp = Console.ReadLine();   

for(int i = temp.Length-1; i>=0 ; i--)
{
    Console.Write(temp[i]);
    
}*/

//Задача 5.10
/*for(int i=90;i>=5;i--)
{
    if(i%2!=0&&i%3==0&&i%5!=0)Console.Write(i+"\t");
} */

//Задача 5.11
/*while (true)
{
    Console.WriteLine("----Меню----\n[+]-Додати\n[-]-Відняти\n[*]-Помножити\n[/]-Ділити\n[0]-Вихід\n");
    string temp=Console.ReadLine();
    switch (temp)
    {
        case "+":
            Console.WriteLine("Введіть число 1:\n");
            double num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число 2:\n");
            double num2 =int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат:{num1+num2}");
            break;
        case "-":
            Console.WriteLine("Введіть число 1:\n");
             num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число 2:\n");
             num2 =int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат:{num1-num2}");
            break;
            case "*":
            Console.WriteLine("Введіть число 1:\n");
            num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число 2:\n");
            num2 =int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат:{num1*num2}");
            break;
            case "/":
            Console.WriteLine("Введіть число 1:\n");
            num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть число 2:\n");
            num2 =int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат:{num1/num2:f02}");
            break;
            case "0": 
            return;
            default:
            break;
    }
}*/