using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

	public void LoadSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Scene2");
    }

}

