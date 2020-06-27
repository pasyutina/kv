namespace kv
{
    partial class FormShipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShipment));
            this.dateTimePickerShip = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelQuant = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewShipment = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelProvider = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerShip
            // 
            this.dateTimePickerShip.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerShip.Location = new System.Drawing.Point(76, 182);
            this.dateTimePickerShip.Name = "dateTimePickerShip";
            this.dateTimePickerShip.Size = new System.Drawing.Size(158, 27);
            this.dateTimePickerShip.TabIndex = 164;
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(76, 123);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(158, 27);
            this.comboBoxProvider.TabIndex = 163;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(76, 62);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(158, 27);
            this.comboBoxMaterial.TabIndex = 162;
            this.comboBoxMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterial_SelectedIndexChanged);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPrice.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPrice.Location = new System.Drawing.Point(73, 332);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(126, 25);
            this.labelTotalPrice.TabIndex = 161;
            this.labelTotalPrice.Text = "Итоговая цена";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTotalPrice.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxTotalPrice.Location = new System.Drawing.Point(76, 360);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(160, 27);
            this.textBoxTotalPrice.TabIndex = 160;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.BackColor = System.Drawing.Color.Transparent;
            this.labelPlace.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlace.Location = new System.Drawing.Point(73, 273);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(177, 25);
            this.labelPlace.TabIndex = 159;
            this.labelPlace.Text = "Место расположения";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPlace.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPlace.Location = new System.Drawing.Point(76, 301);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(160, 27);
            this.textBoxPlace.TabIndex = 158;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.BackColor = System.Drawing.Color.Transparent;
            this.labelMaterial.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.Location = new System.Drawing.Point(73, 35);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(57, 25);
            this.labelMaterial.TabIndex = 157;
            this.labelMaterial.Text = "Товар";
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.BackColor = System.Drawing.Color.Transparent;
            this.labelQuant.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuant.Location = new System.Drawing.Point(73, 212);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(104, 25);
            this.labelQuant.TabIndex = 156;
            this.labelQuant.Text = "Количество";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxQuantity.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxQuantity.Location = new System.Drawing.Point(76, 240);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(160, 27);
            this.textBoxQuantity.TabIndex = 155;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(78, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 154;
            this.pictureBox1.TabStop = false;
            // 
            // listViewShipment
            // 
            this.listViewShipment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listViewShipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Material,
            this.Provider,
            this.Date,
            this.Quantity,
            this.Place,
            this.TotalPrice});
            this.listViewShipment.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewShipment.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewShipment.FullRowSelect = true;
            this.listViewShipment.GridLines = true;
            this.listViewShipment.HideSelection = false;
            this.listViewShipment.Location = new System.Drawing.Point(256, 40);
            this.listViewShipment.MultiSelect = false;
            this.listViewShipment.Name = "listViewShipment";
            this.listViewShipment.Size = new System.Drawing.Size(624, 422);
            this.listViewShipment.TabIndex = 153;
            this.listViewShipment.UseCompatibleStateImageBehavior = false;
            this.listViewShipment.View = System.Windows.Forms.View.Details;
            this.listViewShipment.SelectedIndexChanged += new System.EventHandler(this.listViewShipment_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 29;
            // 
            // Material
            // 
            this.Material.Text = "Товар";
            this.Material.Width = 65;
            // 
            // Provider
            // 
            this.Provider.Text = "Поставщик";
            this.Provider.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = "Дата поставки";
            this.Date.Width = 127;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Количество";
            this.Quantity.Width = 104;
            // 
            // Place
            // 
            this.Place.Text = "Место расположения";
            this.Place.Width = 99;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Итоговая цена";
            this.TotalPrice.Width = 96;
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.BackColor = System.Drawing.Color.Transparent;
            this.labelProvider.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProvider.Location = new System.Drawing.Point(75, 91);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(99, 25);
            this.labelProvider.TabIndex = 152;
            this.labelProvider.Text = "Поставщик";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Ropa Sans SC PTT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(73, 153);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(124, 25);
            this.labelDate.TabIndex = 151;
            this.labelDate.Text = "Дата поставки";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(470, 468);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(202, 44);
            this.buttonEdit.TabIndex = 150;
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
            this.buttonAdd.Location = new System.Drawing.Point(262, 468);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(202, 44);
            this.buttonAdd.TabIndex = 149;
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
            this.buttonDel.Location = new System.Drawing.Point(678, 468);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(202, 44);
            this.buttonDel.TabIndex = 148;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kv.Properties.Resources.BG_for_IS;
            this.ClientSize = new System.Drawing.Size(953, 547);
            this.Controls.Add(this.dateTimePickerShip);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelQuant);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewShipment);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormShipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставка оборудования и материалов";
            this.Load += new System.EventHandler(this.FormShipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerShip;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewShipment;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Material;
        private System.Windows.Forms.ColumnHeader Provider;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Place;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
    }
}