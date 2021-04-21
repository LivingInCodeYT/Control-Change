using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D rb;
    private float hInput;

    [Header("Movement")]
    public float moveSpeed;
    [Header("Keys")]
    public KeyCode moveRight;
    public KeyCode moveLeft;
    public KeyCode jump;
    [Header("Jump Stuff")]
    private bool isGrounded;
    public int jumpForce;
    public Transform groundCheck;
    public float checkRad = 0.1f;
    public LayerMask ground;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRad, ground);
        if (Input.GetKey(moveRight)) {
            hInput = 1f * moveSpeed;
        } else if (Input.GetKey(moveLeft)) {
            hInput = -1f * moveSpeed;
        } else if (!Input.GetKey(moveLeft) && !Input.GetKey(moveRight)) {
            hInput = 0f;
        }
        if (Input.GetKeyDown(jump)) {
            if (isGrounded) {
                Jump();
            }
        }
    }
    void FixedUpdate() {
        rb.velocity = new Vector2(hInput, rb.velocity.y);
    }
    void Jump() {
        FindObjectOfType<AudioManager>().Play("jump");
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}