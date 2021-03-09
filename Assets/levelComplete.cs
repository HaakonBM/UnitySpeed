using UnityEngine.SceneManagement;
using UnityEngine;

public class levelComplete : MonoBehaviour
{
    
    public void LoadNextLevel()
    {
        Debug.Log("Loader ny level fra levelComplete");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
