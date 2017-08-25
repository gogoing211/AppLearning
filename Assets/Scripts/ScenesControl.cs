using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesControl : MonoBehaviour {

    //private static ScenesControl instance;
    
    //public static ScenesControl Instance {
    //    get { return instance; }
    //}

    //public DragAndDrop currentDragItem;

    //private void Awake()
    //{
    //    instance = this; // singleton
    //}

    public void Back()
    {
        SceneManager.LoadScene("Home");
    }
    public void Learn()
    {
        SceneManager.LoadScene("Learn");
    }

    public void FindColors()
    {
        SceneManager.LoadScene("FindColors");
    }
    public void FindName()
    {
        SceneManager.LoadScene("FindName");
    }
    public void MatchColors()
    {
        SceneManager.LoadScene("MatchColors");
    }
    public void ClassifiColorsGame()
    {
        SceneManager.LoadScene("ClassifyColorsGame");
    }
}
