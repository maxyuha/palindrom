using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {
            void Zadacha19()
            {
               //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
               int number=Convert.ToInt32(Console.ReadLine());
               int number2= number%10;
               int number3=number/10%10;
               int number4=number/1000%10;
               int number5=number/10000;
               if (number2==number5&&number3==number4)
               {
                Console.WriteLine("палиндром");
               }
               else Console.WriteLine("не является палиндромом");
          
            }
            Zadacha19();
        }

        
     }
    
}