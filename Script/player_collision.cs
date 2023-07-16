using UnityEngine;

public class player_collision : MonoBehaviour
{
    public movement refer;
    

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            refer.enabled = false;
            FindObjectOfType<Game_Manager>().Endgame();


        }

    }
}
