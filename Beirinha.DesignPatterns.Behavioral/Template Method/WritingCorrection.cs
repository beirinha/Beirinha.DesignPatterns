using System;

namespace Beirinha.DesignPatterns.Behavioral.Template_Method
{
    public class WritingCorrection : Correction
    {
        public override void Correct()
        {
            Console.WriteLine("Correcting writing");
        }

        public override void SendResultToDataBase()
        {
            Console.WriteLine("Sending correction writing to database");
        }

        public override void ClearPreviousCorrections()
        {
            Console.WriteLine("Cleaning previous writing corrections");
        }

        public override void CheckPreRequirements()
        {
            Console.WriteLine("Cheking pre requirements to writing exam");
        }
    }
}
