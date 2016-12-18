using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager6 : MonoBehaviour
{

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public string itemName;
    public Color standard;
    public Color affordable;
    private Slider _slider;

    private void Start()
    {

        _slider = GetComponentInChildren<Slider>();

    }
    private void Update()
    {
        itemInfo.text = itemName + "\n비용: " + cost;
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

    public void PurchaseButtonManager6()
    {
        if (click.gold >= cost)
        {
            click.gold -= cost;
            SceneManager.LoadScene(8);

        }
    }
}