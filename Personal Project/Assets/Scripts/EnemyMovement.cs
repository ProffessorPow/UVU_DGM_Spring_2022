using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject player;

    private Rigidbody goblinRb;
    private float pushbackForce = 1000;

    public float speed;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        goblinRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 walkDirection = (player.transform.position - transform.position).normalized;

        goblinRb.AddForce(walkDirection * speed * Time.deltaTime);
        transform.LookAt(target);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            goblinRb.AddForce((transform.position - player.transform.position) * pushbackForce, ForceMode.Impulse);

            Destroy(gameObject);
        }
    }

}
