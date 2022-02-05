using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour
{

    [SerializeField] private GameObject player;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "  SCORE: " + player.GetComponent<PlayerController>().scorePoints.ToString();
    }
}
