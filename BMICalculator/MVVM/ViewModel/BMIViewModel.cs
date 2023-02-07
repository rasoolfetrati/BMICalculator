namespace BMICalculator.MVVM.ViewModel;

public class BMIViewModel
{
    public Models.BMI BMI { get; set; }
    public BMIViewModel()
    {
        BMI= new Models.BMI();
        BMI.Height = 180;
        BMI.Weight = 73;
    }
}
