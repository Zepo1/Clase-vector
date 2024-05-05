using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Vectores
{
    class Vector
    {//Atributos
        const int MaxE = 100;
        int[] vector;
        int dimension;
        //Constructor
        public Vector()
        {
            vector = new int[MaxE];
            this.dimension = 0;

        }
        public void Dimensionar(int dim)
        {
            this.dimension = dim;
        }
        public void adicionar(int x)
        {
            dimension++;
            vector[dimension] = x;
        }
        public void Poner(int pos, int x)
        {
            if (pos >= 1 && pos <= dimension)
            {
                vector[pos] = x;
            }
        }
        public void CargarPares()
        { int x = 2;
            for (int i = 1; i <= dimension; i++)
            {
                vector[i] = x;
                x = x + 2;
            }
        }
        public void CargarFibonacciINV(int ne)
        {
            this.dimension = ne;
            int a = -1;
            int b = 1;
            int c;

            for (int i = dimension; i >= 1; i--)
            {
                c = a + b;
                vector[i] = c;
                a = b; b = c;
            }
        }
        public void fibonacciNormal(int dim)
        {
            this.dimension = dim;
            int a = -1;
            int b = 1;
            int c;

            for (int i = 1; i <= dim; i++)
            {
                c = a + b;
                vector[i] = c;
                a = b; b = c;
            }
        }
        public void CargarImpares()
        {
            int x = 1;
            for (int i = 1; i <= dimension; i++)
            {
                vector[i] = x;
                x = x + 2;
            }
        }
        public void CargarRandom(int a, int b)
        {
            Random r = new Random();
            for (int i = 1; i <= dimension; i++)
            {
                vector[i] = r.Next(a, b + 1);
            }

        }

        public int Dimension()
        {
            return dimension;
        }

        public void Ordenar() {
            for (int i = 1; i <= dimension - 1; i++) {
                for (int j = i + 1; j <= dimension; j++) {
                    if (vector[j] < vector[i]) {
                        int aux = vector[j];
                        vector[j] = vector[i];
                        vector[i] = aux;
                    }
                }
            }
        }
        public void Insertar(int pos, int valor) {
            if (pos >= 1 && pos <= dimension) {
                dimension++;
                int aux = dimension;
                while (aux > pos)
                {
                    vector[aux] = vector[aux - 1];
                    aux--;
                }
                vector[pos] = valor;
            }
        }
        public int Frec(int digito)
        {
            int cant = 0;
            for (int i = 1; i <= dimension; i++)
            {
                if (vector[i] == digito) {
                    cant++;
                }
            }
            return cant;
        }
        public float FibonaDiv() {
            int denominador = 2;
            float acumulador = 0;
            Boolean band = true;
            for (int i = 1; i <= dimension; i++)
            {
                if (band == true) {
                    acumulador = acumulador + float.Parse((vector[i] / denominador).ToString());
                    band = false;
                } else
                {
                    acumulador = acumulador - float.Parse((vector[i] / denominador).ToString());
                    band = true;
                }
                denominador = denominador + 2;
            }
            return acumulador;
        }
        public void Multiplos(Vector R1, Vector R2, int multiplo)
        {

            int n1 = 0; int n2 = 0;
            for (int i = 1; i <= dimension; i++)
            {
                if (vector[i] % multiplo == 0)
                {//Es Multiplo
                    n1++;
                    R1.vector[n1] = vector[i];

                }
                else
                {
                    n2++;
                    R2.vector[n2] = vector[i];

                }
            }
            R1.dimension = n1;
            R2.dimension = n2;
        }
        public Boolean VerifOrd(int a, int b)
        {
            Boolean r = true;
            while (a < b)
            {
                if (vector[a] > vector[a + 1])
                {
                    r = false;
                }
                a++;
            }
            return r;
        }

        public String ToString()
        {
            String s = "[";
            for (int i = 1; i <= dimension; i++)
            {
                s = s + vector[i] + "|";
            }
            // s= s.Remove(s.Length-1, 1);
            s = s + "]";
            return s;
        }
        public int BusElemMay2()
        {
            bool bandera = true; int aux = 0;
            for (int i = 1; i <= dimension; i++)
            {
                if (i % 2 == 0)
                {
                    if (bandera == true)
                    {
                        aux = vector[i];
                        bandera = false;
                    }
                    if (aux < vector[i])
                    {
                        aux = vector[i];
                    }
                }
            }
            return aux;
        }
        public int BusMediaDe2()
        {
            int aux = 0; int dim = 0;
            for (int i = 1; i <= dimension; i++)
            {
                if (i % 2 == 0)
                {
                    aux = aux + vector[i];
                    dim++;
                }
            }
            return aux = aux / dim;
        }
        public void intercambiar(int posA, int posB)
        {
            int aux = vector[posA];
            vector[posA] = vector[posB];
            vector[posB] = aux;
        }
        public void invertirElem()
        {
            int aux = dimension / 2 ; int dim = dimension;
            for(int i = 1; i <= aux ; i++)
            {
                intercambiar(i, dim);
                dim--;
            }

        }
        public bool VeriIgual()
        {
            bool bandera = false; int aux = 0;
            for (int i = 1;i <= dimension; i++)
            {
                if (bandera == false)
                {
                    aux |= vector[i];
                    bandera = true;
                }
                if (vector[i] != aux)
                {
                    return false;
                }
            }
            return true;
        }
        public void ConjIgual(Vector R1 , Vector R2)
        {
         
        }
    }
}
