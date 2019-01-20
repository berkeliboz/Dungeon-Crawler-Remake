using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public Transform playerTransform;
    // Update is called once per frame

    public Player PlayerReference;

    void Start()
    {
        PlayerReference = GameObject.FindObjectOfType<Player>();
        transform.parent = PlayerReference.transform;
    }
}
