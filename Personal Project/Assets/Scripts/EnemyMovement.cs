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
    public float attackDistance;

    public float speed;

    private int playerHealth = 3;

    [SerializeField] private Animator enemyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        goblinRb = gameObject.GetComponent<Rigidbody>();
        playerRb = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 walkDirection = (player.transform.position - transform.position).normalized;
        float enemyDistance = Vector3.Distance (transform.position, player.transform.position);

        if (enemyDistance <= attackDistance)
        {
            StartCoroutine(AttackPlayer());
        }

        goblinRb.AddForce(walkDirection * speed * Time.deltaTime);
        transform.LookAt(player.transform);

        float enemyVelocity = goblinRb.velocity.magnitude;
        if (enemyVelocity > 1.5f)
        {
            enemyAnimator.SetBool("enemyRun", true);
        }
        else if (enemyVelocity <= 1.5f)
        {
            enemyAnimator.SetBool("enemyRun", false);
        }

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

    IEnumerator AttackPlayer()
    {
        enemyAnimator.SetBool("enemyAttacking", true);
        yield return new WaitForSeconds(2.0f);
        enemyAnimator.SetBool("enemyAttacking", false);
    }

}
