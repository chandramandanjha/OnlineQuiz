using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineQuiz.Models
{
    public class ExamModel
    {
        public List<QuestionModel> QuestionModels { get; set; }

        public List<OptionModel> OptionModels { get; set; }
    }
}
