
using UnityEngine;

public class DieManager : MonoBehaviour
{
    public GameOver GameOver;
    int maxPlatform = 0;
    bool gameHasEnded = false;

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            GameOver.Setup(maxPlatform);

        }
        
        
    }
}
