namespace Exercise_9
{
    public class ChangeInstance
    {
        public void ChangeInstanceMethod(Homework.@ref.Class1 variable)
        {
            variable.x = 10;
        }
        public void ChangeInstanceMethod(ref Homework.@val.Struct1 variable)
        {
            variable.y = 20;
        }
    }
}
