using System;
using UnityEngine;
using UnityEngine.SceneManagement;  // For SceneManager

public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // If Reset key (e.g., 'R') is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Reload the current scene
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        }
    }
}
