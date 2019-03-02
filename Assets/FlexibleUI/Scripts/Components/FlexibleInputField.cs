using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FlexibleUI.Components
{
    [RequireComponent(typeof(InputField))]
    public class FlexibleInputField : FlexibleImage
    {
        // Start is called before the first frame update
        public override void Start()
        {
            base.Start();
        }
        public override void UpdateUI()
        {
            base.UpdateUI();            
            InputFieldData data = GetFlexibleObject<InputFieldData>();
            InputField inputField = GetComponent<InputField>();
            inputField.selectionColor = data.selectionColor;
        }
    } 
}
