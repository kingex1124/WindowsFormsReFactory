﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsReFactory.Temp
{
    class Part2
    {
        //private void btnCalculate_Click(object sender, EventArgs e)
        //{
        //    //選黑貓，計算出運費，呈現物流商名稱與運費
        //    if (this.drpCompany.SelectedValue.ToString() == "1")
        //    {
        //        CalculatedByBlackCat();
        //    }
        //    //選新竹貨運，計算出運費，呈現物流商名稱與運費
        //    else if (this.drpCompany.SelectedValue.ToString() == "2")
        //    {
        //        CalculatedByHsinchu();
        //    }
        //    //選郵局，計算出運費，呈現物流商名稱與運費
        //    else if (this.drpCompany.SelectedValue.ToString() == "3")
        //    {
        //        CalculatedByPostOffice();
        //    }
        //    //發生預期以外的狀況，呈現警告訊息，回首頁
        //    else
        //    {
        //        var js = "alert('發生不預期錯誤，請洽系統管理者');location.href='http://tw.yahoo.com/';";
        //        // this.ClientScript.RegisterStartupScript(this.GetType(), "back", js, true);
        //    }
        //}

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
