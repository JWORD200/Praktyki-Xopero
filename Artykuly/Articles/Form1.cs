using Microsoft.Data.Sqlite;
using System.ComponentModel;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Articles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 formDb = new Form2();
            formDb.ShowDialog();
        }

        private void buttonEditSelected_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {

        }

        private void displayArticlesInfo()
        {

            using (var connection = new SqliteConnection("Data source=C:\\Users\\Xopero\\Documents\\Praktyki\\Github\\Artykuly\\Articles\\artykuly.db"))
            {
                connection.Open();


                var sqliteAdd = connection.CreateCommand();
                sqliteAdd.CommandText = "Select id, articleName, category, dateCreate, hourModify, content, dateModify From info";
                sqliteAdd.Prepare();
                sqliteAdd.ExecuteNonQuery();



                connection.Close();
                Close();
            }

            for () 
            {



                splitContainer1.Panel1.Controls.Add(new dataGridViewMaker());
            }
        }

        private void displayArticleContent()
        {

        }
    }
}

public class dataGridViewMaker : Form
{
    private int id;
    private string name, category, date, dateModify, hourModify;

    public dataGridViewMaker(int id, string name, string category, string date, string dateModify, string hourModify)
    {
        this.id = id;
        this.name = name;
        this.category = category;
        this.date = date;
        this.dateModify = dateModify;
        this.hourModify = hourModify;

        DataGridView dataGridView1 = new DataGridView();
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(40, 40);
        dataGridView1.Margin = new Padding(20);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(428, 159);
        dataGridView1.TabIndex = 1;
    }
}

public class dataConnector
{

}