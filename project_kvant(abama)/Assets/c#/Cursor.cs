using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Cursor : MonoBehaviour
{
    private Animator animation;
    public int proverka = 0;
    
    private void OnMouseEnter()
    {
        
        if(GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("anim2")==false&& GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("anim") == false)
        {
            GameObject.Find("start_button").GetComponent<Animator>().Play("anim");
            GameObject.Find("start_button").GetComponent<Animator>().SetBool("proverka", true);
            Debug.Log(1);
        }
       
        
        
    }
    private void OnMouseExit()
    {
        if(proverka==0)
        {
            proverka++;
        }
        
        if (GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("anim") == false&& GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("anim2") == false && GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("sleep2") == true)
        {
            
            GameObject.Find("start_button").GetComponent<Animator>().Play("anim2");
            
        }

    }
    private void Update()
    {
        Debug.Log(proverka+"ä");
       if(proverka==1&& GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("anim") == false)
       {
            GameObject.Find("start_button").GetComponent<Animator>().Play("anim2");
            proverka=0;
            
       }
                
    }
   


}
