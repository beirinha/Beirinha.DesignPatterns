namespace Beirinha.DesignPatterns.Creational.Builder
{
    public class BikeBuilder : AutoBuilder
    {
        public BikeBuilder()
        {
            _auto = new Auto("Bike");
        }

        public override void BuildDoors()
        {
            _auto["doors"] = "0";
        }

        public override void BuilGear()
        {
            _auto["gear"] = "50c";
        }

        public override void BuildTires()
        {
            _auto["tires"] = "2";
        }
    }
}
