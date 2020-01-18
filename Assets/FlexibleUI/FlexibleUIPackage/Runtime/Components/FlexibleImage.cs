using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FlexibleUI.Components
{
    [RequireComponent(typeof(Image))]
    public class FlexibleImage : FlexibleUIBase
    {

        // Start is called before the first frame update
        public override void Start()
        {
            base.Start();       
        }
        public override void UpdateUI()
        {
            base.UpdateUI();
            Image image = GetComponent<Image>();
            ImageData data = GetFlexibleObject<ImageData>();
            image.sprite = data.sourceImage;
            image.color = data.color;
            image.material = data.material;
            image.type = data.type;
            if (data.setNativeSize)image.SetNativeSize();
        }
    } 
}
