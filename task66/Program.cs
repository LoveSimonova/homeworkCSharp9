// See https://aka.ms/new-console-template for more information
int GetMinNumber()
{
    Console.WriteLine("Введите наименьшее число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetMaxNumber()
{
    Console.WriteLine("Введите наибольшее число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumRec(int min, int num)
{
    if(num==min) 
        return min;    
    else 
        return num+SumRec(min,num-1);
}

int m=GetMinNumber();
int n=GetMaxNumber();
Console.Write("Сумма: " + SumRec(m,n));
