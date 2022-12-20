using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonM : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] private Sprite a1;
    [SerializeField] private Sprite a1o;
    [SerializeField] private Sprite a2;
    [SerializeField] private Sprite a2o;
    [SerializeField] private Sprite a3;
    [SerializeField] private Sprite a3o;
    [SerializeField] private Sprite a4;
    [SerializeField] private Sprite a4o;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        GameObject.Find("start_button").GetComponent<AudioSource>().Play(0);
        if(gameObject.name== "start_button")
        {
            GameObject.Find("cherep").GetComponent<Image>().sprite=a1o;
        }
        if(gameObject.name== "Hz_cho_button")
        {
            GameObject.Find("cubok").GetComponent<Image>().sprite = a2o;
        }
        if(gameObject.name== "settings_button")
        {
            GameObject.Find("settings").GetComponent<Image>().sprite = a3;
        }
        if(gameObject.name== "exit_button")
        {
            GameObject.Find("exit").GetComponent<Image>().sprite = a4;
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if (gameObject.name == "start_button")
        {
            GameObject.Find("cherep").GetComponent<Image>().sprite = a1;
        }
        if(gameObject.name== "Hz_cho_button")
        {
            GameObject.Find("cubok").GetComponent<Image>().sprite=a2;
        }
        if(gameObject.name== "settings_button")
        {
            GameObject.Find("settings").GetComponent<Image>().sprite = a3o;
        }
        if (gameObject.name == "exit_button")
        {
            GameObject.Find("exit").GetComponent<Image>().sprite = a4o;
        }
    }
}
