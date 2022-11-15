void func (double b1, double k1, double b2, double k2)           //Если прямые пересекаются, значит должны быть общие координаты.
{
double  x = (b2 - b1) / (k1 - k2);                                //формулы выведены из решения системы уравнений    
                                                                 //                        {y = k2 * x + b2
                                                                //                         {y = k1 * x + b1 
double y = k1 * x + b1;
Console.WriteLine($"Пересечение в точке: ({x};{y})");
}
Console.Write("Введите k1: ");                              
double k1= double.Parse (Console.ReadLine ()!);
Console.Write("Введите b1: ");
double b1= double.Parse (Console.ReadLine ()!);
Console.Write("Введите k2: ");
double k2= double.Parse (Console.ReadLine ()!);
Console.Write("Введите b2: ");
double b2= double.Parse (Console.ReadLine ()!);
func (b1, k1, b2,k2);