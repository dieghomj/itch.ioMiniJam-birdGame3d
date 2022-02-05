using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField]private int streakMax = 10;
    public int streak = 1;
    public int scorePoints = 0;
    private bool streakBool = true;
    private void OnCollisionEnter(Collision other) {

        if(other.collider.tag == "Wall"){
            streakBool = false;
        }

        if(other.collider.tag == "Obstacle"){
            if(streakBool){
                scorePoints+=2 * streak;
                if(streak < streakMax)streak++;
            }
            else {
                streakBool = true;
                streak = 1;
                scorePoints+=2;
            }
        }

    }
}
