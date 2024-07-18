using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    private Rigidbody2D rb;
    private Vector2 moveDir;
    private Knockback knockback;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        knockback = GetComponent<Knockback>();  
    }

    private void FixedUpdate()
    {
        if(knockback.GettingKnockedBack) return;
        rb.MovePosition(rb.position + moveDir* (moveSpeed* Time.deltaTime));
    }

    public void MoveTo(Vector2 target)
    {
        moveDir = target;
    }
}
