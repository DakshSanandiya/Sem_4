using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Candidate
    {
        public int CandidateId;
        public string CandidateName;
        public int CandidateAge;
        public double CandidateWeight;
        public double CandidateHeight;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter a ID : ");
            CandidateId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Name : ");
            CandidateName = Console.ReadLine();

            Console.WriteLine("Enter a Age : ");
            CandidateAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Weight : ");
            CandidateWeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Height : ");
            CandidateHeight = double.Parse(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine($"Candidate Id is {CandidateId}");
            Console.WriteLine($"Candidate Name is {CandidateName}");
            Console.WriteLine($"Candidate Age is {CandidateAge}");
            Console.WriteLine($"Candidate Weight is {CandidateWeight}");
            Console.WriteLine($"Candidate Height is {CandidateHeight}");
        }
    }
}
