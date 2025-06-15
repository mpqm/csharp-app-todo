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
        // 기본 배경색
        private Color defaultBgColor = Color.Black;
        // 서브메뉴 기본 배경색
        private Color defaultSubMenuBgColor = Color.DarkGray;

        public TodoForm()
        {
            InitializeComponent();
            initSubMenu();
        }

        // 서브메뉴 초기화
        private void initSubMenu()
        {
            panelSideSubMenuCalender.Visible = false;
            panelSideSubMenuTasks.Visible = false;
            panelSideSubMenuManage.Visible = false;
        }

        // 서브메뉴 숨기기
        public void hideSubMenu()
        {
            if (panelSideSubMenuCalender.Visible == true)
                panelSideSubMenuCalender.Visible = false;
            if (panelSideSubMenuTasks.Visible == true)
                panelSideSubMenuTasks.Visible = false;
            if (panelSideSubMenuManage.Visible == true)
                panelSideSubMenuManage.Visible = false;
        }

        // 서브메뉴 표시
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

        // 선택된 버튼 활성화 메서드
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                Button clickedButton = (Button)btnSender;
                
                // 서브 메뉴 버튼인 경우에만 배경색 변경
                if (IsSubMenuButton(clickedButton))
                {
                    if (currentButton != clickedButton)
                    {
                        // 이전 버튼 비활성화
                        DisableButton();
                        
                        // 현재 버튼 활성화
                        currentButton = clickedButton;
                        currentButton.BackColor = Color.Gray;
                    }
                }
            }
        }

        // 버튼 비활성화 메서드
        private void DisableButton()
        {
            if (currentButton != null && IsSubMenuButton(currentButton))
            {
                currentButton.BackColor = defaultSubMenuBgColor;
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

        // 알림 유형을 정의하는 열거형
        public enum NotificationType
        {
            Information,
            Success,
            Warning,
            Error
        }

        private void buttonSideMenuTasks_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSideSubMenuTasks);
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
            showSubMenu(panelSideSubMenuCalender);
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
            openFormByMenu(new CalendarDailyForm());
            ActivateButton(sender);
        }

        // 관리 서브메뉴 버튼 클릭 이벤트
        private void buttonSideMenuManage_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSideSubMenuManage);
        }

        private void buttonSideMenuSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSideMenuNotification_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSideMenuCategory_Click(object sender, EventArgs e)
        {
            openFormByMenu(new CategoryForm());
            ActivateButton(sender);
        }

        private void buttonSideMenuRecurrenceRule_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }


    }
}
