namespace TesteMeusPedidosLuizCarlos_PCL.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Photo { get; set; }
        
        public double Price { get; set; }

        public int? Category_id { get; set; }
        
    }
}