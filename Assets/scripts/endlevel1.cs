
using UnityEngine;

public class endlevel1 : MonoBehaviour
{
    public gamemanager gamemanager;
    void OnTriggerEnter ()
    {
        gamemanager.completelevel();
    }
}
