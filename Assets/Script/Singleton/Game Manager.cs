using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Singleton implementation:
    public static GameManager instance { get; private set; }
    public enum GameState
    {
        MainMenu,
        LevelOne,
        LevelTwo,
        LevelThree,
        Instruction,
        Congrats
    }
    
    public GameState currentState = GameState.MainMenu;

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        ChangeGameState(currentState);
    }

    public void ChangeGameState(GameState newState)
    {
        if (currentState == newState) return;
        currentState = newState;

        switch (currentState)
        {
            case GameState.MainMenu:
                SceneManager.LoadScene("MainMenu");
                break;
            case GameState.LevelOne:
                SceneManager.LoadScene("SampleScene");
                break;
            case GameState.LevelTwo:
                SceneManager.LoadScene("Level 2");
                break;
            case GameState.LevelThree:
                SceneManager.LoadScene("Level 3");
                break;
            case GameState.Instruction:
                SceneManager.LoadScene("Level 3");
                break;
            case GameState.Congrats:
                SceneManager.LoadScene("CongratsScreen");
                break;
        }
    }
}
