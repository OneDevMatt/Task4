using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MostValuablePaper();
        }

        public static void MostValuablePaper()
        {
            try
            {
                Console.WriteLine("Welcome User!");
                Console.WriteLine("Calculate Newspaper Sale Projections for the Month: ");
      
                double pmnewsMonthlyProjection = 0;
                double guardianMonthlyProjection = 0;
                double punchMonthlyProjection = 0;
                double sunMonthlyProjection = 0;

                //PMNews Newspaper Projectons
                Console.WriteLine("Enter Sale Projections for PMNews...");
                Console.WriteLine("Quantity Sold: ");
                Console.Write("Week One Quantity Sold: ");
                double pmNewsWeekOneQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Two Quantity Sold: ");
                double pmNewsWeekTwoQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Three Quantity Sold: ");
                double pmNewsWeekThreeQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Four Quantity Sold: ");
                double pmNewsWeekFourQ = Convert.ToDouble(Console.ReadLine());
                double sumOfPmNewsQuantity = pmNewsWeekOneQ + pmNewsWeekTwoQ + pmNewsWeekThreeQ + pmNewsWeekFourQ;
                Console.WriteLine("Prices Sold: ");
                Console.Write("Price of Week One Quantity Sold: ");
                double pmNewsWeekOneS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Two Quantity Sold: ");
                double pmNewsWeekTwoS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Three Quantity Sold: ");
                double pmNewsWeekThreeS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Four Quantity Sold: ");
                double pmNewsWeekFourS = Convert.ToDouble(Console.ReadLine());
                double sumTotalOfPmNewsPrices = pmNewsWeekOneS + pmNewsWeekTwoS + pmNewsWeekThreeS + pmNewsWeekFourS;
                double singlePmNewsPaper = (sumTotalOfPmNewsPrices / sumOfPmNewsQuantity);
                pmnewsMonthlyProjection = sumOfPmNewsQuantity * singlePmNewsPaper;
                Console.WriteLine("Projected Revenue for Selling PMNews for the Month is " + pmnewsMonthlyProjection);
            
                //Guardian Newspaper Projections
                Console.WriteLine("Projections for Guardian Newspaper");
                Console.WriteLine("Quantity Sold: ");
                Console.Write("Week One Quantity Sold: ");
                double guardianWeekOneQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Two Quantity Sold: ");
                double guardianWeekTwoQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Three Quantity Sold: ");
                double guardianWeekThreeQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Four Quantity Sold: ");
                double guardianWeekFourQ = Convert.ToDouble(Console.ReadLine());
                double sumOfGuardianQuantity = pmNewsWeekOneQ + pmNewsWeekTwoQ + pmNewsWeekThreeQ + pmNewsWeekFourQ;
                Console.WriteLine("Prices Sold: ");
                Console.Write("Price of Week One Quantity Sold: ");
                double guardianWeekOneS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Two Quantity Sold: ");
                double guardianWeekTwoS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Three Quantity Sold: ");
                double guardianWeekThreeS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Four Quantity Sold: ");
                double guardianWeekFourS = Convert.ToDouble(Console.ReadLine());
                double sumTotalOfGuardianPrices = guardianWeekOneS + guardianWeekTwoS + guardianWeekThreeS + guardianWeekFourS;
                double singleGuardianPaper = sumTotalOfGuardianPrices / sumOfGuardianQuantity;
                guardianMonthlyProjection = sumOfGuardianQuantity * singleGuardianPaper;
                Console.WriteLine("Projected Revenue for Selling The Guardian Newspaper for the Month is " + guardianMonthlyProjection);

                //Punch Newspaper Projections
                Console.WriteLine("Projections for Punch Newspaper");
                Console.WriteLine("Quantity Sold: ");
                Console.Write("Week One Quantity Sold: ");
                double punchWeekOneQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Two Quantity Sold: ");
                double punchWeekTwoQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Three Quantity Sold: ");
                double punchWeekThreeQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Four Quantity Sold: ");
                double punchWeekFourQ = Convert.ToDouble(Console.ReadLine());
                double sumOfPunchQuantity = punchWeekOneQ + punchWeekTwoQ + punchWeekThreeQ + punchWeekFourQ;
                Console.WriteLine("Prices Sold: ");
                Console.Write("Price of Week One Quantity Sold: ");
                double punchWeekOneS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Two Quantity Sold: ");
                double punchWeekTwoS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Three Quantity Sold: ");
                double punchWeekThreeS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Four Quantity Sold: ");
                double punchWeekFourS = Convert.ToDouble(Console.ReadLine());
                double sumTotalOfPunchPrices = punchWeekOneS + punchWeekTwoS + punchWeekThreeS + punchWeekFourS;
                double singlePunchPaper = sumTotalOfPunchPrices / sumOfPunchQuantity;
                punchMonthlyProjection = sumOfPunchQuantity * singlePunchPaper;
                Console.WriteLine("Projected Revenue for Selling Punch Newspaper for the Month is " + punchMonthlyProjection);  
                
                //The Sun Newspaper Projections
                Console.WriteLine("Projections for The Sun Newspaper");
                Console.WriteLine("Quantity Sold: ");
                Console.Write("Week One Quantity Sold: ");
                double sunWeekOneQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Two Quantity Sold: ");
                double sunWeekTwoQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Three Quantity Sold: ");
                double sunWeekThreeQ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Week Four Quantity Sold: ");
                double sunWeekFourQ = Convert.ToDouble(Console.ReadLine());
                double sumOfSunQuantity = sunWeekOneQ + sunWeekTwoQ + sunWeekThreeQ + sunWeekFourQ;
                Console.WriteLine("Prices Sold: ");
                Console.Write("Price of Week One Quantity Sold: ");
                double sunWeekOneS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Two Quantity Sold: ");
                double sunWeekTwoS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Three Quantity Sold: ");
                double sunWeekThreeS = Convert.ToDouble(Console.ReadLine());
                Console.Write("Price of Week Four Quantity Sold: ");
                double sunWeekFourS = Convert.ToDouble(Console.ReadLine());
                double sumTotalOfSunPrices = sunWeekOneS + sunWeekTwoS + sunWeekThreeS + sunWeekFourS;
                double singleSunPaper = sumTotalOfSunPrices / sumOfSunQuantity;
                sunMonthlyProjection = sumOfSunQuantity * singleSunPaper;
                Console.WriteLine("Projected Revenue for Selling The Sun Newspapaer for the week is " + sunMonthlyProjection);
            
                //Recommended Newspaper
                Console.Write("Most Valuable Paper is ");
                if (sunMonthlyProjection > pmnewsMonthlyProjection && sunMonthlyProjection >
                    guardianMonthlyProjection && sunMonthlyProjection > punchMonthlyProjection)
                {
                    Console.WriteLine("The Sun");
                }
                else if (pmnewsMonthlyProjection > sunMonthlyProjection && pmnewsMonthlyProjection > punchMonthlyProjection && pmnewsMonthlyProjection > guardianMonthlyProjection)
                {
                    Console.WriteLine("PMNews");
                }
                else if (punchMonthlyProjection > pmnewsMonthlyProjection && punchMonthlyProjection > guardianMonthlyProjection && punchMonthlyProjection > sunMonthlyProjection)
                {
                    Console.WriteLine("The Punch Newspaper");
                }
                else if (guardianMonthlyProjection > pmnewsMonthlyProjection && guardianMonthlyProjection > punchMonthlyProjection &&
                    guardianMonthlyProjection > sunMonthlyProjection)
                {
                    Console.WriteLine("The Guardian Newspaper");
                }
                else
                {
                    Console.WriteLine("All are of equal value");
                }

                }
                catch (Exception e)
                {
                Console.WriteLine(e.Message);
                }
            

        }
        
        //Abandoned Code below, please ignore
        //
        //Console.Write("Enter 1 for PMNews\n");
            //Console.Write("Enter 2 for Guardian Newspaper\n");
            //Console.Write("Enter 3 for Punch Newspaper\n");
            //Console.WriteLine("Enter 4 for The Sun");
            //int paper = Convert.ToInt32(Console.ReadLine());
        /*if (paper == 1)
        {
            Console.WriteLine("Projections for PMNews Selected");
            Console.Write("Estimate Price of PMNews: ");
            int sumOfQuantity = 23 + 20 + 18 + 14;
            float sumOfPrices = 150 + 160 + 155 + 175;
            float singlePaper = (sumOfPrices / sumOfQuantity);
            Console.WriteLine(singlePaper);
            try
            {
                Console.Write("Enter Quantity of PMNews Newspaper: ");
                int pmnewspaperQuantity = Convert.ToInt32(Console.ReadLine());
                pmnewsWeekProjection = (pmnewspaperQuantity * singlePaper);
                Console.WriteLine("Projected Revenue for Selling PMNews for the week is " + pmnewsWeekProjection);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        else if(paper == 2)
        {
            Console.WriteLine("Projections for Guardian Newspaper Selected");
            Console.Write("Estimate Price of Guardian Newspaper: ");
            int sumOfQuantity = 10 + 32 + 27 + 21;
            float sumOfPrices = 324.56f + 300f + 315.28f + 340f;
            float singlePaper = (sumOfPrices / sumOfQuantity);
            Console.WriteLine(singlePaper);
            try
            {
                Console.Write("Enter Quantity of Guardian Newspaper: ");
                int guardianNewsPaperQuantity = Convert.ToInt32(Console.ReadLine());
                guardianWeekProjection = guardianNewsPaperQuantity * singlePaper;
                Console.WriteLine("Projected Revenue for Selling The Guardian Newspaper for the week is " + guardianWeekProjection);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        else if (paper == 3)
        {
            Console.WriteLine("Projections for Punch Newspaper Selected");
            Console.Write("Estimate Price of Punch Newspaper: ");
            int sumOfQuantity = 12 + 20 + 35 + 19;
            float sumOfPrices = 245.35f + 220f + 265.5f + 290.14f;
            float singlePaper = (sumOfPrices / sumOfQuantity);
            Console.WriteLine(singlePaper);
            try
            {
                Console.Write("Enter Quantity of Punch Newspaper: ");
                int punchNewsPaperQuantity = Convert.ToInt32(Console.ReadLine());
                punchWeeklyProjection = (punchNewsPaperQuantity * singlePaper);
                Console.WriteLine("Projected Revenue for Selling Punch Newspaper for the week is " + punchWeeklyProjection);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        else if (paper == 4)
        {
            Console.WriteLine("Projections for The Sun Newspaper Selected");
            Console.Write("Estimate Price of The Sun Newspaper: ");
            int sumOfQuantity = 7 + 10 + 13 + 8;
            float sumOfPrices = 420f + 400f + 450.24f + 400f;
            float singlePaper = (sumOfPrices / sumOfQuantity);
            Console.WriteLine(singlePaper);
            try
            {
                Console.Write("Enter Quantity of The Sun Newspaper: ");
                int sunNewsPaperQuantity = Convert.ToInt32(Console.ReadLine());
                sunWeekProjection = sunNewsPaperQuantity * singlePaper;
                Console.WriteLine("Projected Revenue for Selling The Sun Newspapaer for the week is " + sunWeekProjection);

            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
            }

        }
        else
        {
            Console.WriteLine("Enter Valid selection!");
        }*/      
        
    }
}
