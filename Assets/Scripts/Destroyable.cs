using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{

    [SerializeField] private AudioClip breakingSFX;
    [SerializeField] private GameObject destroyedObject;
    private void OnCollisionEnter(Collision other){
        if(other.collider.tag == "Player"){
        AudioSource.PlayClipAtPoint(breakingSFX,transform.position);
        Instantiate( destroyedObject, transform.position, transform.rotation);
        Destroy(gameObject);
     }
    }
}
