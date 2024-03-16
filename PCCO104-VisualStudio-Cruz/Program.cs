namespace PCCO104_VisualStudio_Cruz
{
    internal class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            string[] names = {"YEYEYE", "NONONO"};
            foreach(var name in names)
            {
                Console.WriteLine($"{name}");
            }
            Console.ReadKey();
        }
    }
}