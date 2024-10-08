namespace MultipleGenericTypeInClass;

class Program
{
    static void Main(string[] args)
    {
        Box<int, string> box = new Box<int, string>(1000, "serebu");
        box.Display();
    }
}
