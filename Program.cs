class Program
{
    static void Main(string[] args)
    {
        Person Person1 = new Person();

        Person1.name = "John";
        Person1.job = "Developer";
        Person1.age = 30;

        Person1.cloth = new Cloth();
        //to access cloth name we need go through person then to Cloth
        Person1.cloth.clothName = "T-shirt";

        Person Person2 = new Person();
        Person2.cloth = new Cloth();
        Person2.name = "anitha";
        Person2.job = "tester";
        Person2.age = 26;
        Person2.cloth.clothName = "jeans";

        Person1.PrintDetails();
        Person2.PrintDetails();
    }
}

