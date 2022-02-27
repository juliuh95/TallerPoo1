namespace TallerPoo
{


    public class Invoice : IPay
    {
        private List<Product> _products;

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public Invoice()
        {
            _products = new List<Product> { };
        }

        public override string ToString()
        {
           
            return $"                        ================\n\t"+
             $"TOTAL..........:{$"{ValueToPay():C2}",15}";
                     
        }

        public decimal ValueToPay()
        {
            //test 3
            decimal total= 0;
            foreach (Product product in _products)
            {
                total += product.ValueToPay();
                Console.WriteLine(product.ToString());
            }
            return total;
        }
    }


}