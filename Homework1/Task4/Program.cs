// Задача 4
Console.Write("Введите первое число: ");
int aa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int bb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int cc = Convert.ToInt32(Console.ReadLine());
if (aa > bb && aa > cc) Console.WriteLine("Max: " + aa); 
if (bb > aa && bb > cc) Console.WriteLine("Max: " + bb);
if (cc > aa && cc > bb) Console.WriteLine("Max: " + cc);