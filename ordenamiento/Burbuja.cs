using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenamiento
{
    public class Burbuja
    {
        public void Ordenar(int [] arr) {
            throw new NotImplementedException("Crear los casos de prueba");
            int aux = 0;

            for(int i = 0; i < arr.Length; i++) {
                for(int j = 0; j < arr.Length-1; j++) {
                    if(arr[j] > arr[j + 1]) {
                    aux = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = aux;
                    }
                }
            }
        }
    }
}
