using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator animator;
    public GameObject enemyObject;
    public HealthBar healthBar;
    public GameObject healthBarCanvas;

    public int maxHealth = 100;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        // Play hurt animation
        animator.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Die animation
        animator.SetBool("IsDead", true);
        healthBarCanvas.SetActive(false);

        GetComponent<Collider2D>().enabled = false;
        Destroy(enemyObject, 3.0f);
    }
}
