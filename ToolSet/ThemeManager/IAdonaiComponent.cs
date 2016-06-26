namespace SmartBuilder
{
    interface IAdonaiComponent
    {
        MainThemeStyle MainTheme { get; set; }
        SecondaryThemeStyle SecondaryTheme { get; set; }

       void ResetTheme();
    }
}
