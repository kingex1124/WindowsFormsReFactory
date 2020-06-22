using System;
using WindowsFormsReFactory.Model;

namespace WindowsFormsReFactory.Business
{
    public class PostOffice: ILogistics
    {
        private double _fee;
        private readonly string _companyName = "郵局";
        public Product ShipProduct { get; set; }

        public PostOffice()
        {
        }

        public void Calculate()
        {
            var weight = this.ShipProduct.Weight;
            var feeByWeight = 80 + weight * 10;

            var length = this.ShipProduct.Size.Length;
            var width = this.ShipProduct.Size.Width;
            var height = this.ShipProduct.Size.Height;

            var size = length * width * height;
            var feeBySize = size * 0.0000353 * 1100;

            //計算運費邏輯
            if (feeByWeight < feeBySize)
            {
                this._fee = feeByWeight;
            }
            else
            {
                this._fee = feeBySize;
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