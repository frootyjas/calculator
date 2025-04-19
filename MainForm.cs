namespace windows_forms_calculator
{
    public partial class MainForm : Form
    {
        private readonly CalculatorEngine calculator = new();

        public MainForm()
        {
            InitializeComponent();
            WireUpEvents();
            SetupKeyboardSupport();
        }

        private void WireUpEvents()
        {
            // Wire up number buttons
            btnZero.Click += Digit_Click;
            btnOne.Click += Digit_Click;
            btnTwo.Click += Digit_Click;
            btnThree.Click += Digit_Click;
            btnFour.Click += Digit_Click;
            btnFive.Click += Digit_Click;
            btnSix.Click += Digit_Click;
            btnSeven.Click += Digit_Click;
            btnEight.Click += Digit_Click;
            btnNine.Click += Digit_Click;

            // Wire up operator buttons
            addBtn.Click += Operator_Click;
            subtractBtn.Click += Operator_Click;
            multiplyBtn.Click += Operator_Click;
            divideBtn.Click += Operator_Click;

            // Special buttons
            btnDecimal.Click += Decimal_Click;
            equalsBtn.Click += Equals_Click;
            btnClear.Click += Clear_Click;

            // Calculator engine events
            calculator.DisplayChanged += UpdateDisplay;
            calculator.HistoryChanged += UpdateHistory;
            calculator.ErrorOccurred += ShowError;
        }

        private void UpdateDisplay(string value) => txtDisplay.Text = value;
        private void UpdateHistory()
        {
            lstHistory.DataSource = null;
            lstHistory.DataSource = calculator.History;
        }

        private void SetupKeyboardSupport()
        {
            KeyPreview = true;
            KeyPress += HandleKeyPress;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            calculator.Clear();
        }

        // Shared button click handlers
        private void Digit_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
                calculator.PressDigit(int.Parse(button.Text));
        }

        private void HandleKeyPress(object? sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar)
            {
                case var c when char.IsDigit(c):
                    calculator.PressDigit(int.Parse(c.ToString()));
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    calculator.PressOperator(e.KeyChar.ToString());
                    break;
                case 'x':
                case 'X':  // Handle keyboard 'x' as multiplication
                    calculator.PressOperator("*");
                    e.Handled = true;
                    break;
                case '.':
                    calculator.PressDecimal();
                    break;
                case '=':
                case '\r':
                    calculator.PressEquals();
                    break;
                case (char)Keys.Escape:
                    calculator.Clear();
                    break;
            }
        }

        private void Operator_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                var op = button.Text switch
                {
                    "÷" => "/",
                    "×" => "*",
                    _ => button.Text
                };

                // Update display before processing operator
                if (!string.IsNullOrEmpty(calculator.CurrentInput))
                {
                    txtDisplay.Text = calculator.CurrentInput;
                }
                calculator.PressOperator(op);
            }
        }

        private void Decimal_Click(object? sender, EventArgs e) => calculator.PressDecimal();
        private void Equals_Click(object? sender, EventArgs e)
        {
            // Force UI update before calculation
            txtDisplay.Text = calculator.CurrentInput;
            calculator.PressEquals();
        }
        private void Clear_Click(object? sender, EventArgs e) => calculator.Clear();
    }
}
