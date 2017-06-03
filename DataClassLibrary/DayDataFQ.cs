using System;


namespace DataClassLibrary
{
   public class DayDataFQ : DayData
    {
        private string _名称;

        public string 名称
        {
            get { return _名称; }
            set { _名称 = value; }
        }

        private decimal _最高价复权;

        public decimal 最高价复权
        {
            get { return _最高价复权; }
            set { _最高价复权 = value; }
        }
        private decimal _最低价复权;

        public decimal 最低价复权
        {
            get { return _最低价复权; }
            set { _最低价复权 = value; }
        }
        private decimal _开盘价复权;

        public decimal 开盘价复权
        {
            get { return _开盘价复权; }
            set { _开盘价复权 = value; }
        }
        private decimal _收盘价复权;

        public decimal 收盘价复权
        {
            get { return _收盘价复权; }
            set { _收盘价复权 = value; }
        }

        public DayDataFQ(DayData daydata)
            : base(daydata)
        {
        }
        public DayDataFQ()
        {
        }
    }

}
