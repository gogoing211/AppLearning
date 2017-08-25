using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameLearn : MonoBehaviour {


    public SpriteHolder[] sh;
    [Serializable]
    public class SpriteHolder
    {
        public Sprite[] sprites;
    }
   // public Sprite[] sprites = new Sprite[] { };


    public Text text;
    public string[] colorName = new string[] { };

    public Color[] colors = new Color[] {};
    public Button B1;
    public Button B2;
    public Button B3;
    public Button B4;

    int count = 0;
    private int index = 0;

    public void ClickNextBtn()
    {
        index++;
        if (index == sh.Length)
        {
            index = 0;
        }
        B1.image.sprite = sh[index].sprites[count];
        B2.image.sprite = sh[index].sprites[count+1];
        B3.image.sprite = sh[index].sprites[count+2];
        B4.image.sprite = sh[index].sprites[count+3];
        text.text = colorName[index % colors.Length];
        text.color = colors[index % colors.Length];
    }


}
