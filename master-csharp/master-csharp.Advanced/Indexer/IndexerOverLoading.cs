

using System.Collections.Generic;

namespace master_csharp.App.Indexer
{
    class Student
    {
        private Dictionary<string, int> grades = new Dictionary<string, int>();

        public int this[string subject]
        {
            get { return grades[subject]; }
            set { grades[subject] = value; }
        }

    }    
}

//public class program
//{
//    static void Main(string[] args)
//    {
//        // Indexer 

//        Student std = new Student();
//        std["Math"] = 13;
//        Console.WriteLine(std["Math"]);

//    }
//}
