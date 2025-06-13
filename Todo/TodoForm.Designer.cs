namespace Todo
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
            this.buttonSideMenuRecurrenceRule = new System.Windows.Forms.Button();
            this.buttonSideMenuCategory = new System.Windows.Forms.Button();
            this.buttonSideMenuManage = new System.Windows.Forms.Button();
            this.panelSideSubMenuCalender = new System.Windows.Forms.Panel();
            this.buttonSideMenuMonthly = new System.Windows.Forms.Button();
            this.buttonSideMenuWeekly = new System.Windows.Forms.Button();
            this.buttonSideMenuDaily = new System.Windows.Forms.Button();
            this.buttonSideMenuCalendar = new System.Windows.Forms.Button();
            this.panelSideSubMenuTasks = new System.Windows.Forms.Panel();
            this.buttonSideMenuActiveRecuriingTask = new System.Windows.Forms.Button();
            this.buttonSideMenuHighPriorityTask = new System.Windows.Forms.Button();
            this.buttonSideMenuCompletedTask = new System.Windows.Forms.Button();
            this.buttonSideMenuTodayTask = new System.Windows.Forms.Button();
            this.buttonSideMenuTasks = new System.Windows.Forms.Button();
            this.panelSideMenuLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelActiveForm = new System.Windows.Forms.Panel();
            this.panelNotification = new System.Windows.Forms.Panel();
            this.labelNotification = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelSideSubMenuManage.SuspendLayout();
            this.panelSideSubMenuCalender.SuspendLayout();
            this.panelSideSubMenuTasks.SuspendLayout();
            this.panelSideMenuLogo.SuspendLayout();
            this.panelNotification.SuspendLayout();
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
            this.panelSideMenu.Controls.Add(this.panelSideMenuLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(282, 725);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelSideSubMenuManage
            // 
            this.panelSideSubMenuManage.Controls.Add(this.buttonSideMenuSetting);
            this.panelSideSubMenuManage.Controls.Add(this.buttonSideMenuRecurrenceRule);
            this.panelSideSubMenuManage.Controls.Add(this.buttonSideMenuCategory);
            this.panelSideSubMenuManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideSubMenuManage.Location = new System.Drawing.Point(0, 554);
            this.panelSideSubMenuManage.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideSubMenuManage.Name = "panelSideSubMenuManage";
            this.panelSideSubMenuManage.Size = new System.Drawing.Size(282, 148);
            this.panelSideSubMenuManage.TabIndex = 7;
            // 
            // buttonSideMenuSetting
            // 
            this.buttonSideMenuSetting.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSideMenuSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuSetting.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuSetting.Location = new System.Drawing.Point(0, 100);
            this.buttonSideMenuSetting.Name = "buttonSideMenuSetting";
            this.buttonSideMenuSetting.Size = new System.Drawing.Size(282, 50);
            this.buttonSideMenuSetting.TabIndex = 13;
            this.buttonSideMenuSetting.Text = "Setting";
            this.buttonSideMenuSetting.UseVisualStyleBackColor = false;
            // 
            // buttonSideMenuRecurrenceRule
            // 
            this.buttonSideMenuRecurrenceRule.AutoSize = true;
            this.buttonSideMenuRecurrenceRule.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSideMenuRecurrenceRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuRecurrenceRule.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuRecurrenceRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuRecurrenceRule.Location = new System.Drawing.Point(0, 50);
            this.buttonSideMenuRecurrenceRule.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuRecurrenceRule.Name = "buttonSideMenuRecurrenceRule";
            this.buttonSideMenuRecurrenceRule.Size = new System.Drawing.Size(282, 50);
            this.buttonSideMenuRecurrenceRule.TabIndex = 0;
            this.buttonSideMenuRecurrenceRule.Text = "Recurrence Rule";
            this.buttonSideMenuRecurrenceRule.UseVisualStyleBackColor = false;
            this.buttonSideMenuRecurrenceRule.Click += new System.EventHandler(this.buttonSideMenuRecurrenceRule_Click);
            // 
            // buttonSideMenuCategory
            // 
            this.buttonSideMenuCategory.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSideMenuCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuCategory.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuCategory.Location = new System.Drawing.Point(0, 0);
            this.buttonSideMenuCategory.Name = "buttonSideMenuCategory";
            this.buttonSideMenuCategory.Size = new System.Drawing.Size(282, 50);
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
            this.buttonSideMenuManage.Location = new System.Drawing.Point(0, 504);
            this.buttonSideMenuManage.Name = "buttonSideMenuManage";
            this.buttonSideMenuManage.Size = new System.Drawing.Size(282, 50);
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
            this.panelSideSubMenuCalender.Location = new System.Drawing.Point(0, 353);
            this.panelSideSubMenuCalender.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideSubMenuCalender.Name = "panelSideSubMenuCalender";
            this.panelSideSubMenuCalender.Size = new System.Drawing.Size(282, 151);
            this.panelSideSubMenuCalender.TabIndex = 4;
            // 
            // buttonSideMenuMonthly
            // 
            this.buttonSideMenuMonthly.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSideMenuMonthly.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuMonthly.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuMonthly.Location = new System.Drawing.Point(0, 100);
            this.buttonSideMenuMonthly.Name = "buttonSideMenuMonthly";
            this.buttonSideMenuMonthly.Size = new System.Drawing.Size(282, 50);
            this.buttonSideMenuMonthly.TabIndex = 7;
            this.buttonSideMenuMonthly.Text = "Monthly";
            this.buttonSideMenuMonthly.UseVisualStyleBackColor = false;
            // 
            // buttonSideMenuWeekly
            // 
            this.buttonSideMenuWeekly.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSideMenuWeekly.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuWeekly.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuWeekly.Location = new System.Drawing.Point(0, 50);
            this.buttonSideMenuWeekly.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuWeekly.Name = "buttonSideMenuWeekly";
            this.buttonSideMenuWeekly.Size = new System.Drawing.Size(282, 50);
            this.buttonSideMenuWeekly.TabIndex = 6;
            this.buttonSideMenuWeekly.Text = "Weekly";
            this.buttonSideMenuWeekly.UseVisualStyleBackColor = false;
            // 
            // buttonSideMenuDaily
            // 
            this.buttonSideMenuDaily.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSideMenuDaily.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuDaily.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuDaily.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSideMenuDaily.Location = new System.Drawing.Point(0, 0);
            this.buttonSideMenuDaily.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuDaily.Name = "buttonSideMenuDaily";
            this.buttonSideMenuDaily.Size = new System.Drawing.Size(282, 50);
            this.buttonSideMenuDaily.TabIndex = 4;
            this.buttonSideMenuDaily.Text = "Daily";
            this.buttonSideMenuDaily.UseVisualStyleBackColor = false;
            // 
            // buttonSideMenuCalendar
            // 
            this.buttonSideMenuCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuCalendar.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuCalendar.Location = new System.Drawing.Point(0, 303);
            this.buttonSideMenuCalendar.Name = "buttonSideMenuCalendar";
            this.buttonSideMenuCalendar.Size = new System.Drawing.Size(282, 50);
            this.buttonSideMenuCalendar.TabIndex = 5;
            this.buttonSideMenuCalendar.Text = "Calendar";
            this.buttonSideMenuCalendar.UseVisualStyleBackColor = true;
            this.buttonSideMenuCalendar.Click += new System.EventHandler(this.buttonSideMenuCalendar_Click);
            // 
            // panelSideSubMenuTasks
            // 
            this.panelSideSubMenuTasks.Controls.Add(this.buttonSideMenuActiveRecuriingTask);
            this.panelSideSubMenuTasks.Controls.Add(this.buttonSideMenuHighPriorityTask);
            this.panelSideSubMenuTasks.Controls.Add(this.buttonSideMenuCompletedTask);
            this.panelSideSubMenuTasks.Controls.Add(this.buttonSideMenuTodayTask);
            this.panelSideSubMenuTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideSubMenuTasks.Location = new System.Drawing.Point(0, 100);
            this.panelSideSubMenuTasks.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideSubMenuTasks.Name = "panelSideSubMenuTasks";
            this.panelSideSubMenuTasks.Size = new System.Drawing.Size(282, 203);
            this.panelSideSubMenuTasks.TabIndex = 3;
            // 
            // buttonSideMenuActiveRecuriingTask
            // 
            this.buttonSideMenuActiveRecuriingTask.AutoSize = true;
            this.buttonSideMenuActiveRecuriingTask.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSideMenuActiveRecuriingTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSideMenuActiveRecuriingTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuActiveRecuriingTask.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuActiveRecuriingTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuActiveRecuriingTask.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSideMenuActiveRecuriingTask.Location = new System.Drawing.Point(0, 150);
            this.buttonSideMenuActiveRecuriingTask.Name = "buttonSideMenuActiveRecuriingTask";
            this.buttonSideMenuActiveRecuriingTask.Size = new System.Drawing.Size(282, 50);
            this.buttonSideMenuActiveRecuriingTask.TabIndex = 12;
            this.buttonSideMenuActiveRecuriingTask.Text = "Active Recurring Task";
            this.buttonSideMenuActiveRecuriingTask.UseVisualStyleBackColor = false;
            // 
            // buttonSideMenuHighPriorityTask
            // 
            this.buttonSideMenuHighPriorityTask.AutoSize = true;
            this.buttonSideMenuHighPriorityTask.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSideMenuHighPriorityTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSideMenuHighPriorityTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuHighPriorityTask.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuHighPriorityTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuHighPriorityTask.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSideMenuHighPriorityTask.Location = new System.Drawing.Point(0, 100);
            this.buttonSideMenuHighPriorityTask.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuHighPriorityTask.Name = "buttonSideMenuHighPriorityTask";
            this.buttonSideMenuHighPriorityTask.Size = new System.Drawing.Size(282, 50);
            this.buttonSideMenuHighPriorityTask.TabIndex = 11;
            this.buttonSideMenuHighPriorityTask.Text = "High Priority Task";
            this.buttonSideMenuHighPriorityTask.UseVisualStyleBackColor = false;
            // 
            // buttonSideMenuCompletedTask
            // 
            this.buttonSideMenuCompletedTask.AutoSize = true;
            this.buttonSideMenuCompletedTask.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSideMenuCompletedTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSideMenuCompletedTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuCompletedTask.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuCompletedTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuCompletedTask.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSideMenuCompletedTask.Location = new System.Drawing.Point(0, 50);
            this.buttonSideMenuCompletedTask.Name = "buttonSideMenuCompletedTask";
            this.buttonSideMenuCompletedTask.Size = new System.Drawing.Size(282, 50);
            this.buttonSideMenuCompletedTask.TabIndex = 10;
            this.buttonSideMenuCompletedTask.Text = "Completed Task";
            this.buttonSideMenuCompletedTask.UseVisualStyleBackColor = false;
            // 
            // buttonSideMenuTodayTask
            // 
            this.buttonSideMenuTodayTask.AutoSize = true;
            this.buttonSideMenuTodayTask.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSideMenuTodayTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSideMenuTodayTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuTodayTask.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuTodayTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuTodayTask.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSideMenuTodayTask.Location = new System.Drawing.Point(0, 0);
            this.buttonSideMenuTodayTask.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuTodayTask.Name = "buttonSideMenuTodayTask";
            this.buttonSideMenuTodayTask.Size = new System.Drawing.Size(282, 50);
            this.buttonSideMenuTodayTask.TabIndex = 7;
            this.buttonSideMenuTodayTask.Text = "Today\'s Task";
            this.buttonSideMenuTodayTask.UseVisualStyleBackColor = false;
            // 
            // buttonSideMenuTasks
            // 
            this.buttonSideMenuTasks.BackColor = System.Drawing.Color.Black;
            this.buttonSideMenuTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSideMenuTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSideMenuTasks.FlatAppearance.BorderSize = 0;
            this.buttonSideMenuTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSideMenuTasks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSideMenuTasks.Location = new System.Drawing.Point(0, 50);
            this.buttonSideMenuTasks.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSideMenuTasks.Name = "buttonSideMenuTasks";
            this.buttonSideMenuTasks.Size = new System.Drawing.Size(282, 50);
            this.buttonSideMenuTasks.TabIndex = 2;
            this.buttonSideMenuTasks.Text = "Tasks";
            this.buttonSideMenuTasks.UseVisualStyleBackColor = false;
            this.buttonSideMenuTasks.Click += new System.EventHandler(this.buttonSideMenuTasks_Click);
            // 
            // panelSideMenuLogo
            // 
            this.panelSideMenuLogo.Controls.Add(this.label1);
            this.panelSideMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenuLogo.Name = "panelSideMenuLogo";
            this.panelSideMenuLogo.Size = new System.Drawing.Size(282, 50);
            this.panelSideMenuLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "TODO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActiveForm
            // 
            this.panelActiveForm.BackColor = System.Drawing.Color.Gray;
            this.panelActiveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveForm.Location = new System.Drawing.Point(282, 0);
            this.panelActiveForm.Name = "panelActiveForm";
            this.panelActiveForm.Size = new System.Drawing.Size(1296, 725);
            this.panelActiveForm.TabIndex = 2;
            // 
            // panelNotification
            // 
            this.panelNotification.BackColor = System.Drawing.Color.Gray;
            this.panelNotification.Controls.Add(this.labelNotification);
            this.panelNotification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNotification.Location = new System.Drawing.Point(282, 654);
            this.panelNotification.Name = "panelNotification";
            this.panelNotification.Size = new System.Drawing.Size(1296, 71);
            this.panelNotification.TabIndex = 3;
            this.panelNotification.Visible = false;
            // 
            // labelNotification
            // 
            this.labelNotification.AutoSize = true;
            this.labelNotification.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelNotification.ForeColor = System.Drawing.Color.White;
            this.labelNotification.Location = new System.Drawing.Point(20, 20);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(0, 24);
            this.labelNotification.TabIndex = 0;
            // 
            // TodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1578, 725);
            this.Controls.Add(this.panelNotification);
            this.Controls.Add(this.panelActiveForm);
            this.Controls.Add(this.panelSideMenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "TodoForm";
            this.Text = "Todo";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideSubMenuManage.ResumeLayout(false);
            this.panelSideSubMenuManage.PerformLayout();
            this.panelSideSubMenuCalender.ResumeLayout(false);
            this.panelSideSubMenuTasks.ResumeLayout(false);
            this.panelSideSubMenuTasks.PerformLayout();
            this.panelSideMenuLogo.ResumeLayout(false);
            this.panelSideMenuLogo.PerformLayout();
            this.panelNotification.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSideMenuLogo;
        private System.Windows.Forms.Button buttonSideMenuTasks;
        private System.Windows.Forms.Panel panelSideSubMenuTasks;
        private System.Windows.Forms.Panel panelSideSubMenuCalender;
        private System.Windows.Forms.Button buttonSideMenuCalendar;
        private System.Windows.Forms.Button buttonSideMenuManage;
        private System.Windows.Forms.Panel panelSideSubMenuManage;
        private System.Windows.Forms.Button buttonSideMenuCategory;
        private System.Windows.Forms.Button buttonSideMenuRecurrenceRule;
        private System.Windows.Forms.Panel panelActiveForm;
        private System.Windows.Forms.Button buttonSideMenuSetting;
        private System.Windows.Forms.Button buttonSideMenuMonthly;
        private System.Windows.Forms.Button buttonSideMenuWeekly;
        private System.Windows.Forms.Button buttonSideMenuDaily;
        private System.Windows.Forms.Button buttonSideMenuActiveRecuriingTask;
        private System.Windows.Forms.Button buttonSideMenuHighPriorityTask;
        private System.Windows.Forms.Button buttonSideMenuCompletedTask;
        private System.Windows.Forms.Button buttonSideMenuTodayTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNotification;
        private System.Windows.Forms.Label labelNotification;
    }
}

