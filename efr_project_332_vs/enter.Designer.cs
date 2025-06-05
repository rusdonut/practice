namespace efr_project_332
{
    partial class enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enter));
            this.enter_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.regist_lbl = new System.Windows.Forms.Label();
            this.enter_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enter_lbl
            // 
            this.enter_lbl.AutoSize = true;
            this.enter_lbl.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_lbl.Location = new System.Drawing.Point(110, 28);
            this.enter_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enter_lbl.Name = "enter_lbl";
            this.enter_lbl.Size = new System.Drawing.Size(100, 33);
            this.enter_lbl.TabIndex = 0;
            this.enter_lbl.Text = "ВХОД";
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_lbl.Location = new System.Drawing.Point(21, 102);
            this.login_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(70, 23);
            this.login_lbl.TabIndex = 1;
            this.login_lbl.Text = "логин";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_lbl.Location = new System.Drawing.Point(21, 154);
            this.password_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(82, 23);
            this.password_lbl.TabIndex = 2;
            this.password_lbl.Text = "пароль";
            // 
            // login_txt
            // 
            this.login_txt.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_txt.Location = new System.Drawing.Point(104, 99);
            this.login_txt.Margin = new System.Windows.Forms.Padding(2);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(186, 30);
            this.login_txt.TabIndex = 3;
            this.login_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_txt_KeyPress);
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_txt.Location = new System.Drawing.Point(105, 152);
            this.password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(184, 30);
            this.password_txt.TabIndex = 4;
            this.password_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_txt_KeyPress);
            // 
            // regist_lbl
            // 
            this.regist_lbl.AutoSize = true;
            this.regist_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regist_lbl.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regist_lbl.ForeColor = System.Drawing.Color.MediumBlue;
            this.regist_lbl.Location = new System.Drawing.Point(111, 304);
            this.regist_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regist_lbl.Name = "regist_lbl";
            this.regist_lbl.Size = new System.Drawing.Size(100, 18);
            this.regist_lbl.TabIndex = 5;
            this.regist_lbl.Text = "Регистрация";
            this.regist_lbl.Click += new System.EventHandler(this.regist_lbl_Click);
            // 
            // enter_btn
            // 
            this.enter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter_btn.Enabled = false;
            this.enter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter_btn.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_btn.Location = new System.Drawing.Point(116, 222);
            this.enter_btn.Margin = new System.Windows.Forms.Padding(2);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(88, 30);
            this.enter_btn.TabIndex = 6;
            this.enter_btn.Text = "Войти";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(321, 340);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.regist_lbl);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.enter_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(337, 379);
            this.MinimumSize = new System.Drawing.Size(337, 379);
            this.Name = "enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.enter_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enter_lbl;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label regist_lbl;
        private System.Windows.Forms.Button enter_btn;
    }
}

