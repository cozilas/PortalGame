using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class coinscolected : MonoBehaviour
{
    // Update is called once per frame
    public static int coins = 0;
    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().SetText(coins.ToString());
    }
}
