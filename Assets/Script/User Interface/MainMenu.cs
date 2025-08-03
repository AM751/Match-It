using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Canvas _creditsCanvas;
    void Awake()
    {
        Time.timeScale = 0;
    }

    void Start()
    {
        _creditsCanvas.enabled = false;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void Instructions()
    {
        SceneManager.LoadScene("InstructionScene");
        Time.timeScale = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
