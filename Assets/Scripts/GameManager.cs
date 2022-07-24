using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public enum GameState:byte { Running, Paused, Restarted, LevelPassed }

    [SerializeField]
    private GameObject[] Levels;
    private GameObject CurrentLevel;
    [SerializeField]
    private Text LevelUI;
    private int _currentLevel;
    private int level
    {
        get { return _currentLevel; }
        set
        {
            _currentLevel = value;
            LevelUI.text = "Level :" + _currentLevel;
        }
    }
    private GameState _state;
    public GameState asd;
    public GameState State
    {
        get { return _state; }
        set
        {
            _state = value;
            switch (_state)
            {
                case GameState.Running:
                    RunGame();
                    break;
                case GameState.Paused:
                    Time.timeScale = 0;
                    break;
                case GameState.Restarted:
                    break;
                case GameState.LevelPassed:
                    LevelPassed();
                    break;
                default:
                    break;
            }
        }
    }
    private void OnEnable()
    {
        State = GameState.Running;
        NextLevel();
    }
    public void RunGame()
    {
        Time.timeScale = 1;
    }
    public void PauseGame()
    {
        State = GameState.Paused;
    }
    void NextLevel()
    {
        if (level <= Levels.Length)
        {
            Destroy(CurrentLevel);
            CurrentLevel = Instantiate(Levels[level]);
            level++;
        }
        else
        {

        }
    }
    void LevelPassed()
    {
        Time.timeScale = 0;
    }
    void RestartGame()
    {
        level = 0;
        NextLevel();
    }
    public void Retry()
    {
        level--;
        NextLevel();
        State = GameState.Running;
    }

    private void OnDisable()
    {
        Application.Quit();
    }
    public void StateChange([SerializeField] GameState state)
    {
        State =state;
    }
}
