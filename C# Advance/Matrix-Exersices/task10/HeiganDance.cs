
namespace task10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class HeiganDance
   {
       private const int ChainberSize = 15;
       private const int CloudDamage = 3500;
       private const int EruptionDamage = 6000;
       private const double PlayerHealth = 18500;
       private const double HeiganHealth = 3000000;

       public static void Main()
       {
           var playerPos = new int[] {ChainberSize / 2, ChainberSize / 2};

           var playerDamage = double.Parse(Console.ReadLine());
           var heiganPoint = HeiganHealth;
           var playerPoints = PlayerHealth;
           var heiganIsDeath = false;
           var PlayerIsDeath = false;
           var hasCloud = false;
           var deathCouse = string.Empty;

           while (true)
           {
               var spellTokens = Console.ReadLine().Split();

               var spell = spellTokens[0];
               var spellRow = int.Parse(spellTokens[1]);
               var spellCol = int.Parse(spellTokens[2]);

               heiganPoint -= playerDamage;
               heiganIsDeath = heiganPoint <= 0;

               if (hasCloud)
               {
                   playerPoints -= CloudDamage;
                   hasCloud = false;
                   PlayerIsDeath = playerPoints <= 0;

               }
                if (PlayerIsDeath || heiganIsDeath)
               {
                   break;
               }

               if (IsPlayerInSpellZone(playerPos, spellRow, spellCol))
               {
                   if (!MovingPlayer(playerPos, spellRow, spellCol))
                   {
                       switch (spell)
                       {
                           case "Cloud":
                               playerPoints -= CloudDamage;
                               hasCloud = true;
                               deathCouse = "Plague Cloud";
                               break;
                            case "Eruption":
                                playerPoints -= EruptionDamage;
                                deathCouse = spell;
                                break;
                       }
                    }
                   
                }
               PlayerIsDeath = playerPoints <= 0;
               if (PlayerIsDeath)
               {
                   break;
               }

               
           }
           printResult(playerPos, heiganPoint, playerPoints, deathCouse);
       }

       private static void printResult(int[] playerPos, double heiganPoint, double playerPoints, string deathCouse)
       {
           if (heiganPoint <= 0)
           {
               Console.WriteLine($"Heigan: Defeated!");
           }
           else
           {
               Console.WriteLine($"Heigan: {heiganPoint:f2}");
           }
           if (playerPoints <= 0)
           {
               Console.WriteLine($"Player: Killed by {deathCouse}");
           }
           else
           {
               Console.WriteLine($"Player: {playerPoints}");
           }
           Console.WriteLine($"Final position: {playerPos[0]}, {playerPos[1]}");    
        }

       private static bool MovingPlayer(int[] playerPos, int spellRow, int spellCol)
       {
           if (playerPos[0] - 1 >= 0 && playerPos[0] - 1 < spellRow -1)
           {
               playerPos[0]--;
               return true;
           }
           else if (playerPos[1] + 1 <= ChainberSize && playerPos[1] + 1 > spellCol + 1)
           {
               playerPos[1]++;
               return true;
           }
           else if (playerPos[0] + 1 <= ChainberSize && playerPos[0] +1 > spellRow + 1)
           {
               playerPos[0]++;
               return true;
           }
           else if (playerPos[1] - 1 >= 0 && playerPos[1] - 1 < spellCol -1)
           {
               playerPos[1]--;
               return true;
           }
           return false;
       }

       private static bool IsPlayerInSpellZone(int[] playerPos, int spellRow, int spellCol)
       {
           bool isRowHit = playerPos[0] >= spellRow - 1 && playerPos[0] <= spellRow + 1;
           bool isCollHit = playerPos[1] >= spellCol - 1 && playerPos[1] <= spellCol + 1;

           return isRowHit && isCollHit;

       }
   }
}
