namespace CS311_FinalProject_JFV
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnConvert_Click(object sender, EventArgs e)
        {

             convertInput();
        }
        private void convertInput()
          {
              double input;
              if (double.TryParse(txtInput.Text, out input))
              {
                  
                  double result = 0;

                  if (rdoMeterToFeet.Checked)
                  {
                      result = Math.Round(input * 3.2808399,2);
                  }
                  else if (rdoFeetToMeters.Checked)
                  {
                        result = Math.Round(input / 3.2808399,2);
                  }

                  else if (rdoKmToM.Checked)
                  {
                      result = Math.Round(input * 0.621371,2);
                  }
                  else if(rdoMToKm.Checked)
                  {
                        result = Math.Round(input * 1.609344,2);
                  }
               
                  else if (rdoFahrenheitToCelsius.Checked)
                  {
                      result = Math.Round((input - 32) * 5 / 9,2);
                  }
                  else if (rdoCelsiusToFahrenheit.Checked)
                  {
                      result = Math.Round((input * 9 / 5) + 32,2);
                  }

                  else if (rdoKiloToPounds.Checked)
                  {
                    result = Math.Round(input * 2.20462262,2);
                  }
                  else if (rdoPoundsToKilograms.Checked)
                  {
                    result = Math.Round(input / 2.20462262,2);
                  }
                  else if (rdoGramsToOunces.Checked)
                  {
                    result = Math.Round(input / 28.3495231, 2);
                  }
                  else if (rdoOuncesToGrams.Checked)
                  {
                    result = Math.Round(input * 28.3495231,2);
                  }
              
                lblConversion.Text = "Result : " + result.ToString();
                
              }
              else
              {
                  MessageBox.Show("Please enter a valid number.");
              }
        }
    }
}

     
    

