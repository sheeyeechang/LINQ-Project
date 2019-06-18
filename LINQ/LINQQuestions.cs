using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class LINQQuestions
    {
        //member varibale (HAS A)
        //constructor

        //method (CAN DO)
        //1. Using LINQ, write a function that returns all words that contain the substring “th” from a list.
        //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", “mathematics” };

        //Contains returns true or false. It indicates whether the IEnumerable collection has an element matching the argument.It acts upon any IEnumerable collection when the System.Linq namespace is included.
       

               public List<string> ReturnSubstringFromList(List<string> list)
        {
            List<string> thList = list.Where(t => t.Contains("th")).ToList();

            return thList;
        }



        
        

    }
}
