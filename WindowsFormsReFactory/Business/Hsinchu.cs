using System;
using WindowsFormsReFactory.Model;

namespace WindowsFormsReFactory.Business
{
    public class Hsinchu: ILogistics
    {
        private double _fee;
        private readonly string _companyName = "新竹貨運";
        public Product ShipProduct { get; set; }

        public Hsinchu()
        {
        }

        public void Calculate()
        {
            var length = this.ShipProduct.Size.Length;
            var width = this.ShipProduct.Size.Width;
            var height = this.ShipProduct.Size.Height;

            var size = length * width * height;

            //計算運費邏輯
            //長 x 寬 x 高（公分）x 0.0000353
            if (length > 100 || width > 100 || height > 100)
            {
                this._fee = size * 0.0000353 * 1100 + 500;
            }
            else
            {
                this._fee = size * 0.0000353 * 1200;
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