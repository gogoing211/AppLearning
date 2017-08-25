using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;

public class MatchColors : MonoBehaviour
{
    public Image[] answers;
    public Image[] questions;
    //public Image[] Frames;
    Vector3[] startPos;
    public SpriteHolder[] sh;
    [Serializable]
    public class SpriteHolder
    {
        public Sprite[] sprites;
    }
    public Sprite[] tartgetSprites;
    //public Sprite[] showframes;

    private List<int> RandomList;
    private List<int> RandomIndex;
    private int random;

    public void Start()
    {
        ClickNextBtn();
       // B1Pos = Button1.transform.position;
    }

    private void GenerateRandomList()
    {
        RandomList = new List<int>();
        for(int i = 0; i < sh.Length; i++)
        {
            RandomList.Add(i);
        }
        Shuffle(RandomList);

        RandomIndex = new List<int>();
        for(int i = 0; i < questions.Length; i++)
        {
            RandomIndex.Add(i);
        }
        Shuffle(RandomIndex);
    }

    private void Shuffle<T>(IList<T> list)
    {
        int n = list.Count;
        System.Random rnd = new System.Random();
        while (n > 1)
        {
            int k = (rnd.Next(0, n) % n);
            n--;
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public void GenerateQuestion()
    {
        GenerateRandomList();
        for(int i = 0; i < questions.Length; i++)
        {
            random = UnityEngine.Random.Range(0, 3);
            int staticI = i;
            int Index = RandomList.ElementAt(staticI);
            questions[staticI].sprite = tartgetSprites[Index];
            DropHandler drop = questions[staticI].GetComponent<DropHandler>();
            drop.sprite = sh[Index].sprites[random];
            drop.id = Index;

            int aIndex = RandomIndex.ElementAt(staticI);
            answers[aIndex].color = Color.white;
            answers[aIndex].sprite = sh[Index].sprites[random];
            DragHandler drag = answers[aIndex].GetComponent<DragHandler>();
            drag.id = Index;

            if (startPos == null)
            {
                startPos = new Vector3[]  {
                    answers[0].gameObject.transform.position,
                    answers[1].gameObject.transform.position,
                    answers[2].gameObject.transform.position,
                    answers[3].gameObject.transform.position,
                };
            }
            answers[aIndex].gameObject.transform.position = questions[staticI].gameObject.transform.position;
        }
    }

    public void ClickNextBtn()
    {
        GenerateQuestion();
    }
}