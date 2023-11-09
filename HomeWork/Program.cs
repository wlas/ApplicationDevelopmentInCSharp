using HomeWork;

/* Доработайте программу калькулятор реализовав выбор действий и вывод результатов на экран в цикле так 
 * чтобы калькулятор мог работать до тех пор пока пользователь не нажмет отмена или введёт пустую строку. */

bool work = true;

var calc = new Calc();
calc.MyEventHandler += Calc_MyEventHandler;

string action;

do
{
    Console.WriteLine("Выберите действие: +, -, *, /, q (для выхода)");

    action = Console.ReadLine();

    if (action == "+" || action == "-" || action == "*" || action == "/")

    {
        Console.Write("Введите первое число: ");
        calc.Result = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");

        int num2 = int.Parse(Console.ReadLine());

        switch (action)

        {
            case "+":
                calc.Sum(num2);
                break;
            case "-":
                calc.Sub(num2);
                break;
            case "*":
                calc.Multy(num2);
                break;
            case "/":
                calc.Divide(num2);
                break;
            default:
                Console.WriteLine("Некорректное действие!");
                break;

        }
    }
    else if (action != "q" && action != "")
    {
        Console.WriteLine("Некорректное действие!");
    }

} while (action != "q" && action != "");

Console.WriteLine("Программа завершена.");

void Calc_MyEventHandler(object? sender, EventArgs e)
{
    if (sender is Calc)
        Console.WriteLine("Результат: " + ((Calc)sender).Result);
}