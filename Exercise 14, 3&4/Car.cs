namespace Exercise_14_3
{
    internal class Car : IVehiculo
    {
        private int gasoline;
        public Car(int gasoline)
        {
            this.gasoline = gasoline;
        }
        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("vroom vroom");
            }
            else
            {
                Console.WriteLine(":(");
            }
        }
        public bool Refuel(int amount)
        {
            gasoline += amount;
            Console.WriteLine($"+{amount} L. Now: {gasoline} L");
            return true;
        }
    }
}
