﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {
    public GameObject go;
    public void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 500f);
        GetComponent<Rigidbody>().useGravity = true;
    }
}
