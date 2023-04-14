
namespace CSharp_methods_development_lab_2
{
    partial class AuthorizationForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.KeyImage = new System.Windows.Forms.PictureBox();
            this.MainNameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.CommandLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.InterButton = new System.Windows.Forms.Button();
            this.CancleButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KeyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyImage
            // 
            this.KeyImage.Image = global::CSharp_methods_development_lab_2.Properties.Resources._2829839;
            this.KeyImage.Location = new System.Drawing.Point(12, 12);
            this.KeyImage.Name = "KeyImage";
            this.KeyImage.Size = new System.Drawing.Size(54, 55);
            this.KeyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KeyImage.TabIndex = 0;
            this.KeyImage.TabStop = false;
            // 
            // MainNameLabel
            // 
            this.MainNameLabel.BackColor = System.Drawing.Color.NavajoWhite;
            this.MainNameLabel.Location = new System.Drawing.Point(72, 12);
            this.MainNameLabel.Name = "MainNameLabel";
            this.MainNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainNameLabel.Size = new System.Drawing.Size(243, 16);
            this.MainNameLabel.TabIndex = 1;
            this.MainNameLabel.Text = "АИС Отдел кадров";
            // 
            // VersionLabel
            // 
            this.VersionLabel.BackColor = System.Drawing.Color.Orange;
            this.VersionLabel.Location = new System.Drawing.Point(72, 30);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VersionLabel.Size = new System.Drawing.Size(243, 16);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Версия 1.0.0.0";
            // 
            // CommandLabel
            // 
            this.CommandLabel.BackColor = System.Drawing.Color.White;
            this.CommandLabel.Location = new System.Drawing.Point(72, 49);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CommandLabel.Size = new System.Drawing.Size(243, 16);
            this.CommandLabel.TabIndex = 3;
            this.CommandLabel.Text = "Введите имя пользователя и пароль";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 95);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(103, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Имя пользователя";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(9, 137);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль";
            // 
            // InterButton
            // 
            this.InterButton.Location = new System.Drawing.Point(12, 199);
            this.InterButton.Name = "InterButton";
            this.InterButton.Size = new System.Drawing.Size(75, 23);
            this.InterButton.TabIndex = 6;
            this.InterButton.Text = "Вход";
            this.InterButton.UseVisualStyleBackColor = true;
            this.InterButton.Click += new System.EventHandler(this.InterFunction);
            // 
            // CancleButton
            // 
            this.CancleButton.Location = new System.Drawing.Point(245, 199);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(75, 23);
            this.CancleButton.TabIndex = 7;
            this.CancleButton.Text = "Отмена";
            this.CancleButton.UseVisualStyleBackColor = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleFunction);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(118, 92);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.userTextBox.Size = new System.Drawing.Size(194, 20);
            this.userTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(118, 134);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 20);
            this.passwordTextBox.TabIndex = 9;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 234);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.CancleButton);
            this.Controls.Add(this.InterButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CommandLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.MainNameLabel);
            this.Controls.Add(this.KeyImage);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.KeyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox KeyImage;
        private System.Windows.Forms.Label MainNameLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label CommandLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button InterButton;
        private System.Windows.Forms.Button CancleButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}

