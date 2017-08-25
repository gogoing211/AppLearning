using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class FindName : MonoBehaviour {

    public Text T1;
    public Text T2;
    public Text T3;
    public Text T4;
    public Button B1;
    public Color[] Colors = new Color[] { };
    public string[] Colornames = new string[] { };
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

        int[] count = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        new System.Random().Shuffle(count);

        // int[] index = new int[] {1, 2, 3 };
        // new System.Random().Shuffler(index);

        int[] index1 = new int[] { 0, 1, 2, 3 };
        new System.Random().Shuffle(index1);

        // Debug.Log("Shuffle: " + count[0] +" , " + count[1] + " , " + count[2]);

        T1.text = Colornames[count[0]];
        T2.text = Colornames[count[1]];
        T3.text = Colornames[count[2]];
        T4.text = Colornames[count[3]];

        T1.color = Colors[count[0]];
        T2.color = Colors[count[1]];
        T3.color = Colors[count[2]];
        T4.color = Colors[count[3]];

        B1.image.sprite = sh[count[index1[0]]].sprites[UnityEngine.Random.Range(0, 3)];

        a = index1[0];



    }

    public void ClickAnswer(int index)
    {
        if (a == index)
        {
            ClickNextBtn();
            Debug.Log("true");
            Debug.Log("index = " + index);
        }
        else
        {
            Debug.Log("false");
        }
    }

}
