using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cliker : MonoBehaviour
{
    public int schet = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            schet++;
            GameObject.Find("schet").GetComponent<TextMeshProUGUI>().text = schet.ToString();
        }
    }
    
}
