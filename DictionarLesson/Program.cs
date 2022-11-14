using System;
using System.Collections.Generic;

namespace DictionarLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<Dipartamenti, List<string>>> citadino =
                new Dictionary<string, Dictionary<Dipartamenti, List<string>>>();
            citadino.Add("gslrtaf", new());
            citadino.Add("djlksl", new());


            citadino["gslrtaf"].Add(Dipartamenti.ASL, new());
            citadino["gslrtaf"].Add(Dipartamenti.POLIZIA, new());
            citadino["gslrtaf"].Add(Dipartamenti.INPS, new());
            citadino["gslrtaf"].Add(Dipartamenti.COMUNE, new());
            citadino["gslrtaf"].Add(Dipartamenti.SCUOLA, new());
            
            citadino["djlksl"].Add(Dipartamenti.ASL, new());
            citadino["djlksl"].Add(Dipartamenti.POLIZIA, new());
            citadino["djlksl"].Add(Dipartamenti.INPS, new());
            citadino["djlksl"].Add(Dipartamenti.COMUNE, new());
            citadino["djlksl"].Add(Dipartamenti.SCUOLA, new());


            if (citadino["gslrtaf"].ContainsKey(Dipartamenti.POLIZIA))
            {
                citadino["gslrtaf"][Dipartamenti.POLIZIA].Add("Casiero Pulito");
            }
            if (citadino["gslrtaf"].ContainsKey(Dipartamenti.ASL))
            {
                citadino["gslrtaf"][Dipartamenti.ASL].Add("medico famiglia - Mario");
                Console.WriteLine("Questi sono gli dipartamenti per il cittadino  \"gslrtaf\"");
                foreach (var item in citadino["djlksl"].Keys)
                {
                    Console.WriteLine(item);
                }
                
            }




        }
        
    }
    public enum Dipartamenti
    {
        ASL,
        COMUNE,
        POLIZIA,
        INPS,
        SCUOLA
    }
}





