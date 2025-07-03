using MauiLearnQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiLearnQuiz.Services
{
    internal class QuizService
    {
        public static List<Question> GetQuestions()
        {
            return new List<Question>
            {
                new Question
                {
                    Texte = "Qu’est-ce que l’intelligence artificielle ?",
                    Choix = new List<string> { "Un robot", "Un algorithme intelligent", "Une puce électronique" },
                    IndexBonneReponse = 1
                },
                new Question
                {
                    Texte = "Quel langage est populaire en IA ?",
                    Choix = new List<string> { "Python", "HTML", "CSS" },
                    IndexBonneReponse = 0
                },
                new Question
                {
                    Texte = "Quelle technique permet à une machine d’apprendre à partir de données ?",
                    Choix = new List<string> { "Le deep learning", "Le câblage", "La compilation" },
                    IndexBonneReponse = 0
                },
                new Question
                {
                    Texte = "Lequel est un domaine de l’IA ?",
                    Choix = new List<string> { "Le traitement de texte", "La vision par ordinateur", "Le design graphique" },
                    IndexBonneReponse = 1
                },
                new Question
                {
                    Texte = "Quel est l’outil le plus utilisé pour entraîner des modèles IA ?",
                    Choix = new List<string> { "Excel", "TensorFlow", "Photoshop" },
                    IndexBonneReponse = 1
                },
                new Question
                {
                    Texte = "Quel type de données l’IA peut-elle traiter ?",
                    Choix = new List<string> { "Texte", "Image", "Tous les types de données" },
                    IndexBonneReponse = 2
                },
                new Question
                {
                    Texte = "Quel est le but de l’IA ?",
                    Choix = new List<string> { "Remplacer l’humain", "Imiter l’intelligence humaine", "Contrôler les machines" },
                    IndexBonneReponse = 1
                },
                new Question
                {
                    Texte = "Quel assistant vocal utilise l’IA ?",
                    Choix = new List<string> { "Google Assistant", "WordPad", "Winamp" },
                    IndexBonneReponse = 0
                },
                new Question
                {
                    Texte = "Quel est un danger potentiel de l’IA ?",
                    Choix = new List<string> { "Manque d’électricité", "Biais algorithmiques", "Temps de chargement lent" },
                    IndexBonneReponse = 1
                },
                new Question
                {
                    Texte = "Qu’est-ce que le machine learning ?",
                    Choix = new List<string> { "Un jeu vidéo", "Une sous-branche de l’IA", "Un logiciel de messagerie" },
                    IndexBonneReponse = 1
                }
            };
        }
    }
}
