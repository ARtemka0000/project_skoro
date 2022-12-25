using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setting : MonoBehaviour
{
    public static bool muzika1=true;
    public static float zvuk1=1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(abn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator abn()
    {
        while(true)
        {
            
            GameObject.Find("music").GetComponent<AudioSource>().enabled = muzika1;

            zvuk1 =GameObject.Find("zvuk").GetComponent<Slider>().value;
            yield return new WaitForSeconds(0);
            if (GameObject.Find("VOLUMEMUSIC").GetComponent<Toggle>().isOn == true)
            {
                muzika1 = true;
            }
            else
            {
                muzika1 = false;
            }

        }
        
        
    }
}
