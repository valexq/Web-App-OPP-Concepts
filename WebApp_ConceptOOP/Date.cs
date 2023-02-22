using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_ConceptOOP
{
    public class Date
    {
        #region Fields
        private int _year;
        private int _month;
        private int _day;
        #endregion

        #region Methods
        //ctor para crear constructor
        public Date(int year, int month, int day)
        {
            _year = Checkyear(year);
            _month = CheckMonth(month);
            _day = CheckDay(day,month,year);
        }

        private int Checkyear(int year)
        {
            if(year >= 1900)
            {
                return year;    
            }
            throw new YearException("Year is invalid");
        }

        private int CheckDay(int day, int month, int year)
        {
            if(month == 2 && day == 29 && IsLeapYear(year)) {
                return day;
            }
            int[] daysPerMonth = {0, 31 ,28 ,31 ,30 ,31 ,30 ,31 ,31 ,30 ,31 ,30 ,31};
            
            if(day >= 1 && day<= daysPerMonth[month] )
            {
                return day;
            }
            throw new DayException("The day is invalid");
        }

        private bool IsLeapYear(int year)
        {
            if(year%400 == 0 || year%4== 0 && year%100 != 0)
            {
                return true;
            }
            return false;
        }

        private int CheckMonth(int month)
        {
            if(month >= 1 && month <= 12)
            {
                return month;
            }
            throw new MonthException("The month is invalid");
        }



        public override string ToString()
        {
            return String.Format("{0:0000}/{1:00}/{2:00}", _year,_month,_day);
          //return $"{-_year}/{_month}/{_day}";
        }



        #endregion
    }
}
