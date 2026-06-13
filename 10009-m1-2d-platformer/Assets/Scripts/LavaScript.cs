// Christopher Lawrick-McKinnon #000983825
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public Player player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Kill(new Vector3(15,-20,0));
        }
    }
}
