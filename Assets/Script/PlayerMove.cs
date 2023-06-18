using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        a++;
    }

    // Update is called once per frame
    void Update()
    {
        if(a == 1)
        {
            Debug.Log("a = 1‚Å‚·");
        }
    }
}
