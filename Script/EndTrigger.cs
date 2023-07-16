using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Game_Manager gamemanager;

    void OnTriggerEnter ()
    {
        gamemanager.completelevel();
    }
    
}
