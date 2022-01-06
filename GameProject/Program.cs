using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamermanager = new GamerManager(new ValidationManager());  // ValidationManager ile doğrulamayı gerçekleştiriyoruz
            gamermanager.GamerAdd(new Gamer { Id = 1, BirthYear = 1995, FirstName = "ENGİN CAN", LastName = "MEYDAN", IdentityNumber = 12345 });
            Gamer gamer1 = new Gamer();

            SaleGameManager saleGameManager = new SaleGameManager();
            saleGameManager.SaleGame(new SaleGame {GameId=1,GameName="Knight Online",GamePrice= 19.99,gamer=gamer1});


        }
    }
}
