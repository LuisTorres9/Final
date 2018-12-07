using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int startingHealth = 100;
    [SerializeField] public int currentHealth;
    [SerializeField] public Slider healthSlider;
    [SerializeField] public Image damageImage;
    [SerializeField] public float flashSpeed = 5f;
    [SerializeField] public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    bool isDead;
    bool damaged;
    public GameObject dieText;

    void Awake()
    {
        currentHealth = startingHealth;
    }

 	void Update ()
    {
        if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
	}

    public void TakeDamage(int amount)
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;
        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
        dieText.SetActive(true);
    }
}
