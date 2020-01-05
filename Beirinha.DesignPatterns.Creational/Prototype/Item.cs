namespace Beirinha.DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Protype
    /// </summary>
    public abstract class Item
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Item(int id, string description, double price)
        {
            this.Id = id;
            this.Description = description;
            this.Price = price;
        }

        //clonar
        public abstract Item Clone();
    }
}
