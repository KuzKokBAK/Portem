namespace Portem.Forms
{
    partial class CreateItemForm
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
            this.WriteItemButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HeadTextBox = new System.Windows.Forms.TextBox();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WriteItemButton
            // 
            this.WriteItemButton.Location = new System.Drawing.Point(660, 400);
            this.WriteItemButton.Name = "WriteItemButton";
            this.WriteItemButton.Size = new System.Drawing.Size(101, 29);
            this.WriteItemButton.TabIndex = 0;
            this.WriteItemButton.Text = "Записать";
            this.WriteItemButton.UseVisualStyleBackColor = true;
            this.WriteItemButton.Click += new System.EventHandler(this.WriteItemButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заголовок";
            // 
            // HeadTextBox
            // 
            this.HeadTextBox.Location = new System.Drawing.Point(57, 53);
            this.HeadTextBox.MaxLength = 50;
            this.HeadTextBox.Name = "HeadTextBox";
            this.HeadTextBox.Size = new System.Drawing.Size(686, 20);
            this.HeadTextBox.TabIndex = 3;
            this.HeadTextBox.TextChanged += new System.EventHandler(this.HeadTextBox_TextChanged);
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(57, 109);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentTextBox.Size = new System.Drawing.Size(704, 285);
            this.ContentTextBox.TabIndex = 4;
            this.ContentTextBox.TextChanged += new System.EventHandler(this.ContentTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Описание (Содержание)";
            // 
            // CreateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.HeadTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WriteItemButton);
            this.MaximizeBox = false;
            this.Name = "CreateItemForm";
            this.ShowIcon = false;
            this.Text = "Создать документацию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WriteItemButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HeadTextBox;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Label label2;
    }
}