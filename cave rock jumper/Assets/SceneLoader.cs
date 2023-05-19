using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private bool IsInteracting = false;
    private void Start()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            IsInteracting = true;
        }
        else {
            IsInteracting = false;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsInteracting && collision.gameObject.CompareTag("Player")) {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        int currectSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currectSceneIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("No more scenes to load.");
        }
    }
}
