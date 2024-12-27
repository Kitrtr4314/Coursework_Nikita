using System.ComponentModel;

namespace StarSystemApp
{
    partial class AddObjectForm
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
            this.GroupBoxObjects = new System.Windows.Forms.GroupBox();
            this.rbMoon = new System.Windows.Forms.RadioButton();
            this.rbPlanet = new System.Windows.Forms.RadioButton();
            this.rbStar = new System.Windows.Forms.RadioButton();
            this.nudLuminosity = new System.Windows.Forms.NumericUpDown();
            this.nudMoonsCount = new System.Windows.Forms.NumericUpDown();
            this.txtPlanetName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblmass = new System.Windows.Forms.Label();
            this.lblDiametr = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLum = new System.Windows.Forms.Label();
            this.lblMoons = new System.Windows.Forms.Label();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.GroupBoxObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuminosity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoonsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxObjects
            // 
            this.GroupBoxObjects.Controls.Add(this.rbMoon);
            this.GroupBoxObjects.Controls.Add(this.rbPlanet);
            this.GroupBoxObjects.Controls.Add(this.rbStar);
            this.GroupBoxObjects.Location = new System.Drawing.Point(33, 84);
            this.GroupBoxObjects.Name = "GroupBoxObjects";
            this.GroupBoxObjects.Size = new System.Drawing.Size(142, 162);
            this.GroupBoxObjects.TabIndex = 0;
            this.GroupBoxObjects.TabStop = false;
            this.GroupBoxObjects.Text = "Тип объекта:";
            // 
            // rbMoon
            // 
            this.rbMoon.Location = new System.Drawing.Point(6, 126);
            this.rbMoon.Name = "rbMoon";
            this.rbMoon.Size = new System.Drawing.Size(110, 30);
            this.rbMoon.TabIndex = 1;
            this.rbMoon.TabStop = true;
            this.rbMoon.Text = "Луна";
            this.rbMoon.UseVisualStyleBackColor = true;
            this.rbMoon.Click += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbPlanet
            // 
            this.rbPlanet.Location = new System.Drawing.Point(6, 71);
            this.rbPlanet.Name = "rbPlanet";
            this.rbPlanet.Size = new System.Drawing.Size(110, 30);
            this.rbPlanet.TabIndex = 2;
            this.rbPlanet.TabStop = true;
            this.rbPlanet.Text = "Планета";
            this.rbPlanet.UseVisualStyleBackColor = true;
            this.rbPlanet.Click += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbStar
            // 
            this.rbStar.Location = new System.Drawing.Point(6, 24);
            this.rbStar.Name = "rbStar";
            this.rbStar.Size = new System.Drawing.Size(110, 30);
            this.rbStar.TabIndex = 1;
            this.rbStar.TabStop = true;
            this.rbStar.Text = "Звезда";
            this.rbStar.UseVisualStyleBackColor = true;
            this.rbStar.Click += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // nudLuminosity
            // 
            this.nudLuminosity.Location = new System.Drawing.Point(251, 270);
            this.nudLuminosity.Name = "nudLuminosity";
            this.nudLuminosity.Size = new System.Drawing.Size(120, 22);
            this.nudLuminosity.TabIndex = 9;
            // 
            // nudMoonsCount
            // 
            this.nudMoonsCount.Location = new System.Drawing.Point(251, 319);
            this.nudMoonsCount.Name = "nudMoonsCount";
            this.nudMoonsCount.Size = new System.Drawing.Size(120, 22);
            this.nudMoonsCount.TabIndex = 10;
            // 
            // txtPlanetName
            // 
            this.txtPlanetName.Location = new System.Drawing.Point(251, 368);
            this.txtPlanetName.Name = "txtPlanetName";
            this.txtPlanetName.Size = new System.Drawing.Size(120, 22);
            this.txtPlanetName.TabIndex = 11;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(33, 447);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Создать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(309, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(356, 218);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(82, 22);
            this.txtAge.TabIndex = 13;
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(356, 163);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(82, 22);
            this.txtDiameter.TabIndex = 14;
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(356, 112);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(82, 22);
            this.txtMass.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(204, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(111, 22);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 17);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Название объекта";
            // 
            // lblmass
            // 
            this.lblmass.Location = new System.Drawing.Point(204, 112);
            this.lblmass.Name = "lblmass";
            this.lblmass.Size = new System.Drawing.Size(146, 22);
            this.lblmass.TabIndex = 17;
            this.lblmass.Text = "Масса(в кг):";
            // 
            // lblDiametr
            // 
            this.lblDiametr.Location = new System.Drawing.Point(204, 163);
            this.lblDiametr.Name = "lblDiametr";
            this.lblDiametr.Size = new System.Drawing.Size(146, 22);
            this.lblDiametr.TabIndex = 18;
            this.lblDiametr.Text = "Диаметр(в км):";
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(204, 218);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(146, 22);
            this.lblAge.TabIndex = 19;
            this.lblAge.Text = "Возраст(в млн лет):";
            // 
            // lblLum
            // 
            this.lblLum.Location = new System.Drawing.Point(33, 270);
            this.lblLum.Name = "lblLum";
            this.lblLum.Size = new System.Drawing.Size(160, 22);
            this.lblLum.TabIndex = 20;
            this.lblLum.Text = "Светимость:";
            // 
            // lblMoons
            // 
            this.lblMoons.Location = new System.Drawing.Point(33, 319);
            this.lblMoons.Name = "lblMoons";
            this.lblMoons.Size = new System.Drawing.Size(160, 22);
            this.lblMoons.TabIndex = 21;
            this.lblMoons.Text = "Количество лун:";
            // 
            // lblPlanet
            // 
            this.lblPlanet.Location = new System.Drawing.Point(33, 368);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(160, 22);
            this.lblPlanet.TabIndex = 22;
            this.lblPlanet.Text = "Планета:";
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(450, 499);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.lblMoons);
            this.Controls.Add(this.lblLum);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDiametr);
            this.Controls.Add(this.lblmass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.txtPlanetName);
            this.Controls.Add(this.nudMoonsCount);
            this.Controls.Add(this.nudLuminosity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.GroupBoxObjects);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AddObjectForm";
            this.GroupBoxObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLuminosity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoonsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblDiametr;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLum;
        private System.Windows.Forms.Label lblMoons;
        private System.Windows.Forms.Label lblPlanet;

        private System.Windows.Forms.Label lblmass;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDiameter;

        private System.Windows.Forms.TextBox txtPlanetName;

        private System.Windows.Forms.NumericUpDown nudLuminosity;
        private System.Windows.Forms.NumericUpDown nudMoonsCount;

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.GroupBox GroupBoxObjects;
        private System.Windows.Forms.RadioButton rbStar;
        private System.Windows.Forms.RadioButton rbPlanet;
        private System.Windows.Forms.RadioButton rbMoon;

        #endregion
    }
}