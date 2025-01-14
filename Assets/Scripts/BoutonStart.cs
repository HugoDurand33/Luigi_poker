using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene()
    {
        SceneManager.LoadScene("SceneJeu");
    }

}
