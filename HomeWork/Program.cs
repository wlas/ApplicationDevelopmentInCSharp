using HomeWork;

var value = new Bits(9);

var a = "";
try
{
    for (int j = 0; j < 8; j++)
    {
        a += value.GetBit(j) ? 1 : 0;

    }
    a = string.Join("", a.Reverse());

    Console.WriteLine(a);
    Console.WriteLine(value.GetBit(2));

    value.SetBit(false, 2);
    Console.WriteLine(value.Value);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

long l = 3243;
int i = 456;
short s = 45;
byte b = 2;
Bits resultL = l;
Bits resultI = i;
Bits resultS = s;
Bits resultB = b;


