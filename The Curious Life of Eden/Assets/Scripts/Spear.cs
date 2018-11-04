using UnityEngine;

public class Spear: Weapon
{
    public GameObject grappleHead;
    public GameObject spearBody;
    public GameObject grappleResetGameObject;
    
    public int speed;
    [SerializeField]
    private int grappleRange;
    private Rigidbody2D rb;

    private LineRenderer line;
    [SerializeField]
    private bool hasFired;
    [SerializeField]
    private bool hasCollided;

    [SerializeField]
    private Vector2 restPosition;
    [SerializeField]
    private Vector2 hitPosition;
    [SerializeField]
    private PlayerMovement playerMovement;

    private void Start()
    {
        rb = grappleHead.GetComponent<Rigidbody2D>();
        line = GetComponent<LineRenderer>();
        playerMovement = GetComponentInParent<PlayerMovement>();
        spearBody = gameObject;
    }

    private void Update()
    {
        line.SetPosition(0,restPosition);
        restPosition = grappleResetGameObject.transform.position;
        
        //If we want to fire and have not fired yet
        if (Input.GetKeyDown(KeyCode.Space) && !hasFired)
        {
            OnSkillUsed();
            line.enabled = true;
            hasCollided = false;
            playerMovement.enabled = false;
        }
        
        //If we have not fired yet disable the line renderer and keep track of the rest
        //position as it will be constantly moving or in rest based on character movement
        if(!hasFired)
        {
            //Keep the spear head where it should be incase it is not being fired
            grappleHead.transform.position = restPosition;
            line.enabled = false;
        }
     
        if (hasCollided)
        {
            grappleHead.transform.position = hitPosition;
            var hitPos = new Vector3(hitPosition.x, hitPosition.y, 0f);
            var distance = Vector3.Distance(transform.position, hitPos);
            if (distance > 2f)
            {
                transform.position = Vector3.MoveTowards(transform.position, hitPos, speed * Time.deltaTime);
            }
            else
            {
                hasCollided = false;
                playerMovement.enabled = true;
            }
        }
    }

    private void FixedUpdate()
    {
        if (hasFired)
        {   
            if (ReachedMaxDistance(line.GetPosition(0), line.GetPosition(1)) && !hasCollided)
            {
                RetractSpearHead();
                Debug.Log("Spear retracting!");
            }
            else
            {
                //TODO::fix this vector2 to find the forward direction of the weapon 
                rb.MovePosition(rb.position + new Vector2(-transform.right.x,-transform.right.y).normalized * speed * Time.fixedDeltaTime);
                line.SetPosition(1,rb.transform.position);
                Debug.Log("Spear is traveling in the air!");
            }
        }   
    }

    private bool ReachedMaxDistance(Vector2 start, Vector2 currentPos)
    {
        return Vector2.Distance(start, currentPos) > grappleRange;
    }

    private void RetractSpearHead()
    {
        grappleHead.transform.parent = spearBody.transform;
        grappleHead.transform.position = restPosition;
        line.SetPosition(1,restPosition);
        hasFired = false;
        hasCollided = false;
        playerMovement.enabled = true;
    }

    public override void OnSkillUsed()
    {
        //grappleHead.transform.parent = null;
        hasFired = true;
        restPosition = grappleHead.transform.position;
        line.positionCount = 2;
        line.SetPosition(0,restPosition);
    }

    public void CollisionFromGrappleHead(Collision2D other)
    {
        OnCollisionEnter2D(other);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        hasCollided = true;
        hasFired = false;
        //Get the point on the object u hit stick and move towards it
        hitPosition = other.contacts[0].point;
        //To deal with losing health on the enemy?
        OnTriggerEnter2D(other.collider);
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        Debug.Log("Spear collided with object");
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position,hitPosition);
    }
}