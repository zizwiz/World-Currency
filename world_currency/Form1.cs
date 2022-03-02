using System;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using System.Xml;
using world_currency.Properties;

namespace world_currency
{
    public partial class Form1 : Form
    {
        private bool flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbobx_country.SelectedIndex = 0;
            cmbobx_currency_number.SelectedIndex = 0;
            
            lbl_country.Visible = true;
            lbl_currency_number.Visible = false;

            cmbobx_country.Visible = true;
            cmbobx_currency_number.Visible = false;

            flag = true;

            //Get the data file from resources and write to file in same dir as the app.
            File.WriteAllText("ISO_4217.xml", Properties.Resources.ISO_4217);

          //  File.WriteAllBytes(fileName, Properties.Resources.file);
        }

        private void rdobtn_country_name_CheckedChanged(object sender, EventArgs e)
        {
            flag = rdobtn_country_name.Checked;
            dgv_data.Rows.Clear();
            dgv_data.Refresh();

            if (flag)
            {
                cmbobx_country.Visible = lbl_country.Visible = true;
                cmbobx_currency_number.Visible = lbl_currency_number.Visible = false;
            }
            else
            {
                cmbobx_country.Visible = lbl_country.Visible = false;
                cmbobx_currency_number.Visible = lbl_currency_number.Visible = true;
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string _sNode = "";

            dgv_data.Rows.Clear();
            dgv_data.Refresh();

            XmlDocument doc = new XmlDocument();
            doc.Load("ISO_4217.xml");

            XmlNodeList nodeList;
            XmlNode root = doc.DocumentElement;

            if (flag)
            {
                _sNode = "descendant::CurrencyBlock[CountryName='" + cmbobx_country.SelectedItem + "']";
            }
            else
            {
                _sNode = "descendant::CurrencyBlock[CurrencyNumber='" + cmbobx_currency_number.SelectedItem + "']";
            }
            
            nodeList = root.SelectNodes(_sNode);

            foreach (XmlNode data in nodeList)
            {
                //if (data["CountryName"].InnerText != "")
                //    rchtxbx_output.AppendText("Country Name = " + data["CountryName"].InnerText + "\r");

                //if (data["CurrencyName"].InnerText != "")
                //    rchtxbx_output.AppendText("Currency Name = " + data["CurrencyName"].InnerText + "\r");

                //if (data["Currency2LetterName"].InnerText != "")
                //    rchtxbx_output.AppendText("Currency 2 Letter Code = " + data["Currency2LetterName"].InnerText + "\r");

                //if (data["Currency3LetterName"].InnerText != "")
                //    rchtxbx_output.AppendText("Currency 3 Letter Code = " + data["Currency3LetterName"].InnerText + "\r");

                //if (data["CurrencyNumber"].InnerText != "")
                //    rchtxbx_output.AppendText("Currency Number = " + data["CurrencyNumber"].InnerText + "\r");

                //if (data["CurrencyMinorUnits"].InnerText != "")
                //    rchtxbx_output.AppendText("Minor Units = " + data["CurrencyMinorUnits"].InnerText + "\r");

                //if (data["CurrencySymbol"].InnerText != "")
                //    rchtxbx_output.AppendText("Currency Symbol = " + data["CurrencySymbol"].InnerText + "\r\r\r");


                string _currencydata = "Country Name = " + data["CountryName"].InnerText + "\r\n" +
                                      "Currency Name = " + data["CurrencyName"].InnerText + "\r" +
                                      "Currency 2 Letter Code = " + data["Currency2LetterName"].InnerText + "\r" +
                                      "Currency 3 Letter Code = " + data["Currency3LetterName"].InnerText + "\r" +
                                      "Currency Number = " + data["CurrencyNumber"].InnerText + "\r" +
                                      "Minor Units = " + data["CurrencyMinorUnits"].InnerText + "\r" +
                                      "Currency Symbol = " + data["CurrencySymbol"].InnerText;


               int index = dgv_data.Rows.Add();
                dgv_data.Rows[index].Cells["_flag"].Value = (Image)Resources.ResourceManager.GetObject(data["Currency2LetterName"].InnerText.ToLower());
                dgv_data.Rows[index].Cells["CurrencyData"].Value = _currencydata;
                dgv_data.Rows[index].Cells["banknote_f"].Value = (Image)Resources.ResourceManager.GetObject("_" + data["CurrencyNumber"].InnerText.ToLower() + "_f");
                dgv_data.Rows[index].Cells["banknote_b"].Value = (Image)Resources.ResourceManager.GetObject("_" + data["CurrencyNumber"].InnerText.ToLower() + "_b");


                //_flag
                //    CurrencyData
                //banknote_f
                //    banknote_b


            }
        }
    }
}
