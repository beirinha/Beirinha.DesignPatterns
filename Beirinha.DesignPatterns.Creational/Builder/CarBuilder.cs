namespace Beirinha.DesignPatterns.Creational.Builder
{
    public class CarBuilder : AutoBuilder
    {
        public CarBuilder()
        {
            _auto = new Auto("Car");
        }

        public override void BuildDoors()
        {
            _auto["doors"] = "4";
        }

        public override void BuilGear()
        {
            _auto["gear"] = "127c";
        }

        public override void BuildTires()
        {
            _auto["tires"] = "4";
        }
    }
}
