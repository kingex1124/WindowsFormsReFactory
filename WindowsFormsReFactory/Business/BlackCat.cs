using System;
using WindowsFormsReFactory.Model;

namespace WindowsFormsReFactory.Business
{
    public class BlackCat: ILogistics
    {
        private double _fee;
        private readonly string _companyName = "黑貓";
        public Product ShipProduct { get; set; }

        public BlackCat()
        {
        }

        public void Calculate()
        {
            var weight = this.ShipProduct.Weight;

            //計算運費邏輯
            if (weight > 20)
            {
                this._fee = 500;
            }
            else
            {
                //頁面呈現計算的運費結果
                var fee = 100 + weight * 10;
                this._fee = fee;
            }
        }

        public string GetsComapanyName()
        {
            return this._companyName;
        }

        public double GetsFee()
        {
            return this._fee;
        }
    }
}