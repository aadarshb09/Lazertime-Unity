using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class slowMotion : MonoBehaviour
{
    public float slowMo = .001f;
    private float normTime = 1.0f;
    public bool doingSlowMo = false;
    public FirstPersonController player;

    void Update()
    {
        if(player.m_CharacterController.velocity.magnitude>0)
        {
            if (doingSlowMo)
            {
                Time.timeScale = normTime;
                //Change back to normal fixeddeltatime
                Time.fixedDeltaTime = .02f * Time.timeScale;
                doingSlowMo = false;
            }
        }
        else
        {
            if (!doingSlowMo)
            {
                Time.timeScale = slowMo;
                //set fixed delta time to scale with timescale
                Time.fixedDeltaTime = .02f * Time.timeScale;
                doingSlowMo = true;
            }
        }
    }
}
