namespace MauiLearnQuiz;

public partial class LecturePage : ContentPage
{
    public LecturePage() => InitializeComponent();

    private async void OnStartQuiz(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(QuizPage));
    }
}