using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifePlayer : MonoBehaviour
{
    public List<GameObject> healthObjects; // Lista de objetos de vida
    public GameObject healthPrefab;
   
    private int maxHealth = 4;
    private int currentHealth;
    private List<Image> healthImages; //Esta lista almacena los componentes Image de los GameObjects en la lista healthObjects

    private void Start()
    {
        currentHealth = maxHealth;
        InitializeHealthImages();
        UpdateHealthUI();
    }

    // Método para que el jugador reciba daño
    public void TakeDamage(int daño)
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            RemoveHealthObject();
            UpdateHealthUI();
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
            //AddHealthObject();
            UpdateHealthUI();
        }
    }

    private void InitializeHealthImages()
    {
        healthImages = new List<Image>();

        // Recorre la lista de objetos de vida y obtiene sus componentes Image
        foreach (GameObject healthObject in healthObjects)
        {
            Image image = healthObject.GetComponent<Image>();
            if (image != null)
            {
                healthImages.Add(image);
            }
        }

        // Llena la lista con imágenes vacías si es necesario
        while (healthImages.Count < maxHealth)
        {
            // Crea una nueva imagen vacía y la agrega a la lista
            healthImages.Add(null);
        }


    }

    private void RemoveHealthObject()
    {
        if (healthImages.Count > 0)
        {
            Image removedImage = healthImages[healthImages.Count - 1];
            healthImages.RemoveAt(healthImages.Count - 1);
            Destroy(removedImage.gameObject);
        }
    }

    //Método para agregar un objeto de vida a la pantalla
    //private void AddHealthObject()
    //{
    //    if (healthImages.Count < maxHealth)
    //    {
    //        // Se crea una nueva imagen y se agrega a la lista
    //        Image newImage = Instantiate(healthPrefab, healthPrefab.transform.parent).GetComponent<Image>();
    //        healthImages.Add(newImage);
    //    }
    //}

    // Método para actualizar la interfaz de usuario de la vida del jugador
    private void UpdateHealthUI()
    {
        // Recorre todas las imágenes de vida y las activa o desactiva según la cantidad actual de vida del jugador
        for (int i = 0; i < maxHealth; i++)
        {
            if (i < currentHealth)
            {
                healthImages[i].enabled = true;
            }
            else
            {
                healthImages[i].enabled = false;
            }
        }
    }

    //public void UpdateLife(int hp)
    //{
    //    foreach (RawImage heart in hearts)
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
