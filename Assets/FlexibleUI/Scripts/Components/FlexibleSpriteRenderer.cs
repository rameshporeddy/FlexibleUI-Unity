using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlexibleUI.Components
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class FlexibleSpriteRenderer : FlexibleUIBase
    {
        // Start is called before the first frame update
        public override void Start()
        {
            base.Start();
        }

        public override void UpdateUI()
        {
            base.UpdateUI();
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            SpriteRendererData data = GetFlexibleObject<SpriteRendererData>();
            spriteRenderer.sprite = data.sprite;
            spriteRenderer.color = data.color;
            spriteRenderer.material = data.material;
            spriteRenderer.drawMode = data.drawMode;
        }
    } 
}
