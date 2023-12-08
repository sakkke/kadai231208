using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoController : MonoBehaviour
{
    [SerializeField]
    float moveY;

    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(0, moveY, 0);

        if (this.gameObject.transform.position.y > gameController.BorderTop)
        {
            Destroy(this.gameObject);
            this.gameController.AmmoExists = false;
        }
    }
}
