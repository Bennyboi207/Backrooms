using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovements : MonoBehaviour
{
    public float speed = 0f;
    public float turnSpeed = 0.5f;
    public float horizontalInput;
    public float forwardInput;
    public float stamina;
    public float maxStamina;
    public Slider staminaBar;
    public float hunger;
    float maxhunger;
    public Slider hungerBar;
    public float thirst;
    float maxThirst;
    public Slider thirstBar;
    public GameObject UiObjectH;
    public GameObject UiObjectT;
    public float hValue;
    public float tValue;
    public float dValue;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        UiObjectH.SetActive(false);
        UiObjectT.SetActive(false);

        maxStamina = stamina;
        staminaBar.maxValue = maxStamina;

        maxThirst = thirst;
        thirstBar.maxValue = maxThirst;

        maxhunger = hunger;
        hungerBar.maxValue = maxhunger;

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
       
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);


           if (Input.GetKey(KeyCode.W))
           {
                if (Input.GetKey(KeyCode.LeftShift))
                DecreaseEnergy();
           }
         else if (stamina != maxStamina)
            IncreaseEnergy();

        if (hunger <= 25)
        {
            UiObjectH.SetActive(true);
        }

        if (hunger > 25)
        {
            UiObjectH.SetActive(false);
        }


        if (thirst <= 25)
        {
            UiObjectT.SetActive(true);
        }

        if (thirst > 25)
        {
            UiObjectT.SetActive(false);
        }

        if (thirst <= 0)
        {
            Destroy(Player);
            {
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }


        staminaBar.value = stamina;
        hungerBar.value = hunger;
        thirstBar.value = thirst;
    }

    private void DecreaseEnergy()
    {
        if (stamina != 0)
            speed = 15;
            stamina -= dValue = Time.deltaTime;

        if (hunger != 0)
            hunger -= hValue = Time.deltaTime;

        if (thirst != 0)
            thirst -= tValue = Time.deltaTime;

    }

    private void IncreaseEnergy()
    {
        if (stamina < maxStamina)
        {
            speed = 5;
            stamina += dValue = Time.deltaTime;
        }
        if (stamina > maxStamina)
        {
            stamina = maxStamina;
        }

    }

    void OnTriggerEnter(Collider collider)
    {
        Destroy(Player);
         {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
         }
       
    }
}