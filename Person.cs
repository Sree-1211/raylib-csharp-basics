class Person
{
    public string name;
    public string job;
    public int age;

    public Cloth cloth;//creating a obj insie another sub class
    public void PrintDetails()
    {
        Console.WriteLine("name: " + name + ", job: " + job + ", age: " + age + "cloth:" + cloth.clothName);
        
    }
}
