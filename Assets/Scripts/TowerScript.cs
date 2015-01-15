﻿using UnityEngine;
using System.Collections;

public class TowerScript : MonoBehaviour {
    public GameObject BulletPrefab;

    void Clamp () {
        /*
        while (transform.position.x > 12) {
            transform.Translate (new Vector3 (-0.01f, 0, 0));
        }
        */
        /*
        if (transform.position.x > 12 && transform.position.x < 13) {
            transform.position = new Vector3 (12.5f, transform.position.y, transform.position.z);
        }
        */

        StartCoroutine ("Shoot");
        StopCoroutine("Clamp");
    }

    protected virtual void Start () {
        StartCoroutine ("Clamp");
    }
}
