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
            String addArticleName, addCategory, addContent;

            addArticleName = inputNewArticleName.Text;
            addCategory = inputNewCategory.Text;
            addContent = inputNewContent.Text;

            Article.AddNewArticle(addArticleName, addCategory, addContent);

            Close();
        }
    }
}
