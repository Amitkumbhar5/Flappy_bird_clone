using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class brdjump : MonoBehaviour
{
    public Rigidbody2D myrb;
    public float flapstrength;
    public GameObject ara;
    private bool birdalive = true;
    // Start is called before the first frame update
    void Start()
    {
        ara = GameObject.FindGameObjectWithTag("Logic");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true && birdalive==true)
        {
            myrb.velocity = Vector2.up * flapstrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ara.GetComponent<logic_manager>().Game_over();
        birdalive = false;
    }

}
