using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FlexibleUI
{
    public class FlexibleUIManager : MonoBehaviour
    {
        public static event Action UIChanged = () => { };
        public static ThemeList themeList;
        public static FlexibleUIManager instance;
        private static bool isInitialized;
        

        // Start is called before the first frame update
        void Start()
        {

        }
        public static void Init(ThemeList list, int themeIndex = 0)
        {
            if (!isInitialized)
            {
                isInitialized = true;
                themeList = list;
                ChangeUI(themeIndex);


            }
            else
            {
                Debug.LogWarning("FlexibleUIManager is already intialized");
            }
        }
        public static void ChangeUI(int themeIndex)
        {
            themeList.SetTheme(themeIndex);
            UIChanged();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}


