using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScrp : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnApplicationQuit()
    {
        
    }
    public void Quit ()
    {
        Debug.Log("Quitting");
        Application.Quit(); 
    }

}
