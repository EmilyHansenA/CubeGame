using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
