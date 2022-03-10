using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class FirstVideoScript : MonoBehaviour
{
    [SerializeField] private float delayBeforeLoading = 8f;
    [SerializeField] private string sceneNameToLoad;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}


