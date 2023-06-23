// See https://aka.ms/new-console-template for more information
int GetNumber()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int AckRec(int m, int n)
{
    if(m==0) 
        return n+1;    
    else if((m>0)&&(n==0))    
        return AckRec(m-1,1);    
    else
        return AckRec(m-1,AckRec(m,n-1));
}

int m=GetNumber();
int n=GetNumber();
Console.WriteLine("А(m,n): " +AckRec(m,n));
