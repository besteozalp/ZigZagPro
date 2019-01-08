using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    bool sagaMiBakiyor;
    public Rigidbody rb;
    GameManager gameManager;
    Animator animController;
    public Transform rayOrijin;
     

    private void Start()
    {
        sagaMiBakiyor = true;
        gameManager = FindObjectOfType<GameManager>();
        animController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            YonDegistir();
        }

        if (transform.position.y < -2)
        {
            gameManager.RestartGame();
        }

	}

    private void YonDegistir()
    {
        sagaMiBakiyor = !sagaMiBakiyor;

        if (sagaMiBakiyor)
        {
            transform.rotation = Quaternion.Euler(0, 45, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, -45, 0);
        }
    }

    private void FixedUpdate()
    {
        if (!gameManager.isGameStarted) return;
        else
        {
            animController.SetTrigger("gameStarted");
            rb.position += transform.forward * Time.deltaTime;

            if (!Physics.Raycast(rayOrijin.position, Vector3.down))
            {
                animController.SetTrigger("falling");
            }
        }
    }
}
