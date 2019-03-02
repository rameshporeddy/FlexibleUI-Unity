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
        private static FlexibleUIData _uiData;
        public static FlexibleUIManager instance;
        private static bool isInitialized;
        public static FlexibleUIData UIData {
            get {
                if (isInitialized)
                {
                    return _uiData;
                }
                else
                {
                    throw new Exception("Init FlexibleUIManager at start of the game");
                }
                
            }
        }
        

        // Start is called before the first frame update
        void Start()
        {

        }
        public static void Init(FlexibleUIData data)
        {
            if (!isInitialized)
            {
                isInitialized = true;
                _uiData = data;

            }
            else
            {
                Debug.LogWarning("FlexibleUIManager is already intialized");
            }

        }
        public static void ChangeUI(FlexibleUIData data)
        {
            _uiData = data;
            UIChanged();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}


