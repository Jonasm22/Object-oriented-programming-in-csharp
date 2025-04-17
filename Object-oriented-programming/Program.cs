namespace Object_oriented_programming;
//125
class Program
{
    static void Main(string[] args)
    {
        CreateCustomer();
    }


    // In the below Method, are many combinations
   public static void CreateCustomer()
    {
        Customer earl = new Customer("Earl");
        // var name = earl.Name;

        Customer frank = new Customer("Frank" , "MainStreet1" , "885412");
        // var name2 = frank.Name;

        // Console.WriteLine("Name of Customer is: " + name);

        Customer myCustomer = new Customer();
        //Console.WriteLine("Please enter the customers Name: ");
        //myCustomer.Name = Console.ReadLine();

        myCustomer.SetDetails("Lisa", "Am Street 2", "885525");
        
       // Console.WriteLine("Details about customer: " + myCustomer.Name);

        Console.WriteLine("My Customer is: " + myCustomer.Name + " and lives: " +myCustomer.Address);
        Console.WriteLine("Earl is: " + earl.Name + " and lives: " +earl.Address);


        Console.ReadKey();




    }




    public static void CreateAuto()
    {

        Car audi = new Car("A3", "Audi", false);
        Car bmw = new Car("I7", "BWM", true);

       //Console.WriteLine("Please enter the Brand name: ");

        //*** Setting Brand ** 
        
        //audi.Brand = Console.ReadLine();

        // *** Getting Brand **

       // Console.WriteLine("Brand is: " + audi.Brand);
       // Console.WriteLine("Brand is: " + bwm.Brand);

        audi.Drive();
        bmw.Drive();

        Console.ReadKey();


    }







}