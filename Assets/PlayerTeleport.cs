using UnityEngine.UI;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour {

    public Transform destination;
    public Transform player;
    public Text countText;

    public float currentScore;
    // Update is called once per frame

    private void Start()
    {
        currentScore = 0;
    }

    private void Update()
    {

        currentScore = player.position.z;
        countText.text = "Score : " + currentScore ;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            player.position = destination.position;

            countText.text = "Score : " + player.position.z;
        }
    }
}
