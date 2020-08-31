using OfflineQuiz.ViewModels;

namespace OfflineQuiz
{
    public static class Instance
    {
        public static MainWindowViewModel MainWindowViewModel { get; set; }
        public static TestPageViewModel TestPageViewModel { get; set; }

        public static void CreateMainWindowInstance(MainWindowViewModel instance)
        {
            MainWindowViewModel = instance;
        }

        public static void CreateTestWindowInstance(TestPageViewModel instance)
        {
            TestPageViewModel = instance;
        }
    }
}
