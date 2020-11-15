namespace ConplementAG.Blazor.Pages
{
    public partial class Index
    {
        public string AzureUrl { get; set; } = "https://portal.azure.com/#@bartvanhoeyhotmail.onmicrosoft.com/resource/subscriptions/59ffed3c-16ac-42bd-be89-71f3fc914213/resourceGroups/rgConplementAG/overview";
        public  bool GoalTodayIsHidden { get; set; } = false;
        public  bool TechnologiesIsHidden { get; set; } = true;

        protected void CloseGoalToday()
        {
            GoalTodayIsHidden = true;
            TechnologiesIsHidden = false;
        }
    }
}
