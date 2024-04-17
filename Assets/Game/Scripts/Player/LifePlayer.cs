using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifePlayer : MonoBehaviour
{
    [SerializeField] Sprite[] hearts;




    private int maxHealth = 4;
    private int currentHealth;
   
    private void Start()
    {
        currentHealth = maxHealth;
        //UpdateLife(currentHealth);
        //UpdateHealthUI();
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Método para que el jugador reciba daño
    public void TakeDamage(int daño)
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            //RemoveHealthObject();
            //UpdateHealthUI();
        }

        if (currentHealth <= 0)
        {
            // Aquí puedes manejar la muerte del jugador
        }
    }

    public void CollectHealth()
    {
        if (currentHealth < maxHealth)
        {
            currentHealth++;
            //UpdateHealthUI();
        }
    }

    //private void InitializeHealthImages()
    //{
    //    healthImages = new List<Image>();

    //    // Recorre la lista de objetos de vida y obtiene sus componentes Image
    //    foreach (GameObject healthObject in healthObjects)
    //    {
    //        Image image = healthObject.GetComponent<Image>();
    //        if (image != null)
    //        {
    //            healthImages.Add(image);
    //        }
    //    }

    //    // Llena la lista con imágenes vacías si es necesario
    //    while (healthImages.Count < maxHealth)
    //    {
    //        // Crea una nueva imagen vacía y la agrega a la lista
    //        healthImages.Add(null);
    //    }


    //}


    //public void UpdateLife(int hp)
    //{
    //    foreach (Sprite heart in hearts)
    //    {
    //        heart.enabled = false;
    //    }

    //    for (int i = 0; i < hp; i++)
    //    {
    //        if (i < hearts.Length)
    //        {
    //            hearts[i].enabled = true;
    //        }
    //    }
    //}

    //private void RemoveHealthObject()
    //{
    //    if (hearts.Length > 0)
    //    {
    //        //RawImage removedImage = hearts[hearts.Length - 1];
    //        System.Array.Resize(ref hearts, hearts.Length - 1);
    //        Destroy(removedImage.gameObject);
    //    }
    //}


    // Método para actualizar la interfaz de usuario de la vida del jugador
    //private void UpdateHealthUI()
    //{
    //    // Recorre todas las imágenes de vida y las activa o desactiva según la cantidad actual de vida del jugador
    //    for (int i = 0; i < maxHealth; i++)
    //    {
    //        if (i < currentHealth)
    //        {
    //            hearts[i].enabled = true;
    //        }
    //        else
    //        {
    //            hearts[i].enabled = false;
    //        }
    //    }
    //}
}

