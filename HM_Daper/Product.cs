namespace HM_Daper
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"ProductId: {ProductId}, Name: {Name}, Price: {Price}$";
        }
    }
}
