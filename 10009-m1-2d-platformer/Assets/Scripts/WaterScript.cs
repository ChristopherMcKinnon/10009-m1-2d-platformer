// Christopher Lawrick-McKinnon #000983825
using UnityEngine;

public class WaterScript : MonoBehaviour
{

    public Player player;
    float playerSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // Collision
    void OnTriggerEnter2D(Collider2D col)
    {
        playerSpeed = player.targetSpeedX;
        if (col.CompareTag("Player"))
        {
            player.speedX = playerSpeed / 2;
        }
        
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.speedX = playerSpeed;
        }
        
    }
}
