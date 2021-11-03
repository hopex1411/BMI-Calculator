using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi_calculator
{
    class bmi_berenger
    {
        //Ada Ulrik - D82
        //BMI Beregner
        //Bruger skal kunne indtaste vægt & højde, og få udskrevet deres BMI
        //BMI er en dårlig måde at regne ens sundhed ud på, da den ikke tager højde for kropsfedt, muskler, fedtfordeling og en hel del andre sundhedsfaglige ting.
        //Der er 2 versioner. En med loops og ekstra ting, og en som kun følger krav.

        static void Main(string[] args)
        {
            //V1 med ekstra ting og flair
            int vægtInput;
            int højdeInput;
            double bmi;
            int num = -1;
            string vægt;
            string højde;

            Console.WriteLine("BMI Beregner");
            Console.WriteLine("============");
            Console.WriteLine("BMI under  18,5      = Undervægtig");
            Console.WriteLine("BMI mellem 18,5-24,9 = Normalvægtig");
            Console.WriteLine("BMI mellem 25-29,9   = Fedme");
            Console.WriteLine("BMI over   40        = Svær fedme");
            Console.WriteLine();

            while (true)
            {
                do
                {
                    Console.Write("Indtast din vægt i kg i heltal: ");
                    vægt = Console.ReadLine();
                    if (!int.TryParse(vægt, out num))
                    {
                        Console.WriteLine("{0} er ikke et tal", vægt);
                        Console.WriteLine("Tryk en tast for at prøve igen");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (!int.TryParse(vægt, out num));

                vægtInput = Int32.Parse(vægt);

                do
                {
                    Console.Write("Indtast din højde i cm i heltal: ");
                    højde = Console.ReadLine();
                    if (!int.TryParse(højde, out num))
                    {
                        Console.WriteLine("{0} er ikke et tal", højde);
                        Console.WriteLine("Tryk en tast for at prøve igen");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (!int.TryParse(højde, out num));

                højdeInput = Int32.Parse(højde);

                //BMI Formlen er baseret på meter, så vi omregner centimeter til meter ved at dividere med 100
                bmi = vægtInput / ((højdeInput / 100.0) * (højdeInput / 100.0));
                //bmi = vægtInput / Math.Pow(højdeInput / 100.0, 2);

                bmi = Math.Round(bmi, 1);

                if (bmi < 18.5)
                {
                    Console.WriteLine("\nDin BMI er {0} som svarer til \"Undervægt\"", bmi);
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    Console.WriteLine("\nDin BMI er {0} som svarer til \"Normal vægt\"", bmi);
                }
                else if (bmi > 25 && bmi <= 29.9)
                {
                    Console.WriteLine("\nDin BMI er {0} som svarer til \"Overvægt\"", bmi);
                }
                else if (bmi > 30 && bmi <= 39.9)
                {
                    Console.WriteLine("\nDin BMI er {0} som svarer til \"Fedme\"", bmi);
                }
                else if (bmi > 40)
                {
                    Console.WriteLine("\nDin BMI er {0} som svarer til \"Svær fedme\"", bmi);
                }
                Console.Write("\nVil du starte forfra? (Ja/Nej): ");
                if (Console.ReadLine().ToLower() != "ja")
                    break;
                Console.Clear();
            }
            

            //V2 Som kun følger krav

            //double vægt;
            //double højde;
            //double bmi;

            //Console.Write("Indtast din vægt: ");
            //vægt = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Indtast din højde: ");
            //højde = Convert.ToDouble(Console.ReadLine());

            //bmi = vægt / ((højde / 100.0) * (højde / 100.0));
            //bmi = Math.Round(bmi, 1);

            //if (bmi < 18.5)
            //{
            //    Console.Write("Din BMI er {0}, og det svarer til undervægt", bmi);
            //}
            //else if (bmi >= 18.5 && bmi <= 24.9)
            //{
            //    Console.Write("Din BMI er {0}, og det svarer til normalvægt", bmi);
            //}
            //else if (bmi >= 25 && bmi <= 29.9)
            //{
            //    Console.Write("Din BMI er {0}, og det svarer til overvægt", bmi);
            //}
            //else if (bmi >= 30 && bmi <= 39.9)
            //{
            //    Console.Write("Din BMI er {0}, og det svarer til fedme", bmi);
            //}
            //else if (bmi > 40)
            //{
            //    Console.Write("Din BMI er {0}, og det svarer til svær fedme", bmi);
            //}

            //Console.ReadKey();
        }
    }
}
