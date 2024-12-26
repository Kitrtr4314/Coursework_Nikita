using System.ComponentModel;

namespace StarSystemApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ListBoxObject = new System.Windows.Forms.ListBox();
            this.AddObject = new System.Windows.Forms.Button();
            this.DeleteObject = new System.Windows.Forms.Button();
            this.ShowInfo = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.ObjectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBoxObject
            // 
            this.ListBoxObject.FormattingEnabled = true;
            this.ListBoxObject.ItemHeight = 16;
            this.ListBoxObject.Items.AddRange(new object[] { "Список объектов" });
            this.ListBoxObject.Location = new System.Drawing.Point(12, 217);
            this.ListBoxObject.Name = "ListBoxObject";
            this.ListBoxObject.Size = new System.Drawing.Size(200, 36);
            this.ListBoxObject.TabIndex = 2;
            this.ListBoxObject.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddObject
            // 
            this.AddObject.Location = new System.Drawing.Point(12, 64);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(200, 40);
            this.AddObject.TabIndex = 3;
            this.AddObject.Text = "Добавить объект";
            this.AddObject.UseVisualStyleBackColor = true;
            this.AddObject.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteObject
            // 
            this.DeleteObject.Location = new System.Drawing.Point(238, 64);
            this.DeleteObject.Name = "DeleteObject";
            this.DeleteObject.Size = new System.Drawing.Size(200, 40);
            this.DeleteObject.TabIndex = 4;
            this.DeleteObject.Text = "Удалить объект";
            this.DeleteObject.UseVisualStyleBackColor = true;
            this.DeleteObject.Click += new System.EventHandler(this.DeleteObject_Click);
            // 
            // ShowInfo
            // 
            this.ShowInfo.Location = new System.Drawing.Point(12, 138);
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.Size = new System.Drawing.Size(200, 40);
            this.ShowInfo.TabIndex = 5;
            this.ShowInfo.Text = "Посмотреть информацию";
            this.ShowInfo.UseVisualStyleBackColor = true;
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(238, 138);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(200, 40);
            this.Sort.TabIndex = 6;
            this.Sort.Text = "Сортировать";
            this.Sort.UseVisualStyleBackColor = true;
            // 
            // ObjectLabel
            // 
            this.ObjectLabel.Location = new System.Drawing.Point(238, 217);
            this.ObjectLabel.Name = "ObjectLabel";
            this.ObjectLabel.Size = new System.Drawing.Size(200, 84);
            this.ObjectLabel.TabIndex = 7;
            this.ObjectLabel.Text = "Информация ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 499);
            this.Controls.Add(this.ObjectLabel);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.ShowInfo);
            this.Controls.Add(this.DeleteObject);
            this.Controls.Add(this.AddObject);
            this.Controls.Add(this.ListBoxObject);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button DeleteObject;
        private System.Windows.Forms.Button ShowInfo;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Label ObjectLabel;

        private System.Windows.Forms.ListBox ListBoxObject;

        private System.Windows.Forms.Button AddObject;

        #endregion
    }
}