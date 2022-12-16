using System;
// write in 2019 by maurizio.conti@fablabromagna.org

public static class Alfabeto
{
    public static bool Verifica(string input)
    {
        string alfabeto = "abcdefghijklmnopqrstuvwxyz";

        input.ToLower();
        int dimensione = input.Length;
        int vero = 0;
        for (int i = 0; i < dimensione; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (input[i] == alfabeto[j])
                {
                    vero=vero++;
                }
                else
                {
                    vero = 0;
                }
            }
        }
        if(vero>=26)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
