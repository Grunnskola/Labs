namespace Lab2
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
            this.XMLTabWindow = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.OpenXMLButton = new System.Windows.Forms.Button();
            this.NewTabButton = new System.Windows.Forms.Button();
            this.RemoveTabButton = new System.Windows.Forms.Button();
            this.XMLTabWindow.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // XMLTabWindow
            // 
            this.XMLTabWindow.Controls.Add(this.tabPage1);
            this.XMLTabWindow.Location = new System.Drawing.Point(12, 12);
            this.XMLTabWindow.Name = "XMLTabWindow";
            this.XMLTabWindow.SelectedIndex = 0;
            this.XMLTabWindow.Size = new System.Drawing.Size(901, 491);
            this.XMLTabWindow.TabIndex = 0;
            this.XMLTabWindow.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Page 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(881, 453);
            this.treeView1.TabIndex = 0;
            // 
            // OpenXMLButton
            // 
            this.OpenXMLButton.Location = new System.Drawing.Point(919, 34);
            this.OpenXMLButton.Name = "OpenXMLButton";
            this.OpenXMLButton.Size = new System.Drawing.Size(98, 23);
            this.OpenXMLButton.TabIndex = 1;
            this.OpenXMLButton.Text = "Open XML";
            this.OpenXMLButton.UseVisualStyleBackColor = true;
            this.OpenXMLButton.Click += new System.EventHandler(this.OpenXMLButton_Click);
            // 
            // NewTabButton
            // 
            this.NewTabButton.Location = new System.Drawing.Point(919, 63);
            this.NewTabButton.Name = "NewTabButton";
            this.NewTabButton.Size = new System.Drawing.Size(98, 23);
            this.NewTabButton.TabIndex = 2;
            this.NewTabButton.Text = "New Tab";
            this.NewTabButton.UseVisualStyleBackColor = true;
            this.NewTabButton.Click += new System.EventHandler(this.NewTabButton_Click);
            // 
            // RemoveTabButton
            // 
            this.RemoveTabButton.Location = new System.Drawing.Point(920, 93);
            this.RemoveTabButton.Name = "RemoveTabButton";
            this.RemoveTabButton.Size = new System.Drawing.Size(97, 23);
            this.RemoveTabButton.TabIndex = 3;
            this.RemoveTabButton.Text = "Remove Current";
            this.RemoveTabButton.UseVisualStyleBackColor = true;
            this.RemoveTabButton.Click += new System.EventHandler(this.RemoveTabButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 531);
            this.Controls.Add(this.RemoveTabButton);
            this.Controls.Add(this.NewTabButton);
            this.Controls.Add(this.OpenXMLButton);
            this.Controls.Add(this.XMLTabWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.XMLTabWindow.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl XMLTabWindow;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button OpenXMLButton;
        private System.Windows.Forms.Button NewTabButton;
        private System.Windows.Forms.Button RemoveTabButton;
    }
}

