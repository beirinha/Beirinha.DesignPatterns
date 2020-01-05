namespace Beirinha.DesignPatterns.Behavioral.ChainOfResponsability
{
    public class Validate : BaseValidate
    {
        public override bool ValidateUser(string name, string password)
        {
            return (name.Equals(password));
        }
    }
}
