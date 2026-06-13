// Christopher Lawrick-McKinnon #000983825
using UnityEngine;

public class Kill : MonoBehaviour
{
    public Player player;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Kill(new Vector3(0, 0, 0));
        }
    }
}
