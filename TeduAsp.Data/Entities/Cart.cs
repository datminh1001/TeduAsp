using System;
using System.Collections.Generic;
using System.Text;

namespace TeduAsp.Data.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Quanity { set; get; }
        public decimal Price { set; get; }
        public Guid UserId { set; get; }
        public Product Product { set; get; }
        public DateTime DateCreated { set; get; }
    }
}
