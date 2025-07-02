using TMPro;
using UnityEngine;

public class texto : MonoBehaviour
{
    public string novoTexto;
    
    public TextMeshProUGUI UItexto;
    
    public int numero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UItexto.text = novoTexto + numero.ToString();
        }
    }
}
