// Christopher Lawrick-McKinnon #000983825
using UnityEngine;

public class WaterCan : MonoBehaviour
{
    public static int NumberCollected = 0;
    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        // Check if Player has hit the pickup
        // (See Inspector tag on GameObject)
        if (collider2d.gameObject.CompareTag("Player"))
        {
            // Increment number of these collected
            NumberCollected += 1;
            Debug.Log($"Watering can collected {NumberCollected}");
            // Dusable object on it's collection
            // This must be the last thing we do!
            this.gameObject.SetActive(false);
        }
    }
}
