namespace Exercise_9
{
    namespace Homework.@ref
    {
       public class Class1
        {
            public int x;
        }
    }
    namespace Homework.@val
    {
        public struct Struct1
        {
            public int y;
        }
        public struct Struct2
        {
            public int x;
            public int y;
        }
        public struct Struct3
        {
            public int x;
            public int y;
            public Struct3()
            {
                x = 0;
                y = 0;
            }
            public Struct3(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}