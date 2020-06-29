namespace kv
{
    partial class FormProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProvider));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.listViewProvider = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SurName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSurName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.buttonEdit.TabIndex = 142;
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
            this.buttonAdd.TabIndex = 141;
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
            this.buttonDel.TabIndex = 140;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::kv.Properties.Resources.ЛОГО_Кванториум_Цветной;
            this.pictureBox1.Location = new System.Drawing.Point(82, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.BackColor = System.Drawing.Color.Transparent;
            this.labelCost.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(81, 211);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(151, 25);
            this.labelCost.TabIndex = 138;
            this.labelCost.Text = "Стоимость услуги";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.labelMiddleName.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(83, 147);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(85, 25);
            this.labelMiddleName.TabIndex = 137;
            this.labelMiddleName.Text = "Отчество";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCost.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxCost.Location = new System.Drawing.Point(84, 239);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(160, 33);
            this.textBoxCost.TabIndex = 136;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMiddleName.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMiddleName.Location = new System.Drawing.Point(84, 175);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(160, 33);
            this.textBoxMiddleName.TabIndex = 135;
            // 
            // listViewProvider
            // 
            this.listViewProvider.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listViewProvider.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.SurName,
            this.FirstName,
            this.MiddleName,
            this.Cost});
            this.listViewProvider.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewProvider.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewProvider.FullRowSelect = true;
            this.listViewProvider.GridLines = true;
            this.listViewProvider.HideSelection = false;
            this.listViewProvider.Location = new System.Drawing.Point(254, 21);
            this.listViewProvider.MultiSelect = false;
            this.listViewProvider.Name = "listViewProvider";
            this.listViewProvider.Size = new System.Drawing.Size(618, 309);
            this.listViewProvider.TabIndex = 134;
            this.listViewProvider.UseCompatibleStateImageBehavior = false;
            this.listViewProvider.View = System.Windows.Forms.View.Details;
            this.listViewProvider.SelectedIndexChanged += new System.EventHandler(this.listViewProvider_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 29;
            // 
            // SurName
            // 
            this.SurName.Text = "Фамилия";
            this.SurName.Width = 128;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Имя";
            this.FirstName.Width = 115;
            // 
            // MiddleName
            // 
            this.MiddleName.Text = "Отчество";
            this.MiddleName.Width = 166;
            // 
            // Cost
            // 
            this.Cost.Text = "Стоимость услуги";
            this.Cost.Width = 174;
            // 
            // labelSurName
            // 
            this.labelSurName.AutoSize = true;
            this.labelSurName.BackColor = System.Drawing.Color.Transparent;
            this.labelSurName.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurName.Location = new System.Drawing.Point(83, 21);
            this.labelSurName.Name = "labelSurName";
            this.labelSurName.Size = new System.Drawing.Size(86, 25);
            this.labelSurName.TabIndex = 133;
            this.labelSurName.Text = "Фамилия";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(81, 83);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(44, 25);
            this.labelFirstName.TabIndex = 132;
            this.labelFirstName.Text = "Имя";
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxSurName.Location = new System.Drawing.Point(84, 49);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(160, 33);
            this.textBoxSurName.TabIndex = 131;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxFirstName.Location = new System.Drawing.Point(84, 111);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(160, 33);
            this.textBoxFirstName.TabIndex = 130;
            // 
            // FormProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kv.Properties.Resources.BG_for_IS;
            this.ClientSize = new System.Drawing.Size(953, 401);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.listViewProvider);
            this.Controls.Add(this.labelSurName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxSurName);
            this.Controls.Add(this.textBoxFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.ListView listViewProvider;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader SurName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader MiddleName;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Label labelSurName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxFirstName;
    }
}