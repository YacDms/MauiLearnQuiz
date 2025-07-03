namespace MauiLearnQuiz;

[QueryProperty("Score", "score")]
public partial class ResultPage : ContentPage
{
    public string? Score { get; set; }

    public ResultPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        int s = int.Parse(Score);
        lblScore.Text = $"Votre score : {s}/10";
        lblMessage.Text = s >= 7 ? "Bravo !" : "Revoyez le cours.";
    }
}