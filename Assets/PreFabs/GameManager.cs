using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public levelComplete LC;
    public void CompleteLevelUI ()
    {
        completeLevelUI.SetActive(true);
    }
    public void CompleteLevel()
    {
        Debug.Log("Level Won!");
        Debug.Log("Dette er metoden");
        LC.LoadNextLevel();
    }


}
