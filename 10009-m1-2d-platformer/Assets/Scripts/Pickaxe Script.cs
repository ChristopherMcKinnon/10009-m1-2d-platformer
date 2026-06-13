using UnityEngine;

public class PickaxeScript : MonoBehaviour
{
    public Player player;
    public bool Collected = false;
    private void OnTriggerEnter2D(Collider2D col)
    {
        // Check if Player has hit the pickup
        // (See Inspector tag on GameObject)
        if (col.CompareTag("Player"))
        {
            // Increment number of these collected
            Collected = true;
            // Dusable object on it's collection
            // This must be the last thing we do!
            this.gameObject.SetActive(false);
        }
    }
}
