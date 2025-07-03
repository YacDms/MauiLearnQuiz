using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiLearnQuiz.Models
{
    internal class Question
    {
        public string? Texte { get; set; }
        public List<string>? Choix { get; set; }
        public int IndexBonneReponse { get; set; }
    }
}
