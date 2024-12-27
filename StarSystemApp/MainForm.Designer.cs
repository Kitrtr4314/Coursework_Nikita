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
            this.btnAddObject = new System.Windows.Forms.Button();
            this.btnRemoveObject = new System.Windows.Forms.Button();
            this.btnViewInfo = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.ObjectLabel = new System.Windows.Forms.Label();
            this.ListBoxObject = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddObject
            // 
            this.btnAddObject.Location = new System.Drawing.Point(12, 64);
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(200, 40);
            this.btnAddObject.TabIndex = 3;
            this.btnAddObject.Text = "Добавить объект";
            this.btnAddObject.UseVisualStyleBackColor = true;
            this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click);
            // 
            // btnRemoveObject
            // 
            this.btnRemoveObject.Location = new System.Drawing.Point(238, 64);
            this.btnRemoveObject.Name = "btnRemoveObject";
            this.btnRemoveObject.Size = new System.Drawing.Size(200, 40);
            this.btnRemoveObject.TabIndex = 4;
            this.btnRemoveObject.Text = "Удалить объект";
            this.btnRemoveObject.UseVisualStyleBackColor = true;
            this.btnRemoveObject.Click += new System.EventHandler(this.btnRemoveObject_Click);
            // 
            // btnViewInfo
            // 
            this.btnViewInfo.Location = new System.Drawing.Point(12, 138);
            this.btnViewInfo.Name = "btnViewInfo";
            this.btnViewInfo.Size = new System.Drawing.Size(200, 40);
            this.btnViewInfo.TabIndex = 5;
            this.btnViewInfo.Text = "Посмотреть информацию";
            this.btnViewInfo.UseVisualStyleBackColor = true;
            this.btnViewInfo.Click += new System.EventHandler(this.btnViewInfo_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(238, 138);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(200, 40);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // ObjectLabel
            // 
            this.ObjectLabel.Location = new System.Drawing.Point(238, 217);
            this.ObjectLabel.Name = "ObjectLabel";
            this.ObjectLabel.Size = new System.Drawing.Size(200, 84);
            this.ObjectLabel.TabIndex = 7;
            this.ObjectLabel.Text = "Информация ";
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
            this.ListBoxObject.SelectedIndexChanged += new System.EventHandler(this.ListBoxObject_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(450, 499);
            this.Controls.Add(this.ObjectLabel);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnViewInfo);
            this.Controls.Add(this.btnRemoveObject);
            this.Controls.Add(this.btnAddObject);
            this.Controls.Add(this.ListBoxObject);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox ListBoxObject;

        private System.Windows.Forms.Button btnRemoveObject;
        private System.Windows.Forms.Button btnViewInfo;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label ObjectLabel;

        private System.Windows.Forms.Button btnAddObject;

        #endregion
    }
}