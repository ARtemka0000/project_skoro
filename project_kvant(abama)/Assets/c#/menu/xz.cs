using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        GameObject.Find("settingsO").GetComponent<Animator>().Play("pon2");
        GameObject.Find("anim").GetComponent<Animator>().Play("dsleep3 0");
    }
}
