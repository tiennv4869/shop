using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int id;
    public string icon;
    public string title;
    public string desc;
    public float price;
}

[System.Serializable]
public class Game
{
    public Item[] items;
}

public class ShopCanvas : MonoBehaviour
{
    public static ShopCanvas instance;
    private ShopCanvas()
    {
        instance = this;
    }
    public static ShopCanvas Instance
    {
        get
        {
            return instance;
        }
    }

    [Header("stats")]
    public int numVal = 0;
    public TextAsset jsonFile;

    [Header("Trans")]
    public Transform prefabsRow;
    public Transform content;

    // Start is called before the first frame update
    void Start()
    {
        ReadData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadData()
    {
        if(content.childCount > 0)
        {
            foreach (Transform t in content)
            {
                Destroy(t.gameObject);
            }
        }

        Game game = JsonUtility.FromJson<Game>(jsonFile.text);

        int count = 0;
        Transform rowwwww = null;
        for (int i = 0; i < game.items.Length; i++)
        {
            if (i < numVal)
            {
                Item t = game.items[i];
                Debug.Log("Read data: " + t.id + " : " + t.icon);

                if (count < 3) {
                    if (count == 0)
                    {
                        Transform r = Instantiate(prefabsRow) as Transform;
                        r.SetParent(content);
                        r.localScale = Vector3.one;
                        rowwwww = r;
                        SetItem(rowwwww, t);
                    }
                    else
                    {
                        if(rowwwww != null)
                        {
                            SetItem(rowwwww, t);
                        }
                    }
                    count++;
                }
                else if(count >= 3)
                {
                    Transform r = Instantiate(prefabsRow) as Transform;
                    r.SetParent(content);
                    r.localScale = Vector3.one;
                    rowwwww = r;
                    SetItem(rowwwww, t);
                    count = 1;
                }
            }
        }
    }

    public void SetItem(Transform trans, Item t)
    {
        for (int j = 0; j < trans.GetChild(1).childCount; j++)
        {
            ItemGame it = trans.GetChild(1).GetChild(j).GetComponent<ItemGame>();
            it.gameObject.SetActive(true);
            if (!it.isData)
            {
                it.isData = true;
                it.id = t.id;
                it.icon = t.icon;
                it.title = t.title;
                it.desc = t.desc;
                it.price = t.price;
                it.Parse();
                break;
            }
        }
    }

    public void OpenSearch()
    {
        PopupCanvas.instance.OnOffP(1,true);
    }
    
}
