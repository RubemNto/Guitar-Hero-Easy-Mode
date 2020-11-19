using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dots : MonoBehaviour
{
    public float speed;
    public buttonsManager bM;
    void Start()
    {
        bM = GameObject.Find("ButtonsManager").GetComponent<buttonsManager>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-speed*Time.deltaTime,0);
        if(transform.position.y<=-10)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D Other)
    {
        bM.click = true;
        bM.dot = gameObject;
    }
}
