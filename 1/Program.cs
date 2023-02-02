/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

int[] ReadIntArray(){
    System.Console.Write("Введите колличество чисел, которое Вы хотели бы ввести: ");
    int count=Convert.ToInt32(Console.ReadLine());
    
        int [] ret =new int[count];
        for (int i=0; i<count; i++){
            System.Console.Write($"Введите число {i+1}: ");
            ret[i]=Convert.ToInt32(Console.ReadLine());
        }
    
    return ret;
}
int count_b_zero(int[] a){
    int ret=0;
    for (int i=0; i<a.Length; i++){
        if (a[i]>0){
            ret++;
        }
    }
    return ret;
}

int[] a=ReadIntArray();
System.Console.WriteLine($"Колличество чисел > 0 = {count_b_zero(a)}");