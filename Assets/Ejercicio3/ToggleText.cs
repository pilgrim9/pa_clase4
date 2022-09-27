using System;
using UnityEngine;
using  UnityEngine.UI;
public class ToggleText : MonoBehaviour
{
    private Text text;
    private void Start()
    { 
        text = GetComponent<Text>(); 
    }
    public void Toggle()
    {
        text.enabled = !text.enabled;
    }
}