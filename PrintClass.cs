namespace PrintLibrary
{
    public class PrintTestClass : IReflectionTest
    {
        public void Test()
        {
            Console.WriteLine("Test method executed.");
        }
    }

    public class PrintClass
    {
        public PrintClass()
        {

        }
        public void Print()
        {
            Console.WriteLine("Hello World!");
        }
    }
}