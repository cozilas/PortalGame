using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    Transform player;
    GameObject youWin;
    private void Awake()
    {
        player = GameObject.Find("PlayerCamera").transform;
        youWin = GameObject.Find("youWin");
    }
    private void LateUpdate()
    {
        transform.LookAt(player);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MainCamera")
        {
            coinscolected.coins++;
            if(coinscolected.coins == 3)
            {
               
                youWin.SetActive(true);
                Time.timeScale = 0;
            }
            
            Destroy(gameObject);
        }
    }
}
