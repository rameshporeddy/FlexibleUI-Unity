using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FlexibleUI
{
    [CreateAssetMenu(fileName = "FlexibleUIData", menuName = "FlexibleUI/FlexibleUIData", order = 1)]
    public class FlexibleUIData : ScriptableObject
    {
        [Header("Button")]
        public TextData buttonSpriteSwapText;
        public ButtonData buttonSpriteSwap;

        [Header("Toggle Button")]
        public ImageData toggleCheckMark;
        public ImageData toggleBackground;
        public TextData toggleLableText;

        [Header("Slider")]
        public ImageData sliderBackground;
        public ImageData sliderFill;
        public ImageData sliderKnob;

        [Header("DropDown")]
        public TextData ddSelectedText;
        public ImageData ddSelectedBackground;
        public ImageData ddArrow;
        public ImageData ddTemplateBackground;

        public ImageData ddItemCheckMark;
        public ImageData ddItemBackground;
        public TextData ddItemText;

        public ImageData ddSliderBackground;
        public ImageData ddSliderHandle;

        [Header("Inputfield")]
        public TextData inputFieldPlaceHolder;
        public InputFieldData inputFieldBackground;
        public TextData inputFieldText;


    }
    
}
