using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private GameObject balaPref;
    GameObject puntaCanon;
    float rotacion;

    private void Start()
    {
        puntaCanon = transform.Find("PuntaCanon").gameObject;
        
    }
    void Update()
    {
        rotacion += Input.GetAxis("Horizontal") * AdministradorJuego.velocidadRotacion;
        if (rotacion <= -90 && rotacion >= 0)
        {
            transform.eulerAngles = new Vector3(rotacion, 90f, 0);
        }
        if (rotacion > -90) rotacion = -90;
        if (rotacion < 0) rotacion = 0;

        if (Input.GetKeyDown(KeyCode.Space) && AdministradorJuego.disparosPorJuego >= 1)
        {
            GameObject temp = Instantiate(balaPref, puntaCanon.transform.position, transform.rotation);
            Rigidbody tempRB = temp.GetComponent<Rigidbody>();
            Vector3 direccionDisparo = transform.rotation.eulerAngles;
            direccionDisparo.y = -90 - direccionDisparo.x;
            tempRB.velocity = direccionDisparo.normalized * AdministradorJuego.velocidadBala;
            AdministradorJuego.disparosPorJuego -= 1;
        }

    }
}
