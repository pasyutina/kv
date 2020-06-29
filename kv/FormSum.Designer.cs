namespace kv
{
    partial class FormSum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSum));
            this.comboBoxExtra = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.listViewSum = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelExtra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxExtra
            // 
            this.comboBoxExtra.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxExtra.FormattingEnabled = true;
            this.comboBoxExtra.Location = new System.Drawing.Point(27, 54);
            this.comboBoxExtra.Name = "comboBoxExtra";
            this.comboBoxExtra.Size = new System.Drawing.Size(158, 33);
            this.comboBoxExtra.TabIndex = 168;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(405, 235);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(202, 44);
            this.buttonEdit.TabIndex = 166;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(197, 235);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(202, 44);
            this.buttonAdd.TabIndex = 165;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(613, 235);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(202, 44);
            this.buttonDel.TabIndex = 164;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::kv.Properties.Resources.ЛОГО_Кванториум_Цветной;
            this.pictureBox1.Location = new System.Drawing.Point(18, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 163;
            this.pictureBox1.TabStop = false;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelBalance.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.Location = new System.Drawing.Point(24, 85);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(136, 25);
            this.labelBalance.TabIndex = 162;
            this.labelBalance.Text = "Текущий баланс";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBalance.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxBalance.Location = new System.Drawing.Point(27, 113);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(160, 33);
            this.textBoxBalance.TabIndex = 161;
            // 
            // listViewSum
            // 
            this.listViewSum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listViewSum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Extra,
            this.Balance});
            this.listViewSum.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSum.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewSum.FullRowSelect = true;
            this.listViewSum.GridLines = true;
            this.listViewSum.HideSelection = false;
            this.listViewSum.Location = new System.Drawing.Point(197, 24);
            this.listViewSum.MultiSelect = false;
            this.listViewSum.Name = "listViewSum";
            this.listViewSum.Size = new System.Drawing.Size(618, 205);
            this.listViewSum.TabIndex = 160;
            this.listViewSum.UseCompatibleStateImageBehavior = false;
            this.listViewSum.View = System.Windows.Forms.View.Details;
            this.listViewSum.SelectedIndexChanged += new System.EventHandler(this.listViewSum_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 29;
            // 
            // Extra
            // 
            this.Extra.Text = "Товар с выдачи";
            this.Extra.Width = 243;
            // 
            // Balance
            // 
            this.Balance.Text = "Текущий баланс";
            this.Balance.Width = 138;
            // 
            // labelExtra
            // 
            this.labelExtra.AutoSize = true;
            this.labelExtra.BackColor = System.Drawing.Color.Transparent;
            this.labelExtra.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExtra.Location = new System.Drawing.Point(22, 26);
            this.labelExtra.Name = "labelExtra";
            this.labelExtra.Size = new System.Drawing.Size(143, 25);
            this.labelExtra.TabIndex = 158;
            this.labelExtra.Text = "Выданный товар";
            // 
            // FormSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kv.Properties.Resources.BG_for_IS;
            this.ClientSize = new System.Drawing.Size(835, 294);
            this.Controls.Add(this.comboBoxExtra);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.listViewSum);
            this.Controls.Add(this.labelExtra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сводная ведомость о текущем балансе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxExtra;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.ListView listViewSum;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Extra;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.Label labelExtra;
    }
}