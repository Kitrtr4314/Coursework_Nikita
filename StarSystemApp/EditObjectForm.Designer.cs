using System.ComponentModel;

namespace StarSystemApp
{
    partial class EditObjectForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtPlanetName = new System.Windows.Forms.TextBox();
            this.nudLuminosity = new System.Windows.Forms.NumericUpDown();
            this.nudMoonsCount = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.TxtLum = new System.Windows.Forms.TextBox();
            this.txtMoons = new System.Windows.Forms.TextBox();
            this.txtPlanet = new System.Windows.Forms.TextBox();
            this.TextBoxAge = new System.Windows.Forms.TextBox();
            this.TextBoxDiametr = new System.Windows.Forms.TextBox();
            this.textboxMass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuminosity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoonsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(135, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название объекта:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(149, 70);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(220, 22);
            this.txtMass.TabIndex = 2;
            this.txtMass.TextChanged += new System.EventHandler(this.txtMass_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(149, 170);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(220, 22);
            this.txtAge.TabIndex = 3;
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(149, 120);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(220, 22);
            this.txtDiameter.TabIndex = 4;
            // 
            // txtPlanetName
            // 
            this.txtPlanetName.Location = new System.Drawing.Point(149, 320);
            this.txtPlanetName.Name = "txtPlanetName";
            this.txtPlanetName.Size = new System.Drawing.Size(220, 22);
            this.txtPlanetName.TabIndex = 7;
            // 
            // nudLuminosity
            // 
            this.nudLuminosity.Location = new System.Drawing.Point(149, 220);
            this.nudLuminosity.Name = "nudLuminosity";
            this.nudLuminosity.Size = new System.Drawing.Size(120, 22);
            this.nudLuminosity.TabIndex = 5;
            // 
            // nudMoonsCount
            // 
            this.nudMoonsCount.Location = new System.Drawing.Point(149, 270);
            this.nudMoonsCount.Name = "nudMoonsCount";
            this.nudMoonsCount.Size = new System.Drawing.Size(120, 22);
            this.nudMoonsCount.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(15, 370);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Сохранить";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TxtLum
            // 
            this.TxtLum.Location = new System.Drawing.Point(15, 220);
            this.TxtLum.Name = "TxtLum";
            this.TxtLum.Size = new System.Drawing.Size(120, 22);
            this.TxtLum.TabIndex = 10;
            this.TxtLum.Text = "Светимость:";
            // 
            // txtMoons
            // 
            this.txtMoons.Location = new System.Drawing.Point(15, 270);
            this.txtMoons.Name = "txtMoons";
            this.txtMoons.Size = new System.Drawing.Size(120, 22);
            this.txtMoons.TabIndex = 11;
            this.txtMoons.Text = "Количество лун:";
            // 
            // txtPlanet
            // 
            this.txtPlanet.Location = new System.Drawing.Point(15, 320);
            this.txtPlanet.Name = "txtPlanet";
            this.txtPlanet.Size = new System.Drawing.Size(120, 22);
            this.txtPlanet.TabIndex = 12;
            this.txtPlanet.Text = "Планета:";
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.Location = new System.Drawing.Point(15, 176);
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.Size = new System.Drawing.Size(120, 22);
            this.TextBoxAge.TabIndex = 15;
            this.TextBoxAge.Text = "Возраст:";
            // 
            // TextBoxDiametr
            // 
            this.TextBoxDiametr.Location = new System.Drawing.Point(15, 121);
            this.TextBoxDiametr.Name = "TextBoxDiametr";
            this.TextBoxDiametr.Size = new System.Drawing.Size(120, 22);
            this.TextBoxDiametr.TabIndex = 14;
            this.TextBoxDiametr.Text = "Диаметр:";
            // 
            // textboxMass
            // 
            this.textboxMass.Location = new System.Drawing.Point(15, 70);
            this.textboxMass.Name = "textboxMass";
            this.textboxMass.Size = new System.Drawing.Size(120, 22);
            this.textboxMass.TabIndex = 13;
            this.textboxMass.Text = "Масса:";
            // 
            // EditObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 418);
            this.Controls.Add(this.TextBoxAge);
            this.Controls.Add(this.TextBoxDiametr);
            this.Controls.Add(this.textboxMass);
            this.Controls.Add(this.txtPlanet);
            this.Controls.Add(this.txtMoons);
            this.Controls.Add(this.TxtLum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudMoonsCount);
            this.Controls.Add(this.nudLuminosity);
            this.Controls.Add(this.txtPlanetName);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "EditObjectForm";
            this.Text = "Редактировать объект";
            ((System.ComponentModel.ISupportInitialize)(this.nudLuminosity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoonsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox TextBoxAge;
        private System.Windows.Forms.TextBox TextBoxDiametr;
        private System.Windows.Forms.TextBox textboxMass;

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.TextBox txtPlanetName;
        private System.Windows.Forms.NumericUpDown nudLuminosity;
        private System.Windows.Forms.NumericUpDown nudMoonsCount;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox TxtLum;
        private System.Windows.Forms.TextBox txtMoons;
        private System.Windows.Forms.TextBox txtPlanet;
    }
}
