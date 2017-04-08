namespace WindowsFormsApp2
{
    partial class PrehledForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dnesLabel = new System.Windows.Forms.Label();
            this.nejblizsiLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.narozeninyLabel = new System.Windows.Forms.Label();
            this.vekLabel = new System.Windows.Forms.Label();
            this.osobyListBox = new System.Windows.Forms.ListBox();
            this.pridatButton = new System.Windows.Forms.Button();
            this.odebratButton = new System.Windows.Forms.Button();
            this.ulozitButton = new System.Windows.Forms.Button();
            this.nacistButton = new System.Windows.Forms.Button();
            this.datumNarozeniDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datumNarozeniLabel = new System.Windows.Forms.Label();
            this.jmenoLabel = new System.Windows.Forms.Label();
            this.jmenoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dnes je";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nejbližší narozeniny";
            // 
            // dnesLabel
            // 
            this.dnesLabel.AutoSize = true;
            this.dnesLabel.Location = new System.Drawing.Point(173, 21);
            this.dnesLabel.Name = "dnesLabel";
            this.dnesLabel.Size = new System.Drawing.Size(35, 13);
            this.dnesLabel.TabIndex = 2;
            this.dnesLabel.Text = "label3";
            // 
            // nejblizsiLabel
            // 
            this.nejblizsiLabel.AutoSize = true;
            this.nejblizsiLabel.Location = new System.Drawing.Point(173, 39);
            this.nejblizsiLabel.Name = "nejblizsiLabel";
            this.nejblizsiLabel.Size = new System.Drawing.Size(35, 13);
            this.nejblizsiLabel.TabIndex = 3;
            this.nejblizsiLabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Narozeniny:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Věk:";
            // 
            // narozeninyLabel
            // 
            this.narozeninyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.narozeninyLabel.AutoSize = true;
            this.narozeninyLabel.Location = new System.Drawing.Point(258, 84);
            this.narozeninyLabel.Name = "narozeninyLabel";
            this.narozeninyLabel.Size = new System.Drawing.Size(35, 13);
            this.narozeninyLabel.TabIndex = 6;
            this.narozeninyLabel.Text = "label7";
            // 
            // vekLabel
            // 
            this.vekLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vekLabel.AutoSize = true;
            this.vekLabel.Location = new System.Drawing.Point(258, 99);
            this.vekLabel.Name = "vekLabel";
            this.vekLabel.Size = new System.Drawing.Size(35, 13);
            this.vekLabel.TabIndex = 7;
            this.vekLabel.Text = "label8";
            // 
            // osobyListBox
            // 
            this.osobyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.osobyListBox.FormattingEnabled = true;
            this.osobyListBox.Location = new System.Drawing.Point(12, 84);
            this.osobyListBox.Name = "osobyListBox";
            this.osobyListBox.Size = new System.Drawing.Size(156, 199);
            this.osobyListBox.TabIndex = 8;
            this.osobyListBox.SelectedIndexChanged += new System.EventHandler(this.osobyListBox_SelectedIndexChanged);
            // 
            // pridatButton
            // 
            this.pridatButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pridatButton.Location = new System.Drawing.Point(340, 284);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.Size = new System.Drawing.Size(75, 23);
            this.pridatButton.TabIndex = 10;
            this.pridatButton.Text = "Přidat";
            this.pridatButton.UseVisualStyleBackColor = true;
            this.pridatButton.Click += new System.EventHandler(this.pridatButton_Click);
            // 
            // odebratButton
            // 
            this.odebratButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.odebratButton.Location = new System.Drawing.Point(438, 284);
            this.odebratButton.Name = "odebratButton";
            this.odebratButton.Size = new System.Drawing.Size(75, 23);
            this.odebratButton.TabIndex = 11;
            this.odebratButton.Text = "Odebrat";
            this.odebratButton.UseVisualStyleBackColor = true;
            this.odebratButton.Click += new System.EventHandler(this.odebratButton_Click);
            // 
            // ulozitButton
            // 
            this.ulozitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ulozitButton.Location = new System.Drawing.Point(12, 291);
            this.ulozitButton.Name = "ulozitButton";
            this.ulozitButton.Size = new System.Drawing.Size(75, 23);
            this.ulozitButton.TabIndex = 12;
            this.ulozitButton.Text = "Uložit";
            this.ulozitButton.UseVisualStyleBackColor = true;
            this.ulozitButton.Click += new System.EventHandler(this.ulozitButton_Click);
            // 
            // nacistButton
            // 
            this.nacistButton.Location = new System.Drawing.Point(93, 291);
            this.nacistButton.Name = "nacistButton";
            this.nacistButton.Size = new System.Drawing.Size(75, 23);
            this.nacistButton.TabIndex = 13;
            this.nacistButton.Text = "Načíst";
            this.nacistButton.UseVisualStyleBackColor = true;
            this.nacistButton.Click += new System.EventHandler(this.nacistButton_Click);
            // 
            // datumNarozeniDateTimePicker
            // 
            this.datumNarozeniDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.datumNarozeniDateTimePicker.Location = new System.Drawing.Point(6, 110);
            this.datumNarozeniDateTimePicker.Name = "datumNarozeniDateTimePicker";
            this.datumNarozeniDateTimePicker.Size = new System.Drawing.Size(173, 20);
            this.datumNarozeniDateTimePicker.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jmenoTextBox);
            this.groupBox1.Controls.Add(this.jmenoLabel);
            this.groupBox1.Controls.Add(this.datumNarozeniLabel);
            this.groupBox1.Controls.Add(this.datumNarozeniDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(334, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 202);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Přidat osobu";
            // 
            // datumNarozeniLabel
            // 
            this.datumNarozeniLabel.AutoSize = true;
            this.datumNarozeniLabel.Location = new System.Drawing.Point(6, 94);
            this.datumNarozeniLabel.Name = "datumNarozeniLabel";
            this.datumNarozeniLabel.Size = new System.Drawing.Size(88, 13);
            this.datumNarozeniLabel.TabIndex = 15;
            this.datumNarozeniLabel.Text = "Datum Narození:";
            // 
            // jmenoLabel
            // 
            this.jmenoLabel.AutoSize = true;
            this.jmenoLabel.Location = new System.Drawing.Point(6, 28);
            this.jmenoLabel.Name = "jmenoLabel";
            this.jmenoLabel.Size = new System.Drawing.Size(62, 13);
            this.jmenoLabel.TabIndex = 16;
            this.jmenoLabel.Text = "Celé jméno:";
            // 
            // jmenoTextBox
            // 
            this.jmenoTextBox.Location = new System.Drawing.Point(6, 44);
            this.jmenoTextBox.Name = "jmenoTextBox";
            this.jmenoTextBox.Size = new System.Drawing.Size(173, 20);
            this.jmenoTextBox.TabIndex = 17;
            // 
            // PrehledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nacistButton);
            this.Controls.Add(this.ulozitButton);
            this.Controls.Add(this.odebratButton);
            this.Controls.Add(this.pridatButton);
            this.Controls.Add(this.osobyListBox);
            this.Controls.Add(this.vekLabel);
            this.Controls.Add(this.narozeninyLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nejblizsiLabel);
            this.Controls.Add(this.dnesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrehledForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narozeniny";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dnesLabel;
        private System.Windows.Forms.Label nejblizsiLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label narozeninyLabel;
        private System.Windows.Forms.Label vekLabel;
        private System.Windows.Forms.ListBox osobyListBox;
        private System.Windows.Forms.Button pridatButton;
        private System.Windows.Forms.Button odebratButton;
        private System.Windows.Forms.Button ulozitButton;
        private System.Windows.Forms.Button nacistButton;
        private System.Windows.Forms.DateTimePicker datumNarozeniDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label jmenoLabel;
        private System.Windows.Forms.Label datumNarozeniLabel;
        private System.Windows.Forms.TextBox jmenoTextBox;
    }
}

