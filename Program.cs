﻿ 
    {
 
        int a, b;
 
        Console.WriteLine("Введите два числа");
 
        a = Convert.ToInt32(Console.ReadLine());
 
        b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b)
 
        {
 
            Console.WriteLine("{0} наибольшее число", a);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} наибольшее число ", b);
 
        }
 
        Console.ReadLine();
  if (a < b)
 
        {
 
            Console.WriteLine("{0} наименьшее число", a);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} наименьшее число ", b);
 
        }
 
        Console.ReadLine();
 
    }