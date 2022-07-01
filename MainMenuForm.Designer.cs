namespace RFAB_builder
{
    partial class MainMenuForm
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
            this.CreateNewCharButton = new System.Windows.Forms.Button();
            this.LoadCharButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNewCharButton
            // 
            this.CreateNewCharButton.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewCharButton.Location = new System.Drawing.Point(120, 105);
            this.CreateNewCharButton.Name = "CreateNewCharButton";
            this.CreateNewCharButton.Size = new System.Drawing.Size(255, 47);
            this.CreateNewCharButton.TabIndex = 0;
            this.CreateNewCharButton.Text = "Создать нового персонажа";
            this.CreateNewCharButton.UseVisualStyleBackColor = true;
            this.CreateNewCharButton.Click += new System.EventHandler(this.CreateNewCharButton_Click);
            // 
            // LoadCharButton
            // 
            this.LoadCharButton.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCharButton.Location = new System.Drawing.Point(120, 158);
            this.LoadCharButton.Name = "LoadCharButton";
            this.LoadCharButton.Size = new System.Drawing.Size(255, 47);
            this.LoadCharButton.TabIndex = 1;
            this.LoadCharButton.Text = "Загрузить персонажа";
            this.LoadCharButton.UseVisualStyleBackColor = true;
            // 
            // InfoButton
            // 
            this.InfoButton.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.Location = new System.Drawing.Point(120, 211);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(255, 47);
            this.InfoButton.TabIndex = 2;
            this.InfoButton.Text = "Справка";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(509, 412);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.LoadCharButton);
            this.Controls.Add(this.CreateNewCharButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenuForm";
            this.Text = "RFABuilder";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewCharButton;
        private System.Windows.Forms.Button LoadCharButton;
        private System.Windows.Forms.Button InfoButton;
    }
}

