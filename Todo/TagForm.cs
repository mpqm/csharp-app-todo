using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo;

namespace todo
{
    public partial class TagForm : Form
    {
        public TagForm()
        {
            InitializeComponent();
            this.Resize += TagForm_Load;
            this.Load += TagForm_Resize;
        }

        private void TagForm_Load(object sender, EventArgs e)
        {
            UpdateButtonPosition();
        }

        private void TagForm_Resize(object sender, EventArgs e)
        {
            UpdateButtonPosition();
        }

        private void UpdateButtonPosition()
        {
            buttonCategoryFormClose.Location = new Point(this.ClientSize.Width - buttonCategoryFormClose.Width - 10, 10);
        }

        private void buttonCategoryFormClose_Click(object sender, EventArgs e)
        {
            // 부모 폼(TodoForm) submenu 숨기기
            if (this.ParentForm is TodoForm todoForm) todoForm.HideSubMenu();
            this.Close();
        }
    }
}
