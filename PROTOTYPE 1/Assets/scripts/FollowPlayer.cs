using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject PLayer;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Offset thw camera behind the player by adding the player's postion
        transform.postion = PLayer.transform.position + new Vector3(0, 5, -7);

    }
}
