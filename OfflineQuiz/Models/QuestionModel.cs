using OfflineQuiz.ViewModels;
using System.Collections.Generic;

namespace OfflineQuiz.Models
{
    public class QuestionModel : ViewModelBase
    { 
        private string _questionText;
        public int Id { get; set; }
        public int Sequence { get; set; }
        public string QuestionText {
            get { return _questionText; }
            set
            {
                _questionText = value;
                OnPropertyChanged(nameof(QuestionText));
            }
        }
        
        public bool IsAnswered { get; set; }

        public List<OptionModel> Options { get; set; }
    }
}
