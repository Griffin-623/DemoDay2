
using UnityEngine;

public class TowerHealth : MonoBehaviour
{
    public float Health = 1000f;

    public void TakeDamage(float amount)
    {
        Health -= amount;
        if (Health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {

        FindObjectOfType<DieManager>().EndGame();       

    }


}
