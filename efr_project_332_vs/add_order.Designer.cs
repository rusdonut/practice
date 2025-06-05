namespace efr_project_332
{
    partial class add_order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.item_txt = new System.Windows.Forms.TextBox();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.create_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оборудование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип неисправности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание проблемы";
            // 
            // item_txt
            // 
            this.item_txt.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_txt.Location = new System.Drawing.Point(241, 20);
            this.item_txt.Name = "item_txt";
            this.item_txt.Size = new System.Drawing.Size(258, 30);
            this.item_txt.TabIndex = 3;
            // 
            // type_txt
            // 
            this.type_txt.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_txt.Location = new System.Drawing.Point(241, 79);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(258, 30);
            this.type_txt.TabIndex = 4;
            // 
            // description_txt
            // 
            this.description_txt.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_txt.Location = new System.Drawing.Point(16, 160);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(483, 112);
            this.description_txt.TabIndex = 5;
            // 
            // create_btn
            // 
            this.create_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.create_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.Location = new System.Drawing.Point(202, 295);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(93, 34);
            this.create_btn.TabIndex = 6;
            this.create_btn.Text = "Создать";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_btn.Location = new System.Drawing.Point(420, 318);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(93, 34);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // add_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(516, 354);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.type_txt);
            this.Controls.Add(this.item_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(532, 350);
            this.Name = "add_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox item_txt;
        private System.Windows.Forms.TextBox type_txt;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}