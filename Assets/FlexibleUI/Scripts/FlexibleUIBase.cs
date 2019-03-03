using System.Reflection;
using UnityEngine;

namespace FlexibleUI
{
    [ExecuteInEditMode]
    public class FlexibleUIBase : MonoBehaviour
    {
        [SerializeField]private string id;
        private FlexibleUIData UIData;
        private object flexibleObjectData;
        private ThemeList themeList;
        // Start is called before the first frame update
        public virtual void Start()
        {
            OnUIChanged();
        }
        public virtual void OnEnable()
        {
            if (Application.isEditor)
            {
                themeList = Resources.Load<ThemeList>("FlexibleUI/ThemeList");
            }
            else
            {
                themeList = FlexibleUIManager.themeList;
            }
            
            FlexibleUIManager.UIChanged += OnUIChanged;
           
        }

        public virtual void OnDisable()
        {
            FlexibleUIManager.UIChanged -= OnUIChanged;
        }

        private void OnUIChanged()
        {
            UIData = themeList.currentTheme;
            if (UIData != null)
            {
                FieldInfo fieldInfo = UIData.GetType().GetField(id);
                if (fieldInfo!=null)
                {
                    flexibleObjectData = fieldInfo.GetValue(UIData);
                    if (flexibleObjectData != null)
                    {
                        UpdateUI();
                    }
                }
            }
        }
        public virtual void UpdateUI()
        {
            
            
        }
        internal T GetFlexibleObject<T>()
        {
            return (T)flexibleObjectData;
        }
        public virtual void Update()
        {
            if (Application.isEditor)
            {
                OnUIChanged();
            }
        }
    }
}
