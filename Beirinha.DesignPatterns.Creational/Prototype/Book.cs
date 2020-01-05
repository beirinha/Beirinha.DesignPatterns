namespace Beirinha.DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Concrete Prototype
    /// </summary>
    public class Book : Item
    {
        public Book(int id, string descricao, double preco)
            : base(id, descricao, preco)
        {

        }

        public override Item Clone()
        {
            return (Item)this.MemberwiseClone();
        }
    }
}
