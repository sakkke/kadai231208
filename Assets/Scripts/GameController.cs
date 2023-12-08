using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float BorderTop;
    public float BorderBottom;
    public float BorderLeft;
    public float BorderRight;

    public bool AmmoExists;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Enemy") == null)
        {
            SceneManager.LoadScene("GameClearScene");
        }
    }

    void GameClear()
    {
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
