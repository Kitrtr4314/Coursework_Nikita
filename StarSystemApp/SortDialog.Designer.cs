using System.ComponentModel;

namespace StarSystemApp
{
    partial class SortDialog
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.RadioButton radioAscending;
            this.labelInstruction = new System.Windows.Forms.Label();
            this.radioMass = new System.Windows.Forms.RadioButton();
            this.radioDiameter = new System.Windows.Forms.RadioButton();
            this.radioAge = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDescending = new System.Windows.Forms.RadioButton();
            radioAscending = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioAscending
            // 
            radioAscending.AutoSize = true;
            radioAscending.Location = new System.Drawing.Point(19, 40);
            radioAscending.Name = "radioAscending";
            radioAscending.Size = new System.Drawing.Size(137, 21);
            radioAscending.TabIndex = 2;
            radioAscending.TabStop = true;
            radioAscending.Text = "По возрастанию";
            radioAscending.UseVisualStyleBackColor = true;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(12, 9);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(224, 17);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Выберите критерий сортировки:";
            // 
            // radioMass
            // 
            this.radioMass.AutoSize = true;
            this.radioMass.Location = new System.Drawing.Point(15, 40);
            this.radioMass.Name = "radioMass";
            this.radioMass.Size = new System.Drawing.Size(70, 21);
            this.radioMass.TabIndex = 1;
            this.radioMass.TabStop = true;
            this.radioMass.Text = "Масса";
            this.radioMass.UseVisualStyleBackColor = true;
            // 
            // radioDiameter
            // 
            this.radioDiameter.AutoSize = true;
            this.radioDiameter.Location = new System.Drawing.Point(15, 70);
            this.radioDiameter.Name = "radioDiameter";
            this.radioDiameter.Size = new System.Drawing.Size(88, 21);
            this.radioDiameter.TabIndex = 2;
            this.radioDiameter.TabStop = true;
            this.radioDiameter.Text = "Диаметр";
            this.radioDiameter.UseVisualStyleBackColor = true;
            // 
            // radioAge
            // 
            this.radioAge.AutoSize = true;
            this.radioAge.Location = new System.Drawing.Point(15, 100);
            this.radioAge.Name = "radioAge";
            this.radioAge.Size = new System.Drawing.Size(83, 21);
            this.radioAge.TabIndex = 3;
            this.radioAge.TabStop = true;
            this.radioAge.Text = "Возраст";
            this.radioAge.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(15, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 30);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDescending);
            this.groupBox1.Controls.Add(radioAscending);
            this.groupBox1.Location = new System.Drawing.Point(201, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите способ сортировки";
            // 
            // radioDescending
            // 
            this.radioDescending.AutoSize = true;
            this.radioDescending.Location = new System.Drawing.Point(19, 85);
            this.radioDescending.Name = "radioDescending";
            this.radioDescending.Size = new System.Drawing.Size(117, 21);
            this.radioDescending.TabIndex = 3;
            this.radioDescending.TabStop = true;
            this.radioDescending.Text = "По убыванию";
            this.radioDescending.UseVisualStyleBackColor = true;
            // 
            // SortDialog
            // 
            this.ClientSize = new System.Drawing.Size(462, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioAge);
            this.Controls.Add(this.radioDiameter);
            this.Controls.Add(this.radioMass);
            this.Controls.Add(this.labelInstruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SortDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сортировка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton radioAscending;
        private System.Windows.Forms.RadioButton radioDescending;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.RadioButton radioMass;
        private System.Windows.Forms.RadioButton radioDiameter;
        private System.Windows.Forms.RadioButton radioAge;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
