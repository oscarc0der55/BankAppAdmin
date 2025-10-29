namespace TestCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            UserRegister user = new UserRegister();
            Admin admin = new Admin();
            admin.ViewCustomer(user);
            Thread.Sleep(3000);
            admin.DeleteCustomer(user);
            admin.ViewCustomer(user);
            Grafik.DisplayLogo();
        }
    }
}
