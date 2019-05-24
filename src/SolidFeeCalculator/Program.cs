using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidFeeCalculator
{
    public class Program
    {
        
        static void Main(string[] args)
        {
             
            if(args.Length != 4){
                Console.WriteLine("Please Enter full details");
                  }
            else{
            decimal fee = 0;
            int usertype = 1, itemtype = 0, itemprice = 100;
            DateTime itemenddate = DateTime.Today;

                         
                
            try
            {
                    usertype = int.Parse(args[0]);
                    itemtype = int.Parse(args[1]);
                    itemprice = int.Parse(args[2]);
                    itemenddate = DateTime.Parse(args[3]);
                    fee = CalculateFee(usertype, itemtype, itemprice, itemenddate);
                             
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }

            System.Console.WriteLine(fee.ToString()+ " Sek");
            }
        }

        
         public static decimal CalculateFee(int usertype, int itemtype, int itemprice,  DateTime itemenddate)
        {
            try
            {
                decimal percentage;
                int auctionAdCost = 25 , buyitnowAdCost = 35;
                int enddateDiscount = (itemenddate == DateTime.Today ) ? 10 :0 ; 
                int companyDiscount = (itemenddate == DateTime.Today ) ? 15 :5 ;
                switch (usertype)
                {
                    case 0: //Normal
                         percentage = 0.07m;
                         #region Normal user
                         switch(itemtype)
                            {
                            case 0://Auction
                               return auctionAdCost - enddateDiscount + (itemprice*percentage);
                               
                            case 1://BuyItNow
                               return buyitnowAdCost - enddateDiscount + (itemprice*percentage);
                               
                            default:
                                Console.WriteLine("Invalid input");
                                break;
                             }
                        break; 
	                    #endregion
                    case 1: //Company
                        percentage = 0.04m;
                        #region Company
                        switch(itemtype){
                            case 0://Auction
                               return auctionAdCost - companyDiscount + (itemprice*percentage);
                               
                            case 1://BuyItNow
                               return buyitnowAdCost - companyDiscount + (itemprice*percentage);
                               
                            default:
                                Console.WriteLine("Invalid input");
                                break;
                                }
                        break; 
                        default:
                        Console.WriteLine("Invalid user type number");
                        break;
                        #endregion
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            return 0;
        }

        
    }
}
