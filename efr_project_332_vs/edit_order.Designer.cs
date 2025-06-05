namespace efr_project_332
{
    partial class edit_order
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
            this.id_order_lbl = new System.Windows.Forms.Label();
            this.item_lbl = new System.Windows.Forms.Label();
            this.type_lbl = new System.Windows.Forms.Label();
            this.description_lbl = new System.Windows.Forms.Label();
            this.item_txt = new System.Windows.Forms.TextBox();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.id_order_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // id_order_lbl
            // 
            this.id_order_lbl.AutoSize = true;
            this.id_order_lbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_order_lbl.Location = new System.Drawing.Point(12, 19);
            this.id_order_lbl.Name = "id_order_lbl";
            this.id_order_lbl.Size = new System.Drawing.Size(139, 23);
            this.id_order_lbl.TabIndex = 0;
            this.id_order_lbl.Text = "Номер заявки";
            // 
            // item_lbl
            // 
            this.item_lbl.AutoSize = true;
            this.item_lbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_lbl.Location = new System.Drawing.Point(12, 71);
            this.item_lbl.Name = "item_lbl";
            this.item_lbl.Size = new System.Drawing.Size(142, 23);
            this.item_lbl.TabIndex = 2;
            this.item_lbl.Text = "Оборудование";
            // 
            // type_lbl
            // 
            this.type_lbl.AutoSize = true;
            this.type_lbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_lbl.Location = new System.Drawing.Point(12, 128);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(189, 23);
            this.type_lbl.TabIndex = 3;
            this.type_lbl.Text = "Тип неисправности";
            // 
            // description_lbl
            // 
            this.description_lbl.AutoSize = true;
            this.description_lbl.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_lbl.Location = new System.Drawing.Point(12, 184);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(102, 23);
            this.description_lbl.TabIndex = 4;
            this.description_lbl.Text = "Описание";
            // 
            // item_txt
            // 
            this.item_txt.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_txt.Location = new System.Drawing.Point(227, 68);
            this.item_txt.Name = "item_txt";
            this.item_txt.Size = new System.Drawing.Size(232, 30);
            this.item_txt.TabIndex = 7;
            // 
            // type_txt
            // 
            this.type_txt.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_txt.Location = new System.Drawing.Point(227, 125);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(232, 30);
            this.type_txt.TabIndex = 8;
            // 
            // description_txt
            // 
            this.description_txt.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_txt.Location = new System.Drawing.Point(120, 184);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(339, 64);
            this.description_txt.TabIndex = 9;
            // 
            // ok_btn
            // 
            this.ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_btn.Location = new System.Drawing.Point(181, 280);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(114, 39);
            this.ok_btn.TabIndex = 11;
            this.ok_btn.Text = "Сохранить";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_btn.Location = new System.Drawing.Point(390, 315);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(90, 34);
            this.cancel_btn.TabIndex = 12;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // id_order_cb
            // 
            this.id_order_cb.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_order_cb.FormattingEnabled = true;
            this.id_order_cb.Location = new System.Drawing.Point(227, 16);
            this.id_order_cb.Name = "id_order_cb";
            this.id_order_cb.Size = new System.Drawing.Size(121, 31);
            this.id_order_cb.TabIndex = 13;
            this.id_order_cb.SelectedIndexChanged += new System.EventHandler(this.id_order_cb_SelectedIndexChanged);
            // 
            // edit_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(481, 350);
            this.ControlBox = false;
            this.Controls.Add(this.id_order_cb);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.type_txt);
            this.Controls.Add(this.item_txt);
            this.Controls.Add(this.description_lbl);
            this.Controls.Add(this.type_lbl);
            this.Controls.Add(this.item_lbl);
            this.Controls.Add(this.id_order_lbl);
            this.MaximumSize = new System.Drawing.Size(497, 389);
            this.MinimumSize = new System.Drawing.Size(497, 389);
            this.Name = "edit_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заявки";
            this.Load += new System.EventHandler(this.edit_order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_order_lbl;
        private System.Windows.Forms.Label item_lbl;
        private System.Windows.Forms.Label type_lbl;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.TextBox item_txt;
        private System.Windows.Forms.TextBox type_txt;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.ComboBox id_order_cb;
    }
}