using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsManager : MonoBehaviour
{
    public bool click = false;
    public GameObject dot;
    public void buttonPress()
    {
        if(click)
        {
            Destroy(dot);
            dot = null;
            click = false;
        }
    }
}
