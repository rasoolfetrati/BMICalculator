using BMICalculator.MVVM.ViewModel;

namespace BMICalculator.MVVM.View;

public partial class BMIView : ContentPage
{
    public BMIView()
    {
        InitializeComponent();
        BindingContext = new BMIViewModel();
    }
}