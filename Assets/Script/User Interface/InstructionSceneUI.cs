using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionSceneUI : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 0;
    }
}
