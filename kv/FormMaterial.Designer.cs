namespace kv
{
    partial class FormMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaterial));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewMaterial = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InventNumb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelInventNumb = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxInventNumb = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(83, 36);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(128, 25);
            this.labelTitle.TabIndex = 116;
            this.labelTitle.Text = "Наименование";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(84, 226);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 25);
            this.labelPrice.TabIndex = 115;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrice.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPrice.Location = new System.Drawing.Point(87, 254);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(160, 33);
            this.textBoxPrice.TabIndex = 114;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::kv.Properties.Resources.ЛОГО_Кванториум_Цветной;
            this.pictureBox1.Location = new System.Drawing.Point(87, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // listViewMaterial
            // 
            this.listViewMaterial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listViewMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.InventNumb,
            this.Unit,
            this.Price});
            this.listViewMaterial.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewMaterial.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewMaterial.FullRowSelect = true;
            this.listViewMaterial.GridLines = true;
            this.listViewMaterial.HideSelection = false;
            this.listViewMaterial.Location = new System.Drawing.Point(252, 32);
            this.listViewMaterial.MultiSelect = false;
            this.listViewMaterial.Name = "listViewMaterial";
            this.listViewMaterial.Size = new System.Drawing.Size(618, 311);
            this.listViewMaterial.TabIndex = 112;
            this.listViewMaterial.UseCompatibleStateImageBehavior = false;
            this.listViewMaterial.View = System.Windows.Forms.View.Details;
            this.listViewMaterial.SelectedIndexChanged += new System.EventHandler(this.listViewMaterial_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 29;
            // 
            // Title
            // 
            this.Title.Text = "Наименование";
            this.Title.Width = 150;
            // 
            // InventNumb
            // 
            this.InventNumb.Text = "Инвентарный номер";
            this.InventNumb.Width = 168;
            // 
            // Unit
            // 
            this.Unit.Text = "Единица измерения";
            this.Unit.Width = 166;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.Width = 98;
            // 
            // labelInventNumb
            // 
            this.labelInventNumb.AutoSize = true;
            this.labelInventNumb.BackColor = System.Drawing.Color.Transparent;
            this.labelInventNumb.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInventNumb.Location = new System.Drawing.Point(85, 100);
            this.labelInventNumb.Name = "labelInventNumb";
            this.labelInventNumb.Size = new System.Drawing.Size(168, 25);
            this.labelInventNumb.TabIndex = 111;
            this.labelInventNumb.Text = "Инвентарный номер";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.BackColor = System.Drawing.Color.Transparent;
            this.labelUnit.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnit.Location = new System.Drawing.Point(83, 162);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(166, 25);
            this.labelUnit.TabIndex = 110;
            this.labelUnit.Text = "Единица измерения";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxTitle.Location = new System.Drawing.Point(86, 65);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(160, 33);
            this.textBoxTitle.TabIndex = 109;
            // 
            // textBoxInventNumb
            // 
            this.textBoxInventNumb.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInventNumb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxInventNumb.Location = new System.Drawing.Point(86, 128);
            this.textBoxInventNumb.Name = "textBoxInventNumb";
            this.textBoxInventNumb.Size = new System.Drawing.Size(160, 33);
            this.textBoxInventNumb.TabIndex = 108;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUnit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUnit.Location = new System.Drawing.Point(86, 190);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(160, 33);
            this.textBoxUnit.TabIndex = 107;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(460, 349);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(202, 44);
            this.buttonEdit.TabIndex = 106;
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
            this.buttonAdd.Location = new System.Drawing.Point(252, 349);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(202, 44);
            this.buttonAdd.TabIndex = 105;
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
            this.buttonDel.Location = new System.Drawing.Point(668, 349);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(202, 44);
            this.buttonDel.TabIndex = 104;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kv.Properties.Resources.BG_for_IS;
            this.ClientSize = new System.Drawing.Size(953, 401);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewMaterial);
            this.Controls.Add(this.labelInventNumb);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxInventNumb);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материалы и оборудование";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewMaterial;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader InventNumb;
        private System.Windows.Forms.ColumnHeader Unit;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label labelInventNumb;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxInventNumb;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
    }
}