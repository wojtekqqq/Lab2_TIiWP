using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface ILanguage
    {
        int Id { get; }
        string Language { get; }
        void StartLabel();
        void chooseFunctionLabel();
        void chooseIntervalLabel();
        void chooseErrorLabel();
        void EndLabel();
        string EndLabelFunction { get; }
        string EndLabelInterval { get; }
        string EndLabelCalculator { get; }
        string EndLabelSummFunction { get; }
        string EndLabelSummInterval { get; }



    }
}
