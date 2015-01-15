﻿using UnityEngine;
using System.Collections;

public class P1MovementScript : PlayerMovementScript {
    protected override void Start () {
        base.Start ();
        m_PXHorizontal = "P1Horizontal";
        m_PXVertical = "P1Vertical";
        SpawnZone = GameObject.Find ("SpawnZoneP1").transform;
    }
}