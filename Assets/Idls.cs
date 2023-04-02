using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idls : MonoBehaviour
{
    //public float speed;
   // public GameObject player;

    void Awake(){
      
        int idleState = Animator.StringToHash("Idle");
        int locoState = Animator.StringToHash("Locomotion");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
