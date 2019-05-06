using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacRestAPI;

namespace ConsoleAppZodiacTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ZodiacRest zodiac = new ZodiacRest();
            ZodiacResult zodiacTest = new ZodiacResult();
            zodiacTest = zodiac.ObtainResult(ZodiacSign.Capricorn, TimeSign.tomorrow);

            Console.WriteLine(zodiacTest.SunSign);
            Console.WriteLine(zodiacTest.Quotes);
            Meta meta = zodiacTest.Content;
            Console.WriteLine("Mood:{0}", meta.Mood);
            Console.WriteLine("Perasaan Hati:{0}", meta.Keywords);
            Console.WriteLine("Semangat Hidup:{0}", meta.intensity);
            Console.ReadLine();
        }
    }
}
