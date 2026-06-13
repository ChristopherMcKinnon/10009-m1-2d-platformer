// Christopher Lawrick-McKinnon #000983825
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject UI;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            UI.gameObject.SetActive(true);
        }
    }
}
