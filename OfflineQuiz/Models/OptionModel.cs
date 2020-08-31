using System.ComponentModel;

namespace OfflineQuiz.Models
{
    public class OptionModel : INotifyPropertyChanged
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }
        //public QuestionModel Question { get; set; }
        public bool IsSelected { get; set; }
        public bool IsAnswer { get; set; }
        public string OptionText { get; set; }
        public int Sequence { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
