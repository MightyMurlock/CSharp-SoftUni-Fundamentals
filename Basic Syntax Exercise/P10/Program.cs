using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int trashedHeadset = 0;
            //int trashedMouse = 0;
            //int trashedKeyboard = 0;
            //int trashedDisplay = 0;

            //bool headset = false;
            //bool mouse = false;

            //double totalPrice = 0;

            //double lostGames = double.Parse(Console.ReadLine());
            //double priceHeadset = double.Parse(Console.ReadLine());
            //double priceMouse = double.Parse(Console.ReadLine());
            //double priceKeyboard = double.Parse(Console.ReadLine());
            //double priceDisplay = double.Parse(Console.ReadLine());



            //for (int game = 1; game <= lostGames; game++)
            //{
            //    trashedHeadset++;
            //    trashedMouse++;

            //    if (trashedHeadset == 2)
            //    {
            //        trashedHeadset = 0;
            //        headset = true;
            //        totalPrice += priceHeadset;
            //    }
            //    else
            //    {
            //        headset = false;
            //    }

            //    if (trashedMouse == 2)
            //    {
            //        trashedMouse = 0;
            //        mouse = true;
            //        totalPrice += priceMouse;
            //    }
            //    else
            //    {
            //        mouse = false;
            //    }

            //    if (headset && mouse)
            //    {
            //        headset = false;
            //        mouse = false;
            //        trashedKeyboard++;
            //        totalPrice += priceKeyboard;
            //    }

            //    if (trashedKeyboard == 2)
            //    {
            //        trashedKeyboard = 0;
            //        totalPrice += priceDisplay;
            //    }
            //}

            //Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");

            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int counterGameForBrokenHeadset = 0;
            int counterGameForBrokenMous = 0;
            int counterGameForBrokenKeyboard = 0;

            bool headsetBroken = false;
            bool mouseBroken = false;

            double price = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                counterGameForBrokenHeadset++;
                counterGameForBrokenMous++;

                if (counterGameForBrokenHeadset == 2)
                {
                    headsetBroken = true;
                    counterGameForBrokenHeadset = 0;
                    price += headsetPrice;
                }
                else
                    headsetBroken = false;

                if (counterGameForBrokenMous == 3)
                {
                    mouseBroken = true;
                    counterGameForBrokenMous = 0;
                    price += mousePrice;
                }
                else
                    mouseBroken = false;

                if (headsetBroken && mouseBroken)
                {
                    headsetBroken = false;
                    mouseBroken = false;
                    counterGameForBrokenKeyboard++;
                    price += keyboardPrice;
                }

                if (counterGameForBrokenKeyboard == 2)
                {
                    counterGameForBrokenKeyboard = 0;
                    price += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {price:f2} lv.");
        }
    }
}
