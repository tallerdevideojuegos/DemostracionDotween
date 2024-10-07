using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDemoBrain : MonoBehaviour
{
    // La instancia única del singleton
    public static FinalDemoBrain Instance { get; private set; }

    public event Action<float> OnFrecuenciaChanged;


    // Variable serializada que será editable en el Inspector
    [SerializeField]
    private float frecuencia = 2f;

    // Propiedad pública para acceder a la frecuencia
    public float Frecuencia
    {
        get { return frecuencia; }
        set
        {
            if (Math.Abs(frecuencia - value) > Mathf.Epsilon) // Solo si hay un cambio significativo
            {
                frecuencia = value;
                // Lanzar el evento cuando cambia el valor
                OnFrecuenciaChanged?.Invoke(frecuencia);
            }
        }
    }


    // Se llama automáticamente cuando se cambia un valor desde el editor
    private void OnValidate()
    {
        // Disparar el evento si la frecuencia cambia desde el editor
        if (OnFrecuenciaChanged != null)
        {
            Frecuencia = frecuencia;  // Esto asegura que el setter de la propiedad sea llamado
        }
    }

    private void Awake()
    {
        // Verifica si ya existe una instancia de esta clase
        if (Instance == null)
        {
            // Si no existe, esta instancia se convierte en la instancia singleton
            Instance = this;
        }
        else
        {
            // Si ya existe otra instancia, destruir este objeto para mantener solo una
            Destroy(gameObject);
        }
    }


    // Para almacenar el valor previo y detectar cambios
    private float frecuenciaAnterior;

    void Start()
    {
        frecuenciaAnterior = frecuencia;  // Guardamos el valor inicial
    }

    void Update()
    {
        // Detectar si el valor de la frecuencia cambió (por ejemplo, desde el Inspector)
        if (Math.Abs(frecuencia - frecuenciaAnterior) > Mathf.Epsilon)
        {
            // Si cambió, actualizar la frecuencia anterior y lanzar el evento
            frecuenciaAnterior = frecuencia;
            OnFrecuenciaChanged?.Invoke(frecuencia);
        }

        // Puedes agregar otros cambios programáticos aquí si lo deseas
    }

}
