//Person tom = new Person();
//tom = print();

class Person
{

    public string name;
    public int age;
    public Person() { name = "Не известно"; age = 18; }
    public Person(string n) { name = n; age = 18; }
    public Person(string n, int a) { name = n; age = a; }
    public Person() { age = 34; name = "4 конструктор"; }

    public void Print()
    {
        Console.WriteLine($"Имя:{name}, Возраст:{age}");
    }
}
