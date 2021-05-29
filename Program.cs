using System;

namespace MyApplication
{
    class Program
    {

        public void Perkalian()
        {
            Console.WriteLine("KALKULATOR SEDERHANA");
            Console.WriteLine("Masukkan angka bilangan pertama");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bilangan pertama sudah disave dengan nilai ", angka1);

            Console.WriteLine("Masukkan angka bilangan kedua");
            int angka2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bilangan kedua sudah disave dengan nilai ", angka2);
            Console.WriteLine("Sedang memprosess bilangan ... ");

            Console.WriteLine("Silakan pilih Menu Aritmatika");
            int menu_kalkulator = Convert.ToInt32(Console.ReadLine());
            switch (menu_kalkulator)
            {
                case 1:
                    Console.WriteLine("Perjumlahan {0} x {1} hasilnya {2} : ", angka1, angka2, Convert.ToInt32(angka1 + angka2));
                    break;
                case 2:
                    Console.WriteLine("Pengurangan {0} x {1} hasilnya : {2} ", angka1, angka2, Convert.ToInt32(angka1 - angka2));
                    break;
                case 3:
                    Console.WriteLine("Perkalian {0} x {1} hasilnya : {2} ", angka1, angka2, Convert.ToInt32(angka1 * angka2));
                    break;
                case 4:
                    Console.WriteLine("Pembagian {0} x {1} hasilnya : {2} ", angka1, angka2, Convert.ToInt32(angka1 / angka2));
                    break;
                default:
                    Console.WriteLine("Menu yang anda pilih tidak tersedia");
                    break;
            }

        }

        public void HitungBonusGaji()
        {
            Console.WriteLine("<<< Program hitung gaji + bonus perminggu >>>");
            const int gajiPokok = 3000000;
            Console.WriteLine("Gaji Pokok Rp.{0}\n", gajiPokok);
            Console.WriteLine("Rumus Gaji Pokok + Bonus\n");
            Console.WriteLine("Pendapatan selama perminggu Rp ?");
            int valueBonus = Convert.ToInt32(Console.ReadLine());
            int bonusOrigin=0;
            Console.WriteLine("Pendapatan selama perminggu Rp {0} sudah tersimpan ",valueBonus);
            bool changeValueBonus = true;
            do
            {   
                Console.WriteLine("Apakah kamu ingin mengganti angka pendapatan perminggu ?\n");
                Console.WriteLine("Ketik y jika iya\nKetik n jika ingin lanjut\n");
                char yesNoChange = Console.ReadKey().KeyChar;
                if (yesNoChange == 'y'){
                    Console.WriteLine("Pendapatan selama perminggu Rp ?");
                    valueBonus = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Pendapatan selama perminggu Rp {0} sudah tersimpan dan diganti ",valueBonus);
                }else{
                    changeValueBonus=false;
                }
            } while (changeValueBonus);
            int result=0,bonusValue=valueBonus*4;// bonus perminggu x 4 minggu
            if (bonusValue>50000000){
                result=gajiPokok+(gajiPokok*15)/100;
                bonusOrigin=(gajiPokok*15)/100;
            }else if(bonusValue>=25000000&&bonusValue<=50000000){
                result=gajiPokok+(gajiPokok*12)/100;
                bonusOrigin=(gajiPokok*12)/100;
            }else if(bonusValue>=10000000&&bonusValue<25000000){
                result=gajiPokok+(gajiPokok*9)/100;
                bonusOrigin=(gajiPokok*9)/100;;
            }else{
                result=gajiPokok+(gajiPokok*0)/100;
                bonusOrigin=(gajiPokok*0)/100;
            }
            Console.WriteLine("Gaji Pokok {0} + Bonus {1} = {2} ",gajiPokok,bonusOrigin,result);
        }

        public void hitungNilaiAkhir()
        {
            int []field=new int[4];
            string []field_label=new string[4]{"Nilai Absen","Nilai Tugas","Nilai UTS","Nilai UAS"};
            int result=0;
            Console.WriteLine("Program hitung nilai akhir");
            Console.WriteLine("Nama mahasiswa : ");
            string nama_user=Console.ReadLine();
            Console.WriteLine("Nama mahasiswa sudah disimpan {0} ",nama_user);
            for (int fieldAdd = 0; fieldAdd < field.Length; fieldAdd++){
                Console.WriteLine("Input nilai {0} \n",field_label[fieldAdd]);
                field[fieldAdd]=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} sudah disimpan ",field_label[fieldAdd]);
            }
            result=(((10*field[0])/100)+((20*field[1])/100)+((30*field[2])/100)+((40*field[3])/100));
            if(result>=80){
                Console.WriteLine("Anda mendapatkan Predikat A (LULUS)");
            }else if(result>=70&&result<80){
                Console.WriteLine("Anda mendapatkan Predikat B (LULUS)");
            }else if(result>56&&result<70){
                Console.WriteLine("Anda mendapatkan Predikat C (LULUS)");
            }else if(result>=40&&result<56){
                Console.WriteLine("Anda mendapatkan Predikat D (TIDAK LULUS)");
            }else{
                Console.WriteLine("Anda mendapatkan Predikat E (TIDAK LULUS)");
            }
            Console.WriteLine("Nilai akhir = {0} ",result);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            // program.Perkalian();
            // program.HitungBonusGaji();
            program.hitungNilaiAkhir();

        }
    }
}