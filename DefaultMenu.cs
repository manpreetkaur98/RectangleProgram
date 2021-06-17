using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProgram
{
    class DefaultMenu
    {
        Rectangle rectangle = new Rectangle();
        String selection;
        public void GetMyMenu()
        {
            Console.WriteLine("1. Get Rectangle Length\n");
            Console.WriteLine("2. Change Rectangle Length\n");
            Console.WriteLine("3. Get Rectangle Width\n");
            Console.WriteLine("4. Change Rectangle Width\n");
            Console.WriteLine("5. Get Rectangle Perimeter \n");
            Console.WriteLine("6. Get Rectangle Area\n");
            Console.WriteLine("7. Exit\n");
            selection = Console.ReadLine();
            if (selection == "1")
            {
                Console.WriteLine("Rectangle Length is " + rectangle.GetLength().ToString());

            }
            else if (selection == "2")

            {
                Console.WriteLine("Enter New Length\n");
                String newLength = Console.ReadLine();
                int inputLenth = Int16.Parse(newLength);
                Console.WriteLine("New Rectangle Length is " + rectangle.SetLength(inputLenth).ToString());

            }
            else if (selection == "3")
            {
                Console.WriteLine("Rectangle Width is " + rectangle.GetWidth().ToString());

            }
            else if (selection == "4")
            {
                Console.WriteLine("Enter New Width\n");
                String setWidth = Console.ReadLine();
                int inputWidth = Int16.Parse(setWidth);
                Console.WriteLine("New Rectangle width is " + rectangle.SetWidth(inputWidth).ToString());

            }
            else if (selection == "5")
            {
                Console.WriteLine("Rectangle Perimeter is " + rectangle.GetPerimeter().ToString());

            }
            else if (selection == "6")
            {
                Console.WriteLine("Rectangle Area is " + rectangle.GetArea().ToString());

            }
            else if (selection == "7")
            {
                Environment.Exit(-1);


            }
            else
            {
                Console.WriteLine("Invalid selection Please try Again \n\n");
                DefaultMenu defaultmenu = new DefaultMenu();
                defaultmenu.GetMyMenu();

            }



        }
    }
}
