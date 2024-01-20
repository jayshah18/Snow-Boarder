using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCrashed : MonoBehaviour
{
    [SerializeField] float delay_time = 1f;
    [SerializeField] ParticleSystem crash_effect;
    [SerializeField] ParticleSystem rock_collide_2;
    [SerializeField] ParticleSystem rock_collide;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            crash_effect.Play();
            Invoke("ReloadScene",delay_time);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Rock"){
            rock_collide.Play();
            Invoke("ReloadScene",delay_time);
        }
        if(other.gameObject.tag == "Rock2"){
            
            rock_collide_2.Play();
            Invoke("ReloadScene",delay_time);
        }
        if(other.gameObject.tag == "Rock3"){
            rock_collide.transform.position = new Vector3(10.9f,-0.6f,0);
            rock_collide.Play();
            Invoke("ReloadScene",delay_time);
        }
    }
    
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
