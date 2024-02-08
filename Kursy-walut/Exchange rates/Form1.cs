using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Net;
using System.Net.Http.Json;
using System.Resources;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml.XPath;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Exchange_rates
{
    public partial class Form1 : Form
    {
        //public string currencyNameJSON, currencyCodeJSON;
        //private List<string> rates;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectCurrency.Items.AddRange(currences());
        }

        private string[] currences()
        {
            string[] currences = ["USD", "JPY", "CHF", "EUR", "GBP", "CZK", "NZD", "AUD", "CAD", "CHF", "HKD", "SGD", "DKK", "CNY", "ISK", "RUB", "INR"];
            return currences;
        }

        private void selectCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string url = "http://api.nbp.pl/api/exchangerates/rates/a/";
                int selected = selectCurrency.SelectedIndex;
                string[] currencyName = currences();

                if (selected != -1)
                {
                    url = url + currencyName[selected] + "/?format=json";
                    var res = GetResult(url);
                    labelJSON.Text = res;
                    currentLink.Text = url;
                    currentLink.BorderStyle = BorderStyle.FixedSingle;

                    panelInfo.Visible = true;
                    panelInfo2.Visible = true;

                    currencyMid.Visible = true;

                    currencyCode.Visible = true;


                    currencyNumber.Visible = true;


                    currencyEffectiveDate.Visible = true;


                    currentCurrency.Visible = true;


                    currencyNamelabel.Visible = true;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectCurrency_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < selectCurrency.Items.Count; ++i)
                if (i != e.Index) selectCurrency.SetItemChecked(i, false);
        }

        private static string GetResult(string url)
        {
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string result_JSON = reader.ReadToEnd();

            var result = JsonConvert.DeserializeObject<object>(result_JSON);
            return result.ToString();
        }
    }
}