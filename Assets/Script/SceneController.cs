using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public void PushButtonSatart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
