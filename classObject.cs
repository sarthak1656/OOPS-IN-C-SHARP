// class: Class in a prototype defined by the user where the properties and behaviour of the object is defined 

//Object: Objects are the instances of the class which represents the class. An object is a real entity which has some state and behaviour

class mobile{
    int price;
    String storage;
    String color;
    public static void Calling(){
        Console.WriteLine("Voice call");
    }
    public static void Chatting(){
        Console.WriteLine("text call");
    }
    public static void Music(){
        Console.WriteLine("song...");
    }
    public static void Main(string[] args){
        mobile m = new mobile();
        m.price= 10000;
        m.storage="128gb";
        m.color="red";
        Console.WriteLine(m.price);
        Console.WriteLine(m.storage);
        Console.WriteLine(m.color);
        Calling();
        Chatting();
        Music();

    }
}