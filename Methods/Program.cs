{
    Add();
    //Add2(50, 70);
    //int number1;
    //int number2 = 100;
    //var result = Add2(50, 70);
    //var result2 = Add3(out number1, number2);

    //Console.WriteLine(result);
    //Console.WriteLine(result2);


    Console.WriteLine(Multiply(2, 4,50));
    Console.WriteLine(Add4(2, 4,8));

    Console.ReadLine();
}
static void Add()
{
    Console.WriteLine("Added!");
}

static int Add2(int number1, int number2)
{
    var result = number1 + number2;
    return result;
}
static int Add3(out int number1,  int number2)
{
    number1 = 50;
    var result = number1 + number2;
    return result;
}
//static int Multiply(int number1, int number2)
//{
//    return number1 * number2;
//}
static int Multiply(int number1, int number2, int number3)
{
    return number1 * number2 * number3;
}
//static int Add4(int number1, int number2)
//{
//    return number1 + number2;
//}
static int Add4(params int[] numbers)
{
    return numbers.Sum();
}

