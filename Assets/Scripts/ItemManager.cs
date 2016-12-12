using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    public Color standard;
    public Color affordable;
    private float baseCost;
    private Slider _slider;

    private void Start()
    {
        baseCost = cost;
        _slider = GetComponentInChildren<Slider> ();
    }

    private void Update()
    {
        itemInfo.text = itemName + " (" + count + ")" + "\nCost: " + cost + "\nGold: " + tickValue + "/s";
        /*if (click.gold >= cost)
        {
            GetComponent<Image>().color = affordable;
        }
        else
        {
            GetComponent<Image>().color = standard;
        }*/
        _slider.value = click.gold / cost * 100;
        if (_slider.value >= 100)
        {
            GetComponent<Image>().color = affordable;
        } else
        {
            GetComponent<Image>().color = standard;
        }
    }

    public void PurchasedItem()
    {
        if (click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            cost = Mathf.Round (baseCost + Mathf.Pow(1.15f, count));
        }
    }
}
