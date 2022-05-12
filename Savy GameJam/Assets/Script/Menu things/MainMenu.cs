
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject instruction;
    // Start is called before the first frame update
    void Start()
    {
        openMain();
    }




    public void openMain()
    {

        mainMenu.SetActive(true);
        instruction.SetActive(false);
    }

    public void openInstruction()
    {

        mainMenu.SetActive(false);
        instruction.SetActive(true);
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
}
