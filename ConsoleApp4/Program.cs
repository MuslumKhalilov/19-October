//namespace ConsoleApp4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Apple Apple = new Apple { price = 3, sort="Alma sortu",VitaminA=10,VitaminB=15 };
//            Pineapple Pineapple = new Pineapple {price=5,sort="Ananas sortu",VitaminD=18,VitaminE=20 };
//            Orange Orange = new Orange { price = 4, sort = "Portaqal sortu",VitaminC=22 };

//            Fruit[] basket = {Apple,Pineapple,Orange};
            

//            foreach (Fruit fruit in basket)
//            {

//                if (fruit is Apple apple)
//                {
//                    Apple apple1 = (Apple)fruit;
//                    Console.WriteLine("Fruit info");
//                    Console.WriteLine($"Qiymet- {apple.price} Manat");
//                    Console.WriteLine($"Meyvenin sortu-{apple.sort}");
//                    Console.WriteLine($"A vitaminin miqdari- {apple.VitaminA}");
//                    Console.WriteLine($"B vitaminin miqdari- {apple.VitaminB}");
//                    Console.WriteLine(apple.Taste());
//                    Console.WriteLine("");
//                }

//                else if (fruit is Pineapple pineapple)
//                {
//                    Pineapple pineapple1 = (Pineapple)fruit;
//                    Console.WriteLine("Fruit info");
//                    Console.WriteLine($"Qiymet- {pineapple.price} Manat");
//                    Console.WriteLine($"Meyvenin sortu-{pineapple.sort}");
//                    Console.WriteLine($"D vitaminin miqdari- {pineapple.VitaminD}");
//                    Console.WriteLine($"E vitaminin miqdari- {pineapple.VitaminE}");
//                    Console.WriteLine(pineapple.Taste());
//                    Console.WriteLine("");


//                }
//                else if (fruit is Orange orange)
//                {
//                    Orange orange1 = (Orange)fruit;
//                    Console.WriteLine("Fruit info");
//                    Console.WriteLine($"Qiymet- {orange.price} Manat");
//                    Console.WriteLine($"Meyvenin sortu-{orange.sort}");
//                    Console.WriteLine($"C vitaminin miqdari- {orange.VitaminC}");
//                    Console.WriteLine(orange.Taste());
//                    Console.WriteLine("");


//                }



//            }
//        }
//    }
//}