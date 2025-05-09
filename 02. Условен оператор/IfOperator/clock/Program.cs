﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            // Булева променлива, която съхраняваме дали въведените входни данни от потребителя са коректни 
            bool isCorrectClock = true;
            if (hour >= 0 && hour < 24)// Проверка дали часът е в диапазона [0,23]
            {
                if (hour < 10)//проверка дали часът е едноцифрено число
                {
                    Console.Write("0" + hour + ":");//изписване часа с водеща нула
                }
                else//ако часът е двуцифрено число
                {
                    Console.Write(hour + ":"); //изписва часа без водеща нула
                }
            }
            else // Ако стойността на променливата hour не е в правилния диапазон
            {
                Console.Write("XX:");//на мястото за часа се изписва ХХ
                isCorrectClock = false;//булевата променилва променя стойността си от true на false
            }

            if (min >= 0 && min < 60) //Проверка дали минутите са в диапазона[0,59]
            {
                if (min < 10) //проверка дали минутите са едноцифрено число
                {
                    Console.WriteLine("0" + min);//изписва минутите с водеща нула
                }
                else// ако минутите са двуцифрено число
                {
                    Console.WriteLine(min); //изписва минутите без водеща нула
                }
            }
            else // Ако стойността на променливата min не е в правилния диапазон
            {
                Console.WriteLine("XX");//на мястото за минутите се изписва ХХ
                isCorrectClock = false;//булевата променлива приема стойнст false
            }

            //Използваме булевата променлива, за да прецени дали въведените от потребителя данни, наистина са коректен час и минути
            //Ако всичко е наред булевата променлива не би трябвало да си е променила първоначалната стойност true
            if (isCorrectClock == true)
            {
                Console.WriteLine("Add 15 minutes"); //Към коректния час трябва да прибавим 15 минути
                int total = hour * 60 + min + 15; //Преобразуваме всички данни в една мерна единица(минути) и ги сабираме
                hour = total / 60;// от общия брой минути, чрез делене извеждаме часа
                min = total % 60; // от общия брой минути, чрез делене с остатък (модулно делене) извеждаме минутите
                if (hour > 23)    // Проверка дали не сме преминали в следващия ден
                {
                    Console.WriteLine($"00:{min:d2}"); //Извеждане на изходни данни, чрез интерполиране d2-извежда минутите с водеща нула
                }
                else // Ако новият час е в границите на същия ден
                    Console.WriteLine($"{hour:d2}:{min:d2}");// Извеждане на новия час, чрез интерполация
            }
            else// Ако булевата променлива е приела стойнот false се извежда съобщение, че са зададени некоретни данни
            {
                Console.WriteLine("Incorrect data!");
            }
        }
    }
}
