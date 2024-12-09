namespace Exercise_19
{
    class Generic<T, U> where T : class where U : struct
    {
        public T Property { get; set; }
        private U field;
        public Generic(T property, U field)
        {
            Property = property;
            this.field = field;
        }
        public V PrintAndReturn<V>(V value)
        {
            Console.WriteLine(value);
            return value;
        }
        public T UreturnT(T param1, U param2)
        {
            Console.WriteLine($"Parameter 1 (T): {param1}");
            Console.WriteLine($"Parameter 2 (U): {param2}");
            return param1;
        }
    }
}
