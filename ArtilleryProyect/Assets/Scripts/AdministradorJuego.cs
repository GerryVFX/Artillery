using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorJuego : MonoBehaviour
{
    public static AdministradorJuego singletonAdminJuego;
    public static int velocidadBala=30;
    public static int disparosPorJuego = 10;
    public static float velocidadRotacion = 1f;

    private void Awake()
    {
        if (singletonAdminJuego == null)
        {
            singletonAdminJuego = this;
        }
        else Debug.LogError("Ya existe una instancia de esta clase");
    }
}
