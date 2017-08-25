using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;

public class ClassifyColorsGame : MonoBehaviour
{

    public Image[] answers;
    public Image[] questions;
    Vector3[] startPos;
    public SpriteHolder[] Sh;
    [Serializable]
    public class SpriteHolder
    {
        public Sprite[] sprites;
    }
    public Sprite[] tartgetSprites;

    private List<int> RandomList;
    private List<int> RandomIndex;
    private int random;
    bool renewobj = false;

    private void Start()
    {
        GenerateQuestions();
    }

    public void GenerateRandomList()
    {
        RandomList = new List<int>();
        for (int i = 0; i < Sh.Length; i++)
        {
            RandomList.Add(i);
        }
        Shuffle(RandomList);

        RandomIndex = new List<int>();
        for (int i = 0; i < questions.Length; i++)
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

    private void GenerateQuestions()
    {
        GenerateRandomList();
        for (int i = 0; i < questions.Length; i++)
        {
            random = UnityEngine.Random.Range(0, 3);
            int staticI = i;
            int Index = RandomList.ElementAt(staticI);
            questions[staticI].sprite = tartgetSprites[Index];
            GameDropHandler Gamedrop = questions[staticI].GetComponent<GameDropHandler>();
            Gamedrop.sprite = Sh[Index].sprites[random];
            Gamedrop.id = Index;

            int aIndex = RandomIndex.ElementAt(staticI);
            //answers[aIndex].color = Color.white;
            answers[aIndex].sprite = Sh[Index].sprites[random];
            DragID dragID = answers[aIndex].GetComponent<DragID>();
            dragID.id = Index;
        }
    }

    //public void NewDropDown()
    //{
    //    if (renewobj)
    //    {
    //        DropDown();
    //        renewobj = false;
    //    }
    //}
}