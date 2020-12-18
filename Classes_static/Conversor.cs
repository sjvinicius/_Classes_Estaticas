namespace _Classes_Atributos_Metodos_Static.Classes_static
{
    public static class Conversor
    {
        
        //Atributos
        private static float real = 1;
        public static float Real 
        { 
            get { return real; } 
            set { real = Real; } 
        
        }
        
        
        private static float dolar = 1;
        public static float Dolar 
        { 
            get { return dolar; } 
            set { dolar = Dolar; } 
        
        }


        //Métodos
        public static float dolartoreal(float Dolar, float cotreal){

            return Dolar * cotreal;

        }
        public static float realtodolar(float cotdol, float Real){

            return Real * cotdol;

        }

    }
}