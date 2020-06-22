using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsReFactory.Business;
using WindowsFormsReFactory.Model;

namespace WindowsFormsReFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //取得畫面資料
            Product product = this.GetProduct();

            var companyName = "";
            double fee = 0;

            ////選黑貓，計算出運費，呈現物流商名稱與運費
            //if (this.drpCompany.SelectedValue.ToString() == "1")
            //{
            //    //CalculatedByBlackCat();
            //    //取得畫面資料

            //    //計算
            //    //BlackCat blackCat = new BlackCat() { ShipProduct = product };
            //    //blackCat.Calculate();

            //    //companyName = blackCat.GetsComapanyName();
            //    //fee = blackCat.GetsFee();

            //    ILogistics logistics = new BlackCat() { ShipProduct = product };
            //    logistics.Calculate();
            //    companyName = logistics.GetsComapanyName();
            //    fee = logistics.GetsFee();
            //}
            ////選新竹貨運，計算出運費，呈現物流商名稱與運費
            //else if (this.drpCompany.SelectedValue.ToString() == "2")
            //{
            //    //CalculatedByHsinchu();
            //    //取得畫面資料

            //    //計算
            //    //Hsinchu hsinchu = new Hsinchu() { ShipProduct = product };
            //    //hsinchu.Calculate();

            //    //companyName = hsinchu.GetsComapanyName();
            //    //fee = hsinchu.GetsFee();

            //    ILogistics logistics = new Hsinchu() { ShipProduct = product };
            //    logistics.Calculate();
            //    companyName = logistics.GetsComapanyName();
            //    fee = logistics.GetsFee();
            //}
            ////選郵局，計算出運費，呈現物流商名稱與運費
            //else if (this.drpCompany.SelectedValue.ToString() == "3")
            //{
            //    //CalculatedByPostOffice();
            //    //取得畫面資料

            //    //計算
            //    //PostOffice postOffice = new PostOffice() { ShipProduct = product };
            //    //postOffice.Calculate();

            //    //companyName = postOffice.GetsComapanyName();
            //    //fee = postOffice.GetsFee();

            //    ILogistics logistics = new PostOffice() { ShipProduct = product };
            //    logistics.Calculate();
            //    companyName = logistics.GetsComapanyName();
            //    fee = logistics.GetsFee();
            //}

            //ILogistics logistics = this.GetILogistics(this.drpCompany.SelectedValue.ToString(), product);

            ILogistics logistics = FactoryRepository.GetILogistics(this.drpCompany.SelectedValue.ToString(), product);

            if (logistics != null)
            {
                logistics.Calculate();
                companyName = logistics.GetsComapanyName();
                fee = logistics.GetsFee();

                //呈現結果
                this.SetResult(companyName, fee);
            }
            //發生預期以外的狀況，呈現警告訊息，回首頁
            else
            {
                var js = "alert('發生不預期錯誤，請洽系統管理者');location.href='http://tw.yahoo.com/';";
                // this.ClientScript.RegisterStartupScript(this.GetType(), "back", js, true);
            }

            //呈現結果
            this.SetResult(companyName, fee);
        }

        /// <summary>
        /// 將ILogistics的instance，交給工廠來決定
        /// </summary>
        /// <param name="p"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        private ILogistics GetILogistics(string company, Product product)
        {
            if (company == "1")
            {
                return new BlackCat() { ShipProduct = product };
            }
            else if (company == "2")
            {
                return new Hsinchu() { ShipProduct = product };
            }
            else if (company == "3")
            {
                return new PostOffice() { ShipProduct = product };
            }
            else
            {
                return null;
            }
        }

        private void SetResult(string companyName, double fee)
        {
            this.lblCompany.Text = companyName;
            this.lblCharge.Text = fee.ToString();
        }

        private Product GetProduct()
        {
            var result = new Product
            {
                Name = this.txtProductName.Text.Trim(),
                Weight = Convert.ToDouble(this.txtProductWeight.Text),
                Size = new WindowsFormsReFactory.Model.Size()
                {
                    Length = Convert.ToDouble(this.txtProductLength.Text),
                    Width = Convert.ToDouble(this.txtProductWidth.Text),
                    Height = Convert.ToDouble(this.txtProductHeight.Text)
                },
                IsNeedCool = this.rdoNeedCool.Checked == true
            };

            return result;
        }

        //private void CalculatedByBlackCat()
        //{
        //    this.lblCompany.Text = "黑貓";
        //    var weight = Convert.ToDouble(this.txtProductWeight.Text);
        //    if (weight > 20)
        //    {
        //        this.lblCharge.Text = "500";
        //    }
        //    else
        //    {
        //        var fee = 100 + weight * 10;
        //        this.lblCharge.Text = fee.ToString();
        //    }
        //}

        //private void CalculatedByHsinchu()
        //{
        //    this.lblCompany.Text = "新竹貨運";
        //    var length = Convert.ToDouble(this.txtProductLength.Text);
        //    var width = Convert.ToDouble(this.txtProductWidth.Text);
        //    var height = Convert.ToDouble(this.txtProductHeight.Text);

        //    var size = length * width * height;

        //    //長 x 寬 x 高（公分）x 0.0000353
        //    if (length > 100 || width > 100 || height > 100)
        //    {
        //        this.lblCharge.Text = (size * 0.0000353 * 1100 + 500).ToString();
        //    }
        //    else
        //    {
        //        this.lblCharge.Text = (size * 0.0000353 * 1200).ToString();
        //    }
        //}

        //private void CalculatedByPostOffice()
        //{
        //    this.lblCompany.Text = "郵局";

        //    var weight = Convert.ToDouble(this.txtProductWeight.Text);
        //    var feeByWeight = 80 + weight * 10;

        //    var length = Convert.ToDouble(this.txtProductLength.Text);
        //    var width = Convert.ToDouble(this.txtProductWidth.Text);
        //    var height = Convert.ToDouble(this.txtProductHeight.Text);
        //    var size = length * width * height;
        //    var feeBySize = size * 0.0000353 * 1100;

        //    if (feeByWeight < feeBySize)
        //    {
        //        this.lblCharge.Text = feeByWeight.ToString();
        //    }
        //    else
        //    {
        //        this.lblCharge.Text = feeBySize.ToString();
        //    }
        //}
    }
}
