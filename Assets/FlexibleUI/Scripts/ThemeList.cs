using System.Collections.Generic;
using UnityEngine;

namespace FlexibleUI
{
    [CreateAssetMenu(fileName = "ThemeList", menuName = "FlexibleUI/ThemeList", order = 2)]
    public class ThemeList : ScriptableObject
    {
        public FlexibleUIData currentTheme;
        public FlexibleUIData[] themes;
        public void SetTheme(int i)
        {
            currentTheme = themes[i];
        }
    } 
}
