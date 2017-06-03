using System;

namespace DataClassLibrary
{
    public class DayData
    {
        private int _日期;
        
        public int 日期
        {
            get { return _日期; }
            set { _日期 = value; }
        }

        public string 日期2
        {
            get { return Convert.ToString(_日期); }
        }

        private int _开盘价;

        public int 开盘价
        {
            get { return _开盘价; }
            set { _开盘价 = value; }
        }
        public decimal 开盘价2
        {

            get { return Convert.ToDecimal(_开盘价 / 100.0); }
            set { _开盘价 = Convert.ToInt32(value * 100); }

        }
        private int _最高价;

        public int 最高价
        {
            get { return _最高价; }
            set { _最高价 = value; }
        }
        public decimal 最高价2
        {
            get { return Convert.ToDecimal(_最高价 / 100.0); }
            set
            {
                _最高价 = Convert.ToInt32(value * 100);
            }
        }

        private int _最低价;

        public int 最低价
        {
            get { return _最低价; }
            set { _最低价 = value; }
        }
        public decimal 最低价2
        {
            get { return Convert.ToDecimal(_最低价 / 100.0); }
            set
            {
                _最低价 = Convert.ToInt32(value * 100);
            }
        }
        private int _收盘价;

        public int 收盘价
        {
            get { return _收盘价; }
            set { _收盘价 = value; }
        }
        public decimal 收盘价2
        {
            get { return Convert.ToDecimal(_收盘价 / 100.0); }
            set
            {
                _收盘价 = Convert.ToInt32(value * 100);
            }
        }

        private decimal _成交金额;

        public decimal 成交金额
        {
            get { return _成交金额; }
            set { _成交金额 = value; }
        }

        public decimal 成交金额2
        {
            get { return _成交金额 / 100000000; }
        }

        private System.Int64 _成交量;

        public System.Int64 成交量
        {
            get { return _成交量; }
            set { _成交量 = value; }
        }
        public decimal 成交量2
        {
            get { return _成交量 / 10000; }
        }
        private int _保留;

        public int 保留
        {
            get { return _保留; }
            set { _保留 = value; }
        }
        private string _代码;

        public string 代码
        {
            get { return _代码; }
            set { _代码 = value; }
        }
        private string _交易所;

        public string 交易所
        {
            get { return _交易所; }
            set { _交易所 = value; }
        }
        public DayData()
        {
        }
        public DayData(string quyu, string code, string riqi, decimal kpj, decimal zgj, decimal zdj, decimal spj, decimal cjje, decimal cjl)
        {
            _交易所 = quyu;
            _代码 = code;
            _日期 = Convert.ToInt32(riqi);
            _开盘价 = Convert.ToInt32(kpj * 100);
            _收盘价 = Convert.ToInt32(spj * 100);
            _最高价 = Convert.ToInt32(zgj * 100);
            _最低价 = Convert.ToInt32(zdj * 100);
            _成交金额 = Convert.ToDecimal(cjje * 100000000);
            _成交量 = Convert.ToInt32(cjl * 10000);
        }
        public DayData(DayData _daydata)
        {
            _交易所 = _daydata._交易所;
            _代码 = _daydata._代码;
            _日期 = _daydata._日期;
            _开盘价 = _daydata._开盘价;
            _收盘价 = _daydata._收盘价;
            _最高价 = _daydata._最高价;
            _最低价 = _daydata._最低价;
            _成交金额 = _daydata._成交金额;
            _成交量 = _daydata._成交量;

        }
    }
}
