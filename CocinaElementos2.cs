using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocinaElementos2 : MonoBehaviour
{

     
    public class Almacenadores   


    {
        public void VerPrecio();

        public string precio1 = "S/.50";
        public string precio2 = "S/.100"; 
    }

    public class Ambiente

    {
        public void Comprar();


        public string comprarprecio1 = "Si";
    }


    public static void Almacen()
    {

        string[] arr = new string[3];

        arr[0] = "alacena";
        arr[1] = "porta frutas";
        arr[2] = "granos";
    }


    public class Congeladores

    {
        public void Comprar();

        public string comprarprecio2 = "Si";
    }

    public void Parte()

    {

        string[] arr = new string[2];

        arr[0] = "molde para cubos de hielo";
        arr[1] = "zona freezer";



        Debug.Log(precio1 + comprarprecio1 + Almacen, precio2 + comprarprecio2 + Parte);
    }

    public class Condimentos


    {

        public void VerPrecio();

        public string precio1 = "S/.70";
        public string precio2 = "S/.200";
        public string precio3 = "S/.90";
    }

    public class Salados

    {
        public void Comprar();


        public string comprarprecio1 = "Si";
    }

    public void Sal()

    {

        string[] arr = new string[3];

        arr[0] = "marina";
        arr[1] = "rosada";
        arr[2] = "yodada";
    }




    public class Dulces

    {
        public void Comprar();

        public string comprarprecio2 = "Si";
    }

    public void Dulcificador()

    {

        string[] arr = new string[3];

        arr[0] = "azúcar";
        arr[1] = "stevia";
        arr[2] = "splenda ";
    }


    public class Picantes

    {
        public void Comprar();

        public string comprarprecio3 = "Si";
    }

    public void Pimienta()
    {

        string[] arr = new string[3];

        arr[0] = "roja";
        arr[1] = "negra";
        arr[2] = "rosa";



        Debug.Log(precio1 + comprarprecio1 + Sal, precio2 + comprarprecio2 + Dulcificador, precio3 + comprarprecio3 + Pimienta);


    }

    public class Carnes


    {

        public void VerPrecio();

        public string precio1 = "S/.40";
        public string precio2 = "S/.100";
        public string precio3 = "S/.30";
    }

    public class Cuadrúpedas

    {
        public void Comprar();
        public string comprarprecio1 = "Si";
    }

    public void CarneTipo()
    {

        string[] arr = new string[3];

        arr[0] = "bistek";
        arr[1] = "molida";
        arr[2] = "roja res";
    }

    public class Marinas

    {
        public void Comprar();
        public string comprarprecio2 = "Si";
    }

    public void MarinaTipo()
    {

        string[] arr = new string[3];

        arr[0] = "pescado";
        arr[1] = "tentaculo pulpo";
        arr[2] = "huevera";
    }


    public class Bípedas

    {
        public void Comprar();
        public string comprarprecio3 = "Si";
    }

    public void PolloParte()

    {

        string[] arr = new string[3];

        arr[0] = "pata";
        arr[1] = "pecho";
        arr[2] = "encuentro";



        Debug.Log(precio1 + comprarprecio1 + CarneTipo, precio2 + comprarprecio2 + MarinaTipo, precio3 + comprarprecio3 + PolloParte);

    }



    public class Frutas


    {

        public void VerPrecio();

        public string precio1 = "S/.20";
        public string precio2 = "S/.15";
    }

    public class Rojas

    {
        public void Comprar();
        public string comprarprecio1 = "Si";
    }

    public void PropiedadRoja()
    {

        string[] arr = new string[3];

        arr[0] = "manzana roja";
        arr[1] = "tomate";
        arr[2] = "cereza";
    }


    public class Verdes

    {
        public void Comprar();
        public string comprarprecio2 = "Si";
    }

    public void PropiedadVerde()
    {

        string[] arr = new string[3];

        arr[0] = "manzana verde";
        arr[1] = "pera";
        arr[2] = "uva verde";

        Debug.Log(precio1 + comprarprecio1 + PropiedadRoja, precio2 + comprarprecio2 + PropiedadVerde);
    }





    public class Granos


    {

        public void VerPrecio();

        public string precio1 = "S/.10";
        public string precio2 = "S/.30";
    }

    public class Fondo

    {
        public void Comprar();
        public string comprarprecio1 = "Si";
    }

    public void ComidaPrincipal();

{

  string[] arr = new string[3];

    arr[0] = "frejol";
    arr[1] = "lentejas";
    arr[2] = "pallar";
}

public class Acompañamiento

{
    public void Comprar();
    public string comprarprecio2 = "Si";
}

public void ComidaSecundaria();

{
  string[] arr = new string[3];

   arr[0] = "trigo";
    arr[1] = "choclo";
    arr[2] = "arroz";  

 Debug.Log(precio1 + comprarprecio1 + ComidaPrincipal, precio2 + comprarprecio2 + ComidaSecundaria);

}

    public class Iluminación


{

    public void VerPrecio();


    public string precio1 = "S/.80";
    public string precio2 = "S/.100";
}

public class Receptores

{
    public void Comprar();
    public string comprarprecio1 = "Si";
}

public void Foco();

{

string[] arr = new string[2];

arr[0] = "led";
    arr[1] = "ahorrador";
 

}


public class Procesadores

{
    public void Comprar();
    public string comprarprecio2 = "Si";
}

public void Componente();

{
 string[] arr = new string[3];

arr[0] = "interruptor";
    arr[1] = "cable";
    arr[2] = "fuente energía";  

    Debug.Log(precio1 + comprarprecio1 + Foco, precio2 + comprarprecio2 + Componente);

}

    public class Implementos


{

    public void VerPrecio();


    public string precio1 = "S/.40";
    public string precio2 = "S/.150";
    public string precio3 = "S/.60";
}

public class Calentadores

{
    public void Comprar();
    public string comprarprecio1 = "Si";
}

public void TipoCalentador();

{

string[] arr = new string[3];

arr[0] = "microondas";
    arr[1] = "horno";
    arr[2] = "parrilla"; 
     
}  

public class Energía

{
    public void Comprar();
    public string comprarprecio2 = "Si";
}

public void ParteEnergía();

{

string[] arr = new string[3];

arr[0] = "hornilla";
    arr[1] = "balón gas";
    arr[2] = "cerillos";
     
}

public class Hervidores

{
    public void Comprar();
    public string comprarprecio3 = "Si";
}

public void Olla();
{

string[] arr = new string[2];

arr[0] = "pequeña";
    arr[1] = "presión";
  
  Debug.Log(precio1 + comprarprecio1 + TipoCalentador, precio2 + comprarprecio2 + ParteEnergía, precio3 + comprarprecio3 + Olla); 

} 

    public class Instantáneos


{

    public void VerPrecio();

    public string precio1 = "S/.140";
    public string precio2 = "S/.110";
}

public class Harinas

{
    public void Comprar();
    public string comprarprecio1 = "Si";
}

public void Preparador();

{
string[] arr = new string[3];

arr[0] = "tostadora";
    arr[1] = "waflera";
    arr[2] = "mini horno galletas";
    
}
public class Salados

{
    public void Comprar();
    public string comprarprecio2 = "Si";
}

public void Máquina();
{
string[] arr = new string[3];
arr[0] = "por corn";
    arr[1] = "papas fritas";
    arr[2] = "hot dog";
 Debug.Log(precio1 + comprarprecio1 + Preparador, precio2 + comprarprecio2 + Máquina);

}   

    public class Limpieza


{

    public void VerPrecio();

    public string precio1 = "S/.40";
    public string precio2 = "S/.30";
}

public class Suelo

{
    public void Comprar();
    public string comprarprecio1 = "Si";
}

public void ElementosLimpiaSuelo();

{
string[] arr = new string[3];
arr[0] = "escoba";
    arr[1] = "recogedor";
    arr[2] = "trapo cocina";

}

public class Brillo

{
    public void Comprar();
    public string comprarprecio2 = "Si";
}

public void TipoAbrillantador();
 {

string[] arr = new string[3];
arr[0] = "cera suelo";
arr[1] = "líquido saca grasa"; 
arr[2] = "ayudín líquido lava platos";

 Debug.Log(precio1 + comprarprecio1 + ElementosLimpiaSuelo, precio2 + comprarprecio2 + TipoAbrillantador);

}  

    public class Líquidos


{

    public void VerPrecio();
    public string precio1 = "S/.50";
    public string precio2 = "S/.60";
}

public class Procesadores

{
    public void Comprar();
    public string comprarprecio1 = "Si";
}

public void TipoMáquina();

{
string[] arr = new string[3];
arr[0] = "cafetera ";
arr[1] = "filtro agua"; 
arr[2] = "máquina jugo";       
}
public class Contenedores

{
    public void Comprar();
    public string comprarprecio2 = "Si";
}

public void TamañoContenedor();

 {
string[] arr = new string[3];
arr[0] = "vaso";
arr[1] = "mini jarra"; 
arr[2] = "jarra";
 Debug.Log(precio1 + comprarprecio1 + TipoMáquina, precio2 + comprarprecio2 + TamañoContenedor);  

}   

    public class Utensilios


{

    public void VerPrecio();
    public string precio1 = "S/.10";
    public string precio2 = "S/.20";
}

public class Principales

{
    public void Comprar();
    public string comprarprecio1 = "Si";
}

public void ObjetoPrincipal();

{
string[] arr = new string[3];
arr[0] = "tenedor";
arr[1] = "cuchillo"; 
arr[2] = "cuchara";    
}
     
public class Secundarios

{
    public void Comprar();
    public string comprarprecio2 = "Si";
}

public void ObjetoSecundario();
 {
 
string[] arr = new string[3];
arr[0] = "cucharita";
arr[1] = "cuchador"; 
arr[2] = "individual";       

Debug.Log(precio1 + comprarprecio1 + ObjetoPrincipal, precio2 + comprarprecio2 + ObjetoSecundario);    

}  

public class Verduras


{

    public void VerPrecio();
    public string precio1 = "S/.10";
    public string precio2 = "S/.20";
    public string precio3 = "S/.30";
}

public class Hojas

{
    public void Comprar();
    public string comprarprecio1 = "Si";
}

public void VariedadHoja();

{
string[] arr = new string[3];
arr[0] = "lechuga";
arr[1] = "espinaca";  
arr[2] = "perejil";    
}  
public class Bulbos

{
    public void Comprar();
    public string comprarprecio2 = "Si";
}

public void Cebolla();

{
string[] arr = new string[3];
arr[0] = "verde";
arr[1] = "china";  
arr[2] = "blanca";    
}  
                 
public class Frutales

{
    public void Comprar();
    public string comprarprecio3 = "Si";
}

public void Picante();
 {
 
string[] arr = new string[3];
arr[0] = "ají amarillo";
arr[1] = "rocoto ";  
arr[2] = "chile";     

  Debug.Log(precio1 + comprarprecio1 + VariedadHoja, precio2 + comprarprecio2 + Cebolla, precio3 + comprarprecio3 + Picante); 

 }   

          






}
