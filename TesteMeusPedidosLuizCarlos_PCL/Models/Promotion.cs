using System.Collections.Generic;

namespace TesteMeusPedidosLuizCarlos_PCL.Models
{
    
    public class Police
    {
        public int min { get; set; }
        public double discount { get; set; }
    }
    
    public class Promotion
    {
        public string Name { get; set; }

        public int? Category_id { get; set; }

        public List<Police> Policies { get; set; }  
    }

}