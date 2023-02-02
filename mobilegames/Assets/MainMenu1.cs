using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale <= 0)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            Time.timeScale = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Level1()
    {
        SceneManager.LoadScene("level");
    }
    public void Load()
    {
        SceneManager.LoadScene("level2");
    }
    public void Extras()
    {
        SceneManager.LoadScene("Win screane");
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}