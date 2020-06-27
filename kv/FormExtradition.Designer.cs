namespace kv
{
    partial class FormExtradition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtradition));
            this.dateTimePickerEx = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAgent = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelQuant = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.listViewExtra = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Agent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelAgent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerEx
            // 
            this.dateTimePickerEx.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEx.Location = new System.Drawing.Point(86, 170);
            this.dateTimePickerEx.Name = "dateTimePickerEx";
            this.dateTimePickerEx.Size = new System.Drawing.Size(158, 27);
            this.dateTimePickerEx.TabIndex = 158;
            // 
            // comboBoxAgent
            // 
            this.comboBoxAgent.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAgent.FormattingEnabled = true;
            this.comboBoxAgent.Location = new System.Drawing.Point(86, 111);
            this.comboBoxAgent.Name = "comboBoxAgent";
            this.comboBoxAgent.Size = new System.Drawing.Size(158, 27);
            this.comboBoxAgent.TabIndex = 157;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(86, 50);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(158, 27);
            this.comboBoxMaterial.TabIndex = 156;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(457, 336);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(202, 44);
            this.buttonEdit.TabIndex = 155;
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
            this.buttonAdd.Location = new System.Drawing.Point(249, 336);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(202, 44);
            this.buttonAdd.TabIndex = 154;
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
            this.buttonDel.Location = new System.Drawing.Point(665, 336);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(202, 44);
            this.buttonDel.TabIndex = 153;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::kv.Properties.Resources.ЛОГО_Кванториум_Цветной;
            this.pictureBox1.Location = new System.Drawing.Point(82, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 152;
            this.pictureBox1.TabStop = false;
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.BackColor = System.Drawing.Color.Transparent;
            this.labelQuant.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuant.Location = new System.Drawing.Point(81, 200);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(104, 25);
            this.labelQuant.TabIndex = 151;
            this.labelQuant.Text = "Количество";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(83, 141);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(109, 25);
            this.labelDate.TabIndex = 150;
            this.labelDate.Text = "Дата выдачи";
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuant.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxQuant.Location = new System.Drawing.Point(84, 228);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(160, 27);
            this.textBoxQuant.TabIndex = 149;
            // 
            // listViewExtra
            // 
            this.listViewExtra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listViewExtra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Material,
            this.Agent,
            this.Date,
            this.Quantity});
            this.listViewExtra.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewExtra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewExtra.FullRowSelect = true;
            this.listViewExtra.GridLines = true;
            this.listViewExtra.HideSelection = false;
            this.listViewExtra.Location = new System.Drawing.Point(254, 21);
            this.listViewExtra.MultiSelect = false;
            this.listViewExtra.Name = "listViewExtra";
            this.listViewExtra.Size = new System.Drawing.Size(618, 309);
            this.listViewExtra.TabIndex = 148;
            this.listViewExtra.UseCompatibleStateImageBehavior = false;
            this.listViewExtra.View = System.Windows.Forms.View.Details;
            this.listViewExtra.SelectedIndexChanged += new System.EventHandler(this.listViewExtra_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 29;
            // 
            // Material
            // 
            this.Material.Text = "Товар";
            this.Material.Width = 128;
            // 
            // Agent
            // 
            this.Agent.Text = "Сотрудник";
            this.Agent.Width = 115;
            // 
            // Date
            // 
            this.Date.Text = "Дата выдачи";
            this.Date.Width = 174;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Количество";
            this.Quantity.Width = 166;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.BackColor = System.Drawing.Color.Transparent;
            this.labelMaterial.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.Location = new System.Drawing.Point(83, 21);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(127, 25);
            this.labelMaterial.TabIndex = 147;
            this.labelMaterial.Text = "Выдача товара";
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.BackColor = System.Drawing.Color.Transparent;
            this.labelAgent.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAgent.Location = new System.Drawing.Point(81, 83);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(94, 25);
            this.labelAgent.TabIndex = 146;
            this.labelAgent.Text = "Сотрудник";
            // 
            // FormExtradition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kv.Properties.Resources.BG_for_IS;
            this.ClientSize = new System.Drawing.Size(953, 401);
            this.Controls.Add(this.dateTimePickerEx);
            this.Controls.Add(this.comboBoxAgent);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelQuant);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxQuant);
            this.Controls.Add(this.listViewExtra);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelAgent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExtradition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдача материалов и оборудования";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerEx;
        private System.Windows.Forms.ComboBox comboBoxAgent;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxQuant;
        private System.Windows.Forms.ListView listViewExtra;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Material;
        private System.Windows.Forms.ColumnHeader Agent;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelAgent;
    }
}