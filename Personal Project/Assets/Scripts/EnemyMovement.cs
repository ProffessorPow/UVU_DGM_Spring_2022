using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject player;

    private Rigidbody goblinRb;
    private Rigidbody playerRb;

    public float pushbackForce;
    public float pushbackForce2;

    public float speed;
    public Transform target;

    private int playerHealth = 3;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        goblinRb = gameObject.GetComponent<Rigidbody>();
        playerRb = GameObject.Find("Player").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 walkDirection = (player.transform.position - transform.position).normalized;

        goblinRb.AddForce(walkDirection * speed * Time.deltaTime);
        transform.LookAt(target);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            playerHealth--;
            goblinRb.AddForce((transform.position - player.transform.position) * pushbackForce, ForceMode.Impulse);
            playerRb.AddForce((player.transform.position - transform.position) * pushbackForce2, ForceMode.Impulse);
            
            Debug.Log("Health: " + playerHealth);
        }
        if (collision.collider.CompareTag("Sword"))
        {
            Destroy(gameObject);
        }
    }

}
