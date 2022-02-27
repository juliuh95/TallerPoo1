namespace TallerPoo
{

    public class FixedPriceProduct : Product
    {
      
        public override decimal ValueToPay()
        {

            return Price + (Price * (decimal) Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                 $"Price..........: {$"{Price:C2}",15}\n\t" +
                $"Tax............: {$"{Tax:P2}",15}\n\t" +
            $"Value..........: {$"{ValueToPay():C2}",15}";
        }
    }

}
    



