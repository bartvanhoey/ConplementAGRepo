namespace ConplementAG.Blazor.Pages
{
    public partial class Index
    {
        public string AzureUrl { get; set; } = "https://portal.azure.com/#@bartvanhoeyhotmail.onmicrosoft.com/resource/subscriptions/59ffed3c-16ac-42bd-be89-71f3fc914213/resourceGroups/rgConplementAG/overview";
        public  bool IsHiddenGoalToday { get; set; } = false;
        public  bool IsHiddenTechnologies { get; set; } = true;

        protected void ToggleVisibility()
        {
            IsHiddenGoalToday = !IsHiddenGoalToday;
            IsHiddenTechnologies = !IsHiddenTechnologies;
        }
    }
}
