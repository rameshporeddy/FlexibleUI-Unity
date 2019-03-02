using System;
using System.Reflection;
using UnityEngine;

namespace FlexibleUI
{
    [ExecuteInEditMode]
    public class FlexibleUIBase : MonoBehaviour
    {
        [SerializeField]private string id;
        [SerializeField] private FlexibleUIData editorOnlyUIData;
        private FlexibleUIData UIData;
        private object flexibleObjectData;
        // Start is called before the first frame update
        public virtual void Start()
        {
            OnUIChanged();
        }
        public virtual void OnEnable()
        {
            FlexibleUIManager.UIChanged += OnUIChanged;
        }

        public virtual void OnDisable()
        {
            FlexibleUIManager.UIChanged -= OnUIChanged;
        }

        private void OnUIChanged()
        {
            if (Application.isEditor)
            {
                UIData = editorOnlyUIData;
            }
            else
            {
                UIData = FlexibleUIManager.UIData;
            }
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
