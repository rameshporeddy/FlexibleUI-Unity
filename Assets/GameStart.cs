using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlexibleUI;

public class GameStart : MonoBehaviour
{
    [SerializeField] private FlexibleUIData[] flexibleUIs;
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("GameStart FlexibleUIManager.Init");
        FlexibleUIManager.Init(flexibleUIs[0]);
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
