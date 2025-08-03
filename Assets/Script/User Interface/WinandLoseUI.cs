using UnityEngine;
using UnityEngine.SceneManagement;

public class WinandLoseUI : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene ("MainMenu");
    }

    public void NextDream() /*Moving to the next level.*/
    {
        SceneManager.LoadScene (3);
    }

    public void ThirdDream()
    {
        SceneManager.LoadScene(4);
    }
    
    public void CongratsScreen()
    {
        SceneManager.LoadScene (5);
    }
}
