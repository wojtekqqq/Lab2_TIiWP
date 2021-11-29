/*Autor: Sławomir Aleksak
    WSEI 2021*/


using System;
using System.Collections.Generic;
using Lab2.SimpleFactory;

namespace Lab2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var F1 = new Funkcja1();
            var F2 = new Funkcja2();
            var F3 = new Funkcja3();
            var F4 = new Funkcja4(); //Dodano z zadania 2
            var Functions = new List<IFunction>();
            Functions.Add(F1);
            Functions.Add(F2);
            Functions.Add(F3);
            Functions.Add(F4); //Dodano z zadania 2

            var kal1 = new Kalkulator1();
            var kal2 = new Kalkulator2();
            var Kalkulatory = new List<ICalculator>();
            Kalkulatory.Add(kal1);
            Kalkulatory.Add(kal2);

            var P1 = new Przedzial1();
            var P2 = new Przedzial2();
            var P3 = new Przedzial3();
            var Przedzialy = new List<IPrzedzialy>();
            Przedzialy.Add(P1);
            Przedzialy.Add(P2);
            Przedzialy.Add(P3);

            Console.WriteLine("PL - 1");
            Console.WriteLine("EN - 2");
            Console.WriteLine("DE - 3");
            var choose = Convert.ToInt32(Console.ReadLine());

            var choosen = LanguageFactory.CreateLanguage((LanguageType)choose);

            choosen.StartLabel();
            foreach (var F in Functions) Console.WriteLine(F.Id + " " + F.Name);
            foreach (var P in Przedzialy) Console.WriteLine(P.Name + " " + P.Id);
            Console.WriteLine("");
            choosen.chooseFunctionLabel();
            var idFunkcji = Convert.ToInt32(Console.ReadLine());
            var wybranyIdFunkcji = Functions.Find(item => item.Id == idFunkcji);
            while (wybranyIdFunkcji == null)
            {
                choosen.chooseErrorLabel();
                idFunkcji = Convert.ToInt32(Console.ReadLine());
                wybranyIdFunkcji = Functions.Find(item => item.Id == idFunkcji);
            }

            choosen.chooseIntervalLabel();
            var idPrzedzialu = Convert.ToInt32(Console.ReadLine());
            var wybranyIdPrzedzialu = Przedzialy.Find(item => item.Id == idPrzedzialu);

            while (wybranyIdPrzedzialu == null)
            {
                choosen.chooseErrorLabel();
                idPrzedzialu = Convert.ToInt32(Console.ReadLine());
                wybranyIdPrzedzialu = Przedzialy.Find(item => item.Id == idPrzedzialu);
            }

            choosen.EndLabel();
            Console.WriteLine(choosen.EndLabelFunction + wybranyIdFunkcji.Name);
            Console.WriteLine(choosen.EndLabelInterval + wybranyIdPrzedzialu.Name);
            Console.WriteLine("");
            foreach (var K in Kalkulatory)
            {
                Console.WriteLine(choosen.EndLabelCalculator + K.Name);
                K.GetIntegralValue(wybranyIdFunkcji, wybranyIdPrzedzialu.rangeFrom(), wybranyIdPrzedzialu.rangeTo());
                Console.WriteLine(choosen.EndLabelSummFunction + wybranyIdFunkcji.Name + choosen.EndLabelSummInterval +
                                  wybranyIdPrzedzialu.Name);
                Console.WriteLine("");
            }
        }
    }
}