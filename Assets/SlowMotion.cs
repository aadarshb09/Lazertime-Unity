﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class SlowMotion : MonoBehaviour
{
    private float slowMo = .001f;
    private float normTime = 1.0f;
    private bool doSlowMo = false;
    [SerializeField] private FirstPersonController player;

    void Update()
    {
        if(player.m_CharacterController.velocity.magnitude>0)
        {
            if (doSlowMo)
            {
                Time.timeScale = normTime;
                Time.fixedDeltaTime = .02f * Time.timeScale;
                doSlowMo = false;
            }
        }
        else
        {
            if (!doSlowMo)
            {
                Time.timeScale = slowMo;
                Time.fixedDeltaTime = .02f * Time.timeScale;
                doSlowMo = true;
            }
        }
    }
}
