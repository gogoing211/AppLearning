using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameDropHandler : MonoBehaviour, IDropHandler
{
    public ParticleSystem effect;
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
        if (id == GameDragHandler.item.GetComponent<DragID>().id)
        {
            GameDragHandler.item.SetActive(false);
            //DropDown();
        }
    }

    //public void DropDown()
    //{
    //    ClassifyColorsGame Classify = new ClassifyColorsGame();
    //    //Classify.GenerateRandomList();
    //    for (int i = 0; i < Classify.answers.Length; i++)
    //    {
    //        if (Classify.answers[i] != null)
    //        {
    //            if (Classify.answers[i + 1] == null)
    //            {
    //                Classify.answers[i + 1] = Classify.answers[i];
    //                Classify.answers[i + 1].gameObject.transform.position = new Vector3(Classify.answers[i + 1].transform.position.x, Classify.answers[i + 1].transform.position.y);
    //                Debug.Log("new Position");
    //            }
    //        }
    //    }

    //}
}


