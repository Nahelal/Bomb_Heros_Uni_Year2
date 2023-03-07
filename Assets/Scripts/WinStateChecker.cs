using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinStateChecker : MonoBehaviour
{
    // array for players in the game
    public GameObject[] players;

    public void WinStateTriggered()
    {
        int playerCount = 0;

        foreach (GameObject player in players)
        {
            // if player game object has not been destroyed, player is alive
            if (player.activeSelf)
            {
                // player count = playercount+1
                playerCount++;
            }
        }

        if (playerCount <= 1)
        {
            // when playercount is less than/= 1, the game scene reloads and the game restarts
            Invoke(nameof(GameReset), 2.5f);
        }

    }

    private void GameReset()
    {
        // reloads the game scene so the game can restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
