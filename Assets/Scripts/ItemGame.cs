using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGame : MonoBehaviour
{
    [Header("stats")]
    public bool isData = false;
    public int id;
    public string icon;
    public string title;
    public string desc;
    public float price;

    [Header("Trans")]
    public Image imgIcon;
    public Text txtTittle;
    public Text txtPrice;

    private void OnEnable()
    {
        transform.GetComponent<Button>().onClick.AddListener(() => {
            ShowP();
        });
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Parse()
    {
        Sprite sprite = Resources.Load<Sprite>("ShopItems/"+icon);

        imgIcon.GetComponent<Image>().sprite = sprite;
        imgIcon.SetNativeSize();

        txtTittle.text = title;
        txtPrice.text = ""+price;
    }

    public void ShowP()
    {
        Debug.Log("Show ------------ : " + id);
        PopupCanvas.instance.OnOffP(0,true);
        PopupCanvas.instance.popups[0].GetComponent<PopupItemScript>().SetInterface(icon,title,desc);
    }
}
