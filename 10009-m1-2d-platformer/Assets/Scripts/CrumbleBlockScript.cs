// Christopher Lawrick-McKinnon #000983825
using UnityEngine;

public class CrumbleBlockScript : MonoBehaviour
{
    public Player player;
    public PickaxeScript pickaxe;



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") && pickaxe.Collected == true)
        {
            this.gameObject.SetActive(false);
        }
    }

}
