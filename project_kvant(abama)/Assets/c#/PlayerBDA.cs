using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBDA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void vibor()
    {
        char[] ind = gameObject.name.ToCharArray();
        string name = ind[0].ToString();
        if(name=="D")
        {
            for (int i = 0; i < 1000000; i++)
            {
                if (gameObject.name == GameObject.Find("Player").GetComponent<Player>().vse[i].name)
                {
                    Debug.Log(4);
                    var sprite = GameObject.Find("Player").GetComponent<Player>().vse[i];
                    GameObject.Find("Player").GetComponent<Player>().armorBODY = sprite;
                    GameObject.Find("armor").GetComponent<SpriteRenderer>().sprite = sprite;
                    break;
                }
            } 
        }
        if(name=="B")
        {
            for (int i = 0; i < 1000000; i++)
            {
                if (gameObject.name == GameObject.Find("Player").GetComponent<Player>().vse[i].name)
                {
                    Debug.Log(4);
                    var sprite = GameObject.Find("Player").GetComponent<Player>().vse[i];
                    GameObject.Find("Player").GetComponent<Player>().armorVERH = sprite;
                    GameObject.Find("shlem").GetComponent<SpriteRenderer>().sprite = sprite;
                    break;
                }
            }
        }
        if(name=="O")
        {
            for (int i = 0; i < 1000000; i++)
            {
                if (gameObject.name == GameObject.Find("Player").GetComponent<Player>().vse[i].name)
                {
                    Debug.Log(4);
                    var sprite = GameObject.Find("Player").GetComponent<Player>().vse[i];
                    GameObject.Find("Player").GetComponent<Player>().orujie = sprite;
                    GameObject.Find("armorOR").GetComponent<SpriteRenderer>().sprite = sprite;
                    break;
                }
            }
        }
    }
}
