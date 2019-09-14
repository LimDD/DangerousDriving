using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    public Button exitButton;
    // Start is called before the first frame update
    void Start()
    {
        exitButton = GetComponent<Button>();
        exitButton.onClick.AddListener(ExitCarGame);
    }

    private void ExitCarGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
