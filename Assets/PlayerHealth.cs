using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.Cinemachine;
using Unity.VisualScripting;
public class PlayerHealth : MonoBehaviour
{
    public Slider healthBar;
    public TMP_Text healthText;

    public int health = 100;
        public int maxHealth = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health + " / " + maxHealth;
        healthBar.value = (float)health / (float)maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Slime")
        {
            health = health - 25;
        }
        if(other.gameObject.tag == "Orange")
        {
            health = health + 10;
        }
    }
}
