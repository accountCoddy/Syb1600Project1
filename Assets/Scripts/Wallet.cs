using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    public int count;
    private TextMeshProUGUI _text;



    private void Start()
    {
        _text = FindObjectOfType<TextMeshProUGUI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            count++;
            Destroy(collision.gameObject);
            _text.text = count.ToString();
        }
    }
}
