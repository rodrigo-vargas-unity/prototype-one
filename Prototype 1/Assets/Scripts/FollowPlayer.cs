using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 8, -10);
    public Vector3 firstPersonOffset = new Vector3(0, 4, 0);
    private bool firstPersonPerspective = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position =
            player.transform.position + (firstPersonPerspective ? firstPersonOffset : offset);

        if (Input.GetKeyDown("space"))
            firstPersonPerspective = !firstPersonPerspective;
    }
}
