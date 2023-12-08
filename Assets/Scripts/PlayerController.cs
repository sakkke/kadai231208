using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    GameObject ammo;

    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(0, 0.1f, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(0, -0.1f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(0.1f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!this.gameController.AmmoExists)
            {
                Instantiate(this.ammo, this.gameObject.transform.position, Quaternion.identity);

                this.gameController.AmmoExists = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            this.gameController.GameOver();
        }
    }
}
