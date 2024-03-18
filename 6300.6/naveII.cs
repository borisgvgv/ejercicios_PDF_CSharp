using System;

public class NaveII
{

    protected int j, k;


    // Usaré el método siguiente si quiero devolver un void
    /* 
        public void SetNaveII(int newj, int newk)
        {
            if ((newj >= 0 && newj <= 1023) && (newk >= 0 && newk <= 767))
            {
                j = newj;

                k = newk;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Los valores deben estar entre 0 y 1023 para j y entre 0 767 para k");
            }
        }


        public void LanzarNaveII()
        {
            Console.WriteLine("Posición de la nave: X = {0}, Y = {1}", j, k);

        }
    */


    //Usaré el método siguente si quiero que retorne los valores

    public int J
    {


        set
        {
            if (value >= 0 && value <= 1023)
            {
                j = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Los valores deben estar entre 0 y 1023 para j y entre 0 767 para k ");
            }


        }
        get
        {
            return j;
        }
    }

    public int K
    {

       set
        {

            if (value >= 0 && value <= 1023)
            {
                k = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Los valores deben estar entre 0 y 1023 para j y entre 0 767 para k ");
            }

        }


        get
        {
            return k;
        }
    }

    public NaveII(int j, int k)
    {
        J = j;
        K = k;
    }



}