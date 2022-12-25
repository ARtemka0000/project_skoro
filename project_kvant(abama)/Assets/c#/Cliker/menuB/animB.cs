using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class animB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickM()
    {
        GameObject.Find("menuG").GetComponent<Animator>().Play("start");
    }
    public void OnClickM()
    {
        GameObject.Find("menuG").GetComponent<Animator>().Play("exit");
    }
    public void OnClickE()
    {
        SceneManager.LoadScene("Menu");
    }
    
}
