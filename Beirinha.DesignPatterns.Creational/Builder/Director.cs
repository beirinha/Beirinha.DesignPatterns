namespace Beirinha.DesignPatterns.Creational.Builder
{
    public class Director
    {
        public void Construct(AutoBuilder builder)
        {
            builder.BuilGear();
            builder.BuildDoors();
            builder.BuildTires();

        }
    }
}
