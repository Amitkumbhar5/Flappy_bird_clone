using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject ara;
    // Start is called before the first frame update
    void Start()
    {
        ara=GameObject.FindGameObjectWithTag("Logic");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer==3)
            ara.GetComponent<logic_manager>().add_score(1);
    }
}
