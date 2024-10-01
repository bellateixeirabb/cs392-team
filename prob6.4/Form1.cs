namespace prob6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Constants for service charges
        private const decimal OilChange = 50.00m;
        private const decimal LubeJob = 40.00m;
        private const decimal RadiatorFlush = 100.00m;
        private const decimal TransmissionFlush = 120.00m;
        private const decimal Inspection = 35.00m;
        private const decimal MufflerReplacement = 150.00m;
        private const decimal TireRotation = 25.00m;
        private const decimal TaxRate = 0.07m;
        private const decimal LaborRate = 75.00m;

        // Method to get the charge for the oil change
        private decimal GetOilChange()
        {
            if (checkOil.Checked)
                return OilChange;
            else
                return 0;
        }

        // Method to get the charge for the lube job
        private decimal GetLubeJob()
        {
           if (checkLube.Checked)
                return LubeJob;
            else
                return 0;
        }

        // Method to get the charge for the radiator flush
        private decimal GetRadiatorFlush()
        {
            if (checkRadiator.Checked)
                return RadiatorFlush;
            else
                return 0;
        }

        // Method to get the charge for the transmission flush
        private decimal GetTransmissionFlush()
        {
            if (checkTransmission.Checked)
                return TransmissionFlush;
            else
                return 0;
        }

        // Method to get the charge for the inspection
        private decimal GetInspection()
        {
            if (checkInspection.Checked)
                return Inspection;
            else
                return 0;
        }

        // Method to get the charge for the muffler replacement
        private decimal GetMufflerReplacement()
        {
            if (checkMuffler.Checked)
                return MufflerReplacement;
            else
                return 0;
        }

        // Method to get the charge for the tire rotation
        private decimal GetTireRotation()
        {
            if (checkTire.Checked)
                return TireRotation;
            else
                return 0;
        }

        // Method to get the charge for parts 
        private decimal GetParts()
        {
            decimal parts = 0;
            if (decimal.TryParse(txtParts.Text, out parts))
            {
                return parts;
            }
            else
            {
                return 0;
            }
        }

        // Method to get the charge for labor
        private decimal GetLabor()
        {
            decimal labor = 0;
            if (decimal.TryParse(txtLabor.Text, out labor))
            {
                return labor * LaborRate;
            }
            else
            {
                return 0;
            }
        }

        // Method to get the tax amount
        private decimal GetTax()
        {
            return GetParts() * TaxRate;
        }

        // Method to get the total charges
        private decimal GetTotal()
        {
            decimal total = 0;
            total += GetOilChange();
            total += GetLubeJob();
            total += GetRadiatorFlush();
            total += GetTransmissionFlush();
            total += GetInspection();
            total += GetMufflerReplacement();
            total += GetTireRotation();
            total += GetParts();
            total += GetLabor();
            total += GetTax();
            return total;
        }

        // Method to calculate the total cost of the charges
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            txtService.Text = (GetParts() + GetLabor()).ToString("c");
            txtParts2.Text = GetParts().ToString("c");
            txtTax.Text = GetTax().ToString("c");
            txtTotal.Text = GetTotal().ToString("c");
        }

        // Method to clear the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            checkOil.Checked = false;
            checkLube.Checked = false;
            checkRadiator.Checked = false;
            checkTransmission.Checked = false;
            checkInspection.Checked = false;
            checkMuffler.Checked = false;
            checkTire.Checked = false;
            txtParts.Text = "";
            txtLabor.Text = "";
            txtTotal.Text = "";
            txtService.Text = "";
            txtParts2.Text = "";
            txtTax.Text = "";
        }

        // Method to exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
