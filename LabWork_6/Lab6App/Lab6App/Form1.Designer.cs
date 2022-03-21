namespace Lab6App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.PreoutputLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.Panel = new System.Windows.Forms.Panel();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputButton
            // 
            this.InputButton.Image = ((System.Drawing.Image)(resources.GetObject("InputButton.Image")));
            this.InputButton.Location = new System.Drawing.Point(299, 10);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 23);
            this.InputButton.TabIndex = 0;
            this.InputButton.Text = "Готово";
            this.InputButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.Location = new System.Drawing.Point(388, 10);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(116, 10);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputBox.Size = new System.Drawing.Size(157, 57);
            this.InputBox.TabIndex = 2;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(12, 10);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(83, 13);
            this.TextLabel.TabIndex = 3;
            this.TextLabel.Text = "Введите текст:";
            // 
            // PreoutputLabel
            // 
            this.PreoutputLabel.AutoSize = true;
            this.PreoutputLabel.Location = new System.Drawing.Point(12, 86);
            this.PreoutputLabel.Name = "PreoutputLabel";
            this.PreoutputLabel.Size = new System.Drawing.Size(98, 13);
            this.PreoutputLabel.TabIndex = 4;
            this.PreoutputLabel.Text = "Введённый текст:";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(3, 4);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(80, 13);
            this.InputLabel.TabIndex = 5;
            this.InputLabel.Text = "Введите текст";
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.LinkArea = new System.Windows.Forms.LinkArea(22, 27);
            this.LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LinkLabel.Location = new System.Drawing.Point(299, 50);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(164, 17);
            this.LinkLabel.TabIndex = 6;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Ссылка на репозиторий здесь";
            this.LinkLabel.UseCompatibleTextRendering = true;
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Controls.Add(this.InputLabel);
            this.Panel.Location = new System.Drawing.Point(116, 82);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(157, 57);
            this.Panel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 159);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.PreoutputLabel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.InputButton);
            this.Name = "Form1";
            this.Text = "Форма ввода текста";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label PreoutputLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.LinkLabel LinkLabel;
        private System.Windows.Forms.Panel Panel;
    }
}

