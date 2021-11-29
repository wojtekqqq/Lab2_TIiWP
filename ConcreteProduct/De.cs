using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.ConcreteProduct
{
    class De : ILanguage
    {
        public int Id => 3;

        public string Language => "DE";
        void ILanguage.StartLabel()
        {
            Console.WriteLine("*** Berechnung des ungefähren Wertes des Integrals für die ausgewählte Funktion und den Datenbereich ***");
        }
        void ILanguage.chooseFunctionLabel()
        {
            Console.WriteLine("Geben Sie die Funktionsnummer ein");
        }
        public void chooseErrorLabel()
        {
            Console.WriteLine("Geben Sie die Nummer außerhalb des Bereichs erneut ein");
        }
        void ILanguage.chooseIntervalLabel()
        {
            Console.WriteLine("Geben Sie die Fachnummer ein");
        }
        void ILanguage.EndLabel()
        {
            Console.WriteLine("### Zur Berechnung vorgesehen ###");
        }

        public string EndLabelFunction => "Die ausgewählte Funktion ist: ";

        public string EndLabelInterval => "Der ausgewählte Bereich ist: ";

        public string EndLabelCalculator => " Rechnertyp: ";

        public string EndLabelSummFunction =>  "Die ausgewählte Funktion ist ";

        public string EndLabelSummInterval => " der ausgewählte Bereich ist ";

    }
}
