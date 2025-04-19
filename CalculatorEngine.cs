public class CalculatorEngine
{
    public string CurrentInput { get; private set; } = "";
    public double? FirstOperand { get; private set; }
    public string CurrentOperator { get; private set; }
    public List<string> History { get; } = new List<string>();

    public event Action<string> DisplayChanged;
    public event Action HistoryChanged;
    public event Action<string> ErrorOccurred;

    public void PressDigit(int digit)
    {
        CurrentInput += digit;
        DisplayChanged?.Invoke(CurrentInput);
    }

    public void PressOperator(string op)
    {
        try
        {
            // Handle operator changes without second operand
            if (!string.IsNullOrEmpty(CurrentOperator) && string.IsNullOrEmpty(CurrentInput))
            {
                CurrentOperator = op;
                return;
            }

            // Handle new operation after equals
            if (FirstOperand.HasValue && string.IsNullOrEmpty(CurrentInput))
            {
                CurrentOperator = op;
                return;
            }

            // Validate and parse input
            if (string.IsNullOrEmpty(CurrentInput))
            {
                CurrentInput = FirstOperand.HasValue ? FirstOperand.Value.ToString() : "0";
            }

            // Store operands
            if (!FirstOperand.HasValue)
            {
                FirstOperand = double.Parse(CurrentInput);
            }
            else if (!string.IsNullOrEmpty(CurrentOperator))
            {
                // Perform pending operation
                PressEquals();
                FirstOperand = double.Parse(CurrentInput);
            }

            CurrentOperator = op;
            CurrentInput = "";
        }
        catch (Exception ex)
        {
            ErrorOccurred?.Invoke(ex.Message);
            Clear();
        }
    }

    public void PressEquals()
    {
        try
        {
            // Handle empty second operand
            if (string.IsNullOrEmpty(CurrentInput))
            {
                if (!FirstOperand.HasValue) throw new InvalidOperationException("No operation pending");
                CurrentInput = FirstOperand.Value.ToString();
            }

            // Validate operation state
            if (!FirstOperand.HasValue || string.IsNullOrEmpty(CurrentOperator))
                throw new InvalidOperationException("Incomplete operation");

            var secondOperand = double.Parse(CurrentInput);
            var result = Calculate(FirstOperand.Value, secondOperand);

            AddToHistory(result);
            UpdateDisplay(result);
        }
        catch (Exception ex)
        {
            ErrorOccurred?.Invoke(ex.Message);
            Clear();
        }
    }

    public void PressDecimal()
    {
        if (CurrentInput.Contains("."))
        {
            ErrorOccurred?.Invoke("Decimal point already exists!");
            return;
        }

        if (string.IsNullOrEmpty(CurrentInput))
        {
            CurrentInput = "0";
        }

        CurrentInput += ".";
        DisplayChanged?.Invoke(CurrentInput);
    }

   

    private double Calculate(double a, double b) => CurrentOperator switch
    {
        "+" => a + b,
        "-" => a - b,
        "*" => a * b,
        "/" when b != 0 => a / b,
        "/" => throw new DivideByZeroException(),
        _ => throw new InvalidOperationException()
    };

    private void AddToHistory(double result)
    {
        History.Add($"{FirstOperand} {CurrentOperator} {CurrentInput} = {result}");
        HistoryChanged?.Invoke();
    }

    private void UpdateDisplay(double result)
    {
        CurrentInput = result.ToString();
        DisplayChanged?.Invoke(CurrentInput);
        FirstOperand = null;
    }

    public void Clear()
    {
        CurrentInput = "";
        FirstOperand = null;
        CurrentOperator = null;
        DisplayChanged?.Invoke("0");
        HistoryChanged?.Invoke();  // Force history refresh
    }
}