
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manage : MonoBehaviour
{
    // Start is called before the first frame update
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameManager gm;
    public levelComplete LC;
    public void CompleteLevel()
    {
        Debug.Log("Level WON!");
        gm.CompleteLevel();
        LC.LoadNextLevel();
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("TEST ENDGAME");
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
            //Restart();
        }
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
