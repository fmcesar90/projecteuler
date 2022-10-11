// See https://aka.ms/new-console-template for more information
//fn = fn-1 + fn-2
//f3 = f2 + f1
int num = 1;
int sum = 0;
int result = 0;
while (sum < 4000000)
{
    sum = Fibonacci(num);
    if (sum % 2 == 0)
        result += sum;
    num++;
}
Console.WriteLine(result);
int Fibonacci(int num)
{
    if (num <= 1)
        return num;
    return Fibonacci(num - 2) + Fibonacci(num - 1);
}