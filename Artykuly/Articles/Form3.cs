using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Articles
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            editArticle();
        }

        private void editArticle()
        {
            string editArticleName, editCategory, editContent;

            editArticleName = inputNewArticleName.Text;
            editCategory = inputNewCategory.Text;
            editContent = inputNewContent.Text;


            //Article.EditSelected(editArticleName, editCategory, editContent, selectedID);

            Close();
        }
    }
}
