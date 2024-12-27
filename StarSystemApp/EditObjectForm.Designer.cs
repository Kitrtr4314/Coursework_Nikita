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
            this.lblmass = new System.Windows.Forms.Label();
            this.lblDiametr = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLum = new System.Windows.Forms.Label();
            this.lblMoons = new System.Windows.Forms.Label();
            this.lblPlanet = new System.Windows.Forms.Label();
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
            this.txtName.Location = new System.Drawing.Point(236, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(236, 70);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(133, 22);
            this.txtMass.TabIndex = 2;
            this.txtMass.TextChanged += new System.EventHandler(this.txtMass_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(236, 170);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(133, 22);
            this.txtAge.TabIndex = 3;
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(236, 120);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(133, 22);
            this.txtDiameter.TabIndex = 4;
            // 
            // txtPlanetName
            // 
            this.txtPlanetName.Location = new System.Drawing.Point(236, 320);
            this.txtPlanetName.Name = "txtPlanetName";
            this.txtPlanetName.Size = new System.Drawing.Size(133, 22);
            this.txtPlanetName.TabIndex = 7;
            // 
            // nudLuminosity
            // 
            this.nudLuminosity.Location = new System.Drawing.Point(236, 218);
            this.nudLuminosity.Name = "nudLuminosity";
            this.nudLuminosity.Size = new System.Drawing.Size(133, 22);
            this.nudLuminosity.TabIndex = 5;
            // 
            // nudMoonsCount
            // 
            this.nudMoonsCount.Location = new System.Drawing.Point(236, 264);
            this.nudMoonsCount.Name = "nudMoonsCount";
            this.nudMoonsCount.Size = new System.Drawing.Size(133, 22);
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
            // lblmass
            // 
            this.lblmass.Location = new System.Drawing.Point(15, 70);
            this.lblmass.Name = "lblmass";
            this.lblmass.Size = new System.Drawing.Size(146, 22);
            this.lblmass.TabIndex = 18;
            this.lblmass.Text = "Масса(в кг):";
            this.lblmass.Click += new System.EventHandler(this.lblmass_Click);
            // 
            // lblDiametr
            // 
            this.lblDiametr.Location = new System.Drawing.Point(15, 120);
            this.lblDiametr.Name = "lblDiametr";
            this.lblDiametr.Size = new System.Drawing.Size(146, 22);
            this.lblDiametr.TabIndex = 19;
            this.lblDiametr.Text = "Диаметр(в км):";
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(15, 170);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(146, 22);
            this.lblAge.TabIndex = 20;
            this.lblAge.Text = "Возраст(в млн лет):";
            // 
            // lblLum
            // 
            this.lblLum.Location = new System.Drawing.Point(12, 218);
            this.lblLum.Name = "lblLum";
            this.lblLum.Size = new System.Drawing.Size(160, 22);
            this.lblLum.TabIndex = 21;
            this.lblLum.Text = "Светимость:";
            // 
            // lblMoons
            // 
            this.lblMoons.Location = new System.Drawing.Point(12, 264);
            this.lblMoons.Name = "lblMoons";
            this.lblMoons.Size = new System.Drawing.Size(160, 22);
            this.lblMoons.TabIndex = 22;
            this.lblMoons.Text = "Количество лун:";
            // 
            // lblPlanet
            // 
            this.lblPlanet.Location = new System.Drawing.Point(15, 320);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(160, 22);
            this.lblPlanet.TabIndex = 23;
            this.lblPlanet.Text = "Планета:";
            // 
            // EditObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 418);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.lblMoons);
            this.Controls.Add(this.lblLum);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDiametr);
            this.Controls.Add(this.lblmass);
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

        private System.Windows.Forms.Label lblPlanet;

        private System.Windows.Forms.Label lblMoons;

        private System.Windows.Forms.Label lblLum;

        private System.Windows.Forms.Label lblAge;

        private System.Windows.Forms.Label lblDiametr;

        private System.Windows.Forms.Label lblmass;

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
    }
}
