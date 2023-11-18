using HomeWork;

/* Доработайте класс калькулятора способным работать как с целочисленными так и с дробными числами. (возможно стоит задействовать перегрузку операций).
//заменить Convert.ToDouble на собственный DoubleTryPars и обрабатываем ошибку
//проверить что введенное число небыло отрицательное (вывести ошибку Exeption , отловить Catch)
// сумма не может быть отрицательной (при делении и вычитании) */

bool work = true;

DoubleTryPars doubleTryPars = new();

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
        calc.Result = doubleTryPars.DoubleTryParse(Console.ReadLine());
        Console.Write("Введите второе число: ");

        double num2 = doubleTryPars.DoubleTryParse(Console.ReadLine());

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
                try
                {
                    calc.Divide(num2);
                }
                catch (CalculatorDivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (CalculatorExeption ex)
                {
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
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