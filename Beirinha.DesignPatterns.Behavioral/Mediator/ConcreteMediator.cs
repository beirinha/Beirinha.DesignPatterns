namespace Beirinha.DesignPatterns.Behavioral.Mediator
{
    public class ConcreteMediator : Mediador
    {
        private Support _suporte;
        private User _usuario;

        public Support Suporte
        {
            set { _suporte = value; }
        }

        public User Usuario
        {
            set { _usuario = value; }
        }

        public override void Send(string message, Colleague colleage)
        {
            if(colleage == _usuario)
            {
                _suporte.Notify(message);
            }
            else
            {
                _usuario.Notify(message);
            }
        }
    }
}
