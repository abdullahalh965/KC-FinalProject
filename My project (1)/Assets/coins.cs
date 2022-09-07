using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coins : MonoBehaviour
{
    int coin = 0;
    public Text coinstext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
  void OnCollisionEnter2D(Collision2D collision)
    {
   if(collision.gameObject.tag == "coin")
        {
            coin += 1;
            Destroy(collision.gameObject);
            coinstext.text = coin.ToString();
        }
    }
}
