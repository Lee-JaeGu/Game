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
    private Slider _slider;

    private void Start()
    {
        baseCost = cost;
        _slider = GetComponentInChildren<Slider>();

    }
    private void Update()
    {
        itemInfo.text = itemName + " (" + count + ")" + "\n비용: " + cost + "\n가격: +" + clickPower;
        _slider.value = click.gold / cost * 100;

        if (_slider.value >= 100)
        {
            GetComponent<Image>().color = affordable;
        }
        else
        {
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
