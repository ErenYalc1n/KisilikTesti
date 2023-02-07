namespace KisilikTesti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            button1.Visible = false;
            button2.Visible=false;

        }
        int soru = 1;
        int puan = 0;
        string a = "Hiç Katýlmýyorum";
        string b = "Katýlmýyorum";
        string c = "Biraz Katýlýyorum";
        string d = "Katýlýyorum";
        string x = "Kesinlikle Katýlýyorum";
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                puan = puan + 1;
                soru++;
            }
            else if (radioButton2.Checked == true)
            {
                puan = puan + 2;
                soru++;
            }
            else if (radioButton3.Checked == true)
            {
                puan = puan + 3;
                soru++;
            }
            else if (radioButton4.Checked == true)
            {
                puan = puan + 4;
                soru++;
            }
            else if (radioButton5.Checked == true)
            {
                puan = puan + 5;
                soru++;
            }
            else
            {
                MessageBox.Show("Lütfen soruyu cevaplayýnýz");
            }
            
            label3.Text = Convert.ToString(puan);            
            switch(soru)
            {
                case 1:
                    label1.Text = "1. Sabahlarý neþeli bir þekilde uyanýrým.";
                    break;
                case 2:
                    label1.Text = "2. Çoðunlukla neþem yerindedir.";
                    break;
                case 3:
                    label1.Text = "3. Çoðu kimse tarafýndan sevilirim.";
                    break;
                case 4:
                    label1.Text = "4. Aynaya baktýðým zaman, aynada gördüklerim hoþuma gider.";
                    break;
                case 5:
                    label1.Text = "5. Eðer karþý cinsten biri olsaydým kendimi çekici bulurdum.";
                    break;
                case 6:
                    label1.Text = "6. Zeki bir insaným.";
                    break;
                case 7:
                    label1.Text = "7. Ýþimden hoþlanýrým.";
                    break;
                case 8:
                    label1.Text = "8. Kendimle ilgili olarak utanýlacak pek bir þey göremiyorum.";
                    break;
                case 9:
                    label1.Text = "9. Arkadaþlarýmýn sayýsý yönünden içim rahat";
                    break;
                case 10:
                    label1.Text = "10. Oldukça enerjik bir insaným.";
                    break;
                case 11:
                    label1.Text = "11. Esas olarak iyimser bir kiþiyim.";
                    break;
                case 12:
                    label1.Text = "12. Kendi hatalarýma gülebilirim.";
                    break;
                case 13:
                    label1.Text = "13. Eðer yaþama yeniden baþlama olanaðým olsaydý,\n deðiþtirmek istediðim pek bir þey olmazdý.";
                    break;
                case 14:
                    label1.Text = "14. Ben ilginç bir insaným.";
                    break;
                case 15:
                    label1.Text = "15. Cinsel yaþamýmdan memnunum.";
                    break;
                case 16:
                    label1.Text = "16. Hala geliþen ve deðiþen bir insaným.";
                    break;
                case 17:
                    label1.Text = "17. Baþkalarý bana önem verir,";
                    break;
                case 18:
                    label1.Text = "18. Bana benzer baþka insan pek bulunmaz.";
                    break;
                case 19:
                    label1.Text = "19. Görünüþümle ilgili olarak deðiþtirmek istediðim bir þey yok.";
                    break;
                case 20:
                    label1.Text = "20. Ben duyarlý bir insaným.";       
                    break;
                case 21:
                    label1.Text = "21. Þimdiye dek yaptýklarýmdan piþman deðilim.";             
                    break;
                case 22:
                    label1.Text = "22. Önem verdiðim kiþiler benim görüþ ve düþüncelerimle ilgilenirler.";
                    break;
                case 23:
                    label1.Text = "23. Duygularýmý açýklamaktan çekinmem.";             
                    break;
                case 24:
                    label1.Text = "24. Gerçekten bir cennet varsa, öldükten sonra ben mutlaka oraya giderim.";
                    break;
                case 25:
                    label1.Text = "25. Baþkalarýyla konuþurken rahatým.";            
                    break;
                case 26:
                    label1.Text = "26. Yaþamýmý istediðim yöne çevirebilirim.";             
                    break;
                case 27:
                    label1.Text = "27. Yerinde olmak istediðim, gýptayla baktýðým pek kimse yok.";                
                    break;
                case 28:
                    label1.Text = "28. Oldukça ilginç bir yaþam sürdüm.";                  
                    break;
                case 29:
                    label1.Text = "29. Ben her türlü iyilik ve ödüle deðer biriyim.";                    
                    break;
                case 30:
                    label1.Text = "30. Yaþamýmda þu anda bulunduðum noktada olmaktan memnunum.";
                    button1.Text = "Bitir";
                    break;
                case 31:
                    if(puan<=47)
                    {
                        MessageBox.Show("Testi tamamladýn! Puanýn: "+puan+"\nSonuç: 47 ve aþaðýsý\nKendinizi pek seven bir insan deðilsiniz. Belki de geçici olarak kendinizi aþaðýlama döneminde bulunuyorsunuz. Herkes böyle bir dönemden ara sýra geçer.");
                        label1.Visible = false;
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        radioButton5.Visible = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        button1.Visible = false;
                        button2.Visible = true;
                    }
                    else if (puan > 47 && puan <= 71)
                    {
                        MessageBox.Show("Testi tamamladýn! Puanýn: "+puan+"\nSonuç; 48-71 arasý\nKendinizle ilgili karmaþýk duygularýnýz var. Bazý güçlü yölerinizin farkýndasýnýz, ancak zayýf yönlerinizi gözünüzde daha çok abartýyor olabilirsiniz.");
                        label1.Visible = false;
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        radioButton5.Visible = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        button1.Visible = false;
                        button2.Visible = true;
                    }
                    else if (puan > 71 && puan <= 95)
                    {
                        MessageBox.Show("Testi tamamladýn! Puanýn: "+puan+"\nSonuç: 72-95 arasý\nKendini seven ve kendiyle barýþýk olan insanlardan birisiniz. Mükemmel olmadýðýnýzý bildiðiniz halde, karþýlaþtýðýnýz bireysel sorunlarý çözebilecek inancý kendinizde bulabiliyorsunuz.");
                        label1.Visible = false;
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        radioButton5.Visible = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        button1.Visible = false;
                        button2.Visible = true;
                    }                    
                    else if (puan > 95)
                    {
                        MessageBox.Show("Testi tamamladýn! Puanýn: "+puan+"\nSonuç: 96 ve yukarýsý\nKendiniz hakkýnda oldukça olumlu düþünen bir insansýnýz. Ama eðer puanýnýz 105'in üzerindeyse, herhalde iþi biraz þakaya vurdunuz. Eðer kendinizi bu denli beðenmiþ biri iseniz iliþkilerinizde insanlarý kaçýrýyor olabilirsiniz.");
                        label1.Visible = false;
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        radioButton5.Visible = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        button1.Visible = false;
                        button2.Visible = true;
                    }
                    break;


            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "1. Sabahlarý neþeli bir þekilde uyanýrým.";
            button1.Visible = true;            
            label2.Visible = false;
            radioButton1.Text = a;
            radioButton2.Text = b;
            radioButton3.Text = c;
            radioButton4.Text = d;
            radioButton5.Text = x;
            button3.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "Sonraki";
            soru = 1;
            puan = 0;
            label1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "1. Sabahlarý neþeli bir þekilde uyanýrým.";
            button1.Visible = true;
            label2.Visible = false;
            radioButton1.Text = a;
            radioButton2.Text = b;
            radioButton3.Text = c;
            radioButton4.Text = d;
            radioButton5.Text = x;
            button3.Visible = false;
            button2.Visible = false;
        }
    }
}