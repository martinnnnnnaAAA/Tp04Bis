using System;
public class Pais
{
public  string Nombre {get; private set;}
public string imgBandera {get; private set;}
public int Poblacion {get; private set;}
public DateTime FechaIndependencia{get; private set;}
public string AtractivosTuristicos {get; private set;}

public Pais(string nom, string img, int Pob,DateTime F_I, string A_T)
    {
        Nombre = nom;
        imgBandera = img;
        Poblacion = Pob;
        FechaIndependencia = F_I;
        AtractivosTuristicos =A_T;
    }
}

