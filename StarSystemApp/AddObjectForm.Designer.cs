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
            this.textboxMass = new System.Windows.Forms.TextBox();
            this.TextBoxDiametr = new System.Windows.Forms.TextBox();
            this.TextBoxAge = new System.Windows.Forms.TextBox();
            this.TxtLum = new System.Windows.Forms.TextBox();
            this.txtMoons = new System.Windows.Forms.TextBox();
            this.txtPlanet = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudLuminosity = new System.Windows.Forms.NumericUpDown();
            this.nudMoonsCount = new System.Windows.Forms.NumericUpDown();
            this.txtPlanetName = new System.Windows.Forms.TextBox();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDiametr = new System.Windows.Forms.TextBox();
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
            this.GroupBoxObjects.Location = new System.Drawing.Point(33, 44);
            this.GroupBoxObjects.Name = "GroupBoxObjects";
            this.GroupBoxObjects.Size = new System.Drawing.Size(142, 175);
            this.GroupBoxObjects.TabIndex = 0;
            this.GroupBoxObjects.TabStop = false;
            this.GroupBoxObjects.Text = "Тип объекта:";
            // 
            // rbMoon
            // 
            this.rbMoon.Location = new System.Drawing.Point(6, 104);
            this.rbMoon.Name = "rbMoon";
            this.rbMoon.Size = new System.Drawing.Size(110, 30);
            this.rbMoon.TabIndex = 1;
            this.rbMoon.TabStop = true;
            this.rbMoon.Text = "Луна";
            this.rbMoon.UseVisualStyleBackColor = true;
            this.rbMoon.CheckedChanged += new System.EventHandler(this.RadioButtonMoon_CheckedChanged);
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
            // 
            // rbStar
            // 
            this.rbStar.Location = new System.Drawing.Point(6, 36);
            this.rbStar.Name = "rbStar";
            this.rbStar.Size = new System.Drawing.Size(110, 30);
            this.rbStar.TabIndex = 1;
            this.rbStar.TabStop = true;
            this.rbStar.Text = "Звезда";
            this.rbStar.UseVisualStyleBackColor = true;
            this.rbStar.CheckedChanged += new System.EventHandler(this.ButtonStar_CheckedChanged);
            // 
            // textboxMass
            // 
            this.textboxMass.Location = new System.Drawing.Point(195, 44);
            this.textboxMass.Name = "textboxMass";
            this.textboxMass.Size = new System.Drawing.Size(120, 22);
            this.textboxMass.TabIndex = 1;
            this.textboxMass.Text = "Масса:";
            this.textboxMass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBoxDiametr
            // 
            this.TextBoxDiametr.Location = new System.Drawing.Point(195, 88);
            this.TextBoxDiametr.Name = "TextBoxDiametr";
            this.TextBoxDiametr.Size = new System.Drawing.Size(120, 22);
            this.TextBoxDiametr.TabIndex = 2;
            this.TextBoxDiametr.Text = "Диаметр:";
            this.TextBoxDiametr.TextChanged += new System.EventHandler(this.TextBoxDiametr_TextChanged);
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.Location = new System.Drawing.Point(195, 133);
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.Size = new System.Drawing.Size(120, 22);
            this.TextBoxAge.TabIndex = 3;
            this.TextBoxAge.Text = "Возраст:";
            // 
            // TxtLum
            // 
            this.TxtLum.Location = new System.Drawing.Point(33, 244);
            this.TxtLum.Name = "TxtLum";
            this.TxtLum.Size = new System.Drawing.Size(160, 22);
            this.TxtLum.TabIndex = 4;
            this.TxtLum.Text = "Светимость:";
            // 
            // txtMoons
            // 
            this.txtMoons.Location = new System.Drawing.Point(33, 288);
            this.txtMoons.Name = "txtMoons";
            this.txtMoons.Size = new System.Drawing.Size(160, 22);
            this.txtMoons.TabIndex = 5;
            this.txtMoons.Text = "Количество лун:";
            // 
            // txtPlanet
            // 
            this.txtPlanet.Location = new System.Drawing.Point(33, 335);
            this.txtPlanet.Name = "txtPlanet";
            this.txtPlanet.Size = new System.Drawing.Size(160, 22);
            this.txtPlanet.TabIndex = 6;
            this.txtPlanet.Text = "Планета:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(33, 447);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Создать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnCreate_Click);
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
            // nudLuminosity
            // 
            this.nudLuminosity.Location = new System.Drawing.Point(232, 244);
            this.nudLuminosity.Name = "nudLuminosity";
            this.nudLuminosity.Size = new System.Drawing.Size(120, 22);
            this.nudLuminosity.TabIndex = 9;
            // 
            // nudMoonsCount
            // 
            this.nudMoonsCount.Location = new System.Drawing.Point(232, 288);
            this.nudMoonsCount.Name = "nudMoonsCount";
            this.nudMoonsCount.Size = new System.Drawing.Size(120, 22);
            this.nudMoonsCount.TabIndex = 10;
            // 
            // txtPlanetName
            // 
            this.txtPlanetName.Location = new System.Drawing.Point(232, 335);
            this.txtPlanetName.Name = "txtPlanetName";
            this.txtPlanetName.Size = new System.Drawing.Size(120, 22);
            this.txtPlanetName.TabIndex = 11;
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(346, 44);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(82, 22);
            this.txtMass.TabIndex = 12;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(346, 133);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(82, 22);
            this.txtAge.TabIndex = 13;
            // 
            // txtDiametr
            // 
            this.txtDiametr.Location = new System.Drawing.Point(346, 84);
            this.txtDiametr.Name = "txtDiametr";
            this.txtDiametr.Size = new System.Drawing.Size(82, 22);
            this.txtDiametr.TabIndex = 14;
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 499);
            this.Controls.Add(this.txtDiametr);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.txtPlanetName);
            this.Controls.Add(this.nudMoonsCount);
            this.Controls.Add(this.nudLuminosity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPlanet);
            this.Controls.Add(this.txtMoons);
            this.Controls.Add(this.TxtLum);
            this.Controls.Add(this.TextBoxAge);
            this.Controls.Add(this.TextBoxDiametr);
            this.Controls.Add(this.textboxMass);
            this.Controls.Add(this.GroupBoxObjects);
            this.Name = "AddObjectForm";
            this.Text = "AddObjectForm";
            this.GroupBoxObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLuminosity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoonsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDiametr;

        private System.Windows.Forms.TextBox txtPlanetName;

        private System.Windows.Forms.NumericUpDown nudLuminosity;
        private System.Windows.Forms.NumericUpDown nudMoonsCount;

        private System.Windows.Forms.TextBox TxtLum;
        private System.Windows.Forms.TextBox txtMoons;
        private System.Windows.Forms.TextBox txtPlanet;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.TextBox textboxMass;
        private System.Windows.Forms.TextBox TextBoxAge;

        private System.Windows.Forms.TextBox TextBoxDiametr;

        private System.Windows.Forms.GroupBox GroupBoxObjects;
        private System.Windows.Forms.RadioButton rbStar;
        private System.Windows.Forms.RadioButton rbPlanet;
        private System.Windows.Forms.RadioButton rbMoon;

        #endregion
    }
}