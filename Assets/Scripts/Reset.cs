using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{

    public void ResetGame()
    {
        SceneManager.LoadScene("TestHandMenu", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
