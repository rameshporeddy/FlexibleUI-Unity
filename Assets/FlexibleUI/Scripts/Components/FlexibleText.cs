using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FlexibleUI.Components
{
    [RequireComponent(typeof(Text))]
    public class FlexibleText : FlexibleUIBase
    {
        // Start is called before the first frame update
        public override void Start()
        {
            base.Start();
        }
        public override void UpdateUI()
        {
            base.UpdateUI();
            Text text = GetComponent<Text>();
            TextData data = GetFlexibleObject<TextData>();
            text.font = data.font;
            text.fontSize = data.fontSize;
            text.fontStyle = data.fontStyle;
            text.color = data.color;
            text.material = data.material;
        }
    } 
}
