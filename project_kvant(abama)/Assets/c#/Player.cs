using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite armorBODY;
    public Sprite armorVERH;
    public Sprite orujie;
    public List<Sprite> vse;
    
    private float zaderchka=0.30f;
    private bool proverka = false;
    [SerializeField] private RaycastHit2D[] hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            if(proverka==false)
            {
                StartCoroutine(abn());
            }
            
        }
    }
    IEnumerator abn()
    {
        proverka = true;
        GetComponent<Animator>().Play("at");
        hit = Physics2D.RaycastAll(transform.position, new Vector2(transform.position.x + 5, transform.position.y)) ;
        for(int n=0;n<100;n++)
        {
            if (hit[n]==GameObject.Find("maneken"))
            {
                
                GameObject.Find("maneken").GetComponent<manek>().Udar();
                break;
            }
        }
        yield return new WaitForSeconds(zaderchka);
        proverka = false;
        
    }
}
