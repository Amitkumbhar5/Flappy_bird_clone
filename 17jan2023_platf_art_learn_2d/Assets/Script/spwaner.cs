using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwaner : MonoBehaviour
{
    public GameObject pipe;
    public Transform pos;
    public float spwanrate =2;
    private float timer =0;
    public float heigh=10f;
    // Start is called before the first frame update
    void Start()
    {
        swanpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spwanrate)
        {
            timer=timer+ Time.deltaTime;
        }
        else
        {
            swanpipe();

            timer=0;
        }
        
    }
    void swanpipe ()
    {
        float lowpoint = pos.position.y - heigh;
        float topoint = pos.position.y + heigh;
        Instantiate(pipe, new Vector3(pos.position.x,Random.Range(topoint,lowpoint),0), pos.rotation);
    }
}
