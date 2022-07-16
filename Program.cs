using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Muhammet Servet";
            gamer1.LastName = "Bayrak";
            gamer1.NationalNumber = "1231234123123";

            Gamer gamer2 = new Gamer();
            gamer2.FirstName = "Deniz";
            gamer2.LastName = "Uygur";
            gamer2.NationalNumber = "870789789";

            Gamer gamer3 = new Gamer();
            gamer3.FirstName = "Aturba";
            gamer3.LastName = "Delibaş";
            gamer3.NationalNumber = "456445656";


            Game game1 = new Game();
            game1.GameName = "RDR2";

            Game game2 = new Game();
            game2.GameName = "NFS2";

            Game game3 = new Game();
            game3.GameName = "Metin2";


            Discount discount1 = new Discount();
            discount1.DiscountName = "Yaz";

            Discount discount2 = new Discount();
            discount2.DiscountName = "Bahar";

            Discount discount3 = new Discount();
            discount3.DiscountName = "Kış";

            GameManager gameManager = new GameManager();
            gameManager.GameAdd(game1);
            gameManager.DeleteGame(game2);
            gameManager.UpdateGame(game3);
            
            Console.WriteLine();

            GamerManager gamerManager = new GamerManager();
            gamerManager.SıgnIn(gamer1);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer3);
            
            Console.WriteLine();

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(game1,gamer1,discount1);
            
            Console.WriteLine();

            DiscountManager discount = new DiscountManager();
            discount.AddDiscount(discount1);
            discount.UpdateDiscount(discount2);
            discount.DeleteDiscount(discount3);
            
            Console.WriteLine();






        }
    }
}
