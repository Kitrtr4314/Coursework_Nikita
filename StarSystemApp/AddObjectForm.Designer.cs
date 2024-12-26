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
            this.RadioButtonMoon = new System.Windows.Forms.RadioButton();
            this.RadioButtonPlanet = new System.Windows.Forms.RadioButton();
            this.ButtonStar = new System.Windows.Forms.RadioButton();
            this.TextBoxMass = new System.Windows.Forms.TextBox();
            this.TextBoxDiametr = new System.Windows.Forms.TextBox();
            this.TextBoxAge = new System.Windows.Forms.TextBox();
            this.TxtLum = new System.Windows.Forms.TextBox();
            this.txtMoons = new System.Windows.Forms.TextBox();
            this.txtPlanet = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GroupBoxObjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxObjects
            // 
            this.GroupBoxObjects.Controls.Add(this.RadioButtonMoon);
            this.GroupBoxObjects.Controls.Add(this.RadioButtonPlanet);
            this.GroupBoxObjects.Controls.Add(this.ButtonStar);
            this.GroupBoxObjects.Location = new System.Drawing.Point(33, 44);
            this.GroupBoxObjects.Name = "GroupBoxObjects";
            this.GroupBoxObjects.Size = new System.Drawing.Size(142, 175);
            this.GroupBoxObjects.TabIndex = 0;
            this.GroupBoxObjects.TabStop = false;
            this.GroupBoxObjects.Text = "Тип объекта:";
            // 
            // RadioButtonMoon
            // 
            this.RadioButtonMoon.Location = new System.Drawing.Point(6, 104);
            this.RadioButtonMoon.Name = "RadioButtonMoon";
            this.RadioButtonMoon.Size = new System.Drawing.Size(110, 30);
            this.RadioButtonMoon.TabIndex = 1;
            this.RadioButtonMoon.TabStop = true;
            this.RadioButtonMoon.Text = "Луна";
            this.RadioButtonMoon.UseVisualStyleBackColor = true;
            this.RadioButtonMoon.CheckedChanged += new System.EventHandler(this.RadioButtonMoon_CheckedChanged);
            // 
            // RadioButtonPlanet
            // 
            this.RadioButtonPlanet.Location = new System.Drawing.Point(6, 71);
            this.RadioButtonPlanet.Name = "RadioButtonPlanet";
            this.RadioButtonPlanet.Size = new System.Drawing.Size(110, 30);
            this.RadioButtonPlanet.TabIndex = 2;
            this.RadioButtonPlanet.TabStop = true;
            this.RadioButtonPlanet.Text = "Планета";
            this.RadioButtonPlanet.UseVisualStyleBackColor = true;
            // 
            // ButtonStar
            // 
            this.ButtonStar.Location = new System.Drawing.Point(6, 36);
            this.ButtonStar.Name = "ButtonStar";
            this.ButtonStar.Size = new System.Drawing.Size(110, 30);
            this.ButtonStar.TabIndex = 1;
            this.ButtonStar.TabStop = true;
            this.ButtonStar.Text = "Звезда";
            this.ButtonStar.UseVisualStyleBackColor = true;
            this.ButtonStar.CheckedChanged += new System.EventHandler(this.ButtonStar_CheckedChanged);
            // 
            // TextBoxMass
            // 
            this.TextBoxMass.Location = new System.Drawing.Point(195, 44);
            this.TextBoxMass.Name = "TextBoxMass";
            this.TextBoxMass.Size = new System.Drawing.Size(120, 22);
            this.TextBoxMass.TabIndex = 1;
            this.TextBoxMass.Text = "Масса:";
            this.TextBoxMass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(33, 447);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 30);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 499);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPlanet);
            this.Controls.Add(this.txtMoons);
            this.Controls.Add(this.TxtLum);
            this.Controls.Add(this.TextBoxAge);
            this.Controls.Add(this.TextBoxDiametr);
            this.Controls.Add(this.TextBoxMass);
            this.Controls.Add(this.GroupBoxObjects);
            this.Name = "AddObjectForm";
            this.Text = "AddObjectForm";
            this.GroupBoxObjects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox TxtLum;
        private System.Windows.Forms.TextBox txtMoons;
        private System.Windows.Forms.TextBox txtPlanet;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.TextBox TextBoxMass;
        private System.Windows.Forms.TextBox TextBoxAge;

        private System.Windows.Forms.TextBox TextBoxDiametr;

        private System.Windows.Forms.GroupBox GroupBoxObjects;
        private System.Windows.Forms.RadioButton ButtonStar;
        private System.Windows.Forms.RadioButton RadioButtonPlanet;
        private System.Windows.Forms.RadioButton RadioButtonMoon;

        #endregion
    }
}