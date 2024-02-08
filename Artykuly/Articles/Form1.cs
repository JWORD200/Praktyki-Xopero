using System.Data.SQLite;
using System.ComponentModel;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Data;
using Articles;
using System.Security.Policy;
using System.Configuration;
using SQLitePCL;

namespace Articles
{
    public partial class Form1 : Form
    {
        public int selectedID;
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
            Form3 formDb = new Form3();
            formDb.ShowDialog();
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {

        }

        private void ArticlesGridView_CellClick(object sender, EventArgs e)
        {
            //displayArticleContent();
        }
        /*
        private void displayArticleContent()
        {
            DataGridViewSelectedRowCollection rows = articlesGirdView.SelectedRows;
            while (rows != null)
            {
                string val = (string)rows[0].Cells["id"].Value.ToString();
                Int64 selectedID = Int64.Parse(val);
                string content = Article.GetSelectedArticleContentByID(selectedID).ToString();
                textBoxContent.Text = content;
            }

        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            articlesGirdView.DataSource = Article.GetArticleInfo();
        }
    }

    public class Article
    {

        public int id { get => id; set => id = value; }
        public string articleName { get => articleName; set => articleName = value; }
        public string category { get => category; set => category = value; }
        public string content { get => content; set => content = value; }

        public static DataTable GetArticleInfo()
        {
            string query = "SELECT id, articleName, category, dateCreate, hourModify FROM info;";
            return DatabaseActions.ExecuteQuery(query);
        }

        public static DataTable GetSelectedArticleContentByID(Int64 selectedID)
        {
            string query = "SELECT content FROM info WHERE id = " + selectedID;

            return DatabaseActions.ExecuteQuery(query);
        }

        //public int GetID()
        //{
        //    string query = "SELECT id FROM info";
        //    return id;
        //}

        public static int EditSelected(int SelectedID, string addArticleName, string addCategory, string addContent)
        {
            string query = string.Format("UPDATE info SET articleName = '{0}', category = '{1}'," +
                            "content = '{2}', hourModify = time(), dateModify = date() WHERE id = {3}", addArticleName, addCategory, addContent, SelectedID);
            return DatabaseActions.ExecuteNonQuery(query);
        }

        public int DeleteSelected(int SelectedID)
        {
            string query = "DELETE * FROM info WHERE id = " + SelectedID;
            return DatabaseActions.ExecuteNonQuery(query);
        }

        public static int AddNewArticle(string addArticleName, string addCategory, string addContent)
        {
            string query = string.Format("INSERT INTO info (id, articleName, category, dateCreate, hourModify, content, dateModify)" +
                            "VALUES(null, '{0}', '{1}', DATE(), time(), '{2}', DATE());", addArticleName, addCategory, addContent);
            return DatabaseActions.ExecuteNonQuery(query);
        }
    }
}