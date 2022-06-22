using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameover;
    public GameObject taptostart;
    public GameObject score;
    private void Start()
    {
        gameover.SetActive(false);
        score.SetActive(false);
        taptostart.SetActive(true);
        PauseGame();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }
    public void GameOver()
    {
        score.SetActive(false);
        gameover.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quitgame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        taptostart.SetActive(false);
        score.SetActive(true);
        Time.timeScale = 1f;

    }
}
