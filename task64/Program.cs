// See https://aka.ms/new-console-template for more information
int GetNumber()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int OutputNumRec(int num)
{
    if(num==1) 
    {
        Console.Write(""+num);
        return 1;
    }
    else 
    {
        Console.Write(""+num+" ");
        return num*OutputNumRec(num-1);
    }
}

int n=GetNumber();
Console.WriteLine("Числа: " );
OutputNumRec(n);
