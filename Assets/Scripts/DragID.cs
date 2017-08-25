using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragID : MonoBehaviour {

    public static GameObject item;
    public int id;

    private void Start()
    {
        GetComponent<Image>().preserveAspect = true;
    }
}
