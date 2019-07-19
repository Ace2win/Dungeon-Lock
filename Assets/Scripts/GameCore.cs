using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{
    public static int Level_ID;

    [SerializeField]
    GameObject I_Player;

    [SerializeField]
    GameObject I_Boss;
   
    GameObject Boss_Spawn;
    GameObject Player_Spawn;

    [SerializeField]
    Vector3 Monster_Spawnpoint = new Vector3 (0,  2, 0);
    [SerializeField]
    Vector3 Player_Spawnpoint  = new Vector3 (0, -1, 0);
    

    void Awake()
    {
        Spawning();
    }

    void Spawning()
    {
        Player_Spawn = GameObject.FindGameObjectWithTag("Player_Spawn");
        Boss_Spawn   = GameObject.FindGameObjectWithTag("Boss_Spawn");

        Player_Spawn.transform.position = Player_Spawnpoint;
        Instantiate(I_Player,Player_Spawn.transform.position,Quaternion.identity);
        Boss_Spawn.transform.position = Monster_Spawnpoint;
        Instantiate(I_Boss, Boss_Spawn.transform.position,Quaternion.identity);
    }

    void Start()
    {
    //  Find Correct Monster corresponed to Level.
    }

    
    void Update()
    {
        
    }
}
