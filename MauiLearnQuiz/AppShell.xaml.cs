namespace MauiLearnQuiz
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Enregistrement des routes de navigation
            Routing.RegisterRoute(nameof(LecturePage), typeof(LecturePage));
            Routing.RegisterRoute(nameof(QuizPage), typeof(QuizPage));
            Routing.RegisterRoute(nameof(ResultPage), typeof(ResultPage));
        }
    }
}
