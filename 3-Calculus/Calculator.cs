using ComplexAlgebra;

namespace Calculus
{
    /// <summary>
    /// A calculator for <see cref="Complex"/> numbers, supporting 2 operations ('+', '-').
    /// The calculator visualizes a single value at a time.
    /// Users may change the currently shown value as many times as they like.
    /// Whenever an operation button is chosen, the calculator memorises the currently shown value and resets it.
    /// Before resetting, it performs any pending operation.
    /// Whenever the final result is requested, all pending operations are performed and the final result is shown.
    /// The calculator also supports resetting.
    /// </summary>
    ///
    /// HINT: model operations as constants
    /// HINT: model the following _public_ properties methods
    /// HINT: - a property/method for the currently shown value
    /// HINT: - a property/method to let the user request the final result
    /// HINT: - a property/method to let the user reset the calculator
    /// HINT: - a property/method to let the user request an operation
    /// HINT: - the usual ToString() method, which is helpful for debugging
    /// HINT: - you may exploit as many _private_ fields/methods/properties as you like
    ///
    /// TODO: implement the calculator class in such a way that the Program below works as expected
    class Calculator
    {
        public const char OperationPlus = '+';
        public const char OperationMinus = '-';

        public char? _selectedOperation = null;
        private Complex _firstOperand = null;

        public Complex ShownValue { get; set; }
        public void GetResult()
        {
            switch (_selectedOperation)
            {
                case '+':
                    ShownValue = _firstOperand.Plus(ShownValue);
                    break;
                case '-':
                    ShownValue = _firstOperand.Minus(ShownValue);
                    break;
            }
        }

        public char? SelectedOperation
        {
            get => _selectedOperation;
            set
            {
                if (value != _selectedOperation)
                {
                    if (_firstOperand != null)
                    {
                        GetResult();
                    }
                    _selectedOperation = value;
                    _firstOperand = ShownValue;
                    ShownValue = null; // reset
                }
            }
        } 

        public void ResetAll()
        {
            _selectedOperation = null;
            ShownValue = null;
            _firstOperand = null;
        }

        public override string ToString()
        {
            return "value: " + (ShownValue == null ? "no value" : ShownValue.ToString())
                + ", selected operation: " + (_selectedOperation == null ? "no operation selected" : _selectedOperation.ToString());
        }
    }
}