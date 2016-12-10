using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    public Color standard;
    public Color affordable;
    private float baseCost;

    private void Start()
    {
        baseCost = cost;

    }
    private void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;

        if(click.gold >= cost)
        {
            GetComponent<Image>().color = affordable;
        } else {
            GetComponent<Image>().color = standard;
        }
    }

    public void PurchaseUpgrade()
    {
        if(click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            click.goldperclick += clickPower;
            cost = Mathf.Round (baseCost * Mathf.Pow(1.15f, count));
  
        }
    }
}
