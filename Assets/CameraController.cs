using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update(){
        Debug.Log(transform.position.ToString());
        Debug.Log(player.transform.position.ToString());
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
    }
    void FixedUpdate(){
        transform.rotation = player.transform.rotation;
    }
}
