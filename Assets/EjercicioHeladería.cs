using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioHeladería : MonoBehaviour
{
    public string Chocolate, frutilla, dulceDeLeche;
    public float CantidadChocolate, CantidadFrutilla, CantidadDulceDeLeche;
    float cantidadHelado, PrecioTotalHelado, PrecioHeladoFrutilla, CantidadCHODDL, PrecioCHODDL;
    // Start is called before the first frame update
    void Start()
    {
        if (Chocolate != "CHO" || frutilla != "FRU" || dulceDeLeche != "DDL" || CantidadChocolate < 250 || CantidadChocolate > 3000 || CantidadFrutilla < 250 || CantidadFrutilla > 3000 || CantidadDulceDeLeche < 250 || CantidadDulceDeLeche > 3000)
        {
            Debug.Log("Error");
        }
        else
        {
            cantidadHelado = CantidadChocolate + CantidadFrutilla + CantidadDulceDeLeche;

            PrecioHeladoFrutilla = ((500f / 1000f) * CantidadFrutilla) * 0.9f;

            CantidadCHODDL = cantidadHelado - CantidadFrutilla;

            PrecioCHODDL = ((500f / 1000f) * CantidadCHODDL);

            PrecioTotalHelado = PrecioHeladoFrutilla + PrecioCHODDL;

            Debug.Log(PrecioTotalHelado);

            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
