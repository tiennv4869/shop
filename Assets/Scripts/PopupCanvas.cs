using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupCanvas : MonoBehaviour
{
    public static PopupCanvas instance;
    private PopupCanvas()
    {
        instance = this;
    }
    public static PopupCanvas Instance
    {
        get
        {
            return instance;
        }
    }

    public Transform bg;
    public Transform[] popups;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnOffP(int id, bool val)
    {
        bg.gameObject.SetActive(val);
        popups[id].gameObject.SetActive(val);
    }
}
