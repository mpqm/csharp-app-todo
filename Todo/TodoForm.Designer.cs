﻿namespace Todo
{
    partial class TodoForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSideSubMenuManage = new System.Windows.Forms.Panel();
            this.buttonSideMenuSetting = new System.Windows.Forms.Button();
            this.buttonSideMenuNotification = new System.Windows.Forms.Button();
            this.buttonSideMenuExport = new System.Windows.Forms.Button();
            this.buttonSidemenuTag = new System.Windows.Forms.Button();
            this.buttonSideMenuCategory = new System.Windows.Forms.Button();
            this.buttonSideMenuManage = new System.Windows.Forms.Button();
            this.panelSideSubMenuCalender = new System.Windows.Forms.Panel();
            this.buttonSideMenuMonthly = new System.Windows.Forms.Button();
            this.buttonSideMenuWeekly = new System.Windows.Forms.Button();
            this.buttonSideMenuDaily = new System.Windows.Forms.Button();
            this.buttonSideMenuCalendar = new System.Windows.Forms.Button();
            this.panelSideSubMenuTasks = new System.Windows.Forms.Panel();
            this.buttonSideMenuCompletedTask = new System.Windows.Forms.Button();
            this.buttonSideMenuActiveRecuriingTask = new System.Windows.Forms.Button();
            this.buttonSideMenuHighPriorityTask = new System.Windows.Forms.Button();
            this.buttonSideMenuTodayTask = new System.Windows.Forms.Button();
            this.buttonSideMenuTasks = new System.Windows.Forms.Button();
            this.panelSideMenuOverView = new System.Windows.Forms.Panel();
            this.buttonSideMenuTodo = new System.Windows.Forms.Button();
            this.panelActiveForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelSideSubMenuManage.SuspendLayout();
            this.panelSideSubMenuCalender.SuspendLayout();
            this.panelSideSubMenuTasks.SuspendLayout();
            this.panelSideMenuOverView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Black;
            this.panelSideMenu.Controls.Add(this.panelSideSubMenuManage);
            this.panelSideMenu.Controls.Add(this.buttonSideMenuManage);
            this.panelSideMenu.Controls.Add(this.panelSideSubMenuCalender);
            this.panelSideMenu.Controls.Add(this.buttonSideMenuCalendar);
            this.panelSideMenu.Controls.Add(this.panelSideSubMenuTasks);
            this.panelSideMenu.Controls.Add(this.buttonSideMenuTasks);
            this.panelSideMenu.Controls.Add(this.panelSideMenuOverView);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(279, 844);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelSideSubMenuManage
            // 
            this.panelSideSubMenuManage.Controls.Add(this.buttonSideMenuSetting);
            this.panelSideSubMenuManage.Controls.Add(this.buttonSideMenuNotification);
            this.panelSideSubMenuManage.Controls.Add(this.buttonSideMenuExport);
            this.panelSideSubMenuManage.Controls.Add(this.buttonSidemenuTag);
            this.panelSideSubMenuManage.Controls.Add(this.buttonSideMenuCategory);
            this.panelSideSubMenuManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideSubMenuManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSideSubMenuManage.Location = new System.Drawing.Point(0, 554);
            this.panelSideSubMenuManage.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideSubMenuManage.Name = "panelSideSubMenuManage";
            this.panelSideSubMenuManage.Size = new System.Drawing.Size(279, 251);
            this.panelSideSubMenuManage.TabIndex = 7;
            // 
            // buttonSideMenuSetting
            // 
            this.buttonSideMenuSetting.BackColor = System.Drawing.Color.White;
            this.buttonSideMenuSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuSetting.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuSetting.ForeColor = System.Drawing.Color.Black;
            this.buttonSideMenuSetting.Location = new System.Drawing.Point(0, 200);
            this.buttonSideMenuSetting.Name = "buttonSideMenuSetting";
            this.buttonSideMenuSetting.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuSetting.TabIndex = 25;
            this.buttonSideMenuSetting.Text = "Setting";
            this.buttonSideMenuSetting.UseVisualStyleBackColor = false;
            this.buttonSideMenuSetting.Click += new System.EventHandler(this.buttonSideMenuSetting_Click);
            // 
            // buttonSideMenuNotification
            // 
            this.buttonSideMenuNotification.BackColor = System.Drawing.Color.White;
            this.buttonSideMenuNotification.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuNotification.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuNotification.ForeColor = System.Drawing.Color.Black;
            this.buttonSideMenuNotification.Location = new System.Drawing.Point(0, 150);
            this.buttonSideMenuNotification.Name = "buttonSideMenuNotification";
            this.buttonSideMenuNotification.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuNotification.TabIndex = 24;
            this.buttonSideMenuNotification.Text = "Notification";
            this.buttonSideMenuNotification.UseVisualStyleBackColor = false;
            this.buttonSideMenuNotification.Click += new System.EventHandler(this.buttonSideMenuNotification_Click);
            // 
            // buttonSideMenuExport
            // 
            this.buttonSideMenuExport.BackColor = System.Drawing.Color.White;
            this.buttonSideMenuExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuExport.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuExport.ForeColor = System.Drawing.Color.Black;
            this.buttonSideMenuExport.Location = new System.Drawing.Point(0, 100);
            this.buttonSideMenuExport.Name = "buttonSideMenuExport";
            this.buttonSideMenuExport.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuExport.TabIndex = 22;
            this.buttonSideMenuExport.Text = "Export";
            this.buttonSideMenuExport.UseVisualStyleBackColor = false;
            this.buttonSideMenuExport.Click += new System.EventHandler(this.buttonSideMenuExport_Click);
            // 
            // buttonSidemenuTag
            // 
            this.buttonSidemenuTag.BackColor = System.Drawing.Color.White;
            this.buttonSidemenuTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSidemenuTag.FlatAppearance.BorderSize = 0;
            this.buttonSidemenuTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSidemenuTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSidemenuTag.ForeColor = System.Drawing.Color.Black;
            this.buttonSidemenuTag.Location = new System.Drawing.Point(0, 50);
            this.buttonSidemenuTag.Name = "buttonSidemenuTag";
            this.buttonSidemenuTag.Size = new System.Drawing.Size(279, 50);
            this.buttonSidemenuTag.TabIndex = 17;
            this.buttonSidemenuTag.Text = "Tag";
            this.buttonSidemenuTag.UseVisualStyleBackColor = false;
            this.buttonSidemenuTag.Click += new System.EventHandler(this.buttonSideMenuTag_Click);
            // 
            // buttonSideMenuCategory
            // 
            this.buttonSideMenuCategory.BackColor = System.Drawing.Color.White;
            this.buttonSideMenuCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuCategory.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuCategory.ForeColor = System.Drawing.Color.Black;
            this.buttonSideMenuCategory.Location = new System.Drawing.Point(0, 0);
            this.buttonSideMenuCategory.Name = "buttonSideMenuCategory";
            this.buttonSideMenuCategory.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuCategory.TabIndex = 10;
            this.buttonSideMenuCategory.Text = "Category";
            this.buttonSideMenuCategory.UseVisualStyleBackColor = false;
            this.buttonSideMenuCategory.Click += new System.EventHandler(this.buttonSideMenuCategory_Click);
            // 
            // buttonSideMenuManage
            // 
            this.buttonSideMenuManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuManage.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuManage.Location = new System.Drawing.Point(0, 504);
            this.buttonSideMenuManage.Name = "buttonSideMenuManage";
            this.buttonSideMenuManage.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuManage.TabIndex = 6;
            this.buttonSideMenuManage.Text = "Manage";
            this.buttonSideMenuManage.UseVisualStyleBackColor = true;
            this.buttonSideMenuManage.Click += new System.EventHandler(this.buttonSideMenuManage_Click);
            // 
            // panelSideSubMenuCalender
            // 
            this.panelSideSubMenuCalender.Controls.Add(this.buttonSideMenuMonthly);
            this.panelSideSubMenuCalender.Controls.Add(this.buttonSideMenuWeekly);
            this.panelSideSubMenuCalender.Controls.Add(this.buttonSideMenuDaily);
            this.panelSideSubMenuCalender.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideSubMenuCalender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSideSubMenuCalender.Location = new System.Drawing.Point(0, 353);
            this.panelSideSubMenuCalender.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideSubMenuCalender.Name = "panelSideSubMenuCalender";
            this.panelSideSubMenuCalender.Size = new System.Drawing.Size(279, 151);
            this.panelSideSubMenuCalender.TabIndex = 4;
            // 
            // buttonSideMenuMonthly
            // 
            this.buttonSideMenuMonthly.BackColor = System.Drawing.Color.White;
            this.buttonSideMenuMonthly.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuMonthly.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuMonthly.ForeColor = System.Drawing.Color.Black;
            this.buttonSideMenuMonthly.Location = new System.Drawing.Point(0, 100);
            this.buttonSideMenuMonthly.Name = "buttonSideMenuMonthly";
            this.buttonSideMenuMonthly.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuMonthly.TabIndex = 7;
            this.buttonSideMenuMonthly.Text = "Monthly";
            this.buttonSideMenuMonthly.UseVisualStyleBackColor = false;
            this.buttonSideMenuMonthly.Click += new System.EventHandler(this.buttonSideMenuMonthly_Click);
            // 
            // buttonSideMenuWeekly
            // 
            this.buttonSideMenuWeekly.BackColor = System.Drawing.Color.White;
            this.buttonSideMenuWeekly.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuWeekly.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuWeekly.ForeColor = System.Drawing.Color.Black;
            this.buttonSideMenuWeekly.Location = new System.Drawing.Point(0, 50);
            this.buttonSideMenuWeekly.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuWeekly.Name = "buttonSideMenuWeekly";
            this.buttonSideMenuWeekly.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuWeekly.TabIndex = 6;
            this.buttonSideMenuWeekly.Text = "Weekly";
            this.buttonSideMenuWeekly.UseVisualStyleBackColor = false;
            this.buttonSideMenuWeekly.Click += new System.EventHandler(this.buttonSideMenuWeekly_Click);
            // 
            // buttonSideMenuDaily
            // 
            this.buttonSideMenuDaily.BackColor = System.Drawing.Color.White;
            this.buttonSideMenuDaily.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuDaily.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuDaily.ForeColor = System.Drawing.Color.Black;
            this.buttonSideMenuDaily.Location = new System.Drawing.Point(0, 0);
            this.buttonSideMenuDaily.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuDaily.Name = "buttonSideMenuDaily";
            this.buttonSideMenuDaily.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuDaily.TabIndex = 4;
            this.buttonSideMenuDaily.Text = "Daily";
            this.buttonSideMenuDaily.UseVisualStyleBackColor = false;
            this.buttonSideMenuDaily.Click += new System.EventHandler(this.buttonSideMenuDaily_Click);
            // 
            // buttonSideMenuCalendar
            // 
            this.buttonSideMenuCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuCalendar.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuCalendar.Location = new System.Drawing.Point(0, 303);
            this.buttonSideMenuCalendar.Name = "buttonSideMenuCalendar";
            this.buttonSideMenuCalendar.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuCalendar.TabIndex = 5;
            this.buttonSideMenuCalendar.Text = "Calendar";
            this.buttonSideMenuCalendar.UseVisualStyleBackColor = true;
            this.buttonSideMenuCalendar.Click += new System.EventHandler(this.buttonSideMenuCalendar_Click);
            // 
            // panelSideSubMenuTasks
            // 
            this.panelSideSubMenuTasks.Controls.Add(this.buttonSideMenuCompletedTask);
            this.panelSideSubMenuTasks.Controls.Add(this.buttonSideMenuActiveRecuriingTask);
            this.panelSideSubMenuTasks.Controls.Add(this.buttonSideMenuHighPriorityTask);
            this.panelSideSubMenuTasks.Controls.Add(this.buttonSideMenuTodayTask);
            this.panelSideSubMenuTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideSubMenuTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSideSubMenuTasks.Location = new System.Drawing.Point(0, 100);
            this.panelSideSubMenuTasks.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideSubMenuTasks.Name = "panelSideSubMenuTasks";
            this.panelSideSubMenuTasks.Size = new System.Drawing.Size(279, 203);
            this.panelSideSubMenuTasks.TabIndex = 3;
            // 
            // buttonSideMenuCompletedTask
            // 
            this.buttonSideMenuCompletedTask.AutoSize = true;
            this.buttonSideMenuCompletedTask.BackColor = System.Drawing.Color.White;
            this.buttonSideMenuCompletedTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSideMenuCompletedTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuCompletedTask.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuCompletedTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuCompletedTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuCompletedTask.ForeColor = System.Drawing.Color.Black;
            this.buttonSideMenuCompletedTask.Location = new System.Drawing.Point(0, 150);
            this.buttonSideMenuCompletedTask.Name = "buttonSideMenuCompletedTask";
            this.buttonSideMenuCompletedTask.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuCompletedTask.TabIndex = 13;
            this.buttonSideMenuCompletedTask.Text = "Completed Task";
            this.buttonSideMenuCompletedTask.UseVisualStyleBackColor = false;
            this.buttonSideMenuCompletedTask.Click += new System.EventHandler(this.buttonSideMenuCompletedTask_Click);
            // 
            // buttonSideMenuActiveRecuriingTask
            // 
            this.buttonSideMenuActiveRecuriingTask.AutoSize = true;
            this.buttonSideMenuActiveRecuriingTask.BackColor = System.Drawing.Color.White;
            this.buttonSideMenuActiveRecuriingTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSideMenuActiveRecuriingTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuActiveRecuriingTask.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuActiveRecuriingTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuActiveRecuriingTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuActiveRecuriingTask.ForeColor = System.Drawing.Color.Black;
            this.buttonSideMenuActiveRecuriingTask.Location = new System.Drawing.Point(0, 100);
            this.buttonSideMenuActiveRecuriingTask.Name = "buttonSideMenuActiveRecuriingTask";
            this.buttonSideMenuActiveRecuriingTask.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuActiveRecuriingTask.TabIndex = 12;
            this.buttonSideMenuActiveRecuriingTask.Text = "Active Recurring Task";
            this.buttonSideMenuActiveRecuriingTask.UseVisualStyleBackColor = false;
            this.buttonSideMenuActiveRecuriingTask.Click += new System.EventHandler(this.buttonSideMenuActiveRecuriingTask_Click);
            // 
            // buttonSideMenuHighPriorityTask
            // 
            this.buttonSideMenuHighPriorityTask.AutoSize = true;
            this.buttonSideMenuHighPriorityTask.BackColor = System.Drawing.Color.White;
            this.buttonSideMenuHighPriorityTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSideMenuHighPriorityTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuHighPriorityTask.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuHighPriorityTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuHighPriorityTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuHighPriorityTask.ForeColor = System.Drawing.Color.Black;
            this.buttonSideMenuHighPriorityTask.Location = new System.Drawing.Point(0, 50);
            this.buttonSideMenuHighPriorityTask.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuHighPriorityTask.Name = "buttonSideMenuHighPriorityTask";
            this.buttonSideMenuHighPriorityTask.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuHighPriorityTask.TabIndex = 11;
            this.buttonSideMenuHighPriorityTask.Text = "High Priority Task";
            this.buttonSideMenuHighPriorityTask.UseVisualStyleBackColor = false;
            this.buttonSideMenuHighPriorityTask.Click += new System.EventHandler(this.buttonSideMenuHighPriorityTask_Click);
            // 
            // buttonSideMenuTodayTask
            // 
            this.buttonSideMenuTodayTask.AutoSize = true;
            this.buttonSideMenuTodayTask.BackColor = System.Drawing.Color.White;
            this.buttonSideMenuTodayTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSideMenuTodayTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuTodayTask.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuTodayTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuTodayTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuTodayTask.ForeColor = System.Drawing.Color.Black;
            this.buttonSideMenuTodayTask.Location = new System.Drawing.Point(0, 0);
            this.buttonSideMenuTodayTask.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuTodayTask.Name = "buttonSideMenuTodayTask";
            this.buttonSideMenuTodayTask.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuTodayTask.TabIndex = 7;
            this.buttonSideMenuTodayTask.Text = "Today\'s Task";
            this.buttonSideMenuTodayTask.UseVisualStyleBackColor = false;
            this.buttonSideMenuTodayTask.Click += new System.EventHandler(this.buttonSideMenuTodayTask_Click);
            // 
            // buttonSideMenuTasks
            // 
            this.buttonSideMenuTasks.BackColor = System.Drawing.Color.Black;
            this.buttonSideMenuTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSideMenuTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuTasks.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuTasks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSideMenuTasks.Location = new System.Drawing.Point(0, 50);
            this.buttonSideMenuTasks.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuTasks.Name = "buttonSideMenuTasks";
            this.buttonSideMenuTasks.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuTasks.TabIndex = 2;
            this.buttonSideMenuTasks.Text = "Tasks";
            this.buttonSideMenuTasks.UseVisualStyleBackColor = false;
            this.buttonSideMenuTasks.Click += new System.EventHandler(this.buttonSideMenuTasks_Click);
            // 
            // panelSideMenuOverView
            // 
            this.panelSideMenuOverView.Controls.Add(this.buttonSideMenuTodo);
            this.panelSideMenuOverView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideMenuOverView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSideMenuOverView.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenuOverView.Name = "panelSideMenuOverView";
            this.panelSideMenuOverView.Size = new System.Drawing.Size(279, 50);
            this.panelSideMenuOverView.TabIndex = 0;
            // 
            // buttonSideMenuTodo
            // 
            this.buttonSideMenuTodo.BackColor = System.Drawing.Color.Black;
            this.buttonSideMenuTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSideMenuTodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuTodo.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSideMenuTodo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSideMenuTodo.Location = new System.Drawing.Point(0, 0);
            this.buttonSideMenuTodo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuTodo.Name = "buttonSideMenuTodo";
            this.buttonSideMenuTodo.Size = new System.Drawing.Size(279, 50);
            this.buttonSideMenuTodo.TabIndex = 3;
            this.buttonSideMenuTodo.Text = "TODO";
            this.buttonSideMenuTodo.UseVisualStyleBackColor = false;
            // 
            // panelActiveForm
            // 
            this.panelActiveForm.BackColor = System.Drawing.Color.White;
            this.panelActiveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelActiveForm.Location = new System.Drawing.Point(279, 0);
            this.panelActiveForm.Name = "panelActiveForm";
            this.panelActiveForm.Size = new System.Drawing.Size(1139, 844);
            this.panelActiveForm.TabIndex = 2;
            // 
            // TodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1418, 844);
            this.Controls.Add(this.panelActiveForm);
            this.Controls.Add(this.panelSideMenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "TodoForm";
            this.Text = "Todo";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideSubMenuManage.ResumeLayout(false);
            this.panelSideSubMenuCalender.ResumeLayout(false);
            this.panelSideSubMenuTasks.ResumeLayout(false);
            this.panelSideSubMenuTasks.PerformLayout();
            this.panelSideMenuOverView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSideMenuOverView;
        private System.Windows.Forms.Button buttonSideMenuTasks;
        private System.Windows.Forms.Panel panelSideSubMenuTasks;
        private System.Windows.Forms.Panel panelSideSubMenuCalender;
        private System.Windows.Forms.Button buttonSideMenuCalendar;
        private System.Windows.Forms.Button buttonSideMenuManage;
        private System.Windows.Forms.Panel panelSideSubMenuManage;
        private System.Windows.Forms.Button buttonSideMenuCategory;
        private System.Windows.Forms.Panel panelActiveForm;
        private System.Windows.Forms.Button buttonSideMenuMonthly;
        private System.Windows.Forms.Button buttonSideMenuWeekly;
        private System.Windows.Forms.Button buttonSideMenuDaily;
        private System.Windows.Forms.Button buttonSideMenuTodo;
        private System.Windows.Forms.Button buttonSidemenuTag;
        private System.Windows.Forms.Button buttonSideMenuExport;
        private System.Windows.Forms.Button buttonSideMenuNotification;
        private System.Windows.Forms.Button buttonSideMenuCompletedTask;
        private System.Windows.Forms.Button buttonSideMenuActiveRecuriingTask;
        private System.Windows.Forms.Button buttonSideMenuHighPriorityTask;
        private System.Windows.Forms.Button buttonSideMenuTodayTask;
        private System.Windows.Forms.Button buttonSideMenuSetting;
    }
}

