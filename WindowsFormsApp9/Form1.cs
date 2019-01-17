using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MiniCafe.Hot_dog = 1.5;
            MiniCafe.Hamburger = 1.3;
            MiniCafe.Coco_cola = 0.9;
            MiniCafe.Cappuchino = 3.5;
            MiniCafe.Americano = 2.5;
            C_hotdogTbx.Text = MiniCafe.Hot_dog.ToString();
            C_hamburgerTbx.Text = MiniCafe.Hamburger.ToString();
            C_cococolaTbx.Text = MiniCafe.Coco_cola.ToString();
            C_cappuchinoTbx.Text = MiniCafe.Cappuchino.ToString();
            C_americanoTbx.Text = MiniCafe.Americano.ToString();
            Oil[] oils = new Oil[]
           {
                new Oil("AI-92",0.9),
                new Oil("Premium Euro-95",1.25),
                new Oil("Super Euro-98",1.5)
           };
            kindOfOilCbx.Items.AddRange(oils);
            kindOfOilCbx.DisplayMember = "KindOfOil";
        }
        List<Check> checks = new List<Check>();

        private void kindOfOilCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            litrePriceTbx.Text = (kindOfOilCbx.SelectedItem as Oil).PriceOfOil.ToString();
            orderTypeGbx.Enabled = true;
        }

        private void hotdogCbx_CheckedChanged(object sender, EventArgs e)
        {
            double overall;
            Q_hotdogTbx.ReadOnly = !hotdogCbx.Checked;
            Q_hamburgerTbx.ReadOnly = !hamburgerCbx.Checked;
            Q_cococolaTbx.ReadOnly = !cococolaCbx.Checked;
            Q_cappuchinoTbx.ReadOnly = !cappuchinoCbx.Checked;
            Q_americanoTbx.ReadOnly = !americanoCbx.Checked;

            if (Q_hotdogTbx.ReadOnly && double.TryParse(Q_hotdogTbx.Text, out overall))
            {
                miniCafeOverallCostLbl.Text = (double.Parse(miniCafeOverallCostLbl.Text) - overall * MiniCafe.Hot_dog).ToString();
                Q_hotdogTbx.Text = "";
            }
            if (Q_hamburgerTbx.ReadOnly && double.TryParse(Q_hamburgerTbx.Text, out overall))
            {
                miniCafeOverallCostLbl.Text = (double.Parse(miniCafeOverallCostLbl.Text) - overall * MiniCafe.Hamburger).ToString();
                Q_hamburgerTbx.Text = "";
            }
            if (Q_cococolaTbx.ReadOnly && double.TryParse(Q_cococolaTbx.Text, out overall))
            {
                miniCafeOverallCostLbl.Text = (double.Parse(miniCafeOverallCostLbl.Text) - overall * MiniCafe.Coco_cola).ToString();
                Q_cococolaTbx.Text = "";
            }
            if (Q_cappuchinoTbx.ReadOnly && double.TryParse(Q_cappuchinoTbx.Text, out overall))
            {
                miniCafeOverallCostLbl.Text = (double.Parse(miniCafeOverallCostLbl.Text) - overall * MiniCafe.Cappuchino).ToString();
                Q_cappuchinoTbx.Text = "";
            }
            if (Q_americanoTbx.ReadOnly && double.TryParse(Q_americanoTbx.Text, out overall))
            {
                miniCafeOverallCostLbl.Text = (double.Parse(miniCafeOverallCostLbl.Text) - overall * MiniCafe.Americano).ToString();
                Q_americanoTbx.Text = "";
            }
        }

        private void Q_hotdogTbx_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(sender as TextBox).ReadOnly) (sender as TextBox).Text = string.Empty;
        }


        private void litrePriceTbx_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = Color.Black;
        }

        private void Q_americanoTbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double price = 0;
                miniCafeOverallCostLbl.Text = price.ToString();
                if (Q_hotdogTbx.Text != string.Empty && hotdogCbx.Checked)
                    price += (double.Parse(Q_hotdogTbx.Text) * MiniCafe.Hot_dog);
                if (Q_hamburgerTbx.Text != string.Empty && hamburgerCbx.Checked)
                    price += (double.Parse(Q_hamburgerTbx.Text) * MiniCafe.Hamburger);
                if (Q_cococolaTbx.Text != string.Empty && cococolaCbx.Checked)
                    price += (double.Parse(Q_cococolaTbx.Text) * MiniCafe.Coco_cola);
                if (Q_cappuchinoTbx.Text != string.Empty && cappuchinoCbx.Checked)
                    price += (double.Parse(Q_cappuchinoTbx.Text) * MiniCafe.Cappuchino);
                if (Q_americanoTbx.Text != string.Empty && americanoCbx.Checked)
                    price += (double.Parse(Q_americanoTbx.Text) * MiniCafe.Americano);
                miniCafeOverallCostLbl.Text = price.ToString();
                if(miniCafeOverallCostLbl.Text != "0") overallCostLbl.Text = (double.Parse(miniCafeOverallCostLbl.Text) + double.Parse(oilStationOverallCostLbl.Text)).ToString() ;
            }

            catch (Exception)
            {
                (sender as TextBox).Text = string.Empty;
            }
        }

        private void printCheckBtn_MouseClick(object sender, MouseEventArgs e)
        {
            overallCostLbl.Text = (double.Parse(oilStationOverallCostLbl.Text) + double.Parse(miniCafeOverallCostLbl.Text)).ToString();
        }

        private void oilStationOverallCostLbl_TextChanged(object sender, EventArgs e)
        {
            overallCostLbl.Text = (double.Parse(oilStationOverallCostLbl.Text) + double.Parse(miniCafeOverallCostLbl.Text)).ToString();
        }

        private void litreRbtn_CheckedChanged(object sender, EventArgs e)
        {
            litresTbx.Enabled = litreRbtn.Checked;
            moneyTbx.Enabled = moneyRbtn.Checked;
        }

        private void litresTbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse((sender as TextBox).Text);
                if ((sender as TextBox).Text.Contains('.')) throw new Exception();
                if (!moneyRbtn.Checked)
                {
                    moneyTbx.Text = "0";
                    oilStationOverallCostLbl.Text = "0";
                    if (double.TryParse(litresTbx.Text, out double result) && kindOfOilCbx.Text != string.Empty && kindOfOilCbx.Text != "Choose kind of oil")
                    {
                        oilStationOverallCostLbl.Text = (result * double.Parse(litrePriceTbx.Text)).ToString();
                        moneyTbx.Text = oilStationOverallCostLbl.Text;
                    }
                }
            }
            catch (Exception)
            {
                (sender as TextBox).Text = string.Empty;
                moneyTbx.Text = "0";
                oilStationOverallCostLbl.Text = "0";
            }
        }

        private void moneyTbx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse((sender as TextBox).Text);
                if ((sender as TextBox).Text.Contains('.')) throw new Exception();
                if (!litreRbtn.Checked)
                {
                    litresTbx.Text = "0";
                    oilStationOverallCostLbl.Text = "0";
                    if (double.TryParse(moneyTbx.Text, out double result) && kindOfOilCbx.Text != string.Empty && kindOfOilCbx.Text != "Choose kind of oil")
                    {
                        litresTbx.Text = (result / double.Parse(litrePriceTbx.Text)).ToString("#.##");
                        oilStationOverallCostLbl.Text = moneyTbx.Text;
                    }
                }
            }
            catch (Exception)
            {
                (sender as TextBox).Text = string.Empty;
                litresTbx.Text = "0";
                oilStationOverallCostLbl.Text = "0";
            }
        }
        static int checkCounter = 0;
        private void printCheckBtn_Click(object sender, EventArgs e)
        {
            Check check;
            if (kindOfOilCbx.SelectedIndex != -1)
            {
                check = new Check($"{kindOfOilCbx.Text}", double.Parse(moneyTbx.Text), double.Parse(litresTbx.Text));
                checks.Add(check);
            }
            if (hotdogCbx.Checked && Q_hotdogTbx.Text != "0" && Q_hotdogTbx.Text != string.Empty)
            { check = new Check(hotdogCbx.Text, double.Parse(C_hotdogTbx.Text), double.Parse(Q_hotdogTbx.Text)); checks.Add(check); }
            if (hamburgerCbx.Checked && Q_hamburgerTbx.Text != "0" && Q_hamburgerTbx.Text != string.Empty)
            { check = new Check(hamburgerCbx.Text, double.Parse(C_hamburgerTbx.Text), double.Parse(Q_hamburgerTbx.Text)); checks.Add(check); }
            if (cococolaCbx.Checked && Q_cococolaTbx.Text != "0" && Q_cococolaTbx.Text != string.Empty)
            { check = new Check(cococolaCbx.Text, double.Parse(C_cococolaTbx.Text), double.Parse(Q_cococolaTbx.Text)); checks.Add(check); }
            if (cappuchinoCbx.Checked && Q_cappuchinoTbx.Text != "0" && Q_cappuchinoTbx.Text != string.Empty)
            { check = new Check(cappuchinoCbx.Text, double.Parse(C_cappuchinoTbx.Text), double.Parse(Q_cappuchinoTbx.Text)); checks.Add(check); }
            if (americanoCbx.Checked && Q_americanoTbx.Text != "0" && Q_americanoTbx.Text != string.Empty)
            { check = new Check(americanoCbx.Text, double.Parse(C_americanoTbx.Text), double.Parse(Q_americanoTbx.Text)); checks.Add(check); }
            var obj = JsonConvert.SerializeObject(checks);
            File.WriteAllText($"Check{++checkCounter}.json", obj);
        }
    }
}
