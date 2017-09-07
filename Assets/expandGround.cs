using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expandGround : MonoBehaviour {

    public Transform player;
    public Vector3 extendVector = new Vector3(0f, 0f, 0f);
    // Update is called once per frame
	void Update () {

    if(player.position.x != transform.position.x)
        {
            transform.localScale + extendVector;
        }

	}
}
