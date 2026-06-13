// Christopher Lawrick-McKinnon #000983825
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If R key is pressed this frame
        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            // Get current scene
            Scene currentScene = SceneManager.GetActiveScene();
            // Reset scene
            SceneManager.LoadScene(currentScene.buildIndex, LoadSceneMode.Single);
        }
    }
}
