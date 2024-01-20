using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerFinished : MonoBehaviour
{

    [SerializeField] float delay_time = 1f;
    [SerializeField] ParticleSystem finish_effect;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Finish"){
            finish_effect.Play();
            Invoke("ReloadScene", delay_time);
        }
    }
    // User Defined Method Name: reload_scene
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }

}
