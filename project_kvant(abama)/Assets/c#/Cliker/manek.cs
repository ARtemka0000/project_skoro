using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class manek : MonoBehaviour
{
    private GameObject mert1;
    private bool mertv = false;
    public float damage;
    public float hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp<0)
        {
            mert1 = GameObject.Find("manekenS");
            mertv = true;
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(94, 94, 94, 120);
            GameObject.Find("manekenHP").GetComponent<TextMeshProUGUI>().text = "Ì¨ÐÒÂ";
            mert1.SetActive(false);
            StartCoroutine(mert());
        }
    }
    public void Udar()
    {
        if(GameObject.Find("Player").GetComponent<Player>().orujie==null)
        {
            if (mertv == false)
            {
                damage = 1;
                hp -= damage;
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 255);
                StartCoroutine(ah());
            }
        }
        else
        {
            if (mertv == false)
            {
                string vrema;
                vrema = GameObject.Find("Player").GetComponent<Player>().orujie.name;
                for (int n = 0; n < 1000; n++)
                {
                    if (GameObject.Find("infoO").GetComponent<infoOO>().name[n] == GameObject.Find("Player").GetComponent<Player>().orujie.name)
                    {
                        damage = GameObject.Find("infoO").GetComponent<infoOO>().nameD[n];
                        hp -= damage;
                        break;
                    }
                }
            }
        }
        GameObject.Find("manekenS").GetComponent<Slider>().value = hp;
        GameObject.Find("manekenHP").GetComponent<TextMeshProUGUI>().text = hp.ToString();
    }
    IEnumerator ah()
    {
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().color = new Color32(94, 94, 94, 255);
    }
    IEnumerator mert()
    {
        yield return new WaitForSeconds(10);

    }
}
