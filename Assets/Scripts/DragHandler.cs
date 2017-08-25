using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public static GameObject item;
    Transform startParent;
    Vector3 startPosition;
    Transform canvas;
    public int id;

    private void Start()
    {
        GetComponent<Image>().preserveAspect = true;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        item = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        canvas = GameObject.FindGameObjectWithTag("UI Canvas").transform;
        transform.SetParent(canvas);
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        //GetComponent<Image>().color = new Color(200f / 255f, 200f / 255f, 200f / 255f, 1);
        // transform.position = Input.mousePosition;
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas as RectTransform, Input.mousePosition, canvas.gameObject.GetComponent<Canvas>().worldCamera, out pos);
        transform.position = canvas.TransformPoint(pos);
        if (GetComponent<Image>().color == new Color(0, 0, 0, 0))
        {

        }
        else
        {
            GetComponent<Image>().color = new Color(200f / 255f, 200f / 255f, 200f / 255f, 1);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        item = null;
       // transform.position = transform.parent.position;
        if(GetComponent<Image>().color != new Color(0, 0, 0, 0))
        {
            GetComponent<Image>().color = Color.white;
        }
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == canvas)
        {
            transform.SetParent(startParent);
            LeanTween.moveLocal(transform.gameObject, startPosition, 0.1f);
        }
        
    }
}
