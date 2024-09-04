using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    public float speed = 5f;
    public float deactivate_timer = 3f;
    public Vector2 direction;
    public bool isEnemy = true;


    private void OnEnable()
    {
        //Start the deactivation timer when the bullet is activated
        Invoke("Deactivate", deactivate_timer);
    }

    private void OnDisable()
    {
        //Cancel the deactivation if the bullet is deactivated early
        CancelInvoke();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

private void OnTriggerEnter2D(Collider2D collision)
{
    if(collision.tag == "Border")
    {
        Destroy(this.gameObject);
    }

}

    void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
