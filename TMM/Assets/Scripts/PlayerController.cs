using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private InteractableController interactingObject;

    //Player Movement
    public Rigidbody2D theRB;
    public float moveSpeed = 5;
    public Animator myAnim;
    public Slider slider;

    //Level Start
    public GameObject Bed;
    public GameObject Player;
    public bool isSleeping;

    //Interaction
    public GameObject SliderObject;
    public bool interacting;
    public static PlayerController instance;

    public GameEventController gameController;


    void Start()
    {
        instance = this;

        //Level Start
        Player.transform.position = Bed.transform.position;
        isSleeping = true;
    }


    void Update()
    {
        if (isSleeping)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isSleeping = false;
            }
        }
        else
        {
            if (!interacting && !isSleeping)
            {
                Movement();
            }
            else
            {
                myAnim.SetFloat("MoveX", 0);
                myAnim.SetFloat("MoveY", 0);
                theRB.velocity = Vector2.zero;
                if (slider.value < 3)
                {
                    slider.value += Time.deltaTime;
                }
                else
                {
                    slider.value = 0;
                    interacting = false;
                    SliderObject.SetActive(false);
                    interactingObject.GetComponent<InteractableController>().Complete();
                    moveSpeed = 5;
                    gameController.GetComponent<GameEventController>().ObjectiveComplete();
                }
            }
        }
    }

    void Movement()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

        myAnim.SetFloat("MoveX", theRB.velocity.x);
        myAnim.SetFloat("MoveY", theRB.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == -1 || Input.GetAxisRaw("Vertical") == 1)
        {
            myAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }

    public void Interact(InteractableController interactingObject)
    {
        moveSpeed = 0;
        interacting = true;
        this.interactingObject = interactingObject;
        SliderObject.SetActive(true);
    }
}
