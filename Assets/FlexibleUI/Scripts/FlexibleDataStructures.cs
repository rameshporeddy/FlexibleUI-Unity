using System;
using UnityEngine;
using UnityEngine.UI;

namespace FlexibleUI
{
    [Serializable]
    public class ImageData
    {
        public Sprite sourceImage;
        public Material material;
        public Color color = Color.white;
        public Image.Type type = Image.Type.Simple;
        public bool setNativeSize;
    }
    [Serializable]
    public class TextData
    {
        public Font font;
        public int fontSize = 14;
        public FontStyle fontStyle = FontStyle.Normal;
        public Color color = Color.white;
        public Material material;

    }
    [Serializable]
    public class SpriteRendererData
    {
        public Sprite sprite;
        public Material material;
        public Color color = Color.white;
        public SpriteDrawMode drawMode = SpriteDrawMode.Simple;
    }
    [Serializable]
    public class ButtonData : ImageData
    {
        //public Selectable.Transition transition;
        public SpriteState spriteState;
    }
    [Serializable]
    public class InputFieldData : ImageData
    {
        public Color selectionColor = Color.cyan;
    }
}
