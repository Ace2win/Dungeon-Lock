using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ActiveTurnbaseCombat : MonoBehaviour
{
    #region Variables
    float Globalroundtime = 0;

    float Player_ActiveCombatbar  = 0;
    float[] Monster_ActiveCombatbars;

    float currentATB = 0;
    float maxATB = 10;

    bool ready;
    #endregion

    #region
    Slider ATB_Bar;
    Slider LIFE_Bar;
    Slider BOSS_Bar;
    #endregion

    GameObject I_Player;

    void Start()
    {
        Setup();

        Globalroundtime += Time.deltaTime;
    }

    void Setup()
    {
        I_Player = GameObject.FindGameObjectWithTag("Player");
        ATB_Bar =  GameObject.FindGameObjectWithTag("ATB_Bar").GetComponent<Slider>();
    }

    void Update()
    {
        
    }

    void ATB()
    {
        if(currentATB >= maxATB)
        {
            ready = true;
            // Frag Command aus der Liste ab
            // Reset Current ATB to 0
            //return;
        }
        else
        {
            ready = false;
            currentATB += Time.deltaTime;

        }
    }
}
