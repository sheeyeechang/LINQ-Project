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
        //Contains returns true or false. It indicates whether the IEnumerable collection has an element matching the argument.
        //It acts upon any IEnumerable collection when the System.Linq namespace is included.   

        public List<string> ReturnSubstringFromList(List<string> list)
        {
            List<string> thList = list.Where(t => t.Contains("th")).ToList();
            return thList;
        }

        //2. Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
        public List<string> GetNameList(List<string> list)
        {
            List<string> nameList = list.Distinct().ToList();
            return nameList;
        }

        //3. Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each 
        //student. The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.

        public void GetCalculatesClassGradeAverage()
        {
            List<string> classGrades = new List<string>()
                {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
                };

            List<double> AverageListClassGrade = new List<double>();        //new list
            for (int i = 0; i < classGrades.Count; i++)                         // for loop
            {
                var splitStringInt = classGrades[i].Split(',').Select(l => int.Parse(l)).OrderBy(l => l);     //LINQ split string and convert int, orderby
                var averageGrades = splitStringInt.Skip(1).Average();                       //LINQ average & remove min()
                AverageListClassGrade.Add(averageGrades);                           //add average grade
            }
            var averageTheAverage = AverageListClassGrade.Average();                //average grade
            Console.WriteLine(averageTheAverage);
        }

        // 4. Write a function that takes in a string of letters(i.e. “Terrill”) and returns an alphabetically ordered 
        // string corresponding to the letter frequency(i.e. "E1I1L2R2T1")

        public void GetStringOfLetters()
        {
            string input = "Terrill";
            var result1 = input.ToUpper().ToArray().OrderBy(x => x);        //To Arry, OrderBy
            var result2 = result1.GroupBy(x => x).Select(x => $"{x.Last()}{x.Count()}");                //GroupBy and Count
            string result = "";
            foreach (var item in result2)
            {
                result += item.ToString();
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
