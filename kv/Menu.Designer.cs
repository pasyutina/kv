namespace kv
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonNal = new System.Windows.Forms.Button();
            this.buttonExtra = new System.Windows.Forms.Button();
            this.buttonPriem = new System.Windows.Forms.Button();
            this.buttonProvider = new System.Windows.Forms.Button();
            this.buttonAgents = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSum
            // 
            this.buttonSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonSum.FlatAppearance.BorderSize = 0;
            this.buttonSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSum.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSum.ForeColor = System.Drawing.Color.White;
            this.buttonSum.Location = new System.Drawing.Point(1000, 326);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(307, 95);
            this.buttonSum.TabIndex = 34;
            this.buttonSum.Text = "Сводная ведомость";
            this.buttonSum.UseVisualStyleBackColor = false;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonNal
            // 
            this.buttonNal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonNal.FlatAppearance.BorderSize = 0;
            this.buttonNal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNal.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNal.ForeColor = System.Drawing.Color.White;
            this.buttonNal.Location = new System.Drawing.Point(661, 326);
            this.buttonNal.Name = "buttonNal";
            this.buttonNal.Size = new System.Drawing.Size(307, 95);
            this.buttonNal.TabIndex = 33;
            this.buttonNal.Text = "Наличие оборудования и материалов";
            this.buttonNal.UseVisualStyleBackColor = false;
            this.buttonNal.Click += new System.EventHandler(this.buttonNal_Click);
            // 
            // buttonExtra
            // 
            this.buttonExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonExtra.FlatAppearance.BorderSize = 0;
            this.buttonExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExtra.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExtra.ForeColor = System.Drawing.Color.White;
            this.buttonExtra.Location = new System.Drawing.Point(1000, 199);
            this.buttonExtra.Name = "buttonExtra";
            this.buttonExtra.Size = new System.Drawing.Size(307, 95);
            this.buttonExtra.TabIndex = 32;
            this.buttonExtra.Text = "Выдача оборудования и материалов";
            this.buttonExtra.UseVisualStyleBackColor = false;
            this.buttonExtra.Click += new System.EventHandler(this.buttonExtra_Click);
            // 
            // buttonPriem
            // 
            this.buttonPriem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonPriem.FlatAppearance.BorderSize = 0;
            this.buttonPriem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPriem.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPriem.ForeColor = System.Drawing.Color.White;
            this.buttonPriem.Location = new System.Drawing.Point(661, 199);
            this.buttonPriem.Name = "buttonPriem";
            this.buttonPriem.Size = new System.Drawing.Size(307, 95);
            this.buttonPriem.TabIndex = 31;
            this.buttonPriem.Text = "Поставка оборудования и материалов";
            this.buttonPriem.UseVisualStyleBackColor = false;
            this.buttonPriem.Click += new System.EventHandler(this.buttonPriem_Click);
            // 
            // buttonProvider
            // 
            this.buttonProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonProvider.FlatAppearance.BorderSize = 0;
            this.buttonProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProvider.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProvider.ForeColor = System.Drawing.Color.White;
            this.buttonProvider.Location = new System.Drawing.Point(1000, 69);
            this.buttonProvider.Name = "buttonProvider";
            this.buttonProvider.Size = new System.Drawing.Size(307, 95);
            this.buttonProvider.TabIndex = 30;
            this.buttonProvider.Text = "Поставщики";
            this.buttonProvider.UseVisualStyleBackColor = false;
            this.buttonProvider.Click += new System.EventHandler(this.buttonProvider_Click);
            // 
            // buttonAgents
            // 
            this.buttonAgents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(83)))), ((int)(((byte)(243)))));
            this.buttonAgents.FlatAppearance.BorderSize = 0;
            this.buttonAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgents.Font = new System.Drawing.Font("BankGothic RUSS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAgents.ForeColor = System.Drawing.Color.White;
            this.buttonAgents.Location = new System.Drawing.Point(661, 69);
            this.buttonAgents.Name = "buttonAgents";
            this.buttonAgents.Size = new System.Drawing.Size(307, 95);
            this.buttonAgents.TabIndex = 29;
            this.buttonAgents.Text = "Сотрудники";
            this.buttonAgents.UseVisualStyleBackColor = false;
            this.buttonAgents.Click += new System.EventHandler(this.buttonAgents_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::kv.Properties.Resources.ЛОГО_Кванториум_Цветной;
            this.pictureBox1.Location = new System.Drawing.Point(63, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("BankGothic RUSS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(867, 27);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(235, 19);
            this.labelHello.TabIndex = 35;
            this.labelHello.Text = "Приветствую тебя,";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kv.Properties.Resources.BG_for_IS;
            this.ClientSize = new System.Drawing.Size(1370, 491);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonNal);
            this.Controls.Add(this.buttonExtra);
            this.Controls.Add(this.buttonPriem);
            this.Controls.Add(this.buttonProvider);
            this.Controls.Add(this.buttonAgents);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonNal;
        private System.Windows.Forms.Button buttonExtra;
        private System.Windows.Forms.Button buttonPriem;
        private System.Windows.Forms.Button buttonProvider;
        private System.Windows.Forms.Button buttonAgents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHello;
    }
}

