using System;

namespace RectangleProgram
{
    class Program
    {
        static void Main(string[] args = null)
        {
            String length, width;
            Console.WriteLine("This is the Rectangle Application.\n\n");
            Console.WriteLine("Enter Rectangle Length\n");
            length = Console.ReadLine();
            Console.WriteLine("Enter Rectangle Width\n");
            width = Console.ReadLine();
            int convertLength = Int16.Parse(length);
            int convertWidth = Int16.Parse(width);
            if (convertLength <= 0 || convertWidth <= 0)
            {
                Console.WriteLine("Length should  not be decimal or less than 1\n\n");
                Program.Main(null);
            }
            else
            {
                DefaultMenu defaultMenu = new DefaultMenu();
                defaultMenu.GetMyMenu();


            }
        }
    }
}
