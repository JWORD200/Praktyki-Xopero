using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Text;
using System.Net;
using System.Net.Http.Json;
using System.Resources;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml.XPath;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Exchange_rates
{
    public partial class Form1 : Form
    {
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

                    currentLink.Text = url;
                    currentLink.BorderStyle = BorderStyle.FixedSingle;

                    panelInfo.Visible = true;
                    panelInfo2.Visible = true;

                    currencyCode.Visible = true;
                    currencyCode.Text = res.Code;

                    currencyNumber.Visible = true;
                    currencyEffectiveDate.Visible = true;
                    currencyMid.Visible = true;

                    currentCurrency.Visible = true;

                    currencyNamelabel.Visible = true;
                    currencyNamelabel.Text = res.Currency;
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

        private CurrentCurrency GetResult(string url)
        {
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string result_JSON = reader.ReadToEnd();

            labelJSON.Text = result_JSON;
            var result = JsonConvert.DeserializeObject<CurrentCurrency>(result_JSON);
            return result;
        }
    }
}

class CurrentCurrency
{
    public string Table { get; set; }
    public string Currency { get; set; }
    public string Code { get; set; }
    public List<CurrencyRates> Rates { get; set; }
    public class CurrencyRates
    {
        [JsonProperty("no")]
        public string Number { get; set; }
        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
        [JsonProperty("mid")]
        public string Mid { get; set; }
    }
}