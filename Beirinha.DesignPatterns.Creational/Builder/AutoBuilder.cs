namespace Beirinha.DesignPatterns.Creational.Builder
{
    public abstract class AutoBuilder
    {
        protected Auto _auto;

        public Auto Auto
        {
            get { return _auto; }            
        }

        //Abstract construction process
        public abstract void BuilGear();
        public abstract void BuildDoors();
        public abstract void BuildTires();
    }
}
