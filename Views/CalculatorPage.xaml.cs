using CommunityToolkit.Maui.Core;

namespace Workup.Views;

public partial class CalculatorPage : ContentPage
{
    public CalculatorPage(CalculatorViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = new CalculatorViewModel(); 
        OnClear(this, null);
    }

    string current = "";
    int state = 1;
    string operation;
    double x, y;
    string decimalNum = "Num";
    
    void SelectNumber(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string entered= button.Text;

        current += entered;

        if ((this.result.Text == "0" && entered == "0")
            || (current.Length <= 1 && entered != "0") 
            || state <0)
        {
            this.result.Text = "";
            if (state < 0)
                state *= -1;
        }

        if (entered == "." && decimalNum != "Num2")
        {
            decimalNum = "Num2";
        }
        this.result.Text += entered;
    }

    void SelectOperation(object sender, EventArgs e)
    {
        

        state = -2;
        Button button = (Button)sender;
        string entered= button.Text;
        operation= entered;
    }

    private void SetNumber(string text)
    {
        double number;
        if (double.TryParse(text, out number))
        {
            if (state == 1)
            {
                x = number;
            }
            else
            {
                y = number;
            }

            current = string.Empty;
        }
    }

    void OnClear(object sender, EventArgs e)
    {
        x = 0;
        y = 0;
        state= 1;
        decimalNum = "Num";
        this.result.Text = "0";
        current = string.Empty;
    }

    void Calculate(object sender, EventArgs e)
    {
        if (state == 2) 
        {
            var result = CalculatorViewModel.Calculator(x, y, operation);

            this.result.Text = result.ToString();
            x = result;
            state = -1;
        }
    }

    void Percentage(object sender, EventArgs e)
    {
        if (state == 1)
        {
            SetNumber(result.Text);
            decimalNum = "Num";
            x = 0.01;
            operation = "×";
            state = 2;
            Calculate(this, null);
        }
    }





}