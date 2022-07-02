namespace RFAB_builder.Forms
{
    partial class CreateCharacterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборРасыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборКамняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пассивныеЭффектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основнойСюжетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гильдииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гражданскаяВойнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чудоПриродыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черныеКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.камниВсесоздателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StoneLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PassiveEffectsDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassiveEffectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборРасыToolStripMenuItem,
            this.выборКамняToolStripMenuItem,
            this.пассивныеЭффектыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборРасыToolStripMenuItem
            // 
            this.выборРасыToolStripMenuItem.Name = "выборРасыToolStripMenuItem";
            this.выборРасыToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.выборРасыToolStripMenuItem.Text = "Выбор расы";
            this.выборРасыToolStripMenuItem.Click += new System.EventHandler(this.ВыборРасыToolStripMenuItem_Click);
            // 
            // выборКамняToolStripMenuItem
            // 
            this.выборКамняToolStripMenuItem.Name = "выборКамняToolStripMenuItem";
            this.выборКамняToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.выборКамняToolStripMenuItem.Text = "Выбор камня";
            this.выборКамняToolStripMenuItem.Click += new System.EventHandler(this.ВыборКамняToolStripMenuItem_Click);
            // 
            // пассивныеЭффектыToolStripMenuItem
            // 
            this.пассивныеЭффектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основнойСюжетToolStripMenuItem,
            this.гильдииToolStripMenuItem,
            this.гражданскаяВойнаToolStripMenuItem,
            this.чудоПриродыToolStripMenuItem,
            this.черныеКнигиToolStripMenuItem,
            this.камниВсесоздателяToolStripMenuItem,
            this.разноеToolStripMenuItem});
            this.пассивныеЭффектыToolStripMenuItem.Name = "пассивныеЭффектыToolStripMenuItem";
            this.пассивныеЭффектыToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.пассивныеЭффектыToolStripMenuItem.Text = "Пассивные эффекты";
            // 
            // основнойСюжетToolStripMenuItem
            // 
            this.основнойСюжетToolStripMenuItem.Name = "основнойСюжетToolStripMenuItem";
            this.основнойСюжетToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.основнойСюжетToolStripMenuItem.Text = "Основной сюжет";
            this.основнойСюжетToolStripMenuItem.Click += new System.EventHandler(this.ОсновнойСюжетToolStripMenuItem_Click);
            // 
            // гильдииToolStripMenuItem
            // 
            this.гильдииToolStripMenuItem.Name = "гильдииToolStripMenuItem";
            this.гильдииToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.гильдииToolStripMenuItem.Text = "Гильдии";
            this.гильдииToolStripMenuItem.Click += new System.EventHandler(this.ГильдииToolStripMenuItem_Click);
            // 
            // гражданскаяВойнаToolStripMenuItem
            // 
            this.гражданскаяВойнаToolStripMenuItem.Name = "гражданскаяВойнаToolStripMenuItem";
            this.гражданскаяВойнаToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.гражданскаяВойнаToolStripMenuItem.Text = "Гражданская война";
            this.гражданскаяВойнаToolStripMenuItem.Click += new System.EventHandler(this.ГражданскаяВойнаToolStripMenuItem_Click);
            // 
            // чудоПриродыToolStripMenuItem
            // 
            this.чудоПриродыToolStripMenuItem.Name = "чудоПриродыToolStripMenuItem";
            this.чудоПриродыToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.чудоПриродыToolStripMenuItem.Text = "Чудо природы";
            this.чудоПриродыToolStripMenuItem.Click += new System.EventHandler(this.ЧудоПриродыToolStripMenuItem_Click);
            // 
            // черныеКнигиToolStripMenuItem
            // 
            this.черныеКнигиToolStripMenuItem.Name = "черныеКнигиToolStripMenuItem";
            this.черныеКнигиToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.черныеКнигиToolStripMenuItem.Text = "Черные книги";
            this.черныеКнигиToolStripMenuItem.Click += new System.EventHandler(this.ЧерныеКнигиToolStripMenuItem_Click);
            // 
            // камниВсесоздателяToolStripMenuItem
            // 
            this.камниВсесоздателяToolStripMenuItem.Name = "камниВсесоздателяToolStripMenuItem";
            this.камниВсесоздателяToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.камниВсесоздателяToolStripMenuItem.Text = "Камни Всесоздателя";
            this.камниВсесоздателяToolStripMenuItem.Click += new System.EventHandler(this.KамниВсесоздателяToolStripMenuItem_Click);
            // 
            // разноеToolStripMenuItem
            // 
            this.разноеToolStripMenuItem.Name = "разноеToolStripMenuItem";
            this.разноеToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.разноеToolStripMenuItem.Text = "Разное";
            this.разноеToolStripMenuItem.Click += new System.EventHandler(this.PазноеToolStripMenuItem_Click);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RaceLabel.Location = new System.Drawing.Point(6, 16);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(49, 20);
            this.RaceLabel.TabIndex = 1;
            this.RaceLabel.Text = "Раса:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(6, 36);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 20);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Имя:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StoneLabel);
            this.groupBox1.Controls.Add(this.RaceLabel);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инфо";
            // 
            // StoneLabel
            // 
            this.StoneLabel.AutoSize = true;
            this.StoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoneLabel.Location = new System.Drawing.Point(6, 56);
            this.StoneLabel.Name = "StoneLabel";
            this.StoneLabel.Size = new System.Drawing.Size(70, 20);
            this.StoneLabel.TabIndex = 3;
            this.StoneLabel.Text = "Камень:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PassiveEffectsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(389, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 337);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список пассивных эффектов:";
            // 
            // PassiveEffectsDataGridView
            // 
            this.PassiveEffectsDataGridView.AllowUserToAddRows = false;
            this.PassiveEffectsDataGridView.AllowUserToDeleteRows = false;
            this.PassiveEffectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PassiveEffectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassiveEffectsDataGridView.Location = new System.Drawing.Point(7, 20);
            this.PassiveEffectsDataGridView.Name = "PassiveEffectsDataGridView";
            this.PassiveEffectsDataGridView.Size = new System.Drawing.Size(770, 311);
            this.PassiveEffectsDataGridView.TabIndex = 0;
            // 
            // CreateCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateCharacterForm";
            this.Text = "CreateCharacterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateCharacterForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateCharacterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PassiveEffectsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выборРасыToolStripMenuItem;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label StoneLabel;
        private System.Windows.Forms.ToolStripMenuItem выборКамняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пассивныеЭффектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основнойСюжетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гильдииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гражданскаяВойнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чудоПриродыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem черныеКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem камниВсесоздателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разноеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView PassiveEffectsDataGridView;
    }
}