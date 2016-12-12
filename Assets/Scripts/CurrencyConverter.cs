using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyConverter : MonoBehaviour {
    private static CurrencyConverter instance;
    public static CurrencyConverter Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        CreateInstance();
    }

    void CreateInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public string GetCurrencyIntoString(float valueToConvert, bool currencyPerSec, bool currencyPerClick)
    {
        string converted;
        if (valueToConvert >= 1000000)
        {
            converted = (valueToConvert / 1000000f).ToString("f3") + " Mil";
        }
        else if (valueToConvert >= 1000)
        {
            converted = (valueToConvert / 1000f).ToString("f3") + " K";
        }
        else if (valueToConvert >= 0)
        {
            converted = valueToConvert.ToString("f0");
        }
        else
        {
            converted = "" + valueToConvert;
        }
        
        if(currencyPerSec == true)
        {
            converted = converted + "gps";
        }

        if(currencyPerClick == true)
        {
            converted = converted + "gpc";
        }
        return converted;
    }


}
