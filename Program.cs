using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApn2
{
    class Program
    {

        static void Main(string[] args)
        {
           
           Program p = new Program();
           string sifreli1 = p.m_sifrelekaydet("ömürburuk"); ;
           string sifreli2 = p.m_sifrelekaydet(sifreli1);

           p.kaydet(sifreli2);
        }
        public void m_sifrecöz(string _yigit_ds)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(_yigit_ds);
            string yigitisifresi = "";
            for (int i = 0; i < asciiBytes.Length; i+=2)
            {
                byte k = asciiBytes[i];
                int j = k -5 ;
                char a = Convert.ToChar(j);
                yigitisifresi += a;
            }
            /*
             * SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
            string sorgu = "select*from kullanicilar where kadi=@kullaniciadi and sifre=@sifre";

            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cmd.Parameters.AddWithValue("@kullaniciadi", TextBox7.Text);
            cmd.Parameters.AddWithValue("@sifre", yigitinsifresi);  // textbox yigitin sifresi olacak
             * SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
             */
            
        }

        public string m_sifrelekaydet(string _yigit_sd)
        {
            
            byte[] asciiBytes = Encoding.ASCII.GetBytes(_yigit_sd);
            string yigitisifresi = "";
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                byte k = asciiBytes[i];
                int j = k + 5;
                char a = Convert.ToChar(j);
                yigitisifresi += a;
            }
            return yigitisifresi;
        }
        public string m_sifrelekaydet2(string _1sifreden2ye)
        {

            byte[] asciiBytes = Encoding.ASCII.GetBytes(_1sifreden2ye);
            string yigitisifresi = "";
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                byte k = asciiBytes[i];
                int j = k;
                int h = k -8;
                char a = Convert.ToChar(j);

                yigitisifresi += a;
                yigitisifresi += h;
            }
            return yigitisifresi;
        }
        public int kaydet(string gelen)
        {
             // veri tabanı kaydetme işlemi
            /*
             * sql.connection
             * 
             *  SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
                                if (control == 1)
                                {

                                    string sorgu = "insert into kullanicilar(adi,sadi,kadi,sehir,sifre,telefon,dtarihi,[E-mail],res) values(@adi,@sadi,@kadi,@sehir,@sifre,@tel,@dtar,@email,@res)";
                                    SqlCommand cmd = new SqlCommand(sorgu, cnn);
                                    cnn.Open();
                                    try
                                    {
             * */
            return 1;
        }
       
    }
}
