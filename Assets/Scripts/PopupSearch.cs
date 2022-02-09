using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupSearch : MonoBehaviour
{
    public InputField input;
    private void OnEnable()
    {
        input.text = "";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Close()
    {
        PopupCanvas.instance.OnOffP(1, false);
    }

    public void Search()
    {
        if(input.text != "")
        {
            int t = Convert.ToInt32(input.text);

            ShopCanvas.instance.numVal = t;
            ShopCanvas.instance.ReadData();

            Close();
        }
    }
}
