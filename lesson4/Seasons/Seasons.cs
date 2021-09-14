namespace lesson4.Seasons
{
   public static class YearSeason
   {
       private static Month Winter = Month.December | Month.January | Month.February;
       private static Month Spring = Month.March | Month.April | Month.May;
       private static Month Summer = Month.June | Month.July | Month.August;
       private static Month Fall   = Month.September | Month.October | Month.November;

       public static Season RevealSeasonBy(int monthNum)
       {
            ThrowExceptionIfMonthNumUncorrect(monthNum);
            Month month = GetMonth(monthNum);

            if ((month & Winter) > 0) return Season.Winter;
            else if ((month & Spring) > 0) return Season.Spring;
            else if ((month & Summer) > 0) return Season.Summer;
            else return Season.Fall;
        }

       private static void ThrowExceptionIfMonthNumUncorrect(int monthNum)
       {
            if( monthNum < 1 || monthNum > 12 )
            {
                throw new OutOfMonthRangeException();
            }
       }

       private static Month GetMonth (int monthNum) => (Month)(1 << (monthNum - 1));     
   }
}
