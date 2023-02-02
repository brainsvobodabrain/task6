/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


double[] peresechenie(double b1,double k1,double b2, double k2){
    double[] ret={0,0};
    ret[0]=(b2-b1)/(k1-k2);
    ret[1]=k1*ret[0]+b1;
    System.Console.WriteLine(ret[0]);
    return ret;
}
void vivod(double[] v){
    System.Console.WriteLine($"Точка пересечения = [{string.Join(",",v)}]");
}
System.Console.WriteLine("----------------------------------------------------");
System.Console.WriteLine("--       Нахождение пересечения двух прямых       --");
System.Console.WriteLine("----------------------------------------------------");
System.Console.WriteLine();
System.Console.Write("Введите b1: ");
int b1=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите k1: ");
int k1=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b2: ");
int b2=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите k2: ");
int k2=Convert.ToInt32(Console.ReadLine());

vivod(peresechenie(b1,k1,b2,k2));
