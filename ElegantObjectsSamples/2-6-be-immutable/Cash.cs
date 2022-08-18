namespace ElegantObjectsSamples._2_6_be_immutable
{
    internal class Cash
    {
        private int dollars;

        public Cash(int amount)
        {
            dollars = amount;
        }

        public void Multiply(int factor)
        {
            dollars *= factor;
        }

        public override string ToString()
        {
            return dollars.ToString();
        }

        public int Dollars => dollars;
    }
}