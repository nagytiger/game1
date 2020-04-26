using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    bool gamehasended = false;
    public GameObject completelevelui;
    float restartdelay = 1f;
    public void completelevel()
    {
        completelevelui.SetActive(true);
        Debug.Log("level completed");
    }
   public void endgame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("GameOver");
            restart();
            Invoke("restert", restartdelay);
        }
    }
    void restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
