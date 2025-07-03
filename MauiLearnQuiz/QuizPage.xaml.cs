using MauiLearnQuiz.Models;
using MauiLearnQuiz.Services;

namespace MauiLearnQuiz;

public partial class QuizPage : ContentPage
{
    List<Question> questions = QuizService.GetQuestions();
    int index = 0;
    int score = 0;
    List<int> reponsesUtilisateur = new List<int>();

    public QuizPage()
    {
        InitializeComponent();
        AfficherQuestion();
    }

    void AfficherQuestion()
    {
        if (index < questions.Count)
        {
            var q = questions[index];
            lblQuestion.Text = q.Texte;
            choice1.Content = q.Choix[0];
            choice2.Content = q.Choix[1];
            choice3.Content = q.Choix[2];

            // Réinitialise les choix radio
            choice1.IsChecked = false;
            choice2.IsChecked = false;
            choice3.IsChecked = false;
        }
    }

    private async void OnNext(object sender, EventArgs e)
    {
        // Enregistre la réponse sélectionnée
        int reponse = choice1.IsChecked ? 0 : choice2.IsChecked ? 1 : 2;

        if (reponsesUtilisateur.Count > index)
            reponsesUtilisateur[index] = reponse; // Mise à jour
        else
            reponsesUtilisateur.Add(reponse); // Nouvelle réponse

        index++;

        if (index < questions.Count)
        {
            AfficherQuestion();
        }
        else
        {
            // Calcul du score à la fin
            score = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if (i < reponsesUtilisateur.Count &&
                    reponsesUtilisateur[i] == questions[i].IndexBonneReponse)
                {
                    score++;
                }
            }

            await Shell.Current.GoToAsync($"{nameof(ResultPage)}?score={score}");
        }
    }

    // je n'ai plus besoin de OnChecked() je pense lol
}
