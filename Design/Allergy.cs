using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CodingChallenges.Design
{
    public interface IDisease
    {
        List<string> GetAllSymptoms();
        bool IsViral();
        List<string> Medication();
    }

    public abstract class Allergy : IDisease
    {
        public abstract List<string> GetAllSymptoms();

        public virtual bool IsViral()
        {
            Console.WriteLine("IsViral BaseClass called");
            return false;
        }

        public virtual List<string> Medication()
        {
            Console.WriteLine("Medication BaseClass class");
            return new List<string>();
        }

        public virtual void SetPescriptionTablets()
        {
            
        }
    }

    public class PollenAllergy : Allergy
    {
        public override List<string> GetAllSymptoms()
        {
            Console.WriteLine("GetAllSymptoms Derived class called");
            return new List<string>();
        }

        public override List<string> Medication()
        {
            Console.WriteLine("Medication Derived class");
            return base.Medication();
        }

        public override void SetPescriptionTablets()
        {
            Console.WriteLine("SetPescriptionTablets Derived class");
            base.SetPescriptionTablets();
        }
    }

    public class Cerner
    { 
        //private static void Main(string[] args)
        //{
        //    PollenAllergy pa = new PollenAllergy();
        //    pa.GetAllSymptoms();
        //    pa.IsViral();
        //    pa.Medication();
        //    pa.SetPescriptionTablets();
        //    Console.ReadKey();
        //}
    }
}
