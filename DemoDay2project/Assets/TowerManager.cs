using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    #region Singleton 

    public static TowerManager instance;


    void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject TurretTower;
}
