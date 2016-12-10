using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public UnityEngine.UI.Text gpc;
    public UnityEngine.UI.Text goldDisplay;
    public float gold = 0.00f;
    public int goldperclick = 1;

    void Update()
    {
        goldDisplay.text = "Gold: " + gold.ToString ("F0");
        gpc.text = goldperclick + " gold/click";
    }

    public void Clicked()
    {  
        gold += goldperclick;
    }
}