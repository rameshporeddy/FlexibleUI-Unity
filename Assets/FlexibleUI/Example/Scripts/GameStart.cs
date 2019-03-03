using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlexibleUI;

public class GameStart : MonoBehaviour
{
    [SerializeField] private ThemeList themeList;
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("GameStart FlexibleUIManager.Init");
        FlexibleUIManager.Init(themeList);
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeTheme(int i)
    {
        FlexibleUIManager.ChangeUI(i);
    }
}
