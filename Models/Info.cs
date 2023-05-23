using System;
static class Info
{
private static List<Pais> ListaPaises {get;set;} =  new List<Pais>();

private static void IniciarLista()
{
     ListaPaises.Add(new Pais("Argentina","BanderaArg.png",45,new DateTime(1816, 07, 09),"Obelisco"));
     ListaPaises.Add(new Pais("Brasil","BanderaBr.png",214,new DateTime(1822, 09, 07),"Cristo Redentor"));
     ListaPaises.Add(new Pais("Chile","BanderaCh.png",19,new DateTime(1810, 10, 18),"Cordillera"));
     ListaPaises.Add(new Pais("Peru","BanderaPe.png",33,new DateTime(1821, 07, 28),"Machu Pichu"));
     ListaPaises.Add(new Pais("Bolivia","BanderaBo.png",12,new DateTime(1816, 10, 14),"Isla Incahuasi"));
}
public static List <Pais> ListarPaises()
{
     if (ListaPaises.Count == 0)
     {
     IniciarLista();
     }
     return ListaPaises;
}
public static Pais DetallePais(string PaisIngresado)
{
     foreach (Pais item in ListaPaises)
     {
          if(item.Nombre == PaisIngresado)
          {
          return item;
          } 
         
     }
     return null;
}
}