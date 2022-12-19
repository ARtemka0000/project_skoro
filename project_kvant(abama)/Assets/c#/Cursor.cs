using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Cursor : MonoBehaviour
{
    private Animator animation;
    public int proverka = 0;
    public int proverka2 = 1;
    
    private void OnMouseEnter()
    {
        proverka2 = 1;
        if (GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("anim") == false)
        {
            GameObject.Find("start_button").GetComponent<Animator>().Play("anim");
            GameObject.Find("start_button").GetComponent<Animator>().SetBool("proverka", false);
        }
        
        //if(GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("anim2")==false&& 
        //GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("anim") == false)
        //   {
        //     Debug.Log("abm");
        //    GameObject.Find("start_button").GetComponent<Animator>().Play("anim");
        //     GameObject.Find("start_button").GetComponent<Animator>().SetBool("proverka", true);
        //    
        //}



    }
    private void OnMouseExit()
    {
        proverka2=0;
        StartCoroutine(abnm());
        if (GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("anim") == false)
        {
            GameObject.Find("start_button").GetComponent<Animator>().SetBool("proverka", true);
        }
          
       /* if(proverka==0)
        //{
         //   proverka++;
        }
        
        if (GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("anim") == false&&
            GameObject.Find("start_button").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("anim2") == false )
        {
            Debug.Log("abn");
            GameObject.Find("start_button").GetComponent<Animator>().Play("anim2");
            
        }
       */
    }
    IEnumerator abnm()
    {
        yield return new WaitForSeconds(2);
        if(proverka2==0)
        {
            GameObject.Find("start_button").GetComponent<Animator>().Play("anim2");
        }
    }
   
   


}
