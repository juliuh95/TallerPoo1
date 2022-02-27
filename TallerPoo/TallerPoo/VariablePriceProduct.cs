
namespace TallerPoo
{
    public class VariablePriceProduct : Product
    {
      
        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            decimal subTotal = Price * (decimal)Quantity;
            return subTotal + (subTotal * (decimal)Tax);
        }


        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Measurement....: {$"{Measurement}",15} \n\t" +
                $"Quantity.......: {$"{Quantity:N2}",15}\n\t" +
                $"Price..........: {$"{Price:C2}",15} \n\t" +
                $"Tax............: {$"{Tax:P2}",15}\n\t" +
                $"Value..........: {$"{ValueToPay():C2}",15} ";




        }
    }
}