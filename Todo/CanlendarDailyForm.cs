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
    public partial class CalendarDailyForm : Form
    {
        public CalendarDailyForm()
        {
            InitializeComponent();
            this.Resize += CalendarDailyForm_Resize;
            this.Load += CalendarDailyForm_Load;
        }

        private void CalendarDailyForm_Load(object sender, EventArgs e)
        {
            UpdateButtonPosition();
        }

        private void CalendarDailyForm_Resize(object sender, EventArgs e)
        {
            UpdateButtonPosition();
        }

        private void UpdateButtonPosition()
        {
            buttonCalendarDailyFormClose.Location = new Point(this.ClientSize.Width - buttonCalendarDailyFormClose.Width - 10, 10);
        }

        private void buttonCalendarDailyFormClose_Click(object sender, EventArgs e)
        {
            // 부모 폼(TodoForm) submenu 숨기기
            if (this.ParentForm is TodoForm todoForm)
            {
                todoForm.hideSubMenu();
                todoForm.ShowNotification("캘린더 일일 화면이 닫혔습니다.", TodoForm.NotificationType.Information);
            }

            this.Close();
        }
    }
}
