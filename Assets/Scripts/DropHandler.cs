using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropHandler : MonoBehaviour, IDropHandler
{
    public Sprite sprite;
    private Image image;
    public int id;

    public void Start()
    {
        image = GetComponent<Image>();
        GetComponent<Image>().preserveAspect = true;
    }
    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
        
    }
   

    public void OnDrop(PointerEventData eventData)
    {
        if (id == DragHandler.item.GetComponent<DragHandler>().id)
        {
            Destroy(DragHandler.item);
            //DragHandler.item.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            //DragHandler.item.transform.SetParent(transform);
            image.sprite = sprite;
        }
        
    }

}


