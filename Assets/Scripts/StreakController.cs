using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StreakController : MonoBehaviour
{

    [SerializeField] private GameObject player;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "  STREAK: x" + player.GetComponent<PlayerController>().streak.ToString();
    }
}
