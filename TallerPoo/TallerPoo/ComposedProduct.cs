
using System.Collections.Generic;

namespace TallerPoo
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }


        public override decimal ValueToPay()
        {
            decimal _totalPrice = 0;
            foreach (Product product in Products)
            {
                _totalPrice += product.ValueToPay();

            }
            return _totalPrice - (_totalPrice * ((decimal)Discount));

        }
        public override string ToString()
        {
            List<string> descProduct = new();//Creamos la lista vacia

            foreach (Product product in Products)
            {
                descProduct.Add(product.Description);
            }
            return $"{base.ToString()}" +
                $"Products.......: {$"{string.Join(", ", descProduct)}",15} \n\t" +
                $"Discount.......: {$"{Discount:P2}",15}\n\t" +
                $"Value..........: {$"{ValueToPay():C2}",15}";
        }
    }
}