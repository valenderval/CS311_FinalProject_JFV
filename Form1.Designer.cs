namespace CS311_FinalProject_JFV
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rdoMeterToFeet = new RadioButton();
            rdoFeetToMeters = new RadioButton();
            gboCoversionOptions = new GroupBox();
            rdoOuncesToGrams = new RadioButton();
            rdoGramsToOunces = new RadioButton();
            rdoPoundsToKilograms = new RadioButton();
            rdoKiloToPounds = new RadioButton();
            rdoCelsiusToFahrenheit = new RadioButton();
            rdoFahrenheitToCelsius = new RadioButton();
            rdoMToKm = new RadioButton();
            rdoKmToM = new RadioButton();
            txtInput = new TextBox();
            lblConversion = new Label();
            btnConvert = new Button();
            gboCoversionOptions.SuspendLayout();
            SuspendLayout();
            // 
            // rdoMeterToFeet
            // 
            rdoMeterToFeet.AutoSize = true;
            rdoMeterToFeet.Location = new Point(6, 47);
            rdoMeterToFeet.Name = "rdoMeterToFeet";
            rdoMeterToFeet.Size = new Size(125, 24);
            rdoMeterToFeet.TabIndex = 0;
            rdoMeterToFeet.TabStop = true;
            rdoMeterToFeet.Text = "Meters to Feet";
            rdoMeterToFeet.UseVisualStyleBackColor = true;
            // 
            // rdoFeetToMeters
            // 
            rdoFeetToMeters.AutoSize = true;
            rdoFeetToMeters.Location = new Point(185, 47);
            rdoFeetToMeters.Name = "rdoFeetToMeters";
            rdoFeetToMeters.Size = new Size(125, 24);
            rdoFeetToMeters.TabIndex = 1;
            rdoFeetToMeters.TabStop = true;
            rdoFeetToMeters.Text = "Feet to Meters";
            rdoFeetToMeters.UseVisualStyleBackColor = true;
            // 
            // gboCoversionOptions
            // 
            gboCoversionOptions.Controls.Add(rdoOuncesToGrams);
            gboCoversionOptions.Controls.Add(rdoGramsToOunces);
            gboCoversionOptions.Controls.Add(rdoPoundsToKilograms);
            gboCoversionOptions.Controls.Add(rdoKiloToPounds);
            gboCoversionOptions.Controls.Add(rdoCelsiusToFahrenheit);
            gboCoversionOptions.Controls.Add(rdoFahrenheitToCelsius);
            gboCoversionOptions.Controls.Add(rdoMToKm);
            gboCoversionOptions.Controls.Add(rdoMeterToFeet);
            gboCoversionOptions.Controls.Add(rdoFeetToMeters);
            gboCoversionOptions.Controls.Add(rdoKmToM);
            gboCoversionOptions.Font = new Font("Segoe UI", 9F);
            gboCoversionOptions.Location = new Point(25, 42);
            gboCoversionOptions.Name = "gboCoversionOptions";
            gboCoversionOptions.Size = new Size(360, 340);
            gboCoversionOptions.TabIndex = 2;
            gboCoversionOptions.TabStop = false;
            gboCoversionOptions.Text = "Select Your Conversion!";
            // 
            // rdoOuncesToGrams
            // 
            rdoOuncesToGrams.AutoSize = true;
            rdoOuncesToGrams.Location = new Point(185, 252);
            rdoOuncesToGrams.Name = "rdoOuncesToGrams";
            rdoOuncesToGrams.Size = new Size(142, 24);
            rdoOuncesToGrams.TabIndex = 7;
            rdoOuncesToGrams.TabStop = true;
            rdoOuncesToGrams.Text = "Ounces to Grams";
            rdoOuncesToGrams.UseVisualStyleBackColor = true;
            // 
            // rdoGramsToOunces
            // 
            rdoGramsToOunces.AutoSize = true;
            rdoGramsToOunces.Location = new Point(6, 252);
            rdoGramsToOunces.Name = "rdoGramsToOunces";
            rdoGramsToOunces.Size = new Size(142, 24);
            rdoGramsToOunces.TabIndex = 6;
            rdoGramsToOunces.TabStop = true;
            rdoGramsToOunces.Text = "Grams to Ounces";
            rdoGramsToOunces.UseVisualStyleBackColor = true;
            // 
            // rdoPoundsToKilograms
            // 
            rdoPoundsToKilograms.AutoSize = true;
            rdoPoundsToKilograms.Location = new Point(185, 203);
            rdoPoundsToKilograms.Name = "rdoPoundsToKilograms";
            rdoPoundsToKilograms.Size = new Size(166, 24);
            rdoPoundsToKilograms.TabIndex = 5;
            rdoPoundsToKilograms.TabStop = true;
            rdoPoundsToKilograms.Text = "Pounds to Kilograms";
            rdoPoundsToKilograms.UseVisualStyleBackColor = true;
            // 
            // rdoKiloToPounds
            // 
            rdoKiloToPounds.AutoSize = true;
            rdoKiloToPounds.Location = new Point(6, 203);
            rdoKiloToPounds.Name = "rdoKiloToPounds";
            rdoKiloToPounds.Size = new Size(166, 24);
            rdoKiloToPounds.TabIndex = 4;
            rdoKiloToPounds.TabStop = true;
            rdoKiloToPounds.Text = "Kilograms to Pounds";
            rdoKiloToPounds.UseVisualStyleBackColor = true;
            // 
            // rdoCelsiusToFahrenheit
            // 
            rdoCelsiusToFahrenheit.AutoSize = true;
            rdoCelsiusToFahrenheit.Location = new Point(185, 152);
            rdoCelsiusToFahrenheit.Name = "rdoCelsiusToFahrenheit";
            rdoCelsiusToFahrenheit.Size = new Size(165, 24);
            rdoCelsiusToFahrenheit.TabIndex = 3;
            rdoCelsiusToFahrenheit.TabStop = true;
            rdoCelsiusToFahrenheit.Text = "Celsius to Fahrenheit";
            rdoCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rdoFahrenheitToCelsius
            // 
            rdoFahrenheitToCelsius.AutoSize = true;
            rdoFahrenheitToCelsius.Location = new Point(6, 152);
            rdoFahrenheitToCelsius.Name = "rdoFahrenheitToCelsius";
            rdoFahrenheitToCelsius.Size = new Size(165, 24);
            rdoFahrenheitToCelsius.TabIndex = 2;
            rdoFahrenheitToCelsius.TabStop = true;
            rdoFahrenheitToCelsius.Text = "Fahrenheit to Celsius";
            rdoFahrenheitToCelsius.UseVisualStyleBackColor = true;
            // 
            // rdoMToKm
            // 
            rdoMToKm.AutoSize = true;
            rdoMToKm.Location = new Point(185, 99);
            rdoMToKm.Name = "rdoMToKm";
            rdoMToKm.Size = new Size(158, 24);
            rdoMToKm.TabIndex = 1;
            rdoMToKm.TabStop = true;
            rdoMToKm.Text = "Miles to Kilometers";
            rdoMToKm.UseVisualStyleBackColor = true;
            // 
            // rdoKmToM
            // 
            rdoKmToM.AutoSize = true;
            rdoKmToM.Location = new Point(6, 99);
            rdoKmToM.Name = "rdoKmToM";
            rdoKmToM.Size = new Size(158, 24);
            rdoKmToM.TabIndex = 0;
            rdoKmToM.TabStop = true;
            rdoKmToM.Text = "Kilometers to Miles";
            rdoKmToM.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(400, 89);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Type number to convert here";
            txtInput.Size = new Size(201, 27);
            txtInput.TabIndex = 4;
            // 
            // lblConversion
            // 
            lblConversion.AutoSize = true;
            lblConversion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConversion.Location = new Point(400, 255);
            lblConversion.Name = "lblConversion";
            lblConversion.Size = new Size(121, 38);
            lblConversion.TabIndex = 5;
            lblConversion.Text = "Result : ";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(505, 175);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(179, 29);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "Click to Convert!";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvert);
            Controls.Add(lblConversion);
            Controls.Add(txtInput);
            Controls.Add(gboCoversionOptions);
            Name = "FrmMain";
            Text = "Conversions";
            Load += Form1_Load;
            gboCoversionOptions.ResumeLayout(false);
            gboCoversionOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdoMeterToFeet;
        private RadioButton rdoFeetToMeters;
        private GroupBox gboCoversionOptions;
        private RadioButton rdoMToKm;
        private RadioButton rdoKmToM;
        private TextBox txtInput;
        private Label lblConversion;
        private Button btnConvert;
        private RadioButton rdoFahrenheitToCelsius;
        private RadioButton rdoCelsiusToFahrenheit;
        private RadioButton rdoKiloToPounds;
        private RadioButton rdoOuncesToGrams;
        private RadioButton rdoGramsToOunces;
        private RadioButton rdoPoundsToKilograms;
    }
}
