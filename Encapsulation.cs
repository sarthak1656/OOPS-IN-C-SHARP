//Encapuslation is a mechanism in which the data member and method is wrapped in a single unit inside a class so that the data can not be accessed by other class
// class A
// {
//     private data + private method
// }

class A
{
    int atmPin;
    public void setValue(int pin)
    {
        atmPin = pin;
    }
    public int getReturn()
    {
        return atmPin;
    }
}
class B
{
    public static void Main(string[] args)
    {
        A r = new A();
        r.setValue(5050);
        Console.Write(r.getReturn());
    }
}