using UnityEngine.SceneManagement;
using UnityEngine;

public class welcome : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
