using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameOverText;
    public bool gameOver;

    private void Awake()
    {
        //singleton
        if (GameController.instance == null)
        {
            GameController.instance = this;
        }else if(GameController.instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EstadoMuerto()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    private void OnDestroy()
    {
        if (GameController.instance == this)
        {
            GameController.instance = null;
        }
    }
}
