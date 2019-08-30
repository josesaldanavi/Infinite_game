using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{

    private bool isDead = false;
    private Rigidbody2D rgb2D;
    public float upForce;
    private Animator animationPlayer;
    private void Awake()
    {
        //tomar el rigidbody del personaje
        rgb2D = GetComponent<Rigidbody2D>();
        animationPlayer = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void  Update()
    {
        if (isDead == false)
        {
            movementPlayer();
        }
    }

    private void  movementPlayer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //frenar en picada
            rgb2D.velocity = Vector2.zero;
            //añadir fuerza en el eje y
            rgb2D.AddForce(Vector2.up * upForce);
            animationPlayer.SetTrigger("clic");
        }
    }
     
    //cuando colisione con cualquier collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        animationPlayer.SetBool("is_dead",true);
        //gameController.EstadoMuerto();
        GameController.instance.EstadoMuerto();
    }
}
