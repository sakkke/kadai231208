using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float TimeOut;

    [SerializeField]
    float radius;

    float moveX;
    float moveY;

    float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        ChangeMoving();
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(moveX, moveY, 0);

        this.timeElapsed += Time.deltaTime;
        if(this.timeElapsed >= this.TimeOut) {
            Interval();
            this.timeElapsed = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Ammo")
        {
            Destroy(this.gameObject);
        }
    }

    void Interval()
    {
        ChangeMoving();
    }

    void ChangeMoving()
    {
        var moveX = Random.Range(-radius, radius);
        var moveY = Random.Range(-radius, radius);

        this.moveX = moveX;
        this.moveY = moveY;
    }
}
