
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerV2: MonoBehaviour
{
    #region Singleton 

    public static PlayerManagerV2 instance;


    void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject FirstPersonPlayer;




}