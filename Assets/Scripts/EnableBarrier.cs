using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableBarrier : MonoBehaviour
{
    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.y > gameController.BorderTop)
        {
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, gameController.BorderTop);
        }

        if (this.gameObject.transform.position.y < gameController.BorderBottom)
        {
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, gameController.BorderBottom);
        }

        if (this.gameObject.transform.position.x < gameController.BorderLeft)
        {
            this.gameObject.transform.position = new Vector2(gameController.BorderLeft, this.gameObject.transform.position.y);
        }

        if (this.gameObject.transform.position.x > gameController.BorderRight)
        {
            this.gameObject.transform.position = new Vector2(gameController.BorderRight, this.gameObject.transform.position.y);
        }
    }
}
