﻿
Console.WriteLine("Введите первое число:");

int a = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Введите второе число:");

int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
  {
  Console.WriteLine("Первое число большее, а второе меньшее.");
  }
if(a < b)
  {
   Console.WriteLine("Второе число большее, а первое меньшее.");
  }
if(a == b)
  {
    Console.WriteLine("Первое число и второе число равны.");  
  }