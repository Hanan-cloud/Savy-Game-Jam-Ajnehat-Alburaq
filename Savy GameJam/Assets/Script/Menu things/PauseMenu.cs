
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject Pause;

    bool paused;
    // Start is called before the first frame update
    void Start()
    {
        Pause.SetActive(false);
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {

            if (paused == false)
            {
                pauseGame();
            }
            else
            {
                continu();
            }
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene("Game");

    }
    public void backToMain()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void continu()
    {
        paused = false;
        Pause.SetActive(false);
        print("resumed");
        Time.timeScale = 1;
    }


    public void pauseGame()
    {
        Pause.SetActive(true);
        paused = true;
        print("paused");
        Time.timeScale = 0;

    }
}
