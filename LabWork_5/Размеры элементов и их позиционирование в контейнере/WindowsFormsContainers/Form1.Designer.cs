
namespace WindowsFormsContainers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.positionButton = new System.Windows.Forms.Button();
            this.increase_sizeButton = new System.Windows.Forms.Button();
            this.dock_rightButton = new System.Windows.Forms.Button();
            this.dock_leftButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // positionButton
            // 
            this.positionButton.Location = new System.Drawing.Point(213, 31);
            this.positionButton.Name = "positionButton";
            this.positionButton.Size = new System.Drawing.Size(143, 23);
            this.positionButton.TabIndex = 0;
            this.positionButton.Text = "Change button position";
            this.positionButton.UseVisualStyleBackColor = true;
            // 
            // increase_sizeButton
            // 
            this.increase_sizeButton.Location = new System.Drawing.Point(362, 31);
            this.increase_sizeButton.Name = "increase_sizeButton";
            this.increase_sizeButton.Size = new System.Drawing.Size(143, 23);
            this.increase_sizeButton.TabIndex = 1;
            this.increase_sizeButton.Text = "Increase button size";
            this.increase_sizeButton.UseVisualStyleBackColor = true;
            // 
            // dock_rightButton
            // 
            this.dock_rightButton.Location = new System.Drawing.Point(249, 80);
            this.dock_rightButton.Name = "dock_rightButton";
            this.dock_rightButton.Size = new System.Drawing.Size(107, 23);
            this.dock_rightButton.TabIndex = 2;
            this.dock_rightButton.Text = "Dock to right";
            this.dock_rightButton.UseVisualStyleBackColor = true;
            // 
            // dock_leftButton
            // 
            this.dock_leftButton.Location = new System.Drawing.Point(362, 80);
            this.dock_leftButton.Name = "dock_leftButton";
            this.dock_leftButton.Size = new System.Drawing.Size(106, 23);
            this.dock_leftButton.TabIndex = 3;
            this.dock_leftButton.Text = "Dock to left";
            this.dock_leftButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 143);
            this.Controls.Add(this.dock_leftButton);
            this.Controls.Add(this.dock_rightButton);
            this.Controls.Add(this.increase_sizeButton);
            this.Controls.Add(this.positionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button positionButton;
        private System.Windows.Forms.Button increase_sizeButton;
        private System.Windows.Forms.Button dock_rightButton;
        private System.Windows.Forms.Button dock_leftButton;
    }
}

