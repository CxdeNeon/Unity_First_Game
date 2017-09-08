using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;


	// Update is called once per frame
	void Update () {

        transform.position = player.position + offset;

        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
