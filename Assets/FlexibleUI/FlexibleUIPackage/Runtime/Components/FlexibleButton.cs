using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FlexibleUI.Components
{
    [RequireComponent(typeof(Button))]
    
    public class FlexibleButton : FlexibleImage
    {
        public override void Start()
        {
            base.Start();
        }
        public override void UpdateUI()
        {            
            base.UpdateUI();
            Button button = GetComponent<Button>();
            ButtonData data = GetFlexibleObject<ButtonData>();
            button.transition = Selectable.Transition.SpriteSwap;
            button.spriteState = data.spriteState;
        }
    } 
}
