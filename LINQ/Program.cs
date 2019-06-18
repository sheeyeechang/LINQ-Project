using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQQuestions list = new LINQQuestions();

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> THwords = list.ReturnSubstringFromList(words);

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> NameList = list.GetNameList(names);

            list.GetCalculatesClassGradeAverage();


            Console.ReadLine();



        }
    }
}
