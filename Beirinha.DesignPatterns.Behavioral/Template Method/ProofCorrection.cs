using System;

namespace Beirinha.DesignPatterns.Behavioral.Template_Method
{
    public class ProofCorrection : Correction
    {
        public override void Correct()
        {
            Console.WriteLine("Correcting exam");
        }

        public override void SendResultToDataBase()
        {
            Console.WriteLine("Sending proof correction data base.");
        }

        public override void ClearPreviousCorrections()
        {
            Console.WriteLine("Cleaning previous proof correction");
        }

        public override void CheckPreRequirements()
        {
            Console.WriteLine("Checking pre requirements to proof correction");
        }
    }
}
