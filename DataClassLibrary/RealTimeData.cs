using System;

namespace DataClassLibrary
{
    public class RealTimeData
    {
        //区域，上海sh或深圳sz
        public string quyu { get; set; }
        //股票代码，6位
        public string code { get; set; }
        //股票名称
        public string name { get; set; }
        //今日开盘价
        public decimal jrkpj { get; set; }
        //昨日收盘价
        public decimal zrspj { get; set; }
        //当前价格
        public decimal dqjg { get; set; }
        //今日最高价
        public decimal jrzgj { get; set; }
        //今日最低价
        public decimal jrzdj { get; set; }
        //竞买价，即“买一”报价
        public decimal m11bj0 { get; set; }
        //竞卖价，即“卖一”报价
        public decimal m21bj0 { get; set; }
        //成交的股票数，由于股票交易以一百股为基本单位，所以在使用时，通常把该值除以一百
        public int cjgs { get; set; }
        //成交金额，单位为“元”，为了一目了然，通常以“万元”为成交金额的单位，所以通常把该值除以一万
        public decimal cjje { get; set; }
        //“买一”申请股数，除以一百为手数
        public int m11gs { get; set; }
        //“买一”报价
        public decimal m11bj { get; set; }
        //“买二”申请股数，除以一百为手数
        public int m12gs { get; set; }
        //“买二”报价
        public decimal m12bj { get; set; }
        //“买三”申请股数，除以一百为手数
        public int m13gs { get; set; }
        //“买三”报价
        public decimal m13bj { get; set; }
        //“买四”申请股数，除以一百为手数
        public int m14gs { get; set; }
        //“买四”报价
        public decimal m14bj { get; set; }
        //“买五”申请股数，除以一百为手数
        public int m15gs { get; set; }
        //“买五”报价
        public decimal m15bj { get; set; }
        //“卖一”申报股数，除以一百为手数
        public int m21gs { get; set; }
        //“卖一”报价
        public decimal m21bj { get; set; }
        //“卖二”申请股数，除以一百为手数
        public int m22gs { get; set; }
        //“卖二”报价
        public decimal m22bj { get; set; }
        //“卖三”申请股数，除以一百为手数
        public int m23gs { get; set; }
        //“卖三”报价
        public decimal m23bj { get; set; }
        //“卖四”申请股数，除以一百为手数
        public int m24gs { get; set; }
        //“卖四”报价
        public decimal m24bj { get; set; }
        //“卖五”申请股数，除以一百为手数
        public int m25gs { get; set; }
        //“卖五”报价
        public decimal m25bj { get; set; }
        //报价日期；
        public string bjday { get; set; }
        //报价时间；
        public string bjtime { get; set; }
    }
}
