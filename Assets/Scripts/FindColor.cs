using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class FindColor : MonoBehaviour {

    public Button B1;
    public Button B2;
    public Button B3;
    public Button B4;
    public Button B5;
    private int a;

    public SpriteHolder[] sh;
    [Serializable]
    public class SpriteHolder
    {
        public Sprite[] sprites;
    }

    public void Start()
    {
       ClickNextBtn();
    }

    public void ClickNextBtn()
    {
        
        int[] count = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        new System.Random().Shuffle(count);

        int[] index1 = new int[] {0, 1, 2, 3 };
        new System.Random().Shuffle(index1);

       // Debug.Log("Shuffle: " + count[0] +" , " + count[1] + " , " + count[2]);

        B1.image.sprite = sh[count[0]].sprites[0];
        B2.image.sprite = sh[count[1]].sprites[0];
        B3.image.sprite = sh[count[2]].sprites[0];
        B4.image.sprite = sh[count[3]].sprites[0];
        B5.image.sprite = sh[count[index1[0]]].sprites[UnityEngine.Random.Range(1, 4)];

        a = index1[0];
        

        
    }

    public void ClickAnswer(int index)
    {
        if (a == index)
        {
            ClickNextBtn();
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false");
        }
    } 
}
