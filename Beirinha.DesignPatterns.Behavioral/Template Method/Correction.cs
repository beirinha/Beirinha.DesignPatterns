namespace Beirinha.DesignPatterns.Behavioral.Template_Method
{
    /// <summary>
    /// Abstract class
    /// </summary>
    public abstract class Correction
    {
        public abstract void Correct();
        public abstract void CheckPreRequirements();
        public abstract void SendResultToDataBase();
        public abstract void ClearPreviousCorrections();

        public void Process()
        {
            CheckPreRequirements();
            ClearPreviousCorrections();
            Correct();
            SendResultToDataBase();
        }
    }
}
