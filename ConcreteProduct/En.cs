using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.ConcreteProduct
{
    class En : ILanguage

    {
        public int Id => 2;

        public string Language => "EN";
        void ILanguage.StartLabel()
        {
            Console.WriteLine("*** " +
                              "Calculating the approximate value of an integral for a selected function and data range ***");
        }
        void ILanguage.chooseFunctionLabel()
        {
            Console.WriteLine("Enter the function number");
        }
        public void chooseErrorLabel()
        {
            Console.WriteLine("Enter the number out of range again");
        }
        void ILanguage.chooseIntervalLabel()
        {
            Console.WriteLine("Enter the compartment number");
        }
        void ILanguage.EndLabel()
        {
            Console.WriteLine("### Provided for calculation ###");
        }

        public string EndLabelFunction => "The selected function is: ";

        public string EndLabelInterval => "The selected range is: ";

        public string EndLabelCalculator => "Calculator type: ";

        public string EndLabelSummFunction => "The selected function is ";

        public string EndLabelSummInterval => " the selected range is ";
        
    }
}
