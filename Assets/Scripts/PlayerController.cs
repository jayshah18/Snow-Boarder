using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float torque_amount = 1f;
    [SerializeField] float BoostSpeed = 20f;
    [SerializeField] float BaseSpeed = 10f;
    SurfaceEffector2D se;
    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        se = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        Boost();
    }

    void RotatePlayer(){
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb2d.AddTorque(torque_amount);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            rb2d.AddTorque(-torque_amount);
        }
    }
    void Boost(){
        if(Input.GetKey(KeyCode.UpArrow)){
            se.speed = BoostSpeed;
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            se.speed = BaseSpeed;
        }
    }
}
