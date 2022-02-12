using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GridButton : MonoBehaviour
{
    private Action callback;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetUp(Action callback)
    {
        this.callback = callback;
    }

    public void Click()
    {
        if(callback != null)
        {
            callback();
        }
    }
}
