using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.ConcreteProduct;

namespace Lab2.SimpleFactory
{
    class LanguageFactory
    {
        public static ILanguage CreateLanguage(LanguageType language)
        {
            switch (language)
            {
                case LanguageType.PL:
                    return new Pl();
                case LanguageType.EN:
                    return new En();
                case LanguageType.DE:
                    return new De();
                default:
                    throw new Exception("Invalid brand type");
            }
        }
    }
}
