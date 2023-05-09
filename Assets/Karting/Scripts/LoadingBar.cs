using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    [SerializeField] private GameObject ProgressPanel;
    [SerializeField] private Slider ProgressBar;
    [SerializeField] private Text ProgressValue;

    public void Awake()
    {
        ProgressPanel.SetActive(false);
    }

    public void LoadLevel(string levelName)
    {
        ProgressPanel.SetActive(true);
        StartCoroutine(LoadLevelAsync(levelName));
    }

    private IEnumerator LoadLevelAsync (string levelName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelName);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress);
            ProgressBar.value = progress;
            ProgressValue.text = (progress * 100f).ToString("F0") + "%";
            
            // Debug.Log(progress);
            yield return null;
        }
    }
}
