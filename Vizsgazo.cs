
using System;

namespace Nyelvvizsga
{
    class Vizsgazo
    {
        //TAGVÁLTOZÓK
        private string vizsgazoNeve;
        private int vizsgazoAzonosito;
        private string vizsgaszint;
        private int vizsgaPont;



        //KONSTRUKTOROK
        public Vizsgazo() { }

        public Vizsgazo(string nev, int azon, string szint, int pont) {

            vizsgazoNeve = nev;
            vizsgazoAzonosito = azon;
            vizsgaszint = szint;
            vizsgaPont = pont;
         }



        //GETTER METÓDUSOK
        public string getVizsgazoNev() { return vizsgazoNeve; }
        public int getVizsgazoAzonosito() { return vizsgazoAzonosito; }
        public string getVizsgaszint() { return vizsgaszint; }
        public int getVizsgaPont() { return vizsgaPont; }



        //SETTER METÓDUSOK
        public void setVizsgazoNev(string nev) { vizsgazoNeve = nev; }
        public void setVizsgazoAzonosito(int azon) { vizsgazoAzonosito = azon; }
        public void setVizsgaszint(string szint) { vizsgaszint = szint; }
        public void setVizsgaPont(int pont) { vizsgaPont = pont; }



		//TAGFÜGGVÉNYEK





    }
}


