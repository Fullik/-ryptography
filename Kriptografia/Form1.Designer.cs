namespace Kriptografia
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BruteForceRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KeyDecryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OTDecryTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CezarTextBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.CryptRadioButton = new System.Windows.Forms.RadioButton();
            this.DecryptRadioButton = new System.Windows.Forms.RadioButton();
            this.ShifButton = new System.Windows.Forms.Button();
            this.AlfphaButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Console = new System.Windows.Forms.RichTextBox();
            this.PtextBox = new System.Windows.Forms.TextBox();
            this.XaTextBox = new System.Windows.Forms.TextBox();
            this.XbTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DiffiButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 245);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.BruteForceRadioButton);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.CryptRadioButton);
            this.tabPage1.Controls.Add(this.DecryptRadioButton);
            this.tabPage1.Controls.Add(this.ShifButton);
            this.tabPage1.Controls.Add(this.AlfphaButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Первое задание";
            // 
            // BruteForceRadioButton
            // 
            this.BruteForceRadioButton.AutoSize = true;
            this.BruteForceRadioButton.Location = new System.Drawing.Point(563, 128);
            this.BruteForceRadioButton.Name = "BruteForceRadioButton";
            this.BruteForceRadioButton.Size = new System.Drawing.Size(75, 17);
            this.BruteForceRadioButton.TabIndex = 11;
            this.BruteForceRadioButton.TabStop = true;
            this.BruteForceRadioButton.Text = "Взломать";
            this.BruteForceRadioButton.UseVisualStyleBackColor = true;
            this.BruteForceRadioButton.CheckedChanged += new System.EventHandler(this.BruteForceRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(492, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 116);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сообщение для взлома";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Изначальное сообщение";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KeyDecryTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.OTDecryTextBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(250, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 116);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // KeyDecryTextBox
            // 
            this.KeyDecryTextBox.Location = new System.Drawing.Point(6, 79);
            this.KeyDecryTextBox.Name = "KeyDecryTextBox";
            this.KeyDecryTextBox.Size = new System.Drawing.Size(224, 20);
            this.KeyDecryTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите ключ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите сообщение";
            // 
            // OTDecryTextBox
            // 
            this.OTDecryTextBox.Location = new System.Drawing.Point(6, 32);
            this.OTDecryTextBox.Name = "OTDecryTextBox";
            this.OTDecryTextBox.Size = new System.Drawing.Size(224, 20);
            this.OTDecryTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CezarTextBox);
            this.groupBox1.Controls.Add(this.InputLabel);
            this.groupBox1.Controls.Add(this.KeyTextBox);
            this.groupBox1.Controls.Add(this.KeyLabel);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // CezarTextBox
            // 
            this.CezarTextBox.Location = new System.Drawing.Point(6, 32);
            this.CezarTextBox.Name = "CezarTextBox";
            this.CezarTextBox.Size = new System.Drawing.Size(224, 20);
            this.CezarTextBox.TabIndex = 0;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(3, 16);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(109, 13);
            this.InputLabel.TabIndex = 1;
            this.InputLabel.Text = "Введите сообщение";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(6, 79);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(224, 20);
            this.KeyTextBox.TabIndex = 3;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(3, 63);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(77, 13);
            this.KeyLabel.TabIndex = 4;
            this.KeyLabel.Text = "Введите ключ";
            // 
            // CryptRadioButton
            // 
            this.CryptRadioButton.AutoSize = true;
            this.CryptRadioButton.Location = new System.Drawing.Point(304, 128);
            this.CryptRadioButton.Name = "CryptRadioButton";
            this.CryptRadioButton.Size = new System.Drawing.Size(101, 17);
            this.CryptRadioButton.TabIndex = 7;
            this.CryptRadioButton.Text = "Расшифровать";
            this.CryptRadioButton.UseVisualStyleBackColor = true;
            this.CryptRadioButton.CheckedChanged += new System.EventHandler(this.CryptRadioButton_CheckedChanged);
            // 
            // DecryptRadioButton
            // 
            this.DecryptRadioButton.AutoSize = true;
            this.DecryptRadioButton.Checked = true;
            this.DecryptRadioButton.Location = new System.Drawing.Point(71, 128);
            this.DecryptRadioButton.Name = "DecryptRadioButton";
            this.DecryptRadioButton.Size = new System.Drawing.Size(101, 17);
            this.DecryptRadioButton.TabIndex = 6;
            this.DecryptRadioButton.TabStop = true;
            this.DecryptRadioButton.Text = "Зашрифровать";
            this.DecryptRadioButton.UseVisualStyleBackColor = true;
            this.DecryptRadioButton.CheckedChanged += new System.EventHandler(this.DecryptRadioButton_CheckedChanged);
            // 
            // ShifButton
            // 
            this.ShifButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShifButton.Location = new System.Drawing.Point(173, 181);
            this.ShifButton.Name = "ShifButton";
            this.ShifButton.Size = new System.Drawing.Size(183, 32);
            this.ShifButton.TabIndex = 5;
            this.ShifButton.Text = "Выполнить";
            this.ShifButton.UseVisualStyleBackColor = true;
            this.ShifButton.Click += new System.EventHandler(this.ShifButton_Click);
            // 
            // AlfphaButton
            // 
            this.AlfphaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlfphaButton.Location = new System.Drawing.Point(362, 181);
            this.AlfphaButton.Name = "AlfphaButton";
            this.AlfphaButton.Size = new System.Drawing.Size(183, 32);
            this.AlfphaButton.TabIndex = 2;
            this.AlfphaButton.Text = "Открыть файл с алфавитом";
            this.AlfphaButton.UseVisualStyleBackColor = true;
            this.AlfphaButton.Click += new System.EventHandler(this.AlfphaButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.DiffiButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.XbTextBox);
            this.tabPage2.Controls.Add(this.XaTextBox);
            this.tabPage2.Controls.Add(this.PtextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Второе задание";
            // 
            // Console
            // 
            this.Console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Console.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Console.ForeColor = System.Drawing.Color.Yellow;
            this.Console.Location = new System.Drawing.Point(0, 241);
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(742, 100);
            this.Console.TabIndex = 2;
            this.Console.Text = "";
            this.Console.TextChanged += new System.EventHandler(this.Console_TextChanged);
            // 
            // PtextBox
            // 
            this.PtextBox.Location = new System.Drawing.Point(72, 37);
            this.PtextBox.Name = "PtextBox";
            this.PtextBox.Size = new System.Drawing.Size(274, 20);
            this.PtextBox.TabIndex = 0;
            // 
            // XaTextBox
            // 
            this.XaTextBox.Location = new System.Drawing.Point(72, 63);
            this.XaTextBox.Name = "XaTextBox";
            this.XaTextBox.Size = new System.Drawing.Size(274, 20);
            this.XaTextBox.TabIndex = 1;
            // 
            // XbTextBox
            // 
            this.XbTextBox.Location = new System.Drawing.Point(72, 89);
            this.XbTextBox.Name = "XbTextBox";
            this.XbTextBox.Size = new System.Drawing.Size(274, 20);
            this.XbTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "P";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Xa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Xb";
            // 
            // DiffiButton
            // 
            this.DiffiButton.Location = new System.Drawing.Point(505, 143);
            this.DiffiButton.Name = "DiffiButton";
            this.DiffiButton.Size = new System.Drawing.Size(220, 70);
            this.DiffiButton.TabIndex = 6;
            this.DiffiButton.Text = "Подсчитать";
            this.DiffiButton.UseVisualStyleBackColor = true;
            this.DiffiButton.Click += new System.EventHandler(this.DiffiButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 340);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Задачи по курсу \"Криптография\"";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox CezarTextBox;
        private System.Windows.Forms.Button AlfphaButton;
        private System.Windows.Forms.Button ShifButton;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox KeyDecryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OTDecryTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CryptRadioButton;
        private System.Windows.Forms.RadioButton DecryptRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton BruteForceRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DiffiButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox XbTextBox;
        private System.Windows.Forms.TextBox XaTextBox;
        private System.Windows.Forms.TextBox PtextBox;
    }
}

