using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    public partial class TodoForm : Form
    {
        public TodoForm()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelSideSubMenuCalender.Visible = false;
            panelSideSubMenuTasks.Visible = false;
            panelSideSubMenuManage.Visible = false;

        }

        // 알림 메시지를 표시하는 메서드
        public void ShowNotification(string message, NotificationType type = NotificationType.Information)
        {
            labelNotification.Text = message;
            
            // 알림 유형에 따른 색상 설정
            switch (type)
            {
                case NotificationType.Success:
                    labelNotification.ForeColor = Color.LightGreen;
                    break;
                case NotificationType.Warning:
                    labelNotification.ForeColor = Color.Yellow;
                    break;
                case NotificationType.Error:
                    labelNotification.ForeColor = Color.Red;
                    break;
                default:
                    labelNotification.ForeColor = Color.White;
                    break;
            }
            
            // 알림 패널이 보이도록 설정
            panelNotification.Visible = true;
            
            // 타이머를 사용하여 일정 시간 후 알림 숨기기
            Timer timer = new Timer();
            timer.Interval = 5000; // 5초 후 사라짐
            timer.Tick += (sender, e) => {
                panelNotification.Visible = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
        
        // 알림 유형을 정의하는 열거형
        public enum NotificationType
        {
            Information,
            Success,
            Warning,
            Error
        }

        private void hideSubMenu()
        {
            if (panelSideSubMenuCalender.Visible == true)
                panelSideSubMenuCalender.Visible = false;
            if (panelSideSubMenuTasks.Visible == true)
                panelSideSubMenuTasks.Visible = false;
            if (panelSideSubMenuManage.Visible == true)
                panelSideSubMenuManage.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void buttonSideMenuTasks_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSideSubMenuTasks);
        }

        private void buttonSideMenuActiveRecuriingTask_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonSideMenuCompletedTask_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonSideMenuHighPriorityTask_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonSideMenuTodayTask_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonSideMenuCalendar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSideSubMenuCalender);
        }

        private void buttonSideMenuMonthly_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonSideMenuWeekly_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonSideMenuDaily_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonSideMenuManage_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSideSubMenuManage);
        }

        private void buttonSideMenuSetting_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonSideMenuNotification_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonSideMenuCategory_Click(object sender, EventArgs e)
        {
            openFormByMenu(new CategoryForm());
            hideSubMenu();
            
            // 알림 메시지 표시 예제
            ShowNotification("카테고리 관리 화면이 열렸습니다.", NotificationType.Success);
        }

        private void buttonSideMenuRecurrenceRule_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private Form activedForm = null;
        private void openFormByMenu(Form activeForm)
        {
            try
            {
                if (activedForm != null)
                {
                    activedForm.Close();
                }
                
                activedForm = activeForm;
                activeForm.TopLevel = false;
                activeForm.FormBorderStyle = FormBorderStyle.None;
                activeForm.Dock = DockStyle.Fill;
                panelActiveForm.Controls.Add(activeForm);
                panelActiveForm.Tag = activeForm;
                activeForm.BringToFront();
                activeForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
