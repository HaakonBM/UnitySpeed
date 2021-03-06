using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuBtnScrp : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
