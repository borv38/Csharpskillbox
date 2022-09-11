using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    internal class Variables
    {
        static void Main(string[] args)
        {
            string fioName = "Борщёв Виталий Викторович";
            byte age = 36; // от 0 до 255, вряд ли здесь это важно, но выбрал такой тип потому что он должен использовать меньше памяти, наиболее подходящий для возраста, возраст не может быть больше 255 и отрицательным
            string elMail = "borv38@gmail.com";
            float codeLearnPoints = 60.32654F; 
            float mathLearnPoints = 92.251876F;
            float physicsLearnPoints = 70.981257F;

            float sumPoints = codeLearnPoints + mathLearnPoints + physicsLearnPoints;
            float avgPoints = (codeLearnPoints + mathLearnPoints + physicsLearnPoints) / 3;

            //вывод через паттерн
            Console.WriteLine("Вывод через паттерн\r\n");
            string pattern = " ФИО: {0}\r\n Возраст: {1}\n Email: {2}\r\n Баллы по программированию: {3}\r\n Баллы по математике: {4}\r\n Баллы по физике: {5}\r\n\r\n";
            Console.WriteLine(pattern,
                fioName,
                age,
                elMail,
                codeLearnPoints,
                mathLearnPoints,
                physicsLearnPoints
                );
            //интерполяция строк
            Console.WriteLine("Вывод через интерполяцию строк\r\n");
            Console.WriteLine($" ФИО: {fioName}\r\n Возраст: {age}\r\n Email: {elMail}\r\n Баллы по программированию: {codeLearnPoints:0.00}\r\n Баллы по математике: {mathLearnPoints:0.00}\r\n Баллы по физике: {physicsLearnPoints:0.00}\r\n");

            //сумма и средний балл
            Console.WriteLine("Нажмите любую клавижу, чтобы посчитать итоговый балл");
            Console.ReadKey();
            Console.WriteLine($" Сумма баллов по всем предметам: {sumPoints:0.00}\r\n");

            Console.WriteLine("Нажмите любую клавижу, чтобы посчитать средний балл");
            Console.ReadKey();
            Console.WriteLine($" Средний балл: {avgPoints:0.00}");
            Console.ReadKey();
        }
    }
}
