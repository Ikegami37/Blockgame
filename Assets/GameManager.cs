using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;
    public GameObject gameOverUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if( DestroyAllBlocks())
        {
            //GameClear
            Debug.Log("GameClear");
        }
    }
    //Block
    private bool DestroyAllBlocks()
    {
        foreach ( Block b in blocks)
        {
            if( b != null)
            {
                return false;
            }
        }
        return true;
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        gameOverUI.SetActive(true);

}
public void GameRetry()
    {
        SceneManager.LoadScene("game");
    }
}
