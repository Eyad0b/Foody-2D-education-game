using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    PlayerControls controls;

    float direction = 0;
    public  float speedFat;
    public  float speed = 250;
    public  float scalSpeed = 1f;
    public float habdehX;
    public float habdehY;
    public int i = 4;
    public Vector3 valueOfDieting = new Vector3(0.5f,0.5f,0);
    public Vector3 check = new Vector3();

    public static bool isTouched = false;
    public static bool Healther = false;
    public bool isFacingRight = true;

    public float jumpForce = 5;
    bool isGrounded;
    int numberOfJumps = 0;

    public GameObject game;
    public Transform groundCheck;
    public LayerMask groundLayer;

    public Rigidbody2D playerRB;
    public Animator animator;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();

        controls.Land.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };

        controls.Land.Jump.performed += ctx => Jump();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        animator.SetBool("isGrounded", isGrounded);

        playerRB.velocity = new Vector2(direction * speed * Time.fixedDeltaTime, playerRB.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(direction));

        if (isFacingRight && direction < 0 || !isFacingRight && direction > 0)
            Flip();
        if (isTouched && speed > 0)
        {
            habdehX = transform.localScale.x + 0.2f;
            habdehY = transform.localScale.y + 0.2f;
            transform.localScale += valueOfDieting;
            check = transform.localScale;
            speedFat = 100f;
            speed = speed - 0.5f * speedFat;
            isTouched = false;
        }
        if (Healther && BecomeHealther.enterCount < 7)
        {
                habdehX -= valueOfDieting.x;
                habdehY -= valueOfDieting.y;
                transform.localScale = new Vector3(habdehX, habdehY, 0);
                check = new Vector3(habdehX, habdehY, 0);
                speedFat = 250f;
                speed = speed + 0.1f * speedFat;
                Healther = false;
                transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
    }

    void Jump()
    {
        if (isGrounded)
        {
            numberOfJumps = 0;
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
            numberOfJumps++;
            AudioManager.instance.Play("FirstJump");
        }
        else
        {
            if (numberOfJumps == 1)
            {
                playerRB.velocity = new Vector2(playerRB.velocity.x, jumpForce);
                numberOfJumps++;
                AudioManager.instance.Play("SecondJump");
            }
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
}
