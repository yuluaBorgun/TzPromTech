
namespace Information
{
    partial class EmployeeControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeImage = new System.Windows.Forms.PictureBox();
            this.Fio = new System.Windows.Forms.Label();
            this.BirthDay = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Pozition = new System.Windows.Forms.Label();
            this.AddAccount = new System.Windows.Forms.Button();
            this.SendMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeImage
            // 
            this.EmployeeImage.Location = new System.Drawing.Point(4, 4);
            this.EmployeeImage.Name = "EmployeeImage";
            this.EmployeeImage.Size = new System.Drawing.Size(70, 70);
            this.EmployeeImage.TabIndex = 0;
            this.EmployeeImage.TabStop = false;
            // 
            // Fio
            // 
            this.Fio.AutoSize = true;
            this.Fio.Location = new System.Drawing.Point(84, 4);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(168, 17);
            this.Fio.TabIndex = 1;
            this.Fio.Text = "Фамилия Имя Отчество";
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.Location = new System.Drawing.Point(84, 21);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(191, 17);
            this.BirthDay.TabIndex = 2;
            this.BirthDay.Text = "День рождения: 23.08.2002";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(84, 38);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(188, 17);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "Мобильный: +78887776655";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(84, 55);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(304, 17);
            this.Department.TabIndex = 4;
            this.Department.Text = "Отдел: разработка промышленных решений";
            // 
            // Pozition
            // 
            this.Pozition.AutoSize = true;
            this.Pozition.Location = new System.Drawing.Point(87, 76);
            this.Pozition.Name = "Pozition";
            this.Pozition.Size = new System.Drawing.Size(182, 17);
            this.Pozition.TabIndex = 5;
            this.Pozition.Text = "Долженость: разработчик";
            // 
            // AddAccount
            // 
            this.AddAccount.Location = new System.Drawing.Point(876, 76);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(169, 23);
            this.AddAccount.TabIndex = 6;
            this.AddAccount.Text = "Подключить Telegram";
            this.AddAccount.UseVisualStyleBackColor = true;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(876, 50);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(169, 23);
            this.SendMessage.TabIndex = 7;
            this.SendMessage.Text = "Отправить сообщение";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.AddAccount);
            this.Controls.Add(this.Pozition);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.EmployeeImage);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(1048, 109);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EmployeeImage;
        private System.Windows.Forms.Label Fio;
        private System.Windows.Forms.Label BirthDay;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label Pozition;
        private System.Windows.Forms.Button AddAccount;
        private System.Windows.Forms.Button SendMessage;
    }
}
