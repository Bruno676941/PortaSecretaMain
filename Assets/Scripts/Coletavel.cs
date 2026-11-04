using Unity.VisualScripting;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    
        public string nomeDoItem = "Item Coletável";
    public float velocidadeGiro = 90f;


    void Update()
    {
        transform.Rotate(0, velocidadeGiro * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        Inventario inventario = other.GetComponent<Inventario>();
        if (inventario != null)
        {
            inventario.AdicionarItem(nomeDoItem);
            Destroy(gameObject);
        }
    }
   
}
