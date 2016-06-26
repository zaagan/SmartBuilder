using System.Drawing;

namespace SmartBuilder
{
    class AdonaiThemeManager
    {

        public sealed class TabControl
        {
            public static Color MainTheme(MainThemeStyle mainTheme)
            {
                switch (mainTheme)
                {
                    case MainThemeStyle.Dark:
                        return AdonaiThemeColor.Dark;

                    case MainThemeStyle.DarkBlue:
                        return AdonaiThemeColor.DarkBlue;

                    case MainThemeStyle.White:
                        return AdonaiThemeColor.White;

                    default:
                        return AdonaiThemeColor.Dark;
                }
            }

            public static Color SecondaryTheme(SecondaryThemeStyle secondaryTheme)
            {
                switch (secondaryTheme)
                {
                    case SecondaryThemeStyle.Green:
                        return AdonaiThemeColor.Green;

                    case SecondaryThemeStyle.MotorRed:
                        return AdonaiThemeColor.MotorRed;

                    case SecondaryThemeStyle.SkyBlue:
                        return AdonaiThemeColor.SkyBlue;

                    case SecondaryThemeStyle.Dark:
                        return AdonaiThemeColor.Carbon;

                    default:
                        return AdonaiThemeColor.MotorRed;
                }
            }

            public static Color HoverTheme(SecondaryThemeStyle hoverTheme)
            {
                switch (hoverTheme)
                {
                    case SecondaryThemeStyle.Green:
                        return AdonaiThemeColor.HoverGreen;

                   
                    case SecondaryThemeStyle.SkyBlue:
                        return AdonaiThemeColor.HoverSkyBlue;

                    case SecondaryThemeStyle.Dark:
                        return AdonaiThemeColor.HoverCarbon;

                    case SecondaryThemeStyle.MotorRed:
                    default:
                        return AdonaiThemeColor.HoverMotor;

                }
            }


            public static Color FontForeColor(SecondaryThemeStyle fontTheme)
            {
                switch (fontTheme)
                {
                    case SecondaryThemeStyle.Green:
                        return AdonaiThemeColor.Green;

                    case SecondaryThemeStyle.MotorRed:
                        return AdonaiThemeColor.MotorRed;

                    case SecondaryThemeStyle.SkyBlue:
                        return AdonaiThemeColor.SkyBlue;

                    case SecondaryThemeStyle.Dark:
                        return AdonaiThemeColor.CarbonFont;

                    default:
                        return AdonaiThemeColor.MotorRed;
                }
            }

        }


    }
}
