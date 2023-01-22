using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{
    public float speed =5;
    private Vector2 scrn;
    // Start is called before the first frame update
    void Start()
    {
        scrn = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position +(Vector3.left * speed *Time.deltaTime);
        if (transform.position.x < scrn.x)
            Destroy(this.gameObject);
    }
}
