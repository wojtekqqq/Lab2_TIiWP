using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.ConcreteProduct
{
    class Pl : ILanguage
    {
        public int Id => 1;

        public string Language => "PL";
        void ILanguage.StartLabel()
        {
            Console.WriteLine("*** " +
                              "Obliczanie przybliżonej wartości całki dla wybranej funkji i zakresu danych ***");
        }
        void ILanguage.chooseFunctionLabel()
        {
            Console.WriteLine("Podaj nr funkcji");
        }
        public void chooseErrorLabel()
        {
            Console.WriteLine("Nr poza zakresem podaj jeszcze raz");
        }
        void ILanguage.chooseIntervalLabel()
        {
            Console.WriteLine("Podaj nr przedziału");
        }
        void ILanguage.EndLabel()
        {
            Console.WriteLine("#### Podano do obliczeń ###"); }

        public string EndLabelFunction => "Wybrana funkcja to: ";

        public string EndLabelInterval => "Wybrany przedział to: ";

        public string EndLabelCalculator => "Rodzaj kalkulatora: ";

        public string EndLabelSummFunction => "Wybrana funkcja to ";

        public string EndLabelSummInterval => " wybrany przedzial to ";

    }
}
