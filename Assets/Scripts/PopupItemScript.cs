using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupItemScript : MonoBehaviour
{
    public Text txtTittle;
    public Text txtDesc;
    public Image imgIcon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetInterface(string icon, string title, string desc)
    {
        txtTittle.text = title;
        txtDesc.text = desc;

        Sprite sprite = Resources.Load<Sprite>("ShopItems/" + icon);

        imgIcon.GetComponent<Image>().sprite = sprite;
        imgIcon.SetNativeSize();
    }

    public void Close()
    {
        PopupCanvas.instance.OnOffP(0,false);
    }
}
