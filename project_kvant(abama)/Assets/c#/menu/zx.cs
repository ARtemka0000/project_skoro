using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zx : MonoBehaviour
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
        
        GameObject.Find("settingsO").GetComponent<Animator>().Play("pon");
        GameObject.Find("anim").GetComponent<Animator>().Play("dsleep4");
    }
}
