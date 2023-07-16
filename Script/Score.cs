using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoretext; 

    // Update is called once per frame
    void Update()
    {
        scoretext.text = player.position.z.ToString("0");
    }
}
