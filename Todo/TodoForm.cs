using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using todo;

namespace Todo
{
    public partial class TodoForm : Form
    {
        // 현재 선택된 메뉴 버튼
        private Button currentButton;
        // 서브메뉴 기본 배경색
        private Color defaultSubMenuBgColor = Color.White;

        public TodoForm()
        {
            InitializeComponent();
            InitSubMenu();
        }

        // 서브메뉴 초기화
        private void InitSubMenu()
        {
            panelSideSubMenuCalender.Visible = false;
            panelSideSubMenuTasks.Visible = false;
            panelSideSubMenuManage.Visible = false;
        }

        // 서브메뉴 숨기기
        public void HideSubMenu()
        {
            if (panelSideSubMenuCalender.Visible == true)
                panelSideSubMenuCalender.Visible = false;
            if (panelSideSubMenuTasks.Visible == true)
                panelSideSubMenuTasks.Visible = false;
            if (panelSideSubMenuManage.Visible == true)
                panelSideSubMenuManage.Visible = false;
        }

        // 서브메뉴 표시
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        // 선택된 버튼 활성화 메서드
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                // 모든 서브메뉴 버튼 비활성화
                DisableAllSubMenuButtons();
                
                Button clickedButton = (Button)btnSender;
                
                // 서브 메뉴 버튼인 경우에만 배경색 변경
                if (IsSubMenuButton(clickedButton))
                {
                    // 현재 버튼 활성화
                    currentButton = clickedButton;
                    currentButton.BackColor = Color.LightGray;
                }
            }
        }

        // 모든 서브메뉴 버튼 비활성화 메서드
        private void DisableAllSubMenuButtons()
        {
            foreach (Control control in panelSideSubMenuTasks.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = defaultSubMenuBgColor;
                }
            }
            
            foreach (Control control in panelSideSubMenuCalender.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = defaultSubMenuBgColor;
                }
            }
            
            foreach (Control control in panelSideSubMenuManage.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = defaultSubMenuBgColor;
                }
            }
        }

        // 버튼이 서브메뉴 버튼인지 확인
        private bool IsSubMenuButton(Button button)
        {
            return button.Parent == panelSideSubMenuTasks || button.Parent == panelSideSubMenuCalender || button.Parent == panelSideSubMenuManage;
        }
        
        // 현재 활성화된 폼을 저장하는 변수
        private Form activedForm = null;

        // 패널에 활성화된 폼을 표시하는 변수
        private void OpenFormByMenu(Form activeForm)
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

        private void buttonSideMenuTasks_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSideSubMenuTasks);
        }

        private void buttonSideMenuActiveRecuriingTask_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSideMenuCompletedTask_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSideMenuHighPriorityTask_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSideMenuTodayTask_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        // 캘린더 서브메뉴 버튼 클릭 이벤트
        private void buttonSideMenuCalendar_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSideSubMenuCalender);
        }

        private void buttonSideMenuMonthly_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSideMenuWeekly_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSideMenuDaily_Click(object sender, EventArgs e)
        {
            OpenFormByMenu(new CalendarDailyForm());
            ActivateButton(sender);
        }

        // 관리 서브메뉴 버튼 클릭 이벤트
        private void buttonSideMenuManage_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSideSubMenuManage);
        }

        private void buttonSideMenuCategory_Click(object sender, EventArgs e)
        {
            OpenFormByMenu(new CategoryForm());
            ActivateButton(sender);
        }

        private void buttonSideMenuTag_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSideMenuNotification_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSideMenuExport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSideMenuSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

    }
}
