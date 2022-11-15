
//static void Moon()
//{
//    Console.WriteLine("bir eded daxil edin");
//    string numstr = Console.ReadLine();
//    int number1 = Convert.ToInt32(numstr);
//    int digits = numstr.Length;
//    int num = 3;
//    for (int i = 1; i <= number1; i++)
//    {
//        num = num * 10;
//    }
//    int sum = number1+num;
//    Console.WriteLine(sum);
//}
//Moon();
static void Son()
{
    string numStr = Console.ReadLine();
    int num = Convert.ToInt32(numStr);
    int result = numStr.Length;
    int main = 3;
    for (int i = 1; i <= result; i++)
    {
        main = main * 10;
    }
    int sum = num + main;
    Console.WriteLine(sum);
}
Son();
