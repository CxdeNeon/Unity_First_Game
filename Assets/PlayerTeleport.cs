using UnityEngine.UI;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour {

    public Transform destination;
    public Transform player;
    public Text countText;

    public int currentScore;
    // Update is called once per frame

    private void Start()
    {
        currentScore = 0;
        countText.text = "Score : " + currentScore;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            player.position = destination.position;
            currentScore = currentScore + 1;
            countText.text = "Score : " + currentScore;
        }
    }
}
