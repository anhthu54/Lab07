using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed;
    public GameObject id;
    private Animator anim;

    void Awake(){
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        id = GameObject.FindGameObjectWithTag("GameController");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float verAxis = Input.GetAxis("Vertical");
        float horAxis = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horAxis,0.0f, verAxis);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
        //anim.SetFloat("Speed",speed);
    }
}
