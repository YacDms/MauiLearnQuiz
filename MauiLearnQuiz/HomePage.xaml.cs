namespace MauiLearnQuiz;

public partial class HomePage : ContentPage
{
    public HomePage() => InitializeComponent();

    private async void OnStartCourse(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LecturePage));
    }
}