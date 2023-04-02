using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed;
    public GameObject id;
    private Animator anim;
   // public float tilt;

    void Awake(){
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        id = GameObject.FindGameObjectWithTag("GameController");
        
    }


    void FixedUpdate()
    {
        float verAxis = Input.GetAxis("Vertical");
        float horAxis = Input.GetAxis("Horizontal");
        // Vector3 movement = new Vector3(horAxis,0.0f, verAxis);
        //GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
        //transform.rotation = Quaternion.Euler(new Vector3(0,0,GetComponent<Rigidbody>().velocity.x * -tilt));

        if(verAxis>0){
            anim.SetFloat("Speed",speed);

      
        }
        else if(verAxis==0){
            anim.SetFloat("Speed",0);
            
            if (horAxis>0){
                anim.SetBool("turnRight",true);
            }
            else if(horAxis==0){

                anim.SetBool("turnRight",false);
            }

            if (horAxis<0){
                anim.SetBool("turnLeft",true);
            }
            else if(horAxis==0){
                anim.SetBool("turnLeft",false);
            }
        }

       
    }
}
