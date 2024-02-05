using Microsoft.Data.Sqlite;

namespace Articles
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            openNewForm();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            newArticle();
        }

        private void newArticle()
        {
            if (File.Exists("artykuly.db"))
            {
                using (var connection = new SqliteConnection("Data source=C:\\Users\\Xopero\\Documents\\Praktyki\\Github\\Artykuly\\Articles\\artykuly.db"))
                {
                    connection.Open();

                    String addArticleName, addCategory, addContent;

                    addArticleName = inputNewArticleName.Text;
                    addCategory = inputNewCategory.Text;
                    addContent = inputNewContent.Text;

                    var sqliteAdd = connection.CreateCommand();
                    sqliteAdd.CommandText = "INSERT INTO info ('id', 'articleName', 'category', 'dateCreate', 'hourModify', 'content', 'dateModify')" +
                                            "VALUES(null, @articleName, @category , DATE(), time(), @content, DATE())";

                    sqliteAdd.Parameters.AddWithValue("@articleName", addArticleName);
                    sqliteAdd.Parameters.AddWithValue("@category", addCategory);
                    sqliteAdd.Parameters.AddWithValue("@content", addContent);

                    sqliteAdd.Prepare();
                    sqliteAdd.ExecuteNonQuery();

                    connection.Close();
                    Close();
                }
            }
            else
            {
                labelNoDb.Visible = true;
            }
        }
    }
}
