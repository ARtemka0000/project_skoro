using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBDA : MonoBehaviour
{
    public List<GameObject> inventO;
    public List<bool> inventB;
    private Sprite spr;

    private GameObject INV;
    // Start is called before the first frame update
    void Start()
    {
        INV = GameObject.Find("inventarCOD");
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
                    spr = sprite;
                    viborI();
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
                    GameObject.Find("helpM").GetComponent<SpriteRenderer>().sprite = sprite;
                    spr = sprite;
                    viborI();
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
                    spr = sprite;
                    viborI();
                    break;
                }
            }
        }
        if(Input.GetKey(KeyCode.S))
        {
            for(int n=0;n<1000;n++)
            {
                if (gameObject.name == INV.GetComponent<PlayerBDA>().inventO[n].name)
                {
                    Debug.Log(123);
                }
            }
        }

    }
    public void viborI()
    {
        for(int k=0;k<1000;k++)
        {
            if (INV.GetComponent<PlayerBDA>().inventB[k]==false)
            {
                
                INV.GetComponent<PlayerBDA>().inventO[k].GetComponent<UnityEngine.UI.Image>().sprite = spr;
                INV.GetComponent<PlayerBDA>().inventO[k].GetComponent<UnityEngine.UI.Image>().color=new Color32(255,255,255,255);
                INV.GetComponent<PlayerBDA>().inventB[k] = true;
                Debug.Log(INV.GetComponent<PlayerBDA>().inventO[k].ToString());
                GameObject.Find(INV.GetComponent<PlayerBDA>().inventO[k].name).name = gameObject.name;
                break;
            }
        }
    }
}
