using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NightlyBuildIssues
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty] private int counter;
        [ObservableProperty] private string? counterString;

        partial void OnCounterChanged(int value)
        {
            CounterString = value.ToString();
        }

        [RelayCommand]
        public void AddCounter()
        {
            Counter++;
        }
    }
}
