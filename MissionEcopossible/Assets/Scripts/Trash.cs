﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public GameObject claw;
    public GameObject trashItem1;
    public GameObject trashItem2;
    public GameObject trashItem3;
    public int trashCount;

    // Start is called before the first frame update
    void Start()
    {
        claw = GameObject.Find("claw");
        trashItem1 = GameObject.Find("trashItem1");
        trashItem2 = GameObject.Find("trashItem2");
        trashItem3 = GameObject.Find("trashItem3");
        trashCount = 0;

        trashItem1.transform.position = new Vector2(0, -1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //picks up trash item if collides with claw; shows trash info
    void ClawPickup(){

    }
}
