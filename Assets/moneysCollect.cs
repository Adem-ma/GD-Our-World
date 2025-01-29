using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneysCollect : MonoBehaviour
{


    private int Coin = 0;

    public Text output;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Coin++;
            output.text = Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
        }
    }
}
